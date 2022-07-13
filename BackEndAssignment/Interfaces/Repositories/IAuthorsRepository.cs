using BackEndAssignment.Models;

namespace BackEndAssignment.Interfaces.Repositories
{
    public interface IAuthorsRepository
    {

        Task<List<Author>> GetAuthorsByBirthDate(string date);
        Task<List<Author>> GetAllAuthors();

        Task<int> AddAuthor(string name, DateTime birthDate);
    }
}
