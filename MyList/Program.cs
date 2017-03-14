using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
           ListClass<int> MyList =  new ListClass<int>(1);
           
           MyList.Add(3);
           MyList.Add(4);


           Console.WriteLine(MyList.firstElement.Value().ToString() + " " + MyList.firstElement.next.Value().ToString() + " " + MyList.endElement.last.Value().ToString()+" " + MyList.endElement.Value().ToString());
            // 1 3 3 4
           Console.ReadKey();
        }
    }
}
