using EduCenterTashkent.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EduCenterTashkentWithAdmin.Media
{
    internal class Media
    {

        #region Counter before enter the menu (5-4-3-2-1)   |   Done
        public static void WelcomeMedia()
        {
            if (OperatingSystem.IsWindows())
            {
                SoundPlayer welcomeSound = new SoundPlayer(Constants.Counter);
                welcomeSound.Load();
                welcomeSound.Play();
                //welcomeSound.PlayLooping();
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.Write("\n\n\n\n\n\n\n\n\n" + @"
                                                                     ████████████████
                                                                     █░░░░░░░░░░░░░░█
                                                                     █░░▄▀▄▀▄▀▄▀▄▀░░█
                                                                     █░░░░░░░░░░▄▀░░█
                                                                     █████████░░▄▀░░█
                                                                     █░░░░░░░░░░▄▀░░█
                                                                     █░░▄▀▄▀▄▀▄▀▄▀░░█
                                                                     █░░░░░░░░░░▄▀░░█
                                                                     █████████░░▄▀░░█
                                                                     █░░░░░░░░░░▄▀░░█
                                                                     █░░▄▀▄▀▄▀▄▀▄▀░░█
                                                                     █░░░░░░░░░░░░░░█
                                                                     ████████████████");

            Thread.Sleep(800); Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\n\n\n\n\n\n\n\n\n" + @"
                                                                     ████████████████
                                                                     █░░░░░░░░░░░░░░█
                                                                     █░░▄▀▄▀▄▀▄▀▄▀░░█
                                                                     █░░░░░░░░░░▄▀░░█
                                                                     █████████░░▄▀░░█
                                                                     █░░░░░░░░░░▄▀░░█
                                                                     █░░▄▀▄▀▄▀▄▀▄▀░░█
                                                                     █░░▄▀░░░░░░░░░░█
                                                                     █░░▄▀░░█████████
                                                                     █░░▄▀░░░░░░░░░░█
                                                                     █░░▄▀▄▀▄▀▄▀▄▀░░█
                                                                     █░░░░░░░░░░░░░░█
                                                                     ████████████████");

            Thread.Sleep(800); Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n\n\n\n\n\n\n\n" + @"
                                                                       ████████████
                                                                       █░░░░░░░░███
                                                                       █░░▄▀▄▀░░███
                                                                       █░░░░▄▀░░███
                                                                       ███░░▄▀░░███
                                                                       ███░░▄▀░░███
                                                                       ███░░▄▀░░███
                                                                       ███░░▄▀░░███
                                                                       ███░░▄▀░░███
                                                                       █░░░░▄▀░░░░█
                                                                       █░░▄▀▄▀▄▀░░█
                                                                       █░░░░░░░░░░█
                                                                       ████████████");

            Thread.Sleep(1000); Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n\n\n\n\n\n\n\n\n" + @"
                                                                     ████████████████
                                                                     █░░░░░░░░░░░░░░█
                                                                     █░░▄▀▄▀▄▀▄▀▄▀░░█
                                                                     █░░▄▀░░░░░░▄▀░░█
                                                                     █░░▄▀░░██░░▄▀░░█
                                                                     █░░▄▀░░██░░▄▀░░█
                                                                     █░░▄▀░░██░░▄▀░░█
                                                                     █░░▄▀░░██░░▄▀░░█
                                                                     █░░▄▀░░██░░▄▀░░█
                                                                     █░░▄▀░░░░░░▄▀░░█
                                                                     █░░▄▀▄▀▄▀▄▀▄▀░░█
                                                                     █░░░░░░░░░░░░░░█
                                                                     ████████████████");

            Thread.Sleep(1000); Console.Clear(); WelcomeToCenter();

        }

        #endregion

        #region If Sytem exit   |   Done

        public static void WelcomeToCenter()
        {
            if (OperatingSystem.IsWindows())
            {
                SoundPlayer welcomeSystem = new SoundPlayer(Constants.WelcomeCenter);
                welcomeSystem.Load();
                welcomeSystem.Play();
            }
        }

        #endregion

        #region If LogIn and Password is true / false  |   Done

        public static void SuccesfulLogIn()
        {

            if (OperatingSystem.IsWindows())
            {
                SoundPlayer succesLogIn = new SoundPlayer(Constants.SuccesLogIn);
                succesLogIn.Load();
                succesLogIn.Play();
            }

        }

        public static void ErrorLogIn1()
        {

            if (OperatingSystem.IsWindows())
            {
                SoundPlayer errorSound1 = new SoundPlayer(Constants.ErorLogInSound1);
                errorSound1.Load();
                errorSound1.Play();
            }

        }

        public static void ErrorLogIn2()
        {

            if (OperatingSystem.IsWindows())
            {
                if (OperatingSystem.IsWindows())
                {
                    SoundPlayer errorSound2 = new SoundPlayer(Constants.ErorLogInSound2);
                    errorSound2.Load();
                    errorSound2.Play();
                }
            }

        }

        #endregion

        #region If Sytem exit   |   Done

        public static void SystemExit()
        {
            if (OperatingSystem.IsWindows())
            {
                Thread.Sleep(800);
                SoundPlayer systemExit = new SoundPlayer(Constants.SystemExit);
                systemExit.Load();
                systemExit.Play();
            }
        }

        #endregion

        #region Enter to the main menu   |   Done

        public static void EnterMainMenu()
        {
            if (OperatingSystem.IsWindows())
            {
                Thread.Sleep(800);
                SoundPlayer systemExit = new SoundPlayer(Constants.SystemExit);
                systemExit.Load();
                systemExit.Play();
            }
        }

        #endregion

    }
}
