using BackEndAssignment.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BackEndAssignment.Controllers
{
    public class AuthorsControllers : BaseApiController
    {


        private readonly IAuthorsRepository _authorsRepository;
        private readonly IUnitOfWork _unitOfWork;

        public AuthorsControllers(IAuthorsRepository authorsRepository, IUnitOfWork unitOfWork)
        {
            _authorsRepository = authorsRepository;
            _unitOfWork = unitOfWork;
        }


        /*
         * TODO:
            - Complete the endpoints funcionality to handle all the requests.
            - Inject the neccesary services.
         */


        // GET: api/<AuthorsController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var list = await _authorsRepository.GetAllAuthorsRawSql();


            
            return Ok(list);
        }




        
        // GET api/<AuthorsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AuthorsController>
        [HttpPost]
        public async void Post([FromBody] string name )
        {
            await _authorsRepository.AddAuthor(name, DateTime.Now);
            await _unitOfWork.Commit(new CancellationToken());
        }

        // PUT api/<AuthorsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AuthorsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
