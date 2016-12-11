﻿using ManagementServices.Implementations;
using ManagementServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementServices.Interfaces
{
    interface IUserManager
    {
        void UpdateUser(UserInfo user);
        void DeleteUser(string userId);
        UserInfo GetUserInfo(string userName);
        IEnumerable<UserInfo> GetUsersInfo();
        string GetUserName(string email);
    }
}
