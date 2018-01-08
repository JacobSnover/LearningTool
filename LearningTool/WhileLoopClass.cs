using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningTool
{
    class WhileLoopClass
    {

        public static void WhileLoop()
        {
            LinkedList temp = new WModLoopClass("while (trueBool)", "{", "", "}", "bool trueBool = true;", "trueBool = false;").ToList();
            string[] LoopArray = Tools.ArrayMaker(temp);

            Tools.Header();
            string firstMsg = "Today we are going to talk about the ";
            string loopBool = "bool ";
            string trueBool = "trueBool = ";
            string loopBoolTrue = "true";
            string loopWhile = "while ";
            string condition = "(trueBool)\n{\n\n";
            string loopBoolFalse = "false";
            string loopEnd = ";\n\n}\n\n";
            string endFirstMsg = "If you've never seen this before you might not know what's happening.\n" +
            "But today I will show you that the ";

            Tools.LoopReader(firstMsg);
            Tools.Highlighter("while loop");
            Tools.LoopReader(Tools.BlackText(" in .Net!! \nThe "));
            Tools.Highlighter("while loop");
            Tools.LoopReader(Tools.BlackText(" that we use today will look like this\n\n"));
            Tools.LoopReader(Tools.BlueText(loopBool));
            Tools.LoopReader(Tools.BlackText(trueBool));
            Tools.LoopReader(Tools.BlueText(loopBoolTrue));
            Console.Write(Tools.BlackText(";\n\n"));
            Tools.LoopReader(Tools.BlueText(loopWhile));
            Tools.LoopReader(Tools.BlackText(condition));
            Tools.LoopReader(trueBool);
            Tools.LoopReader(Tools.BlueText(loopBoolFalse));
            Tools.StringReader(Tools.BlackText(loopEnd));
            Tools.LoopReader(endFirstMsg);
            Tools.Highlighter("while loop");
            Tools.LoopReader(Tools.BlackText(" is simple and very effective.\n"));
            string LoopCont = Tools.SelectionScreen("while loop");

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
                    string loopBool = "bool ";
                    string trueBool = "trueBool = ";
                    string loopBoolTrue = "true";
                    string loopWhile = "while ";
                    string condition = "(trueBool)\n{\n\n";
                    string loopBoolFalse = "false";
                    string loopEnd = ";\n\n}\n\n";
                    string endLoopLesson = "I first use a variable known as a ";


                    Tools.LoopReader(LoopLesson);
                    Tools.Highlighter("while loop");
                    Tools.StringReader(Tools.BlackText(" has one main thing it does, check for true or false.\n\n"));
                    Tools.LoopReader(Tools.BlueText(loopBool));
                    Tools.LoopReader(Tools.BlackText(trueBool));
                    Tools.LoopReader(Tools.BlueText(loopBoolTrue));
                    Console.Write(Tools.BlackText(";\n\n"));
                    Tools.LoopReader(Tools.BlueText(loopWhile));
                    Tools.LoopReader(Tools.BlackText(condition));
                    Tools.LoopReader(trueBool);
                    Tools.LoopReader(Tools.BlueText(loopBoolFalse));
                    Tools.StringReader(Tools.BlackText(loopEnd));
                    Tools.LoopReader(endLoopLesson);
                    Tools.Highlighter("bool");
                    Tools.LoopReader(Tools.BlackText(", which is used for true, false statements.\n" +
                    "I then declare that "));
                    Tools.Highlighter("bool");
                    Tools.LoopReader(Tools.BlackText(" which is named "));
                    Tools.Highlighter("trueBool");
                    Tools.LoopReader(Tools.BlackText(", is set to true.\n" +
                    "I write the beginning of my "));
                    Tools.Highlighter("while loop");
                    Tools.LoopReader(Tools.BlackText(" which looks like this "));
                    Tools.Highlighter("while (trueBool)");
                    Tools.LoopReader(Tools.BlackText(".\nThe "));
                    Tools.Highlighter("while loop");
                    Tools.LoopReader(Tools.BlackText(" first asks if what is in the parenthesis is true. In this case it is.\n" +
                    "Whether you use a variable like I did, with "));
                    Tools.Highlighter("trueBool");
                    Tools.LoopReader(Tools.BlackText(", or use an equation of sorts,\n" +
                    "the "));
                    Tools.Highlighter("while loop");
                    Tools.LoopReader(Tools.BlackText(" will determine if it is true and if it is, then it will perform what\n" +
                    "is in the "));
                    Tools.Highlighter("body");
                    Tools.LoopReader(Tools.BlackText(" of the "));
                    Tools.Highlighter("while loop");
                    Tools.LoopReader(Tools.BlackText(". You can see that I set "));
                    Tools.Highlighter("trueBool");
                    Tools.LoopReader(Tools.BlackText(" to false in the loop.\n" +
                    "This is done to "));
                    Tools.Highlighter("break out from the loop");
                    Tools.LoopReader(Tools.BlackText(", once I am done. If you don't break out of the\n" +
                    "loop at some point then it will be an endless loop. There, now you can see that a "));
                    Tools.Highlighter("while loop");
                    Tools.LoopReader(Tools.BlackText("\n" +
                    "does one simple task, which is ask if something is true, but also allows the user control."));

                    Lesson(LoopArray, Tools.ContSelectionScreen("while loop"));
                }
                else if (LoopCont == "2")
                {
                    Tools.Header();
                    string LoopDemo = "Ok now today I am going to ask you to type out some lines of code.\nThe ";
                    string loopBool = "bool ";
                    string trueBool = "trueBool = ";
                    string loopBoolTrue = "true";
                    string loopWhile = "while ";
                    string condition = "(trueBool)\n{\n\n";
                    string loopBoolFalse = "false";
                    string loopEnd = ";\n\n}\n\n";

                    Tools.LoopReader(LoopDemo);
                    Tools.Highlighter("while loop");
                    Tools.LoopReader(Tools.BlackText(" can be typed in different ways but for learning\n" +
                    "purposes I will need you to be exact today. Lets start!\n" +
                    "I will now type out the lines and ask you to repeat it.\n\n"));
                    Tools.LoopReader(Tools.BlueText(loopBool));
                    Tools.LoopReader(Tools.BlackText(trueBool));
                    Tools.LoopReader(Tools.BlueText(loopBoolTrue));
                    Console.Write(Tools.BlackText(";\n\n"));
                    Tools.LoopReader(Tools.BlueText(loopWhile));
                    Tools.LoopReader(Tools.BlackText(condition));
                    Tools.LoopReader(trueBool);
                    Tools.LoopReader(Tools.BlueText(loopBoolFalse));
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
                            Console.Write(Tools.BlueText(loopWhile));
                            Console.WriteLine(Tools.BlackText("(trueBool)"));
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

                        int h = LoopArray.Length - 1;
                        if (i == h)
                        {
                            Tools.BlackText("");
                            Tools.Header();
                            string victory = "\nCongratulations! You have just coded the - WHILE LOOP!! -\n";
                            Tools.StringReader(victory);
                            Lesson(LoopArray, Tools.SelectionScreen("while loop"));
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
