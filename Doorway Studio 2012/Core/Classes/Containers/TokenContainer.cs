using System;
using System.Reflection;
using Core.Enums;
using Umax.Classes.Containers;
using Umax.Classes.Enums;
using Umax.Interfaces.Containers;
using Umax.Interfaces.Tokens;

namespace Core.Classes.Containers
{
    public class TokenContainer: ITokenContainer
    {
        public TokenContainer()
        {
            this.Items = new EventedList<IToken>();

            // Events
            this.Items.ItemAdded += this.ItemAdded;
        }

        #region ITokenContainer
        public IEventedList<IToken> Items { get; set; }
        #endregion

        /// <summary>
        /// Loading Token classes from DLL
        /// </summary>
        /// <param name="DllPath">Path to the DLL</param>
        public void Load(string DllPath)
        {
            Assembly assembly = Assembly.Load(DllPath);
            Type[] types = assembly.GetTypes();

            for (int i = 0; i < types.Length; i++)
            {
                try
                {
                    if (types[i].Name.Contains("SimpleToken") &&
                        types[i].Attributes == (TypeAttributes.Public | TypeAttributes.BeforeFieldInit))
                    {
                        this.Items.Add(assembly.CreateInstance(types[i].FullName) as ISimpleToken);
                    }
                    else if (types[i].Name.Contains("ComplexToken") &&
                             types[i].Attributes == (TypeAttributes.Public | TypeAttributes.BeforeFieldInit))
                    {
                        this.Items.Add(assembly.CreateInstance(types[i].FullName) as IComplexToken);
                    }
                }
                catch (Exception ex)
                {
                    Logger.Instanse.Append(string.Format("Core: Failed to load {0}.", types[i].Name), LogMessageType.Info);
                    if (Options.Instanse.LogDebugMode)
                    {
                        Logger.Instanse.Append(ex);
                    }
                }
            }
        }

        #region IDisposable

        public void Dispose()
        {
            // Events
            this.Items.ItemAdded -= this.ItemAdded;

            // Data
            this.Items = null;
        }

        #endregion

        protected void ItemAdded(object Sender)
        {
            Logger.Instanse.Append("Core: Loaded " + (Sender as IToken).Name, LogMessageType.Info);
        }
    }
}
