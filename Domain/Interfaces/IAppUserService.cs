﻿using System;
using System.Collections.Generic;
using System.Text;

using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IAppUserService
    {
        public bool Register(AppUser user, string password);
        public bool VerificateWeddingLog(AppUser user, string password);
        public bool LogIn(string userName, string password);
        string HashPassword(string input);
    }
}
