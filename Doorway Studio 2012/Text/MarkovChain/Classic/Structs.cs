using System.Collections;

namespace Umax.Plugins.Text.MarkovChain.Classic
{
    internal class Structs
    {
        internal struct RootWord
        {
            public bool Start;
            public bool End;
            public string Word;
            public int ChildCount;
            public Hashtable Childs;
        }

        internal struct Child
        {
            public int Occurrence;
            public string Word;
        }
    }
}
