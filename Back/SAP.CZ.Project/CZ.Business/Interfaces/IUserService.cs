﻿using CZ.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Business.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAll();
    }
}
