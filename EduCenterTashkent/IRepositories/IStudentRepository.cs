using EduCenterTashkent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCenterTashkent.IRepositories
{
    internal interface IStudentRepository
    {
        public void AddStudent(Admins student);

        public  void UpdateStudent(Admins student,int updatechoice,string newword);

        public  void DeleteStudent(Admins student);

        public IEnumerable<Admins> SearchStudents(Admins student,int searchchoice, string newword);


    }
}
