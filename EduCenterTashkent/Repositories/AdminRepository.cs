using ConsoleTables;
using EduCenterTashkent.Menus;
using EduCenterTashkent.Models;
using EduCenterTashkent.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace EduCenterTashkent.Repositories
{
    internal class AdminRepository
    {
        #region Add Admin Repository   |   Done
        public static void AddAdmin(Admins admin)
        {
            string json = File.ReadAllText(Constants.AdminsDB);
            IList<Admins> admins = JsonConvert.DeserializeObject<IList<Admins>>(json);

            admins.Add(new Admins()
            {
                FirstName = admin.FirstName,
                LastName = admin.LastName,
                PhoneNum = admin.PhoneNum,
                UserName = admin.UserName,
                Password = admin.Password
            });

            string jsoon = JsonConvert.SerializeObject(admins);
            File.WriteAllText(Constants.AdminsDB, jsoon);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n\t\t\t\t\t\t\tThe admin joined successfully");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Thread.Sleep(3000);
            Console.Clear();
            MainMenu.MainMenuAdmins();
        }
        #endregion

        #region Delete Admin Repository   |   Done
        public static void DeleteAdmin(Admins admin)
        {

            string json = File.ReadAllText(Constants.AdminsDB);
            IList<Admins> admins = JsonConvert.DeserializeObject<IList<Admins>>(json);

            var adminsCollect = admins.Where(p => p.FirstName == admin.FirstName && p.LastName == admin.LastName && p.PhoneNum == admin.PhoneNum).ToList();

            if (adminsCollect.Count > 0)
            {
                foreach (var item in adminsCollect)
                {
                    admins.Remove(item);
                }

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("\t\t\t\t\tAdmin was deleted succesfuly!");
                Console.ForegroundColor = ConsoleColor.DarkCyan;

                string res = JsonConvert.SerializeObject(admins);
                File.WriteAllText(Constants.AdminsDB, res);

                Thread.Sleep(3000);
                Console.Clear();
                MainMenu.MainMenuAdmins();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n\n\t\t\t\t\t\t\tThis student is not in database!");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Thread.Sleep(3000);
                Console.Clear();
                MainMenu.MainMenuAdmins();
            }

        }


        #endregion

        #region Update Student Repository   |   Done
        public static void UpdateAdmin(Admins admin, int updatechoice, string newword)
        {
            int check = 0;
            string json = File.ReadAllText(Constants.AdminsDB);
            IList<Admins> admins = JsonConvert.DeserializeObject<IList<Admins>>(json);

            IList<Admins> adminss = new List<Admins>();

            foreach (Admins std in admins)
            {
                if (json is not null or "")
                {
                    if (std.FirstName == admin.FirstName && std.LastName == admin.LastName && std.PhoneNum == admin.PhoneNum)
                    {
                        switch (updatechoice)
                        {
                            case 1:
                                std.FirstName = newword;
                                break;
                            case 2:
                                std.LastName = newword;
                                break;
                            case 3:
                                std.PhoneNum = newword;
                                break;
                            case 4:
                                std.UserName = newword;
                                break;
                            case 5:
                                std.Password = newword;
                                break;
                        }
                        check++;

                        adminss.Add(std);
                    }
                    else adminss.Add(std);
                }
            }

            string json2 = JsonConvert.SerializeObject(adminss);
            File.WriteAllText(Constants.AdminsDB, json2);

            if (check > 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\n\t\t\t\t\t\t\t\tSucces changed!");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                MainMenu.MainMenuProgram();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n\t\t\t\t\t\t\t\tDoesn't exist");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
        }

        #endregion

        #region Student is in database (checker)    |   Done
        public static void IsInDatabase(Admins admin)
        {

            string json = File.ReadAllText(Constants.StudentDbPath);
            IList<Admins> admins = JsonConvert.DeserializeObject<IList<Admins>>(json);

            var studentcollect = admins.Where(p => p.FirstName == admin.FirstName && p.LastName == admin.LastName && p.PhoneNum == admin.PhoneNum).ToList();

            if (studentcollect.Count > 0)
            {
                return;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n\n\t\t\t\t\t\t\t    This admin is not in database!");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Thread.Sleep(3000);
                Console.Clear();
                MainMenu.MainMenuAdmins();
            }

        }

        #endregion

    }
}