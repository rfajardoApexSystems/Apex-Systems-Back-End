using BackEndAssignment.Interfaces.Repositories;
using BackEndAssignment.Models;

namespace BackEndAssignment.Repositories
{
    public class AuthorsRepository : IAuthorsRepository
    {

        private readonly IBaseRepositoryAsync<Author> authorsRepository;


        public AuthorsRepository(IBaseRepositoryAsync<Author> authorsRepo)
        {
            authorsRepository = authorsRepo;
        }

        public async Task<int> AddAuthor(string name, DateTime birthDate)
        {

            var author = new Author
            {
                Name = name,
                BirthDate = birthDate
            };

            await authorsRepository.AddAsync(author);

            return author.ID;

        }

        public async Task<List<Author>> GetAllAuthors()
        {
            return await authorsRepository.GetAllAsync();
        }



        //TODO: Add the filtering logic, change the base repository if needed.
        public Task<List<Author>> GetAuthorsByBirthDate(string date)
        {
            throw new NotImplementedException();
        }


    }
}
