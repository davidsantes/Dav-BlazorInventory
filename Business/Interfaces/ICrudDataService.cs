using System.Collections.Generic;

namespace Business.Interfaces
{
    public interface ICrudDataService<T>
    {
        List<T> ItemList();

        T ItemById(string id);

        void CreateItem(T item);

        void UpdateItem(T item);
    }
}
