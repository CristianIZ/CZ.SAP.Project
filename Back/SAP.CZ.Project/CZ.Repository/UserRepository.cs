using CZ.Domain;
using CZ.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
    }
}
