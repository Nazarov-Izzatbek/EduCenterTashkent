using EduCenterTashkent.IRepositories;
using EduCenterTashkent.Menus;
using EduCenterTashkent.Models;
using EduCenterTashkent.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace EduCenterTashkent.Repositories
{
    internal class RegistrationRepository : IRegistrationRepository
    {
        public void CheckLogin(string userName, string password)
        {
            string json = File.ReadAllText(Constants.AdminsDB);
            List<Admins> admins = JsonConvert.DeserializeObject<List<Admins>>(json);
            int errorsCount = 0;

            foreach (Admins admin in admins)
            {
                if (admin.UserName == userName && admin.Password == password)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\n\n\t\t\t\t\t\t\t\t   Successfully logged in!");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;

                    File.WriteAllText(Constants.SuccesLogInTime, DateTime.Now.ToString("MM/dd/yyyy hh:mm tt"));
                    File.AppendAllText(Constants.WhoWhenLogIn, $"{File.ReadAllText(Constants.SuccesLogInTime)}| {admin.FirstName} {admin.LastName}\n");
                    File.WriteAllText(Constants.SuccesLogInTime, $"{File.ReadAllText(Constants.SuccesLogInTime)}| {admin.FirstName} {admin.LastName}");

                    Thread.Sleep(1500); Console.Clear();
                    MainMenu.MainMenuProgram();
                }
                else
                {
                    errorsCount++;
                }
                if (errorsCount == admins.Count)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\n\n\t\t\t\t\t\t\t   There is an error in LogIn or Password!\n\t\t\t\t\t\t\t\t      Re-Enter please!");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Thread.Sleep(3000); Console.Clear();
                    StarterMenu.IntroductionWindow();
                }
            }
        }


    }
}
