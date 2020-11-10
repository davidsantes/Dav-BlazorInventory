using System.Collections.Generic;

namespace Business.Interfaces
{
    public interface ICrudDataServiceStorage<T>
    {
        List<T> ItemList();

        List<T> ItemListByWarehouse(string idWarehouse);

        T ItemById(string id);

        void CreateItem(T item);

        void UpdateItem(T item);

        bool IsProductInWarehouse(string idProduct);
    }
}
