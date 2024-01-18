using ConsoleTables;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lap
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Barcode { get; set; }
        public double Unitprice { get; set; }
        public double SellPrice { get; set; }
        public double QtyInstock { get; set; }
        public static ArrayList productIteam = new ArrayList();
        private object keyValuePairs;
        public void Add()
        {
            Console.WriteLine("---------------------Add_Buy_Product----------------------");
            //add id name Barcode Unitprice sellprice by array list
            Console.Write("Enter N\t:");
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                Product product = new Product();
                Console.Write("Enter Id          :");
                product.Id = int.Parse(Console.ReadLine());
                Console.Write("Enter Name        :");
                product.Name = Console.ReadLine();
                Console.Write("Enter Barcode     :");
                product.Barcode=double.Parse(Console.ReadLine());
                Console.Write("Enter UnitPrice   :");
                product.Unitprice = double.Parse(Console.ReadLine());
                Console.Write("Enter SellPrice   :");
                product.SellPrice=double.Parse(Console.ReadLine());
                Console.WriteLine("Enter QtyInstock :");
                productIteam.Add(product);
                Console.WriteLine("--------------------- Add --------------------------");
            }
        }
        public void show()
        {
            Console.WriteLine("-----------------------Show product -------------------------");
            //download consoletable
            var table = new ConsoleTable();
            string[] colom = { "ID", "Name", "Barcode", "Unitprice", "SellPrice", "QtyPrice", };
            table.AddColumn(colom);
            for (int i = 0; i < productIteam.Count; i++)
            {
                Product pro = new Product();
                pro=(Product)productIteam[i];
                //pro == product
                object[] row = { pro.Id, pro.Name, pro.Barcode, pro.Unitprice, pro.SellPrice, pro.QtyInstock };

                table.AddRow(row);
            }
            table.Write();
        }
        public void deleteI()
        {
            Console.WriteLine("------------------- Form delete ---------------------");
            Console.Write("Place inter Id For delete\t:");
            this.Id=int.Parse(Console.ReadLine());

            for (int i = 0; i < productIteam.Count; i++)
            {
                Product delete = new Product();
                delete = (Product)productIteam[i];

                if (this.Id==delete.Id)
                {
                    productIteam.Remove(delete);
                }
            }
        }
        public void Addate()
        {
            Console.WriteLine("--------------- Place Addate ----------------------");
            Console.Write("Place Enter product For Addate\t:");
            this.Id= int.Parse(Console.ReadLine());
            int i;
            Product product1 = new Product();
            bool checkaddate=false;
            for (i = 0; i<productIteam.Count; i++)
            {
                
                product1 = (Product)productIteam[i];
                if (this.Id==product1.Id)
                {
                    checkaddate = true;
                    break;

                }

            }
            if (checkaddate==true)
            {

                product1 = (Product)productIteam[i];
                Product addate = new Product();
                Console.Write("Addte to Name\t:");
                product1.Name=Console.ReadLine();
                if (product1.Name!="")
                {
                    addate.Name=product1.Name;
                }
                Console.Write("Addate to Barcode\t:");
                product1.Unitprice=double.Parse(Console.ReadLine());
                addate.Name=product1.Name;
                Console.Write("Addate to Sellprice \t:");
                product1.SellPrice=double.Parse(Console.ReadLine());
                addate.SellPrice=product1.SellPrice;
                Console.Write("Addate to Qtystock\t:");
                product1.QtyInstock=double.Parse(Console.ReadLine());
                addate.QtyInstock=product1.QtyInstock;

            }
            else
            {
                Console.WriteLine("Id Not found!");
            }
        }
        public void Search()
        {
            Console.WriteLine("---------------------------Search Product------------------------");
            var table = new ConsoleTable();
            
            Console.Write("Enter search by Id\t:");
            this.Id=int.Parse(Console.ReadLine());
            
            Product search = new Product();
            bool check_search=false;
            int i;
            for ( i = 0;i<productIteam.Count;i++)
            {  
               
                search= (Product)productIteam[i];
                
                if(this.Id==search.Id)
                {
                    check_search= true;
                    break;
                    
                }
            }
            if(check_search==true)
            {
                string[] colom = { "ID", "Name", "Barcode", "Unitprice", "SellPrice", "QtyPrice", };
                table.AddColumn(colom);
                search= (Product)productIteam[i];
                Console.WriteLine("---------------------Search-----------------------");
                object[] row = { search.Id, search.Name, search.Barcode, search.Unitprice, search.SellPrice, search.QtyInstock };
                table.AddRow(row);
                table.Write();

            }
            else
            {
                Console.WriteLine("Id not found !");
            }
           
        }
    }
}

