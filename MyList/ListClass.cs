using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    public class ListClass<T>
    {
        public Element<T> firstElement, endElement;

        //Создаём пустой список
        public ListClass()
        {
            firstElement = null;
            endElement = null;
        }

        //Создаём список с одним элементом
        public ListClass(T t)
        {
            firstElement = new Element<T>(t);
            endElement = firstElement;
        }

        //Добавляем новый элемент
        public void Add(T t)
        {
            var newElement = new Element<T>(t);

            if(endElement != null)
            {
                endElement.next = newElement;
                newElement.last = endElement;
                endElement = newElement;
            }
            else
            {
                firstElement = newElement;
                endElement = newElement;
            }
        }
    }

    public class Element<T>
    {
        public Element<T> last, next;

        private T varible;

        public Element(T t)
        {
            varible = t;
        }

        //Возвращает значение элемента
        public T Value()
        {
            return varible;
        }

    }

}
