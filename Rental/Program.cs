using System;
namespace Rental
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("                   Car Rentals and Taxi Booking");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(System.DateTime.Now);
            Console.WriteLine("Hello and welcome to Brunei's online Car Rentals and Taxi Booking");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("A) Please choose a number for the type of vehicle you want to rent or book:");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("1) Small vehicle - $10 per day");
            Console.WriteLine("2) Regular vehicle - $15 per day");
            Console.WriteLine("3) Big vehicle - $20 per day");
            Console.WriteLine("4) Luxury vehicle - $30 per day");
            Console.WriteLine("5) Taxi");
            Console.WriteLine("6) Exit");
            Console.WriteLine();
            Console.WriteLine("Please select a number");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------");
            string result = Console.ReadLine();
            if (result == "1")
            {
                Console.WriteLine();
                Result1();
                return true;
            }
            else if (result == "2")
            {
                Console.WriteLine();
                Result2();
                return true;
            }
            else if (result == "3")
            {
                Console.WriteLine();
                Result3();
                return true;
            }
            else if (result == "4")
            {
                Console.WriteLine();
                Result4();
                return true;
            }
            else if (result == "5")
            {
                Console.WriteLine();
                Result5();
                return true;
            }
            else if (result == "6")
            {

                return false;
            }
            else
            {
                Console.WriteLine("------------------Please select a number between 1 and 6--------------------");
                return true;
            }
        }
            private static void Result1()
            {
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("B) Rental Duration  [ Small Vehicle ]");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("1) Day(s)");
                Console.WriteLine("2) Week(s)");
                Console.WriteLine("3) Month(s) [ PROMO $10.00 OFF PER MONTH ]");
                Console.WriteLine("4) Return Back");
                Console.WriteLine();
                Console.WriteLine("Please your rental duration");
                Console.WriteLine();
                Console.WriteLine("----------------------------------------------------------------------------");
                string list = Console.ReadLine();
                if (list == "1")
                {
                    Console.WriteLine();
                    List01();
                }
                else if (list == "2")
                {
                    Console.WriteLine();
                    List02();
                }
                else if (list == "3")
                {
                    Console.WriteLine();
                    List03();
                }
                else if (list == "4")
                {
                    Console.WriteLine();
                    MainMenu();
                }
                else
                {
                    Console.WriteLine("------------------Please select a number between 1 and 4--------------------");
                    Result1();
                }
            }
            private static void List01()
                {
                    Int32 Day = 0;
                    Int32 Price = 10;
                    Int32 Final = 0;

                    Console.Write("State how many day(s) do you want to rent our vehicle : ");
                    Day = Convert.ToInt32(Console.ReadLine());

                    Final = Day * Price;

                    Console.Write("The amount you have to pay is ${0}", Final);

                    Console.WriteLine();
                    Info();
                }
            private static void List02()
                {
                    Int32 Week = 0;
                    Int32 Price = 70;
                    Int32 Final = 0;
                    Console.Write("State how many week(s) do you want to rent our vehicle : ");
                    Week = Convert.ToInt32(Console.ReadLine());
                    Final = Week * Price;
                    Console.Write("The amount you have to pay is ${0}", Final);
                    Console.WriteLine();
                    Info();
                }
            private static void List03()
                {
                    Int32 Month = 0;
                    Int32 Price = 280;
                    Int32 Final = 0;
                    Console.Write("State how many month(s) do you want to rent our vehicle : ");
                    Month = Convert.ToInt32(Console.ReadLine());
                    Final = Month * Price;
                    Console.Write("The amount you have to pay is ${0}", Final);
                    Console.WriteLine();
                    Info();
                }
            private static void Result2()
               {
                    Console.WriteLine("----------------------------------------------------------------------------");
                    Console.WriteLine("B) Rental Duration  [ Regular Vehicle ]");
                    Console.WriteLine("----------------------------------------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine("1) Day(s)");
                    Console.WriteLine("2) Week(s)");
                    Console.WriteLine("3) Month(s) [ PROMO $30.00 OFF PER MONTH ]");
                    Console.WriteLine("4) Return Back");
                    Console.WriteLine();
                    Console.WriteLine("Please your rental duration");
                    Console.WriteLine();
                    Console.WriteLine("----------------------------------------------------------------------------");
                    string list = Console.ReadLine();
                    if (list == "1")
                {
                    Console.WriteLine();
                    List11();
                }
                    else if (list == "2")
                {
                    Console.WriteLine();
                    List12();
                }
                    else if (list == "3")
                {
                    Console.WriteLine();
                    List13();
                }
                    else if (list == "4")
                {
                    Console.WriteLine();
                    MainMenu();
                }
                    else
                {
                    Console.WriteLine("------------------Please select a number between 1 and 4--------------------");
                    Result2();
                }
            }
            private static void List11()
                {
                    Int32 Day = 0;
                    Int32 Price = 15;
                    Int32 Final = 0;
                    Console.Write("State how many day(s) do you want to rent our vehicle : ");
                    Day = Convert.ToInt32(Console.ReadLine());
                    Final = Day * Price;
                    Console.Write("The amount you have to pay is ${0}", Final);
                    Console.WriteLine();
                    Info();
                }
            private static void List12()
                {
                    Int32 Week = 0;
                    Int32 Price = 105;
                    Int32 Final = 0;
                    Console.Write("State how many week(s) do you want to rent our vehicle : ");
                    Week = Convert.ToInt32(Console.ReadLine());
                    Final = Week * Price;
                    Console.Write("The amount you have to pay is ${0}", Final);
                    Console.WriteLine();
                    Info();
                }
            private static void List13()
                {
                    Int32 Month = 0;
                    Int32 Price = 430;
                    Int64 Final = 0;
                    Console.Write("State how many month(s) do you want to rent our vehicle : ");
                    Month = Convert.ToInt32(Console.ReadLine());
                    Final = Month * Price;
                    Console.Write("The amount you have to pay is ${0}", Final);
                    Console.WriteLine();
                    Info();
                }
            private static void Result3()
                {
                    Console.WriteLine("----------------------------------------------------------------------------");
                    Console.WriteLine("B) Rental Duration  [ Large Vehicle ]");
                    Console.WriteLine("----------------------------------------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine("1) Day(s)");
                    Console.WriteLine("2) Week(s)");
                    Console.WriteLine("3) Month(s) [ PROMO $50.00 OFF PER MONTH ]");
                    Console.WriteLine("4) Return Back");
                    Console.WriteLine();
                    Console.WriteLine("Please your rental duration");
                    Console.WriteLine();
                    Console.WriteLine("----------------------------------------------------------------------------");
                    string list = Console.ReadLine();
                    if (list == "1")
                {
                    Console.WriteLine();
                    List21();
                }
                    else if (list == "2")
                {
                    Console.WriteLine();
                    List22();
                }
                    else if (list == "3")
                {
                    Console.WriteLine();
                    List23();
                }
                    else if (list == "4")
                {
                    Console.WriteLine();
                    MainMenu();
                }
                    else
                {
                    Console.WriteLine("------------------Please select a number between 1 and 4--------------------");
                    Result3();
                }
            }
            private static void List21()
                {
                    Int32 Day = 0;
                    Int32 Price = 20;
                    Int32 Final = 0;
                    Console.Write("State how many day(s) do you want to rent our vehicle : ");
                    Day = Convert.ToInt32(Console.ReadLine());
                    Final = Day * Price;
                    Console.Write("The amount you have to pay is ${0}", Final);
                    Console.WriteLine();
                    Info();
                }
            private static void List22()
                {
                    Int32 Week = 0;
                    Int32 Price = 140;
                    Int32 Final = 0;
                    Console.Write("State how many week(s) do you want to rent our vehicle : ");
                    Week = Convert.ToInt32(Console.ReadLine());
                    Final = Week * Price;
                    Console.Write("The amount you have to pay is ${0}", Final);
                    Console.WriteLine();
                    Info();
                }
            private static void List23()
                {
                    Int32 Month = 0;
                    Int32 Price = 550;
                    Int64 Final = 0;
                    Console.Write("State how many month(s) do you want to rent our vehicle : ");
                    Month = Convert.ToInt32(Console.ReadLine());
                    Final = Month * Price;
                    Console.Write("The amount you have to pay is ${0}", Final);
                    Console.WriteLine();
                    Info();
                }
            private static void Result4()
                {
                    Console.WriteLine("----------------------------------------------------------------------------");
                    Console.WriteLine("B) Rental Duration  [ Luxury Vehicle ]");
                    Console.WriteLine("----------------------------------------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine("1) Day(s)");
                    Console.WriteLine("2) Week(s)");
                    Console.WriteLine("3) Month(s) [ PROMO $50.00 OFF PER MONTH ]");
                    Console.WriteLine("4) Return Back");
                    Console.WriteLine();
                    Console.WriteLine("Please your rental duration");
                    Console.WriteLine();
                    Console.WriteLine("----------------------------------------------------------------------------");
                    string list = Console.ReadLine();
                    if (list == "1")
                {
                    Console.WriteLine();
                    List31();
                }
                    else if (list == "2")
                {
                    Console.WriteLine();
                    List32();
                }
                    else if (list == "3")
                {
                    Console.WriteLine();
                    List33();
                }
                    else if (list == "4")
                {
                    Console.WriteLine();
                    MainMenu();
                }
                    else
                {
                    Console.WriteLine("------------------Please select a number between 1 and 4--------------------");
                    Result3();
                }
            }
            private static void List31()
                {
                    Int32 Day = 0;
                    Int32 Price = 30;
                    Int32 Final = 0;
                    Console.Write("State how many day(s) do you want to rent our vehicle : ");
                    Day = Convert.ToInt32(Console.ReadLine());
                    Final = Day * Price;
                    Console.Write("The amount you have to pay is ${0}", Final);
                    Console.WriteLine();
                    Info();
                }
            private static void List32()
                {
                    Int32 Week = 0;
                    Int32 Price = 210;
                    Int32 Final = 0;
                    Console.Write("State how many week(s) do you want to rent our vehicle : ");
                    Week = Convert.ToInt32(Console.ReadLine());
                    Final = Week * Price;
                    Console.Write("The amount you have to pay is ${0}", Final);
                    Console.WriteLine();
                    Info();
                }
            private static void List33()
                {
                    Int32 Month = 0;
                    Int32 Price = 950;
                    Int32 Final = 0;
                    Console.Write("State how many month(s) do you want to rent our vehicle : ");
                    Month = Convert.ToInt32(Console.ReadLine());
                    Final = Month * Price;
                    Console.Write("The amount you have to pay is ${0}", Final);
                    Console.WriteLine();
                    Info();
                }
            private static void Info()
                {
                    String fname, lname, address, input;
                    int age;
                    Console.WriteLine("----------------------------------------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine("        Thank you for using our services. To pay, please fill in your");
                    Console.WriteLine("          credentials and contact our hotline to pursue the payment.");
                    Console.WriteLine();
                    Console.WriteLine("Please enter your details below");
                    Console.WriteLine("First name : ");
                    fname = Console.ReadLine();
                    Console.WriteLine("Last name : ");
                    lname = Console.ReadLine();
                    Console.WriteLine("Address : ");
                    address = Console.ReadLine();
                    Console.WriteLine("What is your age : ");
                    input = Console.ReadLine();
                    age = Convert.ToInt32(input);
                    Console.WriteLine("Hello " + fname + " " + lname + " you are " + age + " years old and from " + address);
                    Console.ReadLine();
                 }
            //String fname, lname, address, input;
            //int age;
            //Console.WriteLine("------------------------------------------------------------------");
            //Console.WriteLine("Please enter your details below");
            //Console.WriteLine("First name:");
            //fname = Console.ReadLine();
            //Console.WriteLine("Last name:");
            //lname = Console.ReadLine();
            //Console.WriteLine("Address:");
            //address = Console.ReadLine();
            //Console.WriteLine("What is your age?");
            //input = Console.ReadLine();
            //age = Convert.ToInt32(input);
            //Console.WriteLine("Hello " + fname + " " + lname + " you are " + age + " years old and from " + address);
            //Console.ReadLine();
        }
    }
