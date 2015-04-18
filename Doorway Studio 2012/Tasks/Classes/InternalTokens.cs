using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Umax.Interfaces.Tokens;

namespace Umax.Plugins.Tasks.Classes
{
    public class InternalTokens
    {
        private static InternalTokens instance;

        public static InternalTokens Instance
        {
            get { return instance ?? (instance = new InternalTokens()); }
        }

        public List<IToken> Items { get; protected set; }

        private InternalTokens()
        {
            this.Items = (from item in Assembly.GetExecutingAssembly().GetTypes()
                          where item.GetInterfaces().Contains(typeof (IToken))
                          select Activator.CreateInstance(item) as IToken).ToList();
        }
    }
}
