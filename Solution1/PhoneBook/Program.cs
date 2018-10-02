using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("******** PhoneBook ********");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            string[] PhoneBookName = new string[] { "Ross Geller", "Monica Geller", "Sheldon cooper", "Chandler Bing" };
            int[] PhoneBookNumber = new int[] { 1234, 5783, 9677, 9799 };

        

            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < PhoneBookName.Length; i++)
            {
                Console.WriteLine(i +"_" + "Name :" + PhoneBookName[i] + "Phonenumber: " +
                    PhoneBookNumber[i] + "\n");
            }
           
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---------------------MENUE----------------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("choose an option");
            Console.WriteLine("1 - ADD ");
            Console.WriteLine("2 - EDIT ");
            Console.WriteLine("3 - REMOVE ");
            Console.WriteLine("4 - EXIT ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("enter new number :");
                    int newnumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter new name :");
                    string newname = Console.ReadLine();
                    Console.WriteLine("New Contact");
                    PhoneBookName[4] = newname;
                    PhoneBookNumber[4] = newnumber;
                    Console.WriteLine("New Contact Added");
                    for (int i = 0; i < PhoneBookName.Length; i++)
                    {
                        Console.WriteLine(i + "_" + "Name :" + PhoneBookName[i] + "Phonenumber: " + PhoneBookNumber[i]);
                    }
                    break;

                case 2:
                    Console.WriteLine("enter name to edit :");
                    string editname = Console.ReadLine();
                    Console.WriteLine("enter number to edit :");
                    int editnumber = int.Parse(Console.ReadLine());

                    break;

                case 3:
                    Console.WriteLine("choose a contact to remove by number" );
                    for (int i = 0; i < PhoneBookName.Length; i++)
                    {
                        Console.WriteLine(i + "_" + "Name :" + PhoneBookName[i] + "Phonenumber: " + PhoneBookNumber[i]);
                    }
                    int s = int.Parse(Console.ReadLine());
                                    
                    break;

                case 4:
                   break;

                default:
                    break; 
            }


            Console.ReadKey();

        }
    }
}
