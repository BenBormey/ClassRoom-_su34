

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create add product in stock
            //and Show product 
            // user while 
            bool Funtion = true;
            while (Funtion)
            {
                //manu Iteam
                Console.WriteLine("------------------------- MaNu Iteam -------------------------- ");
                Console.WriteLine("1. Add Product");//1.Add
                Console.WriteLine("2. Show Product");//2.Show
                Console.WriteLine("3. Delete product");
                Console.WriteLine("4. Addate Product");
                Console.WriteLine("5. Search product");
                Console.WriteLine("6. Exit system");//stop system
                //create variable for insertoptin
                Console.Write("Place choose Option\t:");
                Product product = new Product();
                int option=int.Parse(Console.ReadLine());
                //user switch for choose
               
                switch (option)
                {
                    case 1:
                        //for add creat add void add
                        product.Add();
                        break;
                    case 2:
                        //for
                        product.show();
                        break;
                    case 3:
                        product.deleteI();
                        break;
                    case 4:
                        product.Addate();
                        break;
                    case 5:
                        product.Search();
                        break;
                    case 6:
                        Funtion = false;
                        break;
                    default:

                        //if no nums
                        Console.WriteLine("Place Try again!");
                        break;
                }


            }
        }
    }
}
