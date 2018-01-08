using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LearningTool
{
    class Tools
    {
        public static void Header()
        {

            Console.WriteLine(GreenText("\n====================================================\n" +
                "===================================================="));
            BlackText("");
        }

        public static string SelectionScreen(string data)
        {

            Header();
            string selectionScreen = $"\nIf you would like to learn more on the {data} Press 1.\n" +
                           "Or please, to continue with coding, Press 2.\n" +
                           "Learn about a different Loops? Press 3.\n" +
                           "And you can always exit, Press 4.\n";
            for (int i = 0; i < selectionScreen.Length; i++)
            {
                Console.Write(selectionScreen[i]);
                System.Threading.Thread.Sleep(10); // Sleep for 10 milliseconds
            }
            string LoopCont = Console.ReadLine();
            Console.Clear();
            return LoopCont;
        }

        public static string ContSelectionScreen(string data)
        {

            Header();
            string selectionScreen = $"\nTo continue with coding a {data}, Press 1.\n" +
                           "Learn about a different Loops? Press 2.\n" +
                           "And you can always exit, Press 3.\n";
            for (int i = 0; i < selectionScreen.Length; i++)
            {
                Console.Write(selectionScreen[i]);
                System.Threading.Thread.Sleep(10); // Sleep for 10 milliseconds
            }
            string LoopCont = Console.ReadLine();
            int tempInt = Convert.ToInt16(LoopCont);
            tempInt = tempInt + 1;
            LoopCont = tempInt.ToString();
            Console.Clear();
            return LoopCont;
        }

        public static void StringReader(string data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i]);
                System.Threading.Thread.Sleep(40); // Sleep for 40 milliseconds
            }
            System.Threading.Thread.Sleep(800);
        }

        public static void LoopReader(string data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i]);
                System.Threading.Thread.Sleep(40); // Sleep for 40 milliseconds
            }
        }

        public static string[] ArrayMaker(LinkedList data)
        {
            int counter = 0;
            int arraySize = data.Count;
            string[] LoopArray = new string[0];
            for (int i = 0; i < data.Count; i++)
            {
                if (counter == 0)
                {
                    LoopArray = new string[arraySize];
                    LoopArray[0] = (string)data.Find(i);
                }
                else if (counter > 0)
                {
                    LoopArray[counter] = (string)data.Find(i);
                }
                counter++;
            }
            return LoopArray;
        }

        public static void GrayBackground()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
        }

        public static string BlackText(string text)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            return text;
        }

        public static string GreenText(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            return text;
        }

        public static string BlueText(string text)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            return text;
        }

        public static string YellowText(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            return text;
        }

        public static void Highlighter(string text)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);
                System.Threading.Thread.Sleep(40); // Sleep for 40 milliseconds
            }
            Console.BackgroundColor = ConsoleColor.Gray;
        }
    }
}
