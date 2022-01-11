using EduCenterTashkent.Repositories;
using EduCenterTashkent.Service;
using EduCenterTashkentWithAdmin.Media;
using System;
using System.IO;
using System.Threading;
using WindowsInput;

namespace EduCenterTashkent.Menus
{
    internal class StarterMenu
    {

        public static string StartSytemTime()
        {
            string sytemRunTime = File.ReadAllText(Constants.WhenSystemRun);
            return sytemRunTime;

        }

        public static void IntroductionWindow()
        {
            string sys = StartSytemTime();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n" +
                    "\t\t\t\t   ███████╗ ██████╗░ ██╗░░░██╗    ░█████╗░ ███████╗ ███╗░░██╗ ████████╗ ███████╗ ██████╗░\n" +
                    "\t\t\t\t   ██╔════╝ ██╔══██╗ ██║░░░██║    ██╔══██╗ ██╔════╝ ████╗░██║ ╚══██╔══╝ ██╔════╝ ██╔══██╗\n" +
                    "\t\t\t\t   █████╗░░ ██║░░██║ ██║░░░██║    ██║░░╚═╝ █████╗░░ ██╔██╗██║ ░░░██║░░░ █████╗░░ ██████╔╝\n" +
                    "\t\t\t\t   ██╔══╝░░ ██║░░██║ ██║░░░██║    ██║░░██╗ ██╔══╝░░ ██║╚████║ ░░░██║░░░ ██╔══╝░░ ██╔══██╗\n" +
                    "\t\t\t\t   ███████╗ ██████╔╝ ╚██████╔╝    ╚█████╔╝ ███████╗ ██║░╚███║ ░░░██║░░░ ███████╗ ██║░░██║\n" +
                    "\t\t\t\t   ╚══════╝ ╚═════╝░░ ╚═════╝░    ░╚════╝░ ╚══════╝ ╚═╝░░╚══╝ ░░░╚═╝░░░ ╚══════╝ ╚═╝░░╚═╝\n" +
                    "\n" +
                    "\t\t\t\t         ████████╗ ░█████╗░ ░██████╗ ██╗░░██╗ ██╗░░██╗ ███████╗ ███╗░░██╗ ████████╗\n" +
                    "\t\t\t\t         ╚══██╔══╝ ██╔══██╗ ██╔════╝ ██║░░██║ ██║░██╔╝ ██╔════╝ ████╗░██║ ╚══██╔══╝\n" +
                    "\t\t\t\t         ░░░██║░░░ ███████║ ╚█████╗░ ███████║ █████═╝░ █████╗░░ ██╔██╗██║ ░░░██║░░░\n" +
                    "\t\t\t\t         ░░░██║░░░ ██╔══██║ ░╚═══██╗ ██╔══██║ ██╔═██╗░ ██╔══╝░░ ██║╚████║ ░░░██║░░░\n" +
                    "\t\t\t\t         ░░░██║░░░ ██║░░██║ ██████╔╝ ██║░░██║ ██║░╚██╗ ███████╗ ██║░╚███║ ░░░██║░░░\n" +
                    "\t\t\t\t         ░░░╚═╝░░░ ╚═╝░░╚═╝ ╚═════╝░ ╚═╝░░╚═╝ ╚═╝░░╚═╝ ╚══════╝ ╚═╝░░╚══╝ ░░░╚═╝░░░\n" +

                    $"\n\t\t\t\t\t\t\tTime the system was started: {sys}");
            
            LogInOrExit();

        }

        #region LogIn or Exit

        public static void LogInOrExit()
        {
            string LoginAndExitMenu = "|    1) LogIn    |    2) Exit    |";
            Console.Write("\n\t\t\t\t\t\t\t      "); for (int i = 0; i < LoginAndExitMenu.Length; i++) Console.Write("-");
            Console.Write($"\n\t\t\t\t\t\t\t      {LoginAndExitMenu}");
            Console.Write("\n\t\t\t\t\t\t\t      "); for (int i = 0; i < LoginAndExitMenu.Length; i++) Console.Write("-");

            try
            {
                Console.Write("\n\t\t\t\t\t\t\t\t\t   >>> "); int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.Write("\n\t\t\t\t\t\t\t\t         Login: ");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    string login = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;

                    Console.Write("\t\t\t\t\t\t\t\t      Password: ");
                    string password = (string)HidePassword();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;

                    RegistrationRepository checkLogin = new RegistrationRepository();
                    checkLogin.CheckLogin(login, password);
                }
                else if (choice == 2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Media.SystemExit();
                    Console.Write("\n\t\t\t\t\t\t\t\t\tSystem exit");
                    for (int i = 0; i < 3; i++)
                    {
                        Thread.Sleep(500);
                        Console.Write(".");
                    }
                    Thread.Sleep(1000);
                    InputSimulator input = new InputSimulator();

                    input.Keyboard.ModifiedKeyStroke(WindowsInput.Native.VirtualKeyCode.MENU, WindowsInput.Native.VirtualKeyCode.F4);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\n\t\t\t\t\t\t    There is no such menu. Please re-enter your transaction!");
                    Thread.Sleep(3000);
                    Console.Clear();
                    IntroductionWindow();
                }
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n\t\t\t\t\t\t    Wrong character! Please re-enter your transaction!");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Thread.Sleep(3000);
                Console.Clear();
                IntroductionWindow();
            }
        }

        #endregion

        public static object HidePassword()
        {
            string hidePassword = "";
            while (true)
            {
            place:
                try
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    switch (key.Key)
                    {
                        case ConsoleKey.Escape:
                            return null;
                        case ConsoleKey.Enter:
                            return hidePassword;
                        case ConsoleKey.Backspace:
                            hidePassword = hidePassword.Substring(0, (hidePassword.Length - 1));
                            Console.Write("\b \b");
                            break;
                        default:
                            hidePassword += key.KeyChar;
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("*");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            break;
                    }
                }
                catch
                {
                    goto place;
                }
            }
        }
    }
}
