using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningTool
{
    class DWModLoopClass : WModLoopClass
    {
        private String LOOPEND;

        public DWModLoopClass(string LOOP, string OPENBRACKET, string WHITESPACE, string CLOSEBRACKET, string TRUEBOOL, string FALSEBOOL, string LOOPEND) : base(LOOP, OPENBRACKET, WHITESPACE, CLOSEBRACKET, TRUEBOOL, FALSEBOOL)
        {
            loopEnd = LOOPEND;
        }

        public string loopEnd { get => LOOPEND; set => LOOPEND = value; }

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
            temp.AddAtLast(loopEnd);
            return temp;
        }
    }
}
