﻿using Pharmacy.Model;
using Pharmacy.Model.ModelLogin;
using Pharmacy.Model.ModelUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Service.UserServiceLayer
{
    //Kullanici Interface i olusturuldu.
    public interface IUserService
    {
        
        public General<UserViewModel> Insert(UserViewModel newUser);
        public General<UserViewModel> Login(LoginViewModel loginUser);
        public General<UserViewModel> GetUsers();
        public General<UserViewModel> Update(int id, UserViewModel user);
        public General<UserViewModel> Delete(int id);
        public List<Pharmacy.DB.Entities.User> GetPatients();
    }
}
