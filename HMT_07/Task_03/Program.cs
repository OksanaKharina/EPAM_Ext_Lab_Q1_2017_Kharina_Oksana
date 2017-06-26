using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    /// <summary>
    /// На базе обычного массива (коллекции .NET не использовать) 
    /// реализовать свой собственный класс  DynamicArray, 
    /// представляющий собой массив с запасом. Класс должен содержать:
    /// </summary>
    public interface IEnumerable //todo pn ты затерла системный интерфейс? зачем?
    {
        IEnumerable GetEnumerator();
    }
    public interface ICollection<T> : IEnumerable<T>, IEnumerable //todo pn и где ты его (ICollection) реализуешь?
	{
        int Count { get; }
        void Insert(int index, T item);
        void Add(T item);
        void RemoveAt(int index);
        bool Remove(T item);
        int Capacity { get; }
        int Length { get; }
        new System.Collections.IEnumerator GetEnumerator();
    }
    public class DynamicArray<T> 
    {
        private int count = 1;
        /// <summary>
        /// 1. Конструктор без параметров (создается массив 
        /// емкостью 8 элементов). 
        /// </summary>
        object[] array;
        private IEnumerable<T> data;

        public DynamicArray()
        {
            array = new object[8];
        }
        /// <summary>
        /// 2. Конструктор с 1 целочисленным параметром 
        /// (создается массив заданной емкости).
        /// </summary>
        public DynamicArray(int length)
        {
            array = new object[length];
        }
        ///<summary>
        ///3. Конструктор, который в качестве параметра 
        ///принимает коллекцию, реализующую интерфейс IEnumerable, 
        ///создает массив нужного размера и копирует в него 
        ///все элементы из коллекции. 
        /// </summary>
        class DynamicAray<T>
        {
            
            public T[] array;
            public DynamicAray(IEnumerable<T> sourse)
            {
                array = sourse.ToArray();
            }
        }
        ///<summary>
        ///4. Метод Add, добавляющий в конец массива один элемент. 
        ///При нехватке места для добавления элемента емкость 
        ///массива должна расширяться в 2 раза.
        /// </summary>
        
        /// <summary>
        /// 5. Метод AddRange, добавляющий в конец массива 
        /// содержимое коллекции, реализующей интерфейс 
        /// IEnumerable. Обратите внимание, метод должен 
        /// корректно учитывать число элементов в коллекции 
        /// с тем, чтобы при необходимости расширения массива 
        /// делать это только один раз вне зависимости  
        /// от числа элементов в добавляемой коллекции. 
        /// </summary>
        public void Add(T item)
        {
            if (data.Length == count)//todo pn ты билдила приложение перед отправкой на проверку?
            {
                GrowArray();
            }

            data[count++] = item;
        }
        public void AddRange(IEnumerable<T> source1)
        {
            throw new NotImplementedException();
        }
        public void AddRange(IEnumerable<T> source, IEnumerable<T> destination)
        {
            DynamicArray<T> list = destination as DynamicArray<T>;
            if (list != null)
            {
                list.AddRange(source);
            }
            else
            {
                foreach (T item in source)
                {
                    destination.Add(item);
                }
            }
        }
        /// <summary>
        /// 6. Метод Remove, удаляющий из коллекции указанный элемент. 
        /// Метод должен возвращать true, если  удаление прошло 
        /// успешно и false в противном случае. При удалении 
        /// элементов реальная емкость массива не должна уменьшаться.
        /// </summary>
        private void GrowArray()//todo pn мне кажется, что описание не к тому методу
        {
            int newLength = data.Length == 0 ? (data.Length * 3) / 2 + 1 : data.Length << 1;//todo pn а теперь представь, что у тебя 1млн элементов в массиве, а добавить нужно 100. лучше вынести в константу число, на которое ты увеличиваешь массив каждый раз.

            T[] newArray = new T[newLength];

            data.CopyTo(newArray, 0);

            data = newArray;
        }
        public void RemoveAt(int index)
        {
            if (index >= count)
            {
                throw new IndexOutOfRangeException();
            }
            int shiftStart = index + 1;
            if (shiftStart < count)
            {
                Array.Copy(data, shiftStart, data, index, count - shiftStart);
            }
            count--;
        }

        public bool Remove(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (data[i].Equals(item))
                {
                    RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// 7. Метод Insert, позволяющий добавить элемент 
        /// в произвольную позицию массива (обратите внимание, 
        /// может потребоваться расширить массив). Метод должен
        /// возвращать true, если добавление прошло успешно и 
        /// false в противном случае. При выходе за границу 
        /// массива должно генерироваться исключение 
        /// ArgumentOutOfRangeException.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="item"></param>
        public void Insert(int index, T item)
        {
            if (index >= count)
            {
                throw new IndexOutOfRangeException();
            }

            if (data.Length == this.count)
            {
                this.GrowArray();
            }

            Array.Copy(data, index, data, index + 1, count - index);

            data[index] = item;

            count++;
        }
        /// <summary>
        /// 8. Свойство Length – получение длины массива.
        /// </summary>
        public int LengthArr()
        {
            return array.Length;
        }
        /// <summary>
        /// 9. Свойство Capacity – получение реальной длины массива
        /// </summary>
        public int CapacityArr()
        {

        }
        ///<summary>
        ///10. Методы, реализующие интерфейсы IEnumerable и IEnumerator
        /// </summary>
        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in data)
            {
                yield return item;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.CursorVisible = false;

            DynamicArray<Task> a1 = new DynamicArray<Task>();
            DynamicArray<Task> a2 = new DynamicArray<Task>(8);


            Console.ReadKey();
        }
    }
}
