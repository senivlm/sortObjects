using System;
using System.Collections.Generic;

namespace SortObject
{
    class Program
    {
        Посортувати просили список. Отже, після сортування масиву треба перетворити назад в список.
        static int CompareProductByName(object obj1, object obj2)
        {
            if (obj1 is Product product1 && obj2 is Product product2)
                return product1.Name.CompareTo(product2.Name);
            else
                throw new ArgumentException($"One of Objects is not a Product, actual Objects type is " +
                    $"{obj1?.GetType()?.Name ?? "null"} and {obj2?.GetType()?.Name ?? "null"}");
        }

        static void Main(string[] args)
        {
            Product product1 = new Product("Apple", 5.50, 0.120, 5, new DateTime(2021, 9, 30));
            Product product2 = new Product("Cookies", 45, 1, 10, new DateTime(2021, 7, 31));
            Product product3 = new Product("Bread", 15, 0.5, 7, new DateTime(2021, 10, 6));
            Product product4 = new Product("Sweets", 5.50, 0.120, 5, new DateTime(2021, 9, 30));
            Product product5 = new Product("Sugar", 30, 1, 10, new DateTime(2021, 7, 31));
            Product product6 = new Product("Bread", 17, 0.5, 7, new DateTime(2021, 10, 6));

            List<Product> objList = new List<Product> { product1, product2, product3, product4, product5, product6 };
            Product[] objArr = objList.ToArray();

            try
            {
                //Sort Products by name
                SortClass.Sort(objArr, CompareProductByName);

                Console.WriteLine("Products array after sorting by name:");
                foreach(var elem in objArr)
                    Console.Write(elem);

                //Sort Products by price with lambda expressions
                SortClass.Sort(objArr, (object obj1, object obj2) =>
                {
                    if (obj1 is Product product1 && obj2 is Product product2)
                        return product1.Price.CompareTo(product2.Price);
                    else
                        throw new ArgumentException($"One of Objects is not a Product, actual Objects type is " +
                            $"{obj1?.GetType()?.Name ?? "NULL"} and {obj2?.GetType()?.Name ?? "NULL"}");
                });

                Console.WriteLine("\nProducts array after sorting by price:");
                foreach (var elem in objArr)
                    Console.Write(elem);
            }
            catch (ArgumentNullException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
