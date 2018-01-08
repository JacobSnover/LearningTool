using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningTool
{
    class ForeachLoopClass
    {

        public static void ForeachLoop()
        {
            LinkedList temp = new LoopClass("foreach (int num in array)", "{", "", "}").ToList();
            string[] LoopArray = Tools.ArrayMaker(temp);

            Tools.Header();
            string firstMsg = "Today we are going to talk about the ";
            string loopStart = "foreach ";
            string brack = "(";
            string loopVar = "int ";
            string num = "num ";
            string locale = "in";
            string loopEnd = " array)\n{\n\n}\n\n";
            string endFirstMsg = "If this is your first time seeing this you may be confused.\n" +
            "This lesson that I have for you will help put you at ease.\n";

            Tools.LoopReader(firstMsg);
            Tools.Highlighter("foreach loop");
            Tools.LoopReader(Tools.BlackText(" in .Net!! \nThe "));
            Tools.Highlighter("foreach loop");
            Tools.StringReader(Tools.BlackText(" that we use today will look like this\n\n"));

            Tools.LoopReader(Tools.BlueText(loopStart));
            Tools.LoopReader(Tools.BlackText(brack));
            Tools.LoopReader(Tools.BlueText(loopVar));
            Tools.LoopReader(Tools.BlackText(num));
            Tools.LoopReader(Tools.BlueText(locale));
            Tools.StringReader(Tools.BlackText(loopEnd));
            Tools.StringReader(endFirstMsg);
            string LoopCont = Tools.SelectionScreen("foreach loop");

            Lesson(LoopArray, LoopCont);
        }

        private static void Lesson(string[] LoopArray, string LoopCont)
        {
            while (LoopCont == "1" || LoopCont == "2" || LoopCont == "3" || LoopCont == "4")
            {

                if (LoopCont == "1")
                {

                    Tools.Header();
                    string LoopLesson = "The ";
                    string loopStart = "foreach ";
                    string brack = "(";
                    string loopVar = "int ";
                    string num = "num ";
                    string locale = "in";
                    string loopEnd = " array)\n{\n\n}\n\n";
                    string endLoopLesson = "It first declares an ";

                    Tools.LoopReader(LoopLesson);
                    Tools.Highlighter("foreach loop");
                    Tools.LoopReader(Tools.BlackText(" will evaluate each element in a collection\n\n"));
                    Tools.LoopReader(Tools.BlueText(loopStart));
                    Tools.LoopReader(Tools.BlackText(brack));
                    Tools.LoopReader(Tools.BlueText(loopVar));
                    Tools.LoopReader(Tools.BlackText(num));
                    Tools.LoopReader(Tools.BlueText(locale));
                    Tools.StringReader(Tools.BlackText(loopEnd));
                    Tools.LoopReader(endLoopLesson);
                    Tools.Highlighter("int");
                    Tools.LoopReader(Tools.BlackText(" and names it "));
                    Tools.Highlighter("num");
                    Tools.LoopReader(Tools.BlackText(", it then tells the "));
                    Tools.Highlighter("foreach loop");
                    Tools.LoopReader(Tools.BlackText(" to look in "));
                    Tools.Highlighter("array");
                    Tools.LoopReader(Tools.BlackText(".\nThe "));
                    Tools.Highlighter("foreach loop");
                    Tools.LoopReader(Tools.BlackText(" could be described as simpler than the "));
                    Tools.Highlighter("for loop");
                    Tools.StringReader(Tools.BlackText(" because it's defined.\n" +
                    "It's defined because it always starts at the beginning of the collection and checks every element.\n"));

                    Lesson(LoopArray, Tools.ContSelectionScreen("foreach loop"));

                }
                else if (LoopCont == "2")
                {

                    Tools.Header();
                    string LoopDemo = "Ok now today I am going to ask you to type out some lines of code.\nThe ";
                    string loopStart = "foreach ";
                    string brack = "(";
                    string loopVar = "int ";
                    string num = "num ";
                    string locale = "in";
                    string loopEnd = " array)\n{\n\n}\n\n";

                    Tools.LoopReader(LoopDemo);
                    Tools.Highlighter("foreach loop");
                    Tools.StringReader(Tools.BlackText(" can be typed in different ways but for learning\n" +
                    "purposes I will need you to be exact today. Lets start!\n" +
                    "I will now type out the lines and ask you to repeat it.\n\n"));

                    Tools.LoopReader(Tools.BlueText(loopStart));
                    Tools.LoopReader(Tools.BlackText(brack));
                    Tools.LoopReader(Tools.BlueText(loopVar));
                    Tools.LoopReader(Tools.BlackText(num));
                    Tools.LoopReader(Tools.BlueText(locale));
                    Tools.StringReader(Tools.BlackText(loopEnd));
                    Console.WriteLine(Tools.GreenText("===================================================="));
                    Tools.BlackText("\n");

                    for (int i = 0; i < LoopArray.Length; i++)
                    {
                        string answer = Console.ReadLine();
                        if (answer != LoopArray[i])
                        {
                            Tools.BlackText("");
                            Tools.Header();
                            Console.Write("\nI'm sorry that is not correct please try again\n" +
                                                        "To continue type Y. To exit type N. ");
                            string tryAgain = Console.ReadLine().ToLower();
                            Console.Clear();
                            if (tryAgain == "n")
                            {
                                Console.WriteLine("\nGoodBye!! ");
                                Environment.Exit(1);
                            }
                            break;
                        }
                        else if (i == 0 && answer == LoopArray[0])
                        {
                            Console.SetCursorPosition(0, Console.CursorTop - 1);
                            Console.Write(new string(' ', Console.WindowWidth));
                            Console.SetCursorPosition(0, Console.CursorTop);
                            Console.SetCursorPosition(0, Console.CursorTop - 1);

                            Console.Write(Tools.BlueText(loopStart));
                            Console.Write(Tools.BlackText(brack));
                            Console.Write(Tools.BlueText(loopVar));
                            Console.Write(Tools.BlackText(num));
                            Console.Write(Tools.BlueText(locale));
                            Console.WriteLine(Tools.BlackText(" array)"));
                        }

                        int h = LoopArray.Length - 1;
                        if (i == h)
                        {
                            Tools.BlackText("");
                            Tools.Header();
                            string victory = "\nCongratulations! You have just coded the - FOREACH LOOP!! -\n";
                            Tools.StringReader(victory);
                            Lesson(LoopArray, Tools.SelectionScreen("foreach loop"));
                        }
                    }
                    continue;
                }
                else if (LoopCont == "3")
                {
                    Program.LoopSelectionScreen();
                }
                else if (LoopCont == "4")
                {
                    Console.Write("\nGoodBye!! ");
                    Environment.Exit(1);
                }
                else
                {
                    Console.Clear();
                    Tools.Header();
                    Console.Write("\nThat is not correct response. Press 1. or 2. please: ");
                }
            }
        }

    }
}
