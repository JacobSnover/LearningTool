using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningTool
{
    class WModLoopClass : LoopClass
    {
        private String TRUEBOOL;
        private String FALSEBOOL;

        public WModLoopClass(string LOOP, string OPENBRACKET, string WHITESPACE, string CLOSEBRACKET, string TRUEBOOL, string FALSEBOOL) : base(LOOP, OPENBRACKET, WHITESPACE, CLOSEBRACKET)
        {
            trueBool = TRUEBOOL;
            falseBool = FALSEBOOL;

        }

        public string trueBool { get => TRUEBOOL; set => TRUEBOOL = value; }
        public string falseBool { get => FALSEBOOL; set => FALSEBOOL = value; }

        public override LinkedList ToList()
        {
            LinkedList temp = new LinkedList();
            temp.AddAtLast(trueBool);
            temp.AddAtLast(Whitespace);
            temp.AddAtLast(Loop);
            temp.AddAtLast(Openbracket);
            temp.AddAtLast(Whitespace);
            temp.AddAtLast(falseBool);
            temp.AddAtLast(Whitespace);
            temp.AddAtLast(Closebracket);
            return temp;
        }
    }
}
