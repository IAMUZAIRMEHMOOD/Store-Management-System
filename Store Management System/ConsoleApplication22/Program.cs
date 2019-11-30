using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication22
{
    public struct AddStock
    {
        public int product_id;
        public string product_name;
        public string product_companyname;
        public float product_price;

        public void GetValues(int ID, string n, string n1, float p)
        {
            product_id = ID;
            product_name = n;
            product_companyname = n1;
            product_price = p;

        }
        public void displaydetail()
        {
            Console.WriteLine("Product ID : {0}\nProduct Name : {1}\nCompany Name : {2} \nProduct Price : {3}", product_id, product_name, product_companyname, product_price);
        }

    }

    class Project
    {
        private void Profile()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t\t********** My Profile **********\n\n\n\n\t\tName : AAHM\t\t\t\t\t Contact : 03xx-xxxxxxx");
            Console.WriteLine("\t\tEmail : xxxxxxxxx@email.com \t\t\t Department : Administration");
            Console.WriteLine("\t\tCity : Karachi \t\t\t\t\t Country : Pakistan");
        }

        public void Stock()
        {
            Console.Clear();
            Console.WriteLine("How many items you want to enter");
            int it = int.Parse(Console.ReadLine());
            Console.Clear();
            for (int i = 0; i < it; i++)
            {
               string Filepath= @"C:\Users\fall2017\Downloads\New folder\stock.txt";
                StreamWriter srstock=File.AppendText(Filepath);
                
                          
                AddStock st1 = new AddStock();
                Console.WriteLine("Enter Product name ");
                st1.product_name = Convert.ToString(Console.ReadLine());
                srstock.WriteLine(st1.product_name);
                Console.WriteLine("Enter Product ID");
                st1.product_id = int.Parse(Console.ReadLine());
                srstock.WriteLine(st1.product_id);
                Console.WriteLine("Enter Company Name");
                st1.product_companyname = Convert.ToString(Console.ReadLine());
                srstock.WriteLine(st1.product_companyname);
                Console.WriteLine("Enter Product's Price");
                st1.product_price = float.Parse(Console.ReadLine());
                srstock.WriteLine(st1.product_price);
                srstock.Close();
                Console.Clear();
                Console.WriteLine("\t\t\t********** Stock Sucessfully Added **********");
                st1.displaydetail();
                Console.ReadKey();
                Console.Clear();
                

            }
        }

        public static void ReadFromFile(String Filename)
        {
            Console.Clear();
            StreamReader srname = new StreamReader(Filename);
            while (!srname.EndOfStream)
            {
               
                Console.WriteLine(srname.ReadLine());
            }
            srname.Close();
        }

        public static void WriteToFile(String Filename)
        {
            Console.Clear();
            Console.WriteLine("How Many New Employees Name You Want to Add");
            int e = int.Parse(Console.ReadLine());
            Console.Clear();
            string[] enames = new string[e];
            for (int i = 0; i < enames.Length; i++)
            {
                Console.WriteLine("Enter Employee Name");
                enames[i] = Convert.ToString(Console.ReadLine());

            }

            StreamWriter swname = File.AppendText(Filename);

            for (int i = 0; i < enames.Length; i++)
            {
                swname.Write("\n"+enames[i]);

            }
            swname.Close();


        }
       

        static void Main(string[] args)
        {


            int loginAttempts = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter username");
                string username = Console.ReadLine();
                Console.WriteLine("Enter password");
                string password = Console.ReadLine();

                if (username != "valid" || password != "valid")
                    loginAttempts++;
                else
                    break;
            }

            Console.Clear();

            if (loginAttempts > 2)
            {
                Console.WriteLine("Login failure");

            }
            else
            {

                Console.WriteLine("Login successful");
                Console.Clear();
                char ans;
                do
                {
                    Console.WriteLine("\t\t\t\t**********You're Logged in as Admin**********\n\n\n\n (1) My Profile\n (2) Add Stock\n (3) Employees List \n (4) Add Employees");
                    Console.WriteLine("\n Enter The Respective Number To Perform Action");
                    int n = int.Parse(Console.ReadLine());
                    switch (n)
                    {
                        case 1:
                            {
                                Project f1 = new Project();
                                f1.Profile();
                                break;
                            }
                        case 2:
                            {
                                
                                Project f2 = new Project();
                                f2.Stock();
                                break;
                            }
                        case 3:
                            {
                                String Filename = @"C:\Users\fall2017\Downloads\New folder\names.txt";
                                ReadFromFile(Filename);
                                break;
                            }
                        case 4:
                            {
                                String Filename = @"C:\Users\fall2017\Downloads\New folder\names.txt";
                                WriteToFile(Filename);
                                break;
                            }

                    }
                    Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine("Do you want to Continue [Y/N]");
                    ans = Convert.ToChar(Console.ReadLine());
                    Console.Clear();
                }
                while (ans == 'y');


            }

        }
    }
}
