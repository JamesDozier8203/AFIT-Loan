﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AFIT_Cooperative.Models
{
    public class UsersAccount
    {
        public UsersAccount()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { set; get; }
        public string Username { set; get; }
        public string Password { set; get; }
    }
}