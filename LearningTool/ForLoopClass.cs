using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningTool
{
    class ForLoopClass
    {
        public int loops = 0;

        public static void ForLoop()
        {

            LinkedList temp = new LoopClass("for (int i = 0; i < array.Length; i++)", "{", "", "}").ToList();

            string[] LoopArray = Tools.ArrayMaker(temp);

            Tools.Header();
            string firstMsg = "Today we are going to talk about the ";
            string loopStart = "for ";
            string brack = "(";
            string loopVar = "int ";
            string iEquals = "i = ";
            string zero = "0";
            string loopEnd = "; i < array.Length; i++)\n{\n\n}\n\n";
            string endFirstMsg = "If this is your first time seeing this it can be intimidating.\n" +
            "There seems to be a lot going on and to be honest there is.\n";

            Tools.LoopReader(firstMsg);
            Tools.Highlighter("for loop");
            Tools.LoopReader(Tools.BlackText(" in .Net!! \nThe "));
            Tools.Highlighter("for loop");
            Tools.LoopReader(Tools.BlackText(" that we use today will look like this\n\n"));
            Tools.LoopReader(Tools.BlueText(loopStart));
            Tools.LoopReader(Tools.BlackText(brack));
            Tools.LoopReader(Tools.BlueText(loopVar));
            Tools.LoopReader(Tools.BlackText(iEquals));
            Tools.LoopReader(Tools.YellowText(zero));
            Tools.StringReader(Tools.BlackText(loopEnd));
            Tools.StringReader(Tools.BlackText(endFirstMsg));
            string LoopCont = Tools.SelectionScreen("for loop");

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
                    string loopStart = "for ";
                    string brack = "(";
                    string loopVar = "int ";
                    string iEquals = "i = ";
                    string zero = "0";
                    string loopEnd = "; i < array.Length; i++)\n{\n\n}\n\n";
                    string endLoopLesson = "It first declares an ";

                    Tools.LoopReader(LoopLesson);
                    Tools.Highlighter("for loop");
                    Tools.StringReader(Tools.BlackText(" has one main thing it does, which is iterate through a collection.\n\n"));
                    Tools.LoopReader(Tools.BlueText(loopStart));
                    Tools.LoopReader(Tools.BlackText(brack));
                    Tools.LoopReader(Tools.BlueText(loopVar));
                    Tools.LoopReader(Tools.BlackText(iEquals));
                    Tools.LoopReader(Tools.YellowText(zero));
                    Tools.StringReader(Tools.BlackText(loopEnd));
                    Tools.LoopReader(endLoopLesson);
                    Tools.Highlighter("int");
                    Tools.LoopReader(Tools.BlackText(" named "));
                    Tools.Highlighter("i");
                    Tools.LoopReader(Tools.BlackText(" which it gives a value of "));
                    Tools.Highlighter("0");
                    Tools.LoopReader(Tools.BlackText(",\nIt then asks if that value is less then the value of "));
                    Tools.Highlighter("array.Length");
                    Tools.LoopReader(Tools.BlackText(".\nIf it is it does whatever is in the body of the "));
                    Tools.Highlighter("for loop");
                    Tools.LoopReader(Tools.BlackText(".\nIf it succesfully makes it to the end it adds "));
                    Tools.Highlighter("1");
                    Tools.LoopReader(Tools.BlackText(" to the value of "));
                    Tools.Highlighter("i");
                    Tools.LoopReader(Tools.BlackText(" with "));
                    Tools.Highlighter("i++");
                    Tools.LoopReader(Tools.BlackText(".\nYou can have the value of "));
                    Tools.Highlighter("i");
                    Tools.LoopReader(Tools.BlackText(" start at any number and have the value decrease as well.\n"));
                    Tools.LoopReader("You can use ");
                    Tools.Highlighter("i++");
                    Tools.LoopReader(Tools.BlackText(",or "));
                    Tools.Highlighter("i--");
                    Tools.LoopReader(Tools.BlackText(",or "));
                    Tools.Highlighter("i += 10 ");
                    Tools.LoopReader(Tools.BlackText("to increase the value by ten. Try other combinations.\n"));

                    Lesson(LoopArray, Tools.ContSelectionScreen("for loop"));
                }
                else if (LoopCont == "2")
                {
                    Tools.Header();
                    string LoopDemo = "Ok now today I am going to ask you to type out some lines of code.\nThe ";
                    string loopStart = "for ";
                    string brack = "(";
                    string loopVar = "int ";
                    string iEquals = "i = ";
                    string zero = "0";
                    string loopEnd = "; i < array.Length; i++)\n{\n\n}\n\n";

                    Tools.LoopReader(LoopDemo);
                    Tools.Highlighter("For Loop");
                    Tools.LoopReader(Tools.BlackText(" can be typed in different ways but for learning\n" +
                    "purposes I will need you to be exact today. Lets start!\n" +
                    "I will now type out the lines and ask you to repeat it.\n\n"));
                    Tools.LoopReader(Tools.BlueText(loopStart));
                    Tools.LoopReader(Tools.BlackText(brack));
                    Tools.LoopReader(Tools.BlueText(loopVar));
                    Tools.LoopReader(Tools.BlackText(iEquals));
                    Tools.LoopReader(Tools.YellowText(zero));
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
                            Console.Write(Tools.BlackText(iEquals));
                            Console.Write(Tools.YellowText(zero));
                            Console.WriteLine(Tools.BlackText("; i < array.Length; i++)"));
                        }

                        int h = LoopArray.Length - 1;
                        if (i == h)
                        {
                            Tools.BlackText("");
                            Tools.Header();
                            string victory = "\nCongratulations! You have just coded the - FOR LOOP!! -\n";
                            Tools.StringReader(victory);
                            Lesson(LoopArray, Tools.SelectionScreen("for loop"));
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
            Console.WriteLine("That is not a correct response. ");
            
        }

    }
}
