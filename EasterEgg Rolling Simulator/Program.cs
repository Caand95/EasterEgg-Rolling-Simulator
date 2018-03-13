using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasterEgg_Rolling_Simulator
{
    class Program
    {
        //Statics();
        static string programbanner = System.IO.File.ReadAllText(@"..\..\ASCII\Easter_banner.txt");
        static string[] menu =
            {
                    "Close",
                    ""
            };


        static void Main(string[] args)
        {

            //INIT();

            string menuint;

            //PROGRAM();
            Output(programbanner);
            bool program = true;
            while (program)
            {
                menuint = Menu(menu);
                switch (menuint)
                {

                    case "-":
                        break;
                    default:
                        Output("Something went wrong");
                        break;
                }
                Output("press anykey to return to the menu...");

                Wait();
                Clear();
            }
        }

        //GUI METHODs
        static void Output(string text)
        {
            Console.WriteLine(text);
        }

        static string Input(string text)
        {
            Console.Write(text);
            return Console.ReadLine();
        }

        static void Wait()
        {
            Console.ReadKey();
        }

        static void Clear()
        {
            Console.Clear();
        }

        static string Menu(string[] menu)
        {
            Output("\nMenu:");
            for (int i = 1; i < menu.Length; i++)
            {
                Output(i + ". " + menu[i]);
            }
            Output("0. " + menu[0]);
            return Input("\nEnter your choice: ");
        }

        //LOGIC METHODs



    }
}