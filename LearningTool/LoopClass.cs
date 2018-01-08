using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LearningTool
{
    class LoopClass
    {
        
        private String LOOP;
        private String OPENBRACKET;
        private String WHITESPACE;
        private String CLOSEBRACKET;

        public LoopClass(string LOOP, string OPENBRACKET, string WHITESPACE, string CLOSEBRACKET)
        {
           
            Loop = LOOP;
            Openbracket = OPENBRACKET;
            Whitespace = WHITESPACE;
            Closebracket = CLOSEBRACKET;
        }

      
        public string Loop { get => LOOP; set => LOOP = value; }
        public string Openbracket { get => OPENBRACKET; set => OPENBRACKET = value; }
        public string Whitespace { get => WHITESPACE; set => WHITESPACE = value; }
        public string Closebracket { get => CLOSEBRACKET; set => CLOSEBRACKET = value; }

        public virtual LinkedList ToList()
        {
            LinkedList temp = new LinkedList();
            temp.AddAtLast(Loop);
            temp.AddAtLast(Openbracket);
            temp.AddAtLast(Whitespace);
            temp.AddAtLast(Closebracket);
            return temp;
        }

    }
}
