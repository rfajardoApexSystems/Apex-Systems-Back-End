using BackEndAssignment.Models;
using Microsoft.Data.SqlClient;

namespace BackEndAssignment.Interfaces.Repositories
{
    public interface IAuthorsRepository
    {

        Task<List<Author>> GetAuthorsByBirthDate(string date);
        Task<List<Author>> GetAllAuthors();

        Task<List<Author>> GetAllAuthorsRawSql();

        Task<int> AddAuthor(string name, DateTime birthDate);
    }
}
