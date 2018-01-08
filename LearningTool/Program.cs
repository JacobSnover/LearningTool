using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            Tools.GrayBackground();
            Console.Clear();

            CodeWithMe();
        }

        private static void CodeWithMe()
        {
            while (true)
            {
                Console.WriteLine(Tools.BlackText("Hello lets learn .Net!\n" +
                "--Loops--    Press 1.\n" +
                "Exit Program Press 2."));

                string selection = Console.ReadLine();
                Console.Clear();
                if (selection == "1")
                {

                    LoopSelectionScreen();
                }
                else if (selection == "2")
                {
                    Environment.Exit(1);
                }
                else
                {
                    Console.WriteLine("\nThat is not a proper selection.\n");
                    continue;
                }
            }
        }

        public static void LoopSelectionScreen()
        {
            while (true)
            {
                Console.WriteLine("Welcome to the --Loops-- selection screen.\n" +
                                    "--For Loop--   Press 1.\n" +
                                    "--Foreach Loop--   Press 2.\n" +
                                    "--While Loop--   Press 3.\n" +
                                    "--Do While Loop   Press 4.\n" +
                                    "Exit Program   Press 5.");

                string loopSelection = Console.ReadLine();
                Console.Clear();
                if (loopSelection == "1")
                {
                    ForLoopClass.ForLoop();
                }
                else if (loopSelection == "2")
                {
                    ForeachLoopClass.ForeachLoop();
                }
                else if (loopSelection == "3")
                {
                    WhileLoopClass.WhileLoop();
                }
                else if (loopSelection == "4")
                {
                    DoWhileLoopClass.DoWhileLoop();
                }
                else if (loopSelection == "5")
                {
                    Environment.Exit(1);
                }
                else
                {
                    Console.WriteLine("\nThat is not a proper selection.\n");
                }
            }
        }

       

    }
}
