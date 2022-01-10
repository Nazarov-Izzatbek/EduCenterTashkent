using EduCenterTashkent.Menus;
using EduCenterTashkent.Service;
using System;
using System.IO;
using WindowsInput;

namespace EduCenterTashkent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InputSimulator input = new InputSimulator();
            input.Keyboard.ModifiedKeyStroke(WindowsInput.Native.VirtualKeyCode.LWIN, WindowsInput.Native.VirtualKeyCode.UP);

            Console.Title = "Edu Center Tashkent by Izzatbek Nazarov     |    Version 0.0.1";
            string systemRunTime = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
            File.WriteAllText(Constants.WhenSystemRun, systemRunTime);

            StarterMenu.IntroductionWindow();
        }
    }
}
