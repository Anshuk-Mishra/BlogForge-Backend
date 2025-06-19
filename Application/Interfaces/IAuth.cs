using Domain.Models;

namespace Application.Interfaces
{
    public interface IAuth
    {
        public Task<string> Authenticate(string Email, string Password);
        public Task<string> Register(Users users);
        public Task<string> DeleteUser(Users users);
        public Task<string> UpdateName(int Uid, string Name);
        public Task<string> UpdatePassHash(int Uid, string PassHash, string NewPassHash);
        public Task<string> ForgetPassHash(int Uid, string PhraseHash, string NewPassHash);
        public Task<string> UpdateDob(int Uid, DateTime Dob);
        public Task<string> AddDescription(int Uid, string desc);
    }
}