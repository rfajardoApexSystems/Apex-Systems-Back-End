using BackEndAssignment.Models;

namespace BackEndAssignment.Interfaces.Repositories
{
    public interface IEditorialRepository
    {
        public EditorialModel Get(int id);

        public IList<EditorialModel> Get(Func<EditorialModel, bool> filter);

        public void Add(EditorialModel model);

        public void Update(EditorialModel model);

        public void Remove(EditorialModel model);
    }
}
