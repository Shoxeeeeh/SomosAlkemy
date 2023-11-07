using SomosAlkemy.DTO_s;
using System.Security.Cryptography.X509Certificates;

namespace SomosAlkemy.Repository.Interfaces
{
    public interface IRepository<T> where T : class
    {
        public Task<List<T>> GetAll();
        Task<bool> InsertUser(UserRegisterDTO userRegisterDTO);
    }
}
