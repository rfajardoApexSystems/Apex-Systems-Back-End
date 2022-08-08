using BackEndAssignment.Models;
using System.Collections;

namespace BackEndAssignment.Repositories
{
    /*
     * TODO:
     * 1.- Implement IList<EditorialModel> interface on this custom collection class
     * 2.- Use try catch statements witu custom exceptions to handle validations
     */
    public class EditorialDb : IList<EditorialModel>
    {
        private IDictionary<int, EditorialModel> _editors;

        public EditorialDb()
        {
            _editors = new Dictionary<int, EditorialModel>();

            Add(new EditorialModel { Id = 1, Name = "Mirahadas", Status = true });
            Add(new EditorialModel { Id = 2, Name = "Errara Natura", Status = true });
            Add(new EditorialModel { Id = 3, Name = "Pre-textos", Status = true });
            Add(new EditorialModel { Id = 4, Name = "Sexto piso", Status = true });
            Add(new EditorialModel { Id = 5, Name = "Nordica", Status = true });
            Add(new EditorialModel { Id = 6, Name = "Acantilado", Status = true });
        }

        public EditorialModel this[int index]
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(EditorialModel item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(EditorialModel item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(EditorialModel[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<EditorialModel> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(EditorialModel item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, EditorialModel item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(EditorialModel item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
