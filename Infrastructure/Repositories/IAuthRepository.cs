using Microsoft.AspNetCore.Authentication.JwtBearer;
using Application.Interfaces;
using Domain.Models;

namespace Infrastructure.Repositories
{
    public class IAuthRepository : IAuth
    {
        public Task<string> AddDescription(int Uid, string desc)
        {
            throw new NotImplementedException();
        }

        public Task<string> Authenticate(string Email, string Password)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteUser(Users users)
        {
            throw new NotImplementedException();
        }

        public Task<string> ForgetPassHash(int Uid, string PhraseHash, string NewPassHash)
        {
            throw new NotImplementedException();
        }

        public Task<string> Register(Users users)
        {
            
            return Task.FromResult("Success");
        }

        public Task<string> UpdateDob(int Uid, DateTime Dob)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateName(int Uid, string Name)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdatePassHash(int Uid, string PassHash, string NewPassHash)
        {
            throw new NotImplementedException();
        }
    }
}