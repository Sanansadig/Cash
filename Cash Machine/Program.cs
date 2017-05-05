using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cash_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            int pul_miqdari = Convert.ToInt32(Console.ReadLine());
            int[] money = new int [6] {100, 50, 20, 10, 5, 1};
            int i;
           

            for (i=0; i<6; i++)
            {
                int qaliq = pul_miqdari % money[i];
                    if (qaliq>0) {
                    int say = pul_miqdari / money[i];
                    int ikinci_qaliq = qaliq;
                    int a = ikinci_qaliq / money[i];
                    //Console.WriteLine(money[i] + " Bolen " + qaliq + " Qaliq pul " + say + " Pulun Sayi " + ikinci_qaliq + " Ikinci Qaliq ");
                    //Console.ReadLine();
                    Console.WriteLine(a);
                }


            }


        }
    }
}
