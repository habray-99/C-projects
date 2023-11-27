using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class List<T>
    {
        private T[] _items = new T[0];
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T GetItemAt(int index) => _items[index];
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        public void SetItemAt(int index, T value) => _items[index] = value;
        /// <summary>
        /// adds to the list 
        /// </summary>
        /// <param name="newValue"></param>
        /// <returns updated list></returns>
        public void Add(T newValue)
        {
            T[] updated = new T[_items.Length + 1];
            for (int index = 0; index < _items.Length; index++)
                updated[index] = _items[index];
            updated[^1] = newValue;
            _items = updated;

        }

        
    }
    public class MainClass
    {
        public static void Main(string[] args)
        {
            List<int> list1 = new List<int>();
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.SetItemAt(0,5);
            Console.WriteLine($"Item at position 1 is {list1.GetItemAt(1)}");
        }
    }

}

namespace OutOfGenerics
{
    public class MainClass
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            List<int> list2 = new List<int>();
            list2.Add(1);
            list2.Add(2);
            
            Console.WriteLine($"Item at position 1 is {list2.GetItemAt(1)}"); 
            // there is error because there is no getitemat() for the list that is located out of generics
        }
    }
}