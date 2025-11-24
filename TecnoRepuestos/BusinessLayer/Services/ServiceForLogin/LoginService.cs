using CommonLayer.Entities;
using DataAccesLayer.Repositories.LoginRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.ServiceForLogin
{
    public class LoginService
    {
        private LoginRepository _loginRepository;

        public LoginService(LoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        public User Login(string username, string password)
        {
            return _loginRepository.Login(username, password);
        }
    }
}
