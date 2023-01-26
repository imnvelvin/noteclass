using notebookclass;
using System;

namespace notebookclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            notebook[] pc = new notebook[3];

            for (int i = 0; i < pc.Length; i++)
            {
                Console.WriteLine("Brandi Daxil Edin");
                string brand = Console.ReadLine();


                Console.WriteLine("Modeli Daxil edin");
                string model = Console.ReadLine();

                double price;
                do
                {
                    Console.WriteLine("Price Daxil Edin");
                    string Price = Console.ReadLine();
                    price = Convert.ToDouble(Price);

                } while ( price <= 0);

                Console.WriteLine("Model Daxil Edin");
                string Model = Console.ReadLine();

                notebook Pc = new notebook(brand,Model, price );
                pc[i] = Pc;
            }
                   double sum = 0;
            for (int i = 0; i < pc.Length; i++)
            {
                sum += pc[i].Price;
                
            }
            double average = sum / pc.Length;
            Console.WriteLine(average);
        }  


    }
}
