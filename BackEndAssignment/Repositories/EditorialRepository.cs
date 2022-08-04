using BackEndAssignment.Interfaces.Repositories;
using BackEndAssignment.Models;

namespace BackEndAssignment.Repositories
{
    /*
     * TODO:
     * 1.- Implement Get method to get an editorial by id
     * 2.- Implement Get method to get editorials by filtering with a function
     * 3.- Implement Remove method to remove an item from the data source
     * 4.- Implement Update method to remove an item in the data source
     * 5.- Implement Add method to add an item to the data source
     */
    public class EditorialRepository : IEditorialRepository
    {
        private EditorialDb _editorialModels;

        public EditorialRepository()
        {
            _editorialModels = new EditorialDb();
        }

        public void Add(EditorialModel model)
        {
            throw new NotImplementedException();
        }

        public EditorialModel Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<EditorialModel> Get(Func<EditorialModel, bool> filter)
        {
            throw new NotImplementedException();
        }

        public void Remove(EditorialModel model)
        {
            throw new NotImplementedException();
        }

        public void Update(EditorialModel model)
        {
            throw new NotImplementedException();
        }
    }
}
