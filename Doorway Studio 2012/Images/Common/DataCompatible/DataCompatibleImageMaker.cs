using System;
using Umax.Interfaces.Compatibility.Images;
using Umax.Interfaces.Containers;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Enums;
using Umax.Plugins.Images.Enums;
using Umax.Plugins.Images.Modify.Common;
using IO = System.IO;

namespace Umax.Plugins.Images.Common.DataCompatible
{
    public abstract class DataCompatibleImageMaker : ImageMaker, IImageDataCompatible
    {
        public IEventedList<IImage> ImageData { get; set; }

        /// <summary>
        /// Gets or sets Images Index
        /// </summary>
        protected int ImagesIndex { get; set; }

        protected string Select()
        {
            int imageIndex = 0;

            if ((this.Settings as ModifyImageSettings).Location == LocationType.Internal)
            {
                imageIndex = this.Random.Next(this.ImageData.Count);

                // HTTP
                if (this.ImageData[imageIndex].Path.ToLower().StartsWith("http"))
                {
                    return this.ImageData[imageIndex].Path;
                }

                // File
                while (!IO.File.Exists(this.ImageData[imageIndex].Path))
                {
                    imageIndex = this.Random.Next(this.ImageData.Count);
                }

                return this.ImageData[imageIndex].Path;
            }

            // External
            imageIndex = this.Random.Next(this.ExternalImages.Length);

            return this.ExternalImages[imageIndex];
        }

        protected override MakerStateType Validate()
        {
            if ((this.Settings as DataCompatibleImageSettings).Location == LocationType.Internal)
            {
                if (this.ImageData == null)
                {
                    throw new Exception("Images data isn't provided.");
                }

                if (this.ImageData.Count == 0)
                {
                    throw new Exception("Images data empty.");
                }

                this.ImagesIndex = -1;

                for (int i = 0; i < this.ImageData.Count; i++)
                {
                    if (this.ImageData[i].ID == (this.Settings as DataCompatibleImageSettings).ImageID)
                    {
                        this.ImagesIndex = i;
                        break;
                    }
                }

                if (this.ImagesIndex == -1)
                {
                    throw new Exception("Internal images not found.");
                }
            }
            else
            {
                if (IO.Directory.Exists((this.Settings as DataCompatibleImageSettings).LocationPath))
                {
                    throw new Exception("External images location not found.");
                }

                this.ExternalImages = IO.Directory.GetFiles((this.Settings as DataCompatibleImageSettings).LocationPath, "*",
                                                            IO.SearchOption.AllDirectories);

                if (this.ExternalImages.Length == 0)
                {
                    throw new Exception("External images not found.");
                }
            }

            return MakerStateType.Initialized;
        }
    }
}
