using System.Collections.Generic;
using Umax.Classes.Containers;
using Umax.Interfaces.Containers.Items;

namespace Umax.Plugins.Tasks.Classes
{
    public class TaskCategory : Category
    {
        public TaskCategory()
        {
            this.Parent = null;
            this.categories = new List<ICategory>();
        }

        public TaskCategory(ICategory Category)
        {
            this.ID = Category.ID;
            this.Keyword = Category.Keyword;
            this.Name = Category.Name;
            this.Path = Category.Path;
            this.URL = Category.URL;

            for (int i = 0; i < Category.Categories.Count; i++)
            {
                this.AddCategory(Category.Categories[i]);
            }
        }

        public TaskCategory Parent { get; protected set; }

        private List<ICategory> categories;
        public override List<ICategory> Categories { get { return this.categories; } }

        public void AddCategory(ICategory Item)
        {
            this.categories.Add(new TaskCategory(Item)
                                    {
                                        Parent = this
                                    });
        }
    }
}
