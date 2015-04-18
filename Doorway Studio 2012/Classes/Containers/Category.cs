using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Umax.Interfaces.Containers.Items;

namespace Umax.Classes.Containers
{
    [Serializable, XmlRoot(ElementName = "Category")]
    public class Category : ICategory
    {
        public Category()
        {
            this.Categories = new List<ICategory>();
        }

        public void Dispose()
        {
            this.Categories = null;
        }

        [XmlElementAttribute(ElementName = "ID")]
        public int ID { get; set; }

        [XmlElementAttribute(ElementName = "Name")]
        public string Name { get; set; }

        [XmlElementAttribute(ElementName = "Path")]
        public string Path { get; set; }

        [XmlElementAttribute(ElementName = "URL")]
        public string URL { get; set; }

        [XmlElementAttribute(ElementName = "Keyword")]
        public string Keyword { get; set; }

        [XmlElementAttribute(ElementName = "Categories")]
        public virtual List<ICategory> Categories { get; set; }
    }
}
