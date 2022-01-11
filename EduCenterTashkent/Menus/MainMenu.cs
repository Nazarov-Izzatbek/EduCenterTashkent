using EduCenterTashkent.Models;
using EduCenterTashkent.Repositories;
using EduCenterTashkent.Service;
using EduCenterTashkentWithAdmin.Media;
using System;
using System.IO;
using System.Threading;
using WindowsInput;

namespace EduCenterTashkent.Menus
{
    internal class MainMenu
    {
        public static void MainMenuProgram()
        {
        MainMenu:
            Console.Write(@"
                                    ███╗░░░███╗ ░█████╗░ ██╗ ███╗░░██╗    ███╗░░░███╗ ███████╗ ███╗░░██╗ ██╗░░░██╗
                                    ████╗░████║ ██╔══██╗ ██║ ████╗░██║    ████╗░████║ ██╔════╝ ████╗░██║ ██║░░░██║
                                    ██╔████╔██║ ███████║ ██║ ██╔██╗██║    ██╔████╔██║ █████╗░░ ██╔██╗██║ ██║░░░██║
                                    ██║╚██╔╝██║ ██╔══██║ ██║ ██║╚████║    ██║╚██╔╝██║ ██╔══╝░░ ██║╚████║ ██║░░░██║
                                    ██║░╚═╝░██║ ██║░░██║ ██║ ██║░╚███║    ██║░╚═╝░██║ ███████╗ ██║░╚███║ ╚██████╔╝
                                    ╚═╝░░░░░╚═╝ ╚═╝░░╚═╝ ╚═╝ ╚═╝░░╚══╝    ╚═╝░░░░░╚═╝ ╚══════╝ ╚═╝░░╚══╝ ░╚═════╝░");

            string succesLogInTime = File.ReadAllText(Constants.SuccesLogInTime);
            string[] vs = succesLogInTime.Split(" | ");

            Console.Write($"\n\n\t\t\t\t\t      Admin: {vs[1]}   |   LogIn time: {vs[0]}\n");

            string mainMenu = "| 1) Reception | 2) Administration | 3) Go back | 4) Exit |";
            Console.Write("\n\t\t\t\t\t      ");
            for (int i = 0; i < mainMenu.Length; i++) Console.Write("-"); Console.Write("\n");
            Console.WriteLine($"\t\t\t\t\t      {mainMenu}");
            Console.Write("\t\t\t\t\t      ");
            for (int i = 0; i < mainMenu.Length; i++) Console.Write("-"); Console.Write("\n");

            Console.Write("\n\t\t\t\t\t\t\t\t\t>>> ");

            try
            {
                int choice = int.Parse(Console.ReadLine());

                #region Reception Menu     |   Full Done

                if (choice == 1)
                {
                AdminMenu:
                    Console.Clear();
                    Console.Write(@"
                                ██████╗░  ███████╗  ░█████╗░  ███████╗  ██████╗░  ████████╗  ██╗  ░█████╗░  ███╗░░██╗
                                ██╔══██╗  ██╔════╝  ██╔══██╗  ██╔════╝  ██╔══██╗  ╚══██╔══╝  ██║  ██╔══██╗  ████╗░██║
                                ██████╔╝  █████╗░░  ██║░░╚═╝  █████╗░░  ██████╔╝  ░░░██║░░░  ██║  ██║░░██║  ██╔██╗██║
                                ██╔══██╗  ██╔══╝░░  ██║░░██╗  ██╔══╝░░  ██╔═══╝░  ░░░██║░░░  ██║  ██║░░██║  ██║╚████║
                                ██║░░██║  ███████╗  ╚█████╔╝  ███████╗  ██║░░░░░  ░░░██║░░░  ██║  ╚█████╔╝  ██║░╚███║
                                ╚═╝░░╚═╝  ╚══════╝  ░╚════╝░  ╚══════╝  ╚═╝░░░░░  ░░░╚═╝░░░  ╚═╝  ░╚════╝░  ╚═╝░░╚══╝");
                    string receptionMenu = "| 1) Add student | 2) Delete student | 3)  Search student | 4) Update student | 5) Go back |";
                    Console.Write("\n\n\t\t\t     ");
                    for (int i = 0; i < receptionMenu.Length; i++) Console.Write("-"); Console.Write("\n");
                    Console.WriteLine($"\t\t\t     {receptionMenu}");
                    Console.Write("\t\t\t     ");
                    for (int i = 0; i < receptionMenu.Length; i++) Console.Write("-"); Console.Write("\n");
                    Console.Write("\n\t\t\t\t\t\t\t\t\t>>> ");
                    try
                    {
                        int adminChoice = int.Parse(Console.ReadLine());
                        Console.Clear();


                        #region Add Student   |   Done

                        if (adminChoice == 1)
                        {
                            Console.Write(@"
                           ░█████╗░  ██████╗░  ██████╗░    ░██████╗  ████████╗  ██╗░░░██╗  ██████╗░  ███████╗  ███╗░░██╗  ████████╗
                           ██╔══██╗  ██╔══██╗  ██╔══██╗    ██╔════╝  ╚══██╔══╝  ██║░░░██║  ██╔══██╗  ██╔════╝  ████╗░██║  ╚══██╔══╝
                           ███████║  ██║░░██║  ██║░░██║    ╚█████╗░  ░░░██║░░░  ██║░░░██║  ██║░░██║  █████╗░░  ██╔██╗██║  ░░░██║░░░
                           ██╔══██║  ██║░░██║  ██║░░██║    ░╚═══██╗  ░░░██║░░░  ██║░░░██║  ██║░░██║  ██╔══╝░░  ██║╚████║  ░░░██║░░░
                           ██║░░██║  ██████╔╝  ██████╔╝    ██████╔╝  ░░░██║░░░  ╚██████╔╝  ██████╔╝  ███████╗  ██║░╚███║  ░░░██║░░░
                           ╚═╝░░╚═╝  ╚═════╝░  ╚═════╝░    ╚═════╝░  ░░░╚═╝░░░  ░╚═════╝░  ╚═════╝░  ╚══════╝  ╚═╝░░╚══╝  ░░░╚═╝░░░");

                            Students student = new Students();

                        ReadData:
                            Console.Write("\n\n\t\t\t\t\t\t          Enter firstname: ");
                            student.FirstName = Console.ReadLine();
                            Console.Write("\t\t\t\t\t\t           Enter lastname: ");
                            student.LastName = Console.ReadLine();
                            Console.Write("\t\t\t\t\t\t   Enter the phone number: ");
                            student.PhoneNum = Console.ReadLine();
                            Console.Write("\t\t\t\t\t\t         Enter the course: ");
                            student.Course = Console.ReadLine();
                            Console.Write("\t\t\t\t\t\t   Enter the group number: ");
                            student.GroupNum = Console.ReadLine();

                            if (student.FirstName == "" || student.LastName == "" || student.PhoneNum == "" || student.Course == "" || student.GroupNum == "")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\n\t\t\t\t\t\t     There is an error in entering data! Re-enter please!\n");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                string queryMenu = "| 1) Re-enter data | 2) Go back |";
                                Console.Write("\t\t\t\t\t\t\t     ");
                                for (int i = 0; i < queryMenu.Length; i++) Console.Write("-");
                                Console.Write($"\n\t\t\t\t\t\t\t     {queryMenu}\n\t\t\t\t\t\t\t     ");
                                for (int i = 0; i < queryMenu.Length; i++) Console.Write("-");
                                Console.Write("\n\t\t\t\t\t\t\t\t\t   >>> ");
                                try
                                {
                                    int queryChoice = int.Parse(Console.ReadLine());
                                    if (queryChoice == 1)
                                    {
                                        Console.Clear();
                                        goto ReadData;
                                    }
                                    else if (queryChoice == 2)
                                    {
                                        goto AdminMenu;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine("\n\t\t\t\t\t\t\t\t    There is no such menu!");
                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        Thread.Sleep(3000);
                                        Console.Clear();
                                        goto AdminMenu;
                                    }
                                }
                                catch
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("\n\t\t\t\t\t\t       Wrong character! Please re-enter your transaction!");
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                    Thread.Sleep(3000);
                                    Console.Clear();
                                    goto AdminMenu;

                                }
                            }
                            else
                            {
                                StudentRepository.AddStudent(student);
                            }

                        }
                        #endregion

                        #region Delete Student  |   Done
                        else if (adminChoice == 2)
                        {
                        ReadData:
                            Console.Write(@"

         ██████╗░  ███████╗  ██╗░░░░░  ███████╗  ████████╗  ███████╗    ░██████╗  ████████╗  ██╗░░░██╗  ██████╗░  ███████╗  ███╗░░██╗  ████████╗
         ██╔══██╗  ██╔════╝  ██║░░░░░  ██╔════╝  ╚══██╔══╝  ██╔════╝    ██╔════╝  ╚══██╔══╝  ██║░░░██║  ██╔══██╗  ██╔════╝  ████╗░██║  ╚══██╔══╝
         ██║░░██║  █████╗░░  ██║░░░░░  █████╗░░  ░░░██║░░░  █████╗░░    ╚█████╗░  ░░░██║░░░  ██║░░░██║  ██║░░██║  █████╗░░  ██╔██╗██║  ░░░██║░░░
         ██║░░██║  ██╔══╝░░  ██║░░░░░  ██╔══╝░░  ░░░██║░░░  ██╔══╝░░    ░╚═══██╗  ░░░██║░░░  ██║░░░██║  ██║░░██║  ██╔══╝░░  ██║╚████║  ░░░██║░░░
         ██████╔╝  ███████╗  ███████╗  ███████╗  ░░░██║░░░  ███████╗    ██████╔╝  ░░░██║░░░  ╚██████╔╝  ██████╔╝  ███████╗  ██║░╚███║  ░░░██║░░░
         ╚═════╝░  ╚══════╝  ╚══════╝  ╚══════╝  ░░░╚═╝░░░  ╚══════╝    ╚═════╝░  ░░░╚═╝░░░  ░╚═════╝░  ╚═════╝░  ╚══════╝  ╚═╝░░╚══╝  ░░░╚═╝░░░");

                            Admins student = new Admins();

                            Console.Write("\n\n\t\t\t\t\t\t        Enter the firstname: ");
                            student.FirstName = Console.ReadLine();

                            Console.Write("\n\t\t\t\t\t\t         Enter the lastname: ");
                            student.LastName = Console.ReadLine();

                            Console.Write("\n\t\t\t\t\t\t     Enter the phone number: ");
                            student.PhoneNum = Console.ReadLine();

                            if (student.FirstName == "" && student.LastName == "" && student.PhoneNum == "")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\n\t\t\t\t\t\t     There is an error in entering data! Re-enter please!\n");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                string queryMenu = "| 1) Re-enter data | 2) Go back |";
                                Console.Write("\t\t\t\t\t\t\t     ");
                                for (int i = 0; i < queryMenu.Length; i++) Console.Write("-");
                                Console.Write($"\n\t\t\t\t\t\t\t     {queryMenu}\n\t\t\t\t\t\t\t     ");
                                for (int i = 0; i < queryMenu.Length; i++) Console.Write("-");
                                Console.Write("\n\t\t\t\t\t\t\t\t\t   >>> ");
                                try
                                {
                                    int queryChoice = int.Parse(Console.ReadLine());
                                    if (queryChoice == 1)
                                    {
                                        Console.Clear();
                                        goto ReadData;
                                    }
                                    else if (queryChoice == 2)
                                    {
                                        goto AdminMenu;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine("\n\t\t\t\t\t\t\t\t    There is no such menu!");
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Thread.Sleep(3000);
                                        Console.Clear();
                                        goto AdminMenu;
                                    }
                                }
                                catch
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("\n\t\t\t\t\t\t       Wrong character! Please re-enter your transaction!");
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Thread.Sleep(3000);
                                    Console.Clear();
                                    goto AdminMenu;

                                }
                            }
                            else
                            {
                                StudentRepository.DeleteStudent(student);
                            }

                        }
                        #endregion

                        #region Search Student   |   Done

                        else if (adminChoice == 3)
                        {

                        ReadData:
                            Console.Write(@"
        ░██████╗  ███████╗  ░█████╗░  ██████╗░  ░█████╗░  ██╗░░██╗    ░██████╗  ████████╗  ██╗░░░██╗  ██████╗░  ███████╗  ███╗░░██╗  ████████╗
        ██╔════╝  ██╔════╝  ██╔══██╗  ██╔══██╗  ██╔══██╗  ██║░░██║    ██╔════╝  ╚══██╔══╝  ██║░░░██║  ██╔══██╗  ██╔════╝  ████╗░██║  ╚══██╔══╝
        ╚█████╗░  █████╗░░  ███████║  ██████╔╝  ██║░░╚═╝  ███████║    ╚█████╗░  ░░░██║░░░  ██║░░░██║  ██║░░██║  █████╗░░  ██╔██╗██║  ░░░██║░░░
        ░╚═══██╗  ██╔══╝░░  ██╔══██║  ██╔══██╗  ██║░░██╗  ██╔══██║    ░╚═══██╗  ░░░██║░░░  ██║░░░██║  ██║░░██║  ██╔══╝░░  ██║╚████║  ░░░██║░░░
        ██████╔╝  ███████╗  ██║░░██║  ██║░░██║  ╚█████╔╝  ██║░░██║    ██████╔╝  ░░░██║░░░  ╚██████╔╝  ██████╔╝  ███████╗  ██║░╚███║  ░░░██║░░░
        ╚═════╝░  ╚══════╝  ╚═╝░░╚═╝  ╚═╝░░╚═╝  ░╚════╝░  ╚═╝░░╚═╝    ╚═════╝░  ░░░╚═╝░░░  ░╚═════╝░  ╚═════╝░  ╚══════╝  ╚═╝░░╚══╝  ░░░╚═╝░░░");
                            Students student = new Students();

                            Console.Write("\n\n\t\t\t\t\t\t        Enter the firstname: ");
                            student.FirstName = Console.ReadLine();

                            Console.Write("\n\t\t\t\t\t\t         Enter the lastname: ");
                            student.LastName = Console.ReadLine();

                            Console.Write("\n\t\t\t\t\t\t     Enter the phone number: ");
                            student.PhoneNum = Console.ReadLine();

                            if (student.FirstName == "" && student.LastName == "" && student.PhoneNum == "")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\n\t\t\t\t\t\t     There is an error in entering data! Re-enter please!\n");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                string queryMenu = "| 1) Re-enter data | 2) Go back |";
                                Console.Write("\t\t\t\t\t\t\t     ");
                                for (int i = 0; i < queryMenu.Length; i++) Console.Write("-");
                                Console.Write($"\n\t\t\t\t\t\t\t     {queryMenu}\n\t\t\t\t\t\t\t     ");
                                for (int i = 0; i < queryMenu.Length; i++) Console.Write("-");
                                Console.Write("\n\t\t\t\t\t\t\t\t\t   >>> ");
                                try
                                {
                                    int queryChoice = int.Parse(Console.ReadLine());
                                    if (queryChoice == 1)
                                    {
                                        Console.Clear();
                                        goto ReadData;
                                    }
                                    else if (queryChoice == 2)
                                    {
                                        goto AdminMenu;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine("\n\t\t\t\t\t\t\t\t    There is no such menu!");
                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        Thread.Sleep(3000);
                                        Console.Clear();
                                        goto AdminMenu;
                                    }
                                }
                                catch
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("\n\t\t\t\t\t\t       Wrong character! Please re-enter your transaction!");
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                    Thread.Sleep(3000);
                                    Console.Clear();
                                    goto AdminMenu;

                                }
                            }
                            else
                            {
                                StudentRepository.SearchStudent(student);
                            }

                            string query = "| 1) Re-enter data | 2) Go back |";
                            Console.Write("\t\t\t\t\t\t\t     ");
                            for (int i = 0; i < query.Length; i++) Console.Write("-");
                            Console.Write($"\n\t\t\t\t\t\t\t     {query}\n\t\t\t\t\t\t\t     ");
                            for (int i = 0; i < query.Length; i++) Console.Write("-");
                            Console.Write("\n\t\t\t\t\t\t\t\t\t   >>> ");
                            try
                            {
                                int queryChoice = int.Parse(Console.ReadLine());
                                if (queryChoice == 1)
                                {
                                    Console.Clear();
                                    goto ReadData;
                                }
                                else if (queryChoice == 2)
                                {
                                    goto AdminMenu;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("\n\t\t\t\t\t\t\t\t    There is no such menu!");
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                    Thread.Sleep(3000);
                                    Console.Clear();
                                    goto AdminMenu;
                                }
                            }
                            catch
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\n\t\t\t\t\t\t       Wrong character! Please re-enter your transaction!");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Thread.Sleep(3000);
                                Console.Clear();
                                goto AdminMenu;

                            }

                        }

                        #endregion

                        #region Update Student   |   Done

                        else if (adminChoice == 4)
                        {
                        ReadData:
                            Console.Write(@"
             ██╗░░░██╗ ██████╗░ ██████╗ ░░█████╗ ░████████╗ ███████╗    ░██████╗ ████████╗ ██╗░░░██╗ ██████╗ ░███████╗ ███╗░░██╗ ████████╗
             ██║░░░██║ ██╔══██╗ ██╔══██╗ ██╔══██╗ ╚══██╔══╝ ██╔════╝    ██╔════╝ ╚══██╔══╝ ██║░░░██║ ██╔══██╗ ██╔════╝ ████╗░██║ ╚══██╔══╝
             ██║░░░██║ ██████╔╝ ██║░░██║ ███████║ ░░░██║░░░ █████╗░░    ╚█████╗ ░░░░██║░░░ ██║░░░██║ ██║░░██║ █████╗░░ ██╔██╗██║ ░░░██║░░░
             ██║░░░██║ ██╔═══╝░ ██║░░██║ ██╔══██║ ░░░██║░░░ ██╔══╝░░    ░╚═══██╗ ░░░██║░░░ ██║░░░██║ ██║░░██║ ██╔══╝░░ ██║╚████║ ░░░██║░░░
             ╚██████╔╝ ██║░░░░░ ██████╔╝ ██║░░██║ ░░░██║░░░ ███████╗    ██████╔╝ ░░░██║░░░ ╚██████╔╝ ██████╔╝ ███████╗ ██║░╚███║ ░░░██║░░░
             ░╚═════╝░ ╚═╝░░░░░ ╚═════╝░ ╚═╝░░╚═╝ ░░░╚═╝░░░ ╚══════╝    ╚═════╝ ░░░░╚═╝░░░░ ╚═════╝░ ╚═════╝░ ╚══════╝ ╚═╝░░╚══╝ ░░░╚═╝░░░");

                            Students student = new Students();

                            Console.Write("\n\n\t\t\t\t\t\t        Enter the firstname: ");
                            student.FirstName = Console.ReadLine();

                            Console.Write("\n\t\t\t\t\t\t         Enter the lastname: ");
                            student.LastName = Console.ReadLine();

                            Console.Write("\n\t\t\t\t\t\t     Enter the phone number: ");
                            student.PhoneNum = Console.ReadLine();

                            if (student.FirstName == "" && student.LastName == "" && student.PhoneNum == "")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\n\t\t\t\t\t\t     There is an error in entering data! Re-enter please!\n");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                string queryMenu = "| 1) Re-enter data | 2) Go back |";
                                Console.Write("\t\t\t\t\t\t\t     ");
                                for (int i = 0; i < queryMenu.Length; i++) Console.Write("-");
                                Console.Write($"\n\t\t\t\t\t\t\t     {queryMenu}\n\t\t\t\t\t\t\t     ");
                                for (int i = 0; i < queryMenu.Length; i++) Console.Write("-");
                                Console.Write("\n\t\t\t\t\t\t\t\t\t   >>> ");
                                try
                                {
                                    int queryChoice = int.Parse(Console.ReadLine());
                                    if (queryChoice == 1)
                                    {
                                        Console.Clear();
                                        goto ReadData;
                                    }
                                    else if (queryChoice == 2)
                                    {
                                        goto AdminMenu;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine("\n\t\t\t\t\t\t\t\t    There is no such menu!");
                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        Thread.Sleep(3000);
                                        Console.Clear();
                                        goto AdminMenu;
                                    }
                                }
                                catch
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("\n\t\t\t\t\t\t       Wrong character! Please re-enter your transaction!");
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                    Thread.Sleep(3000);
                                    Console.Clear();
                                    goto AdminMenu;

                                }
                            }

                            else
                            {
                                StudentRepository.IsInDatabase(student);

                                string queryMenu = "| 1) Update firstname | 2) Update lastname | 3) Update phone number | 4) Update login | 5) Update password |";
                                Console.Write("\n\t\t    ");
                                for (int i = 0; i < queryMenu.Length; i++) Console.Write("-");
                                Console.Write($"\n\t\t    {queryMenu}\n");
                                Console.Write("\t\t    ");
                                for (int i = 0; i < queryMenu.Length; i++) Console.Write("-");
                                Console.Write("\n\t\t\t\t\t\t\t\t\t>>> ");


                                try
                                {
                                    int updateType = int.Parse(Console.ReadLine());


                                    if (updateType <= 0 || updateType > 5)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine("\n\t\t\t\t\t\t\t\t    There is no such menu!");
                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        Thread.Sleep(3000);
                                        Console.Clear();
                                        goto AdminMenu;
                                    }

                                    Console.Write("\n\t\t\t\t\t\t\tEnter the new data: ");
                                    string updateNewData = Console.ReadLine();
                                    StudentRepository.UpdateStudent(student, updateType, updateNewData);

                                    if (updateNewData == "")
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine("\n\t\t\t\t\t\t\t\t    New data is empty!");
                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        Thread.Sleep(3000);
                                        Console.Clear();
                                        goto AdminMenu;
                                    }



                                }
                                catch
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("\n\t\t\t\t\t\t       Wrong character! Please re-enter your transaction!");
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                    Thread.Sleep(3000);
                                    Console.Clear();
                                    goto AdminMenu;
                                }

                            }

                        }

                        #endregion

                        #region Go back   |   Done

                        else if (adminChoice == 5)
                        {
                            Console.Clear();
                            goto MainMenu;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\n\t\t\t\t\t\t\t\t    There is no such menu!");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Thread.Sleep(3000);
                            Console.Clear();
                            goto AdminMenu;
                        }

                        #endregion

                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\n\t\t\t\t\t\t    Wrong character! Please re-enter your transaction!");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Thread.Sleep(3000);
                        Console.Clear();
                        goto AdminMenu;

                    }
                }

                #endregion

                #region Admins Menu |   Done

                else if (choice == 2)
                {
                    MainMenuAdmins();
                }

                #endregion

                #region Go back Menu  Reception  |   Done

                else if (choice == 3)
                {
                    Console.Clear();
                    StarterMenu.IntroductionWindow();
                }

                #endregion

                #region Exit Main Menu | Done

                else if (choice == 4)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Media.SystemExit();
                    Console.Write("\n\t\t\t\t\t\t\t\t      System exit");
                    //Thread.Sleep(1000);
                    for (int i = 0; i < 3; i++)
                    {
                        Thread.Sleep(500);
                        Console.Write(".");
                    }
                    Thread.Sleep(1000);
                    InputSimulator input = new InputSimulator();

                    input.Keyboard.ModifiedKeyStroke(WindowsInput.Native.VirtualKeyCode.MENU, WindowsInput.Native.VirtualKeyCode.F4);
                }

                #endregion

                #region There isn't Menu    |   Done

                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\n\t\t\t\t\t\t\t\tThere is not such menu!");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Thread.Sleep(3000);
                    Console.Clear();
                    goto MainMenu;
                }

                #endregion

            }

            catch
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n\t\t\t\t\t\tWrong character! Please re-enter your transaction!");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Thread.Sleep(3000);
                Console.Clear();
                goto MainMenu;
            }
        }

        public static void MainMenuAdmins()
        {
        AdminMenu:
            Console.Clear();
            Console.Write(@"
                  ░█████╗ ░██████╗ ░███╗░░░███╗ ██╗ ███╗░░██╗ ██╗ ░██████╗ ████████╗ ██████╗ ░░█████╗ ░████████╗ ██╗ ░█████╗░ ███╗░░██╗
                  ██╔══██╗ ██╔══██╗ ████╗░████║ ██║ ████╗░██║ ██║ ██╔════╝ ╚══██╔══╝ ██╔══██╗ ██╔══██╗ ╚══██╔══╝ ██║ ██╔══██╗ ████╗░██║
                  ███████║ ██║░░██║ ██╔████╔██║ ██║ ██╔██╗██║ ██║ ╚█████╗ ░░░░██║░░░ ██████╔╝ ███████║ ░░░██║░░░ ██║ ██║░░██║ ██╔██╗██║
                  ██╔══██║ ██║░░██║ ██║╚██╔╝██║ ██║ ██║╚████║ ██║ ░╚═══██╗ ░░░██║░░░ ██╔══██╗ ██╔══██║ ░░░██║░░░ ██║ ██║░░██║ ██║╚████║
                  ██║░░██║ ██████╔╝ ██║░╚═╝░██║ ██║ ██║░╚███║ ██║ ██████╔╝ ░░░██║░░░ ██║░░██║ ██║░░██║ ░░░██║░░░ ██║ ╚█████╔╝ ██║░╚███║
                  ╚═╝░░╚═╝ ╚═════╝░ ╚═╝░░░░░╚═╝ ╚═╝ ╚═╝░░╚══╝ ╚═╝ ╚═════╝ ░░░░╚═╝░░░ ╚═╝░░╚═╝ ╚═╝░░╚═╝ ░░░╚═╝░░░ ╚═╝ ░╚════╝░ ╚═╝░░╚══╝");
            string receptionMenu = "| 1) Add Admin | 2) Delete admin | 3) Update admin | 4) Go back |";
            Console.Write("\n\n\t\t\t\t        ");
            for (int i = 0; i < receptionMenu.Length; i++) Console.Write("-"); Console.Write("\n");
            Console.WriteLine($"\t\t\t\t        {receptionMenu}");
            Console.Write("\t\t\t\t        ");
            for (int i = 0; i < receptionMenu.Length; i++) Console.Write("-"); Console.Write("\n");
            Console.Write("\n\t\t\t\t\t\t\t\t\t>>> ");
            try
            {
                int adminChoice = int.Parse(Console.ReadLine());
                Console.Clear();


                #region Add Admin   |   Done

                if (adminChoice == 1)
                {
                    Console.Write(@"
                                ░█████╗░  ██████╗░  ██████╗░    ░█████╗░  ██████╗░  ███╗░░░███╗  ██╗  ███╗░░██╗
                                ██╔══██╗  ██╔══██╗  ██╔══██╗    ██╔══██╗  ██╔══██╗  ████╗░████║  ██║  ████╗░██║
                                ███████║  ██║░░██║  ██║░░██║    ███████║  ██║░░██║  ██╔████╔██║  ██║  ██╔██╗██║
                                ██╔══██║  ██║░░██║  ██║░░██║    ██╔══██║  ██║░░██║  ██║╚██╔╝██║  ██║  ██║╚████║
                                ██║░░██║  ██████╔╝  ██████╔╝    ██║░░██║  ██████╔╝  ██║░╚═╝░██║  ██║  ██║░╚███║
                                ╚═╝░░╚═╝  ╚═════╝░  ╚═════╝░    ╚═╝░░╚═╝  ╚═════╝░  ╚═╝░░░░░╚═╝  ╚═╝  ╚═╝░░╚══╝");

                    Admins admin = new Admins();

                ReadData:
                    Console.Write("\n\n\t\t\t\t\t\t          Enter firstname: ");
                    admin.FirstName = Console.ReadLine();
                    Console.Write("\t\t\t\t\t\t           Enter lastname: ");
                    admin.LastName = Console.ReadLine();
                    Console.Write("\t\t\t\t\t\t   Enter the phone number: ");
                    admin.PhoneNum = Console.ReadLine();
                    Console.Write("\t\t\t\t\t\t      Enter the user name: ");
                    admin.UserName = Console.ReadLine();
                    Console.Write("\t\t\t\t\t\t       Enter the password: ");
                    admin.Password = Console.ReadLine();

                    if (admin.FirstName == "" || admin.LastName == "" || admin.PhoneNum == "" || admin.UserName == "" || admin.Password == "")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\n\t\t\t\t\t\t     There is an error in entering data! Re-enter please!\n");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        string queryMenu = "| 1) Re-enter data | 2) Go back |";
                        Console.Write("\t\t\t\t\t\t\t     ");
                        for (int i = 0; i < queryMenu.Length; i++) Console.Write("-");
                        Console.Write($"\n\t\t\t\t\t\t\t     {queryMenu}\n\t\t\t\t\t\t\t     ");
                        for (int i = 0; i < queryMenu.Length; i++) Console.Write("-");
                        Console.Write("\n\t\t\t\t\t\t\t\t\t   >>> ");
                        try
                        {
                            int queryChoice = int.Parse(Console.ReadLine());
                            if (queryChoice == 1)
                            {
                                Console.Clear();
                                goto ReadData;
                            }
                            else if (queryChoice == 2)
                            {
                                goto AdminMenu;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\n\t\t\t\t\t\t\t\t    There is no such menu!");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Thread.Sleep(3000);
                                Console.Clear();
                                goto AdminMenu;
                            }
                        }
                        catch
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\n\t\t\t\t\t\t       Wrong character! Please re-enter your transaction!");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Thread.Sleep(3000);
                            Console.Clear();
                            goto AdminMenu;

                        }
                    }
                    else
                    {
                        AdminRepository.AddAdmin(admin);
                    }

                }
                #endregion

                #region Delete Admin  |   Done
                else if (adminChoice == 2)
                {
                ReadData:
                    Console.Write(@"

                    ██████╗░  ███████╗  ██╗░░░░░  ███████╗  ████████╗  ███████╗    ░█████╗░  ██████╗░  ███╗░░░███╗  ██╗  ███╗░░██╗
                    ██╔══██╗  ██╔════╝  ██║░░░░░  ██╔════╝  ╚══██╔══╝  ██╔════╝    ██╔══██╗  ██╔══██╗  ████╗░████║  ██║  ████╗░██║
                    ██║░░██║  █████╗░░  ██║░░░░░  █████╗░░  ░░░██║░░░  █████╗░░    ███████║  ██║░░██║  ██╔████╔██║  ██║  ██╔██╗██║
                    ██║░░██║  ██╔══╝░░  ██║░░░░░  ██╔══╝░░  ░░░██║░░░  ██╔══╝░░    ██╔══██║  ██║░░██║  ██║╚██╔╝██║  ██║  ██║╚████║
                    ██████╔╝  ███████╗  ███████╗  ███████╗  ░░░██║░░░  ███████╗    ██║░░██║  ██████╔╝  ██║░╚═╝░██║  ██║  ██║░╚███║
                    ╚═════╝░  ╚══════╝  ╚══════╝  ╚══════╝  ░░░╚═╝░░░  ╚══════╝    ╚═╝░░╚═╝  ╚═════╝░  ╚═╝░░░░░╚═╝  ╚═╝  ╚═╝░░╚══╝");

                    Admins admin = new Admins();

                    Console.Write("\n\n\t\t\t\t\t\t        Enter the firstname: ");
                    admin.FirstName = Console.ReadLine();

                    Console.Write("\n\t\t\t\t\t\t         Enter the lastname: ");
                    admin.LastName = Console.ReadLine();

                    Console.Write("\n\t\t\t\t\t\t     Enter the phone number: ");
                    admin.PhoneNum = Console.ReadLine();

                    if (admin.FirstName == "" && admin.LastName == "" && admin.PhoneNum == "")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\n\t\t\t\t\t\t     There is an error in entering data! Re-enter please!\n");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        string queryMenu = "| 1) Re-enter data | 2) Go back |";
                        Console.Write("\t\t\t\t\t\t\t     ");
                        for (int i = 0; i < queryMenu.Length; i++) Console.Write("-");
                        Console.Write($"\n\t\t\t\t\t\t\t     {queryMenu}\n\t\t\t\t\t\t\t     ");
                        for (int i = 0; i < queryMenu.Length; i++) Console.Write("-");
                        Console.Write("\n\t\t\t\t\t\t\t\t\t   >>> ");
                        try
                        {
                            int queryChoice = int.Parse(Console.ReadLine());
                            if (queryChoice == 1)
                            {
                                Console.Clear();
                                goto ReadData;
                            }
                            else if (queryChoice == 2)
                            {
                                goto AdminMenu;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\n\t\t\t\t\t\t\t\t    There is no such menu!");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Thread.Sleep(3000);
                                Console.Clear();
                                goto AdminMenu;
                            }
                        }
                        catch
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\n\t\t\t\t\t\t       Wrong character! Please re-enter your transaction!");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Thread.Sleep(3000);
                            Console.Clear();
                            goto AdminMenu;

                        }
                    }
                    else
                    {
                        AdminRepository.DeleteAdmin(admin);
                    }

                }
                #endregion

                #region Update Admin   |   Done

                else if (adminChoice == 3)
                {
                ReadData:
                    Console.Write(@"
             ██╗░░░██╗   ██████╗░   ██████╗   ░░█████╗ ░  ████████╗   ███████╗    ░█████╗░  ██████╗░  ███╗░░░███╗  ██╗  ███╗░░██╗
             ██║░░░██║   ██╔══██╗   ██╔══██╗   ██╔══██╗   ╚══██╔══╝   ██╔════╝    ██╔══██╗  ██╔══██╗  ████╗░████║  ██║  ████╗░██║
             ██║░░░██║   ██████╔╝   ██║░░██║   ███████║   ░░░██║░░░   █████╗░░    ███████║  ██║░░██║  ██╔████╔██║  ██║  ██╔██╗██║
             ██║░░░██║   ██╔═══╝░   ██║░░██║   ██╔══██║   ░░░██║░░░   ██╔══╝░░    ██╔══██║  ██║░░██║  ██║╚██╔╝██║  ██║  ██║╚████║
             ╚██████╔╝   ██║░░░░░   ██████╔╝   ██║░░██║   ░░░██║░░░   ███████╗    ██║░░██║  ██████╔╝  ██║░╚═╝░██║  ██║  ██║░╚███║
             ░╚═════╝░   ╚═╝░░░░░   ╚═════╝░   ╚═╝░░╚═╝   ░░░╚═╝░░░   ╚══════╝    ╚═╝░░╚═╝  ╚═════╝░  ╚═╝░░░░░╚═╝  ╚═╝  ╚═╝░░╚══╝");

                    Admins admin = new Admins();

                    Console.Write("\n\n\t\t\t\t\t\t        Enter the firstname: ");
                    admin.FirstName = Console.ReadLine();

                    Console.Write("\n\t\t\t\t\t\t         Enter the lastname: ");
                    admin.LastName = Console.ReadLine();

                    Console.Write("\n\t\t\t\t\t\t     Enter the phone number: ");
                    admin.PhoneNum = Console.ReadLine();

                    if (admin.FirstName == "" && admin.LastName == "" && admin.PhoneNum == "")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\n\t\t\t\t\t\t     There is an error in entering data! Re-enter please!\n");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        string queryMenu = "| 1) Re-enter data | 2) Go back |";
                        Console.Write("\t\t\t\t\t\t\t     ");
                        for (int i = 0; i < queryMenu.Length; i++) Console.Write("-");
                        Console.Write($"\n\t\t\t\t\t\t\t     {queryMenu}\n\t\t\t\t\t\t\t     ");
                        for (int i = 0; i < queryMenu.Length; i++) Console.Write("-");
                        Console.Write("\n\t\t\t\t\t\t\t\t\t   >>> ");
                        try
                        {
                            int queryChoice = int.Parse(Console.ReadLine());
                            if (queryChoice == 1)
                            {
                                Console.Clear();
                                goto ReadData;
                            }
                            else if (queryChoice == 2)
                            {
                                goto AdminMenu;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\n\t\t\t\t\t\t\t\t    There is no such menu!");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Thread.Sleep(3000);
                                Console.Clear();
                                goto AdminMenu;
                            }
                        }
                        catch
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\n\t\t\t\t\t\t       Wrong character! Please re-enter your transaction!");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Thread.Sleep(3000);
                            Console.Clear();
                            goto AdminMenu;

                        }
                    }

                    else
                    {
                        AdminRepository.IsInDatabase(admin);

                        string queryMenu = "| 1) Update firstname | 2) Update lastname | 3) Update phone number | 4) Update course | 5) Update group number |";
                        Console.Write("\n\t\t    ");
                        for (int i = 0; i < queryMenu.Length; i++) Console.Write("-");
                        Console.Write($"\n\t\t    {queryMenu}\n");
                        Console.Write("\t\t    ");
                        for (int i = 0; i < queryMenu.Length; i++) Console.Write("-");
                        Console.Write("\n\t\t\t\t\t\t\t\t\t>>> ");


                        try
                        {
                            int updateType = int.Parse(Console.ReadLine());


                            if (updateType <= 0 || updateType > 5)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\n\t\t\t\t\t\t\t\t    There is no such menu!");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Thread.Sleep(3000);
                                Console.Clear();
                                goto AdminMenu;
                            }

                            Console.Write("\n\t\t\t\t\t\t\tEnter the new data: ");
                            string updateNewData = Console.ReadLine();
                            AdminRepository.UpdateAdmin(admin, updateType, updateNewData);

                            if (updateNewData == "")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\n\t\t\t\t\t\t\t\t    New data is empty!");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Thread.Sleep(3000);
                                Console.Clear();
                                goto AdminMenu;
                            }



                        }
                        catch
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\n\t\t\t\t\t\t       Wrong character! Please re-enter your transaction!");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Thread.Sleep(3000);
                            Console.Clear();
                            goto AdminMenu;
                        }

                    }

                }

                #endregion

                #region Go back |   Done

                else if (adminChoice == 4)
                {
                    Console.Clear();
                    MainMenu.MainMenuProgram();
                }

                #endregion

                #region There is not such menu  |   Done

                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\n\t\t\t\t\t\t\t\tThere is not such menu!");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Thread.Sleep(3000);
                    Console.Clear();
                    goto AdminMenu;
                }

                #endregion

            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n\t\t\t\t\t\tWrong character! Please re-enter your transaction!");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Thread.Sleep(3000);
                Console.Clear();
                goto AdminMenu;
            }
        }
    }
}