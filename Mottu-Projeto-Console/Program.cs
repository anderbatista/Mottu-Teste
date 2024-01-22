using System;
using System.Collections.Generic;
using System.Linq;
using Mottu_Projeto_Console;

namespace Mottu_Projeto_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.ExibirMenu();            

            Console.ReadLine();
        }
    }
}
