using System;

namespace Rental
{
    class Program
    {
        private static object result;

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
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine(System.DateTime.Now);
            Console.WriteLine("Hello and welcome to Brunei's online Car Rentals and Taxi Booking");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("A) Please choose the type of vehicle you want to rent or book:");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("1) Small vehicle - $20 per day");
            Console.WriteLine("2) Regular vehicle - $30 per day");
            Console.WriteLine("3) Big vehicle - $40 per day");
            Console.WriteLine("4) Luxury vehicle - $60 per day");
            Console.WriteLine("5) Taxi");
            Console.WriteLine("6) Click here to Exit");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Please choose a number");
            Console.WriteLine();


            string result = Console.ReadLine();

            if (result == "1")
            {
                Console.WriteLine();

                Option1();
                return true;
            }

            else if (result == "2")
            {
                Console.WriteLine();
                Option2();
                return true;
            }

            else if (result == "3")
            {
                Console.WriteLine();
                // Option3();
                return true;
            }


            else if (result == "4")
            {
                Console.WriteLine();
                // Option4();
                return true;
            }

            else if (result == "5")
            {
                Console.WriteLine();
                // Option5();
                return true;
            }

            else if (result == "6")
            {

                return false;
            }

            else
            {
                return true;

            }
        }

            private static void Option1()
            {


                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine("Time");
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("1) Morning");
                Console.WriteLine("2) Evening");
                Console.WriteLine("3) Night");
                Console.WriteLine("4) Return Back");
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("Please insert time code");



                string list = Console.ReadLine();
                if (list == "1")
                {

                    Console.WriteLine();
                    ticket();



                }

            }

            private static void ticket()
            {



                double Adultprice = 6.00;
                double Childprice = 4.00;

                Console.WriteLine("=======================================================");
                Console.WriteLine("Ticket");
                Console.WriteLine("=======================================================");
                Console.WriteLine();
                Console.WriteLine("Adultprice=$6.00");
                Console.WriteLine("Childprice=$4.00");
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("=> Ticket For Adult:");
                int result1 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine(result1 * Adultprice);
                Console.WriteLine();


                Console.WriteLine("=> Ticket For Child:");
                int result2 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine(result2 * Childprice);
                Console.WriteLine();

                Console.WriteLine();
                Console.WriteLine("The total ticket for adult and kids is:");
                Console.WriteLine(result1 * Adultprice + result2 * Childprice);
                Console.WriteLine();


                Console.WriteLine("Click Yes to proceed or No to exit");
                string next = Console.ReadLine();


                if (next == "yes")
                {
                    Console.WriteLine();

                    extra1();
                    ;
                }
                else if (next == "no")
                {

                    MainMenu();
                }

            }


            private static void extra1()
            {

                Console.Clear();
                Console.WriteLine("=======================================================");
                Console.WriteLine("Foods and drinks");
                Console.WriteLine("=======================================================");
                Console.WriteLine();

                Console.WriteLine();
                Console.WriteLine("Do you want to buy Food or drinks");



                string food = Console.ReadLine();

                if (food == "yes")
                {
                    Console.WriteLine();
                    Console.WriteLine("food: chicken");
                    Console.WriteLine("food: chicken");
                    Console.WriteLine("food: chicken");
                    Console.ReadLine();
                }


                else if (food == "no")


                    Console.WriteLine();
                Console.WriteLine("=======================================================");
                Console.WriteLine("Please select Hall");
                Console.WriteLine("=======================================================");
                Console.WriteLine();
                Console.WriteLine("Please insert time code");

                Console.WriteLine();
                Console.WriteLine("=> Hall 1");
                Console.WriteLine("=> Hall 2");
                Console.WriteLine("=> Hall 3");
                Console.WriteLine();
                Console.ReadLine();
            }







            private static void Option2()
            {




            }

            private static void Option3()
            {




            }

            private static void Option4()
            {


            }


            private static void Option5()
            {

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
