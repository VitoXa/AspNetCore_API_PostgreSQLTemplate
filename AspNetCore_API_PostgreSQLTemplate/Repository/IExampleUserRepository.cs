﻿using AspNetCore_API_PostgreSQLTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore_API_PostgreSQLTemplate.Repository
{
    public interface IExampleUserRepository
    {
        void AddUser(User user);

        User getUser(int id);
    }
}
