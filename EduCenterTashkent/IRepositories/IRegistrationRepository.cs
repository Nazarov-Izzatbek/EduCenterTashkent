using EduCenterTashkent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCenterTashkent.IRepositories
{
    internal interface IRegistrationRepository
    {
        void CheckLogin (string userName, string password);

       
    }
}
