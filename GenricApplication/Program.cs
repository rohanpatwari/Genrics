using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsApplication
{

    public class GenericList<T>
    {
        dynamic a1;
        dynamic b1;

        public T Add(T a, T b)
        {

            this.a1 = a;
            this.b1 = b;

            T c = this.a1 + this.b1;
            return c;
        }
    }
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Genric Lists: int, float");
            GenericList<int> i = new GenericList<int>();
            int inte = i.Add(10, 20);
            Console.WriteLine("Sum of two integers: {0}", inte);
            GenericList<float> fl = new GenericList<float>();
            float floa = fl.Add(10.2f, 20.3f);
            Console.WriteLine("Sum of two float numbers: {0}", floa);
            Console.ReadLine();

        }
    }
}
