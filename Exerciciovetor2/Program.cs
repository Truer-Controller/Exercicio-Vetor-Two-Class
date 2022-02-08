using System;
using System.Globalization;

namespace Exerciciovetor2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberChoose = int.Parse(Console.ReadLine());

            Product[] productVetor = new Product[numberChoose];

            for(int i = 0; i < numberChoose; i++)
            {
                string nameproduct = Console.ReadLine();
                double priceproduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                productVetor[i] = new Product { NameProduct = nameproduct, PriceProduct = priceproduct };
            }

            double sum = 0.0;
            for(int i = 0; i < numberChoose; i++)
            {
                sum += productVetor[i].PriceProduct;
            }

            double avaregePrice = sum / numberChoose;
            Console.WriteLine("Avarege product price: " + avaregePrice.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
