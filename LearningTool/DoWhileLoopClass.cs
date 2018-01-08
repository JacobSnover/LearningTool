using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningTool
{
    class DoWhileLoopClass
    {

        public static void DoWhileLoop()
        {
            LinkedList temp = new DWModLoopClass("do", "{", "", "}", "bool trueBool = true;", "trueBool = false;", "while (trueBool)").ToList();
            string[] LoopArray = Tools.ArrayMaker(temp);

            Tools.Header();
            string firstMsg = "Today we are going to talk about the ";
            string loopBool = "bool ";
            string trueBool = "trueBool = ";
            string loopBoolTrue = "true";
            string loopDo = "do\n";
            string loopWhile = "while ";
            string condition = "(trueBool)\n\n";
            string bracket = "{\n\n";
            string loopBoolFalse = "false";
            string loopEnd = ";\n\n}\n";
            string endFirstMsg = "If you've never seen this before I know what you're thinking.\n" +
            "Actually I don't, but I do have a lesson on this to help.\n";

            Tools.LoopReader(firstMsg);
            Tools.Highlighter("do while loop");
            Tools.LoopReader(Tools.BlackText(" in .Net!! \nThe "));
            Tools.Highlighter("do while loop");
            Tools.LoopReader(Tools.BlackText(" that we use today will look like this\n\n"));
            Tools.LoopReader(Tools.BlueText(loopBool));
            Tools.LoopReader(Tools.BlackText(trueBool));
            Tools.LoopReader(Tools.BlueText(loopBoolTrue));
            Console.Write(Tools.BlackText(";\n\n"));
            Tools.LoopReader(Tools.BlueText(loopDo));
            Tools.LoopReader(Tools.BlackText(bracket));
            Tools.LoopReader(trueBool);
            Tools.LoopReader(Tools.BlueText(loopBoolFalse));
            Tools.LoopReader(Tools.BlackText(loopEnd));
            Tools.LoopReader(Tools.BlueText(loopWhile));
            Tools.StringReader(Tools.BlackText(condition));
            Tools.StringReader(endFirstMsg);
            string LoopCont = Tools.SelectionScreen("do while loop");

            Lesson(LoopArray, LoopCont);
        }

        private static void Lesson(string[] LoopArray, string LoopCont)
        {
            while (LoopCont == "1" || LoopCont == "2" || LoopCont == "3" || LoopCont == "4")
            {
                if (LoopCont == "1")
                {
                    Tools.Header();
                    string LoopLesson = "The - do while loop - has one main thing it does, which is run some code before checking for true, or false.\n\n";
                    string loopBool = "bool ";
                    string trueBool = "trueBool = ";
                    string loopBoolTrue = "true";
                    string loopDo = "do\n";
                    string loopWhile = "while ";
                    string condition = "(trueBool)\n\n";
                    string bracket = "{\n\n";
                    string loopBoolFalse = "false";
                    string loopEnd = ";\n\n}\n";
                    string endLoopLesson = "I first use a variabable known as a ";

                    Tools.StringReader(LoopLesson);
                    Tools.LoopReader(Tools.BlueText(loopBool));
                    Tools.LoopReader(Tools.BlackText(trueBool));
                    Tools.LoopReader(Tools.BlueText(loopBoolTrue));
                    Console.Write(Tools.BlackText(";\n\n"));
                    Tools.LoopReader(Tools.BlueText(loopDo));
                    Tools.LoopReader(Tools.BlackText(bracket));
                    Tools.LoopReader(trueBool);
                    Tools.LoopReader(Tools.BlueText(loopBoolFalse));
                    Tools.LoopReader(Tools.BlackText(loopEnd));
                    Tools.LoopReader(Tools.BlueText(loopWhile));
                    Tools.StringReader(Tools.BlackText(condition));
                    Tools.LoopReader(endLoopLesson);
                    Tools.Highlighter("bool");
                    Tools.LoopReader(Tools.BlackText(", which is used for true, false statements .\n" +
                    "I then declare that "));
                    Tools.Highlighter("bool");
                    Tools.LoopReader(Tools.BlackText(", which is named trueBool, is set to true.\n" +
                    "Then the "));
                    Tools.Highlighter("do while loop");
                    Tools.LoopReader(Tools.BlackText(" goes through whatever code you have in the "));
                    Tools.Highlighter("body");
                    Tools.LoopReader(Tools.BlackText(" of the loop,\n" +
                    "in the example I set trueBool to "));
                    Tools.Highlighter("false");
                    Tools.LoopReader(Tools.BlackText(" in the "));
                    Tools.Highlighter("body");
                    Tools.LoopReader(Tools.BlackText(" of this "));
                    Tools.Highlighter("do while loop");
                    Tools.LoopReader(Tools.BlackText(".\n" +
                    "Once the loop reaches the end, the "));
                    Tools.Highlighter("while");
                    Tools.LoopReader(Tools.BlackText(" part of this "));
                    Tools.Highlighter("do while loop");
                    Tools.LoopReader(Tools.BlackText(" appears.\n"));
                    Tools.Highlighter("while (trueBool)");
                    Tools.LoopReader(Tools.BlackText(" is asking if trueBool, or whatever you have in the parenthesis, is "));
                    Tools.Highlighter("true");
                    Tools.LoopReader(Tools.BlackText(".\n" +
                    "If the answer is "));
                    Tools.Highlighter("false");
                    Tools.LoopReader(Tools.BlackText(" then the "));
                    Tools.Highlighter("do while loop");
                    Tools.LoopReader(Tools.BlackText(" will break out of the loop.\n" +
                    "I hope you can see where this may be useful, sometimes you want to do an equation before\n" +
                    "exiting a loop. The "));
                    Tools.Highlighter("do while loop");
                    Tools.LoopReader(Tools.BlackText(" is very good at what it does."));

                    Lesson(LoopArray, Tools.ContSelectionScreen("do while loop"));
                }
                else if (LoopCont == "2")
                {
                    Tools.Header();
                    string LoopDemo = "Ok now today I am going to ask you to type out some lines of code.\nThe ";
                    string loopBool = "bool ";
                    string trueBool = "trueBool = ";
                    string loopBoolTrue = "true";
                    string loopDo = "do\n";
                    string loopWhile = "while ";
                    string condition = "(trueBool)\n\n";
                    string bracket = "{\n\n";
                    string loopBoolFalse = "false";
                    string loopEnd = ";\n\n}\n";

                    Tools.StringReader(LoopDemo);
                    Tools.Highlighter("do while loop");
                    Tools.LoopReader(Tools.BlackText(" can be typed in different ways but for learning\n" +
                    "purposes I will need you to be exact today. Lets start!\n" +
                    "I will now type out the lines and ask you to repeat it.\n\n"));
                    Tools.LoopReader(Tools.BlueText(loopBool));
                    Tools.LoopReader(Tools.BlackText(trueBool));
                    Tools.LoopReader(Tools.BlueText(loopBoolTrue));
                    Console.Write(Tools.BlackText(";\n\n"));
                    Tools.LoopReader(Tools.BlueText(loopDo));
                    Tools.LoopReader(Tools.BlackText(bracket));
                    Tools.LoopReader(trueBool);
                    Tools.LoopReader(Tools.BlueText(loopBoolFalse));
                    Tools.LoopReader(Tools.BlackText(loopEnd));
                    Tools.LoopReader(Tools.BlueText(loopWhile));
                    Tools.StringReader(Tools.BlackText(condition));
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
                            Console.Write(Tools.BlueText(loopBool));
                            Console.Write(Tools.BlackText(trueBool));
                            Console.Write(Tools.BlueText("true"));
                            Console.WriteLine(Tools.BlackText(";"));
                        }
                        else if (i == 2 && answer == LoopArray[2])
                        {
                            Console.SetCursorPosition(0, Console.CursorTop - 1);
                            Console.Write(new string(' ', Console.WindowWidth));
                            Console.SetCursorPosition(0, Console.CursorTop);
                            Console.SetCursorPosition(0, Console.CursorTop - 1);
                            Console.WriteLine(Tools.BlueText("do"));
                            Tools.BlackText("");
                        }
                        else if (i == 5 && answer == LoopArray[5])
                        {
                            Console.SetCursorPosition(0, Console.CursorTop - 1);
                            Console.Write(new string(' ', Console.WindowWidth));
                            Console.SetCursorPosition(0, Console.CursorTop);
                            Console.SetCursorPosition(0, Console.CursorTop - 1);
                            Console.Write(trueBool);
                            Console.Write(Tools.BlueText("false"));
                            Console.WriteLine(Tools.BlackText(";"));
                        }
                        else if (i == 8 && answer == LoopArray[8])
                        {
                            Console.SetCursorPosition(0, Console.CursorTop - 1);
                            Console.Write(new string(' ', Console.WindowWidth));
                            Console.SetCursorPosition(0, Console.CursorTop);
                            Console.SetCursorPosition(0, Console.CursorTop - 1);
                            Console.Write(Tools.BlueText(loopWhile));
                            Console.WriteLine(Tools.BlackText("(trueBool)"));
                        }


                        int h = LoopArray.Length - 1;
                        if (i == h)
                        {
                            Tools.BlackText("");
                            Tools.Header();
                            string victory = "\nCongratulations! You have just coded the - DO WHILE LOOP!! -\n";
                            Tools.StringReader(victory);
                            Lesson(LoopArray, Tools.SelectionScreen("do while loop"));
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
                    Tools.Header();
                    Console.Write("\nThat is not correct response. Press 1. or 2. please: ");
                }
            }
        }


    }
}



