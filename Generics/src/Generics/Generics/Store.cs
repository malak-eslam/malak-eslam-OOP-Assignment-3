using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics;
public class Store<T>
{
    private readonly List<T> _items;

    public Store()
    {
        _items = new List<T>();
    }

    public void Add(T item)
    {
        _items.Add(item);
    }

    public T? GetById(int id)
    {
        foreach (var item in _items)
        {
            if (item.Id == id)
                return item;
        }

        return default;
    }

    public List<T> GetAll()
    {
        return _items;
    }

    public void Remove(int id)
    {

    }
}
