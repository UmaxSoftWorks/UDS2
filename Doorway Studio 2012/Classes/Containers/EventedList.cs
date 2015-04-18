using System.Collections.Generic;
using Umax.Interfaces.Containers;
using Umax.Interfaces.Containers.Items;
using Umax.Interfaces.Events;

namespace Umax.Classes.Containers
{
    public class EventedList<T> : IEventedList<T>
    {
        public T this[int Index]
        {
            get { return items[Index]; }
            set
            {
                T item = this.items[Index];

                this.items[Index] = value;

                if (this.ItemChanged != null)
                {
                    this.ItemChanged.Invoke(item);
                }
            }
        }

        private List<T> items;

        public EventedList()
        {
            this.items = new List<T>();
        }

        public EventedList(IEnumerable<T> Items)
        {
            this.items = new List<T>(Items);
        }

        public void Add(T Item)
        {
            if (Item == null)
            {
                return;
            }

            this.items.Add(Item);

            if (this.CountChanged != null)
            {
                this.CountChanged.Invoke();
            }

            if (this.ItemAdded != null)
            {
                this.ItemAdded.Invoke(Item);
            }
        }

        public void Remove(T Item)
        {
            this.items.Remove(Item);

            if (this.CountChanged != null)
            {
                this.CountChanged.Invoke();
            }

            if (this.ItemRemoved != null)
            {
                this.ItemRemoved.Invoke(Item);
            }
        }

        public void RemoveAt(int Index)
        {
            T item = this.items[Index];

            this.items.RemoveAt(Index);

            if (this.CountChanged != null)
            {
                this.CountChanged.Invoke();
            }

            if (this.ItemRemoved != null)
            {
                this.ItemRemoved.Invoke(item);
            }
        }

        public List<T> ToList()
        {
            return this.items;
        }

        public int Count
        {
            get
            {
                return this.items.Count;
            }
        }

        public event SimpleEventHandler CountChanged;
        public event SimpleSenderEventHandler ItemAdded;
        public event SimpleSenderEventHandler ItemRemoved;
        public event SimpleSenderEventHandler ItemChanged;

        public int NextID()
        {
            if (this.items == null)
            {
                return 0;
            }

            if (this.items.Count == 0)
            {
                return 0;
            }

            int id = 0;
            for (int i = 0; i < this.items.Count; i++)
            {
                if (!(this.items[i] is IItem)) continue;

                if (id < (this.items[i] as IItem).ID)
                {
                    id = (this.items[i] as IItem).ID;
                }

            }

            return id + 1;
        }

        public T[] ToArray()
        {
            return this.items.ToArray();
        }

        public bool Contains(T Item)
        {
            return this.items.Contains(Item);
        }

        public int Number(T Item)
        {
            int result = 0;

            if (Item == null)
            {
                return result;
            }

            if (this.items.Count == 0)
            {
                return result;
            }

            for (int i = 0; i < this.items.Count; i++)
            {
                if (this.items[i].Equals(Item))
                {
                    result++;
                }
            }

            return result;
        }

        public bool Contains(int ID)
        {
            if (this.items == null)
            {
                return false;
            }

            if (this.items.Count == 0)
            {
                return false;
            }

            for (int i = 0; i < this.items.Count; i++)
            {
                if (!(this.items[i] is IItem)) continue;

                if ((this.items[i] as IItem).ID == ID)
                {
                    return true;
                }
            }

            return false;
        }

        public int Number(int ID)
        {
            int result = 0;
            if (this.items == null)
            {
                return result;
            }

            if (this.items.Count == 0)
            {
                return result;
            }

            for (int i = 0; i < this.items.Count; i++)
            {
                if (!(this.items[i] is IItem)) continue;

                if ((this.items[i] as IItem).ID == ID)
                {
                    result++;
                }
            }

            return result;
        }

        public int IndexOf(T Item)
        {
            return this.items.IndexOf(Item);
        }

        public int IndexOf(int ID)
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (!(this.items[i] is IItem)) continue;

                if ((this.items[i] as IItem).ID == ID)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
