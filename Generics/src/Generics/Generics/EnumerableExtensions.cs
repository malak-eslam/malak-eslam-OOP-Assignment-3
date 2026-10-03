using System.Collections.Generic;

namespace Generics;
public static class EnumerableExtensions
{
    public static IEnumerable<T> Page<T>(this IEnumerable<T> sourse, int pageNumber, int pageSize)
    {
        if (pageNumber <= 0)
            throw new ArgumentException("Page number must be greater than zero.");

        if (pageSize <= 0)
            throw new ArgumentException("Page size must be greater than zero.");

        int startIndex = (pageNumber - 1) * pageSize;
        int currentIndex = 0;

        foreach (var item in sourse)
        {
            if (currentIndex >= startIndex &&
                currentIndex < startIndex + pageSize)
            {
                yield return item;
            }

            if (currentIndex >= startIndex + pageSize)
                yield break;

            currentIndex++;
        }

    }

    public static T? FindById<T>(this IEnumerable<T> sourse, int id) where T : IHasId
    {
        foreach (var item in sourse)
        {
            if (item.Id == id)
                 return item;
        }
        return default;
    }

     
    public static IReadOnlyDictionary<int,T> ToIdDictionary<T>(this IEnumerable<T> sourse) where T : IHasId
    {
        var dictionary = new Dictionary<int, T>();

        foreach (var item in sourse)
        {
            dictionary.Add(item.Id, item);
        }
        return dictionary;
    }
}
