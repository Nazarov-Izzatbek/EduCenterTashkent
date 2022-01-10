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
    internal class StudentRepository
    {
        #region Add Student Repository   |   Done
        public static void AddStudent(Students student)
        {
            string json = File.ReadAllText(Constants.StudentDbPath);
            IList<Students> students = JsonConvert.DeserializeObject<IList<Students>>(json);

            students.Add(new Students()
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
                PhoneNum = student.PhoneNum,
                Course = student.Course,
                GroupNum = student.GroupNum
            });

            string jsoon = JsonConvert.SerializeObject(students);
            File.WriteAllText(Constants.StudentDbPath, jsoon);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n\t\t\t\t\t\t\tThe student joined successfully");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Thread.Sleep(3000);
            Console.Clear();
            MainMenu.MainMenuProgram();
        }
        #endregion

        #region Delete Student Repository   |   Done
        public static void DeleteStudent(Admins student)
        {

            string json = File.ReadAllText(Constants.StudentDbPath);
            IList<Admins> students = JsonConvert.DeserializeObject<IList<Admins>>(json);

            var studentcollect = students.Where(p => p.FirstName == student.FirstName && p.LastName == student.LastName && p.PhoneNum == student.PhoneNum).ToList();

            if (studentcollect.Count > 0)
            {
                foreach (var item in studentcollect)
                {
                    students.Remove(item);
                }

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("\t\t\t\t\tStudent was deleted succesfuly!");
                Console.ForegroundColor = ConsoleColor.DarkCyan;

                string res = JsonConvert.SerializeObject(students);
                File.WriteAllText(Constants.StudentDbPath, res);

                Thread.Sleep(3000);
                Console.Clear();
                MainMenu.MainMenuProgram();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n\n\t\t\t\t\t\t\tThis student is not in database!");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Thread.Sleep(3000);
                Console.Clear();
                MainMenu.MainMenuProgram();
            }

        }


        #endregion

        #region Update Student Repository   |   Done
        public static void UpdateStudent(Students student, int updatechoice, string newword)
        {
            int check = 0;
            string json = File.ReadAllText(Constants.StudentDbPath);
            IList<Students> students = JsonConvert.DeserializeObject<IList<Students>>(json);

            IList<Students> studentss = new List<Students>();

            foreach (Students std in students)
            {
                if (json is not null or "")
                {
                    if (std.FirstName == student.FirstName && std.LastName == student.LastName && std.PhoneNum == student.PhoneNum)
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
                                std.Course = newword;
                                break;
                            case 5:
                                std.GroupNum = newword;
                                break;
                        }
                        check++;

                        studentss.Add(std);
                    }
                    else studentss.Add(std);
                }
            }

            string json2 = JsonConvert.SerializeObject(studentss);
            File.WriteAllText(Constants.StudentDbPath, json2);

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

        #region Search Student Repository   |   Done

        public static void SearchStudent(Students student)
        {

            string json = File.ReadAllText(Constants.StudentDbPath);
            IList<Students> students = JsonConvert.DeserializeObject<IList<Students>>(json);

            var studentcollect = students.Where(p => p.FirstName == student.FirstName && p.LastName == student.LastName && p.PhoneNum == student.PhoneNum).ToList();

            if (studentcollect.Count > 0)
            {
                foreach (var item in studentcollect)
                {
                    ConsoleTable table = new ConsoleTable("First name", "Last name", "Phone number", "Course", "Group number");
                    table.AddRow(item.FirstName, item.LastName, item.PhoneNum, item.Course, item.GroupNum);
                    Console.WriteLine($"\n{table}");
                }

            }

            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n\n\t\t\t\t\t\t\t    This student is not in database!");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Thread.Sleep(3000);
                Console.Clear();
                MainMenu.MainMenuProgram();
            }

        }


        #endregion

        #region Student is in database (checker)    |   Done
        public static void IsInDatabase(Students student)
        {

            string json = File.ReadAllText(Constants.StudentDbPath);
            IList<Students> students = JsonConvert.DeserializeObject<IList<Students>>(json);

            var studentcollect = students.Where(p => p.FirstName == student.FirstName && p.LastName == student.LastName && p.PhoneNum == student.PhoneNum).ToList();

            if (studentcollect.Count > 0)
            {
                return;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n\n\t\t\t\t\t\t\t    This student is not in database!");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Thread.Sleep(3000);
                Console.Clear();
                MainMenu.MainMenuProgram();
            }

        }

        #endregion

    }
}