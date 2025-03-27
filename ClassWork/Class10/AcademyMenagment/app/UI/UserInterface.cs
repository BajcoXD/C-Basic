using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.UI
{
    public class UserInterface
    {
        public bool InitApp()
        {
            WelcomeMenu();

            return false;
        }
        public void WelcomeMenu()
        {
            WriteInColor("Welcome to Academy Menagment!" , ConsoleColor.DarkCyan);
            WriteInColor("Choose your role to login: \n1.Admin \n2.Trainer \n3.Student", ConsoleColor.Cyan);
        }
        public void WriteInColor(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
