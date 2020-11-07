using System.Collections.Generic;

namespace Business.Interfaces
{
    public interface ICrudDataService<T>
    {

        List<T> ItemList();

        void CreateItem(T item);

        void UpdateItem(T item);

        //void DeleteItem(T item);
    }
}
