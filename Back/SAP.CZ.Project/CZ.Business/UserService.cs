using CZ.Business.Interfaces;
using CZ.Domain;
using CZ.Repository;
using CZ.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Business
{
    public class UserService : IUserService
    {
        public IUserRepository _userRepository;

        public UserService(IUserRepository storeRepository)
        {
            _userRepository = storeRepository;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await this._userRepository.GetAll();
        }
    }
}
