using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Fracc
    {
        private int num, dem;
        public Fracc(int num, int dem)
        {
            this.num = num;
            this.dem = dem;
        }
        public Fracc()
        {
            num = 1;
            dem = 1;
        }
        public static Fracc operator +(Fracc x, Fracc y)
        {
            Fracc result = new
            Fracc(x.num * y.dem + x.dem * y.num, y.dem * x.dem);
            return result;
        }
       public static Fracc operator -(Fracc x, Fracc y)
        {
            Fracc result = new
            Fracc(x.num * y.dem - x.dem * y.num, y.dem * x.dem);
            return result;
        }
        public static Fracc operator *(Fracc x, Fracc y)
        {
            Fracc result = new
            Fracc((x.num * y.dem )*( x.dem * y.num), y.dem * x.dem);
            return result;
        }
        public static Fracc operator /(Fracc x, Fracc y)
        {
            Fracc result = new
            Fracc(x.num*y.dem, y.num * x.dem);
            return result;
        }
        public void imprimir()
        {
            Console.WriteLine("{0}/{1}", num, dem);
        }
        public decimal a_decimal()
        {
            return num / dem;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fracc a = new Fracc(1, 2);
            Fracc b = new Fracc(1, 2);
            Fracc c = a + b;
            Fracc x = new Fracc(2, 4);
            Fracc y = new Fracc(1, 2);
            Fracc z = x - y;
            Fracc m = x * y;
            Fracc d = x / y;
            
            c.imprimir();
            z.imprimir();
            m.imprimir();
            d.imprimir();
            Console.ReadKey();


        }
    }
}
