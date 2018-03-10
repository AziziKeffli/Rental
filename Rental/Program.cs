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
            Console.WriteLine("Hello and welcome to Brunei's Car Rentals and Taxi Booking services");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("A) Please choose a number for the type of vehicle you want to rent or book:");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("1) Small vehicle - $10 per day");
            Console.WriteLine("2) Regular vehicle - $15 per day");
            Console.WriteLine("3) Big vehicle - $20 per day");
            Console.WriteLine("4) Luxury vehicle - $30 per day");
            Console.WriteLine("5) Taxi / Uber");
            Console.WriteLine("6) Exit");
            Console.WriteLine();
            Console.WriteLine("Please select a number");
            Console.WriteLine();
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
                Console.WriteLine("                          You have selected");
                Console.WriteLine("                          [ Small Vehicle ]");
                Console.WriteLine();
                Console.WriteLine("B) Rental Duration");
                Console.WriteLine();
                Console.WriteLine("1) Day(s)");
                Console.WriteLine("2) Week(s)");
                Console.WriteLine("3) Month(s) [ PROMO $10.00 OFF PER MONTH ]");
                Console.WriteLine("4) Return Back");
                Console.WriteLine();
                Console.WriteLine("Please select your rental duration");
                Console.WriteLine();
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
                    Console.WriteLine("                          You have selected");
                    Console.WriteLine("                         [ Regular Vehicle ]");
                    Console.WriteLine();
                    Console.WriteLine("B) Rental Duration");
                    Console.WriteLine();
                    Console.WriteLine("1) Day(s)");
                    Console.WriteLine("2) Week(s)");
                    Console.WriteLine("3) Month(s) [ PROMO $30.00 OFF PER MONTH ]");
                    Console.WriteLine("4) Return Back");
                    Console.WriteLine();
                    Console.WriteLine("Please select your rental duration");
                    Console.WriteLine();
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
                    Console.WriteLine("                          You have selected");
                    Console.WriteLine("                          [ Large Vehicle ]");
                    Console.WriteLine();
                    Console.WriteLine("B) Rental Duration");
                    Console.WriteLine();
                    Console.WriteLine("1) Day(s)");
                    Console.WriteLine("2) Week(s)");
                    Console.WriteLine("3) Month(s) [ PROMO $50.00 OFF PER MONTH ]");
                    Console.WriteLine("4) Return Back");
                    Console.WriteLine();
                    Console.WriteLine("Please select your rental duration");
                    Console.WriteLine();
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
                    Console.WriteLine("                          You have selected");
                    Console.WriteLine("                         [ Luxury Vehicle ]");
                    Console.WriteLine();
                    Console.WriteLine("B) Rental Duration");
                    Console.WriteLine();
                    Console.WriteLine("1) Day(s)");
                    Console.WriteLine("2) Week(s)");
                    Console.WriteLine("3) Month(s) [ PROMO $50.00 OFF PER MONTH ]");
                    Console.WriteLine("4) Return Back");
                    Console.WriteLine();
                    Console.WriteLine("Please select your rental duration");
                    Console.WriteLine();
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
            private static void Result5()
                {
                    Console.WriteLine("----------------------------------------------------------------------------");
                    Console.WriteLine("                          You have selected");
                    Console.WriteLine("                           [ Taxi / Uber ]");
                    Console.WriteLine();
                    Console.WriteLine("B) Type of vehicle");
                    Console.WriteLine();
                    Console.WriteLine("1) Regular taxi [ 1 to 2 Adults ]");
                    Console.WriteLine("2) Van  [ 1 to 6 Adults]");
                    Console.WriteLine("3) Uber [ PROMO $1.00 OFF ]");
                    Console.WriteLine("4) Return Back");
                    Console.WriteLine();
                    Console.WriteLine("Please choose type of vehicle");
                    Console.WriteLine();
                    string list = Console.ReadLine();
                    if (list == "1")
                    {
                        Console.WriteLine();
                        List41();
                    }
                    else if (list == "2")
                    {
                        Console.WriteLine();
                        List42();
                    }
                    else if (list == "3")
                    {
                        Console.WriteLine();
                        List43();
                    }
                    else if (list == "4")
                    {
                        Console.WriteLine();
                        MainMenu();
                    }
                    else
                    {
                        Console.WriteLine("------------------Please select a number between 1 and 4--------------------");
                        Result5();
                    }
                }
            private static void List41()
                {
                    String now, later;
                    Console.WriteLine("----------------------------------------------------------------------------");
                    Console.WriteLine("                          You have selected");
                    Console.WriteLine("                           [ Regular Taxi ]");
                    Console.WriteLine();
                    Console.WriteLine("Please input your current location");
                    Console.WriteLine("Location : ");
                    now = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Please input your destination");
                    Console.WriteLine("Destination : ");
                    later = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                       Your driver will arrive shortly.");
                    Console.WriteLine("                       Your current location is " + now + ".");
                    Console.WriteLine("                       Your destination is " + later + ".");
                    Console.WriteLine();
                    Console.WriteLine("                       Press enter to continue");
                    Console.ReadLine();
                    Info();
                }
            private static void List42()
                {
                    String now, later;
                    Console.WriteLine("----------------------------------------------------------------------------");
                    Console.WriteLine("                          You have selected");
                    Console.WriteLine("                                [ Van ]");
                    Console.WriteLine();
                    Console.WriteLine("Please input your current location");
                    Console.WriteLine("Location : ");
                    now = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Please input your destination");
                    Console.WriteLine("Destination : ");
                    later = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                       Your uber will arrive shortly.");
                    Console.WriteLine("                       Your current location is " + now + ".");
                    Console.WriteLine("                       Your destination is " + later + ".");
                    Console.WriteLine();
                    Console.WriteLine("                       Press enter to continue");
                    Console.ReadLine();
                    Info();
                }
            private static void List43()
                {
                    String now, later;
                    Console.WriteLine("----------------------------------------------------------------------------");
                    Console.WriteLine("                          You have selected");
                    Console.WriteLine("                                [ Uber ]");
                    Console.WriteLine();
                    Console.WriteLine("Please input your current location");
                    Console.WriteLine("Location : ");
                    now = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Please input your destination");
                    Console.WriteLine("Destination : ");
                    later = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                       PROMOTION $1.00 OFF EVERY RIDES");
                    Console.WriteLine("                       PROMOTION $1.00 OFF EVERY RIDES");
                    Console.WriteLine();
                    Console.WriteLine("                       Your uber will arrive shortly.");
                    Console.WriteLine("                       Your current location is " + now + ".");
                    Console.WriteLine("                       Your destination is " + later + ".");
                    Console.WriteLine();
                    Console.WriteLine("                       Press enter to continue");
                    Console.ReadLine();
                    Info();
                }
            private static void Info()
                {
                    String fname, lname, gps, input, day, month, year, country, email, sex, job, hedu, status, contact;
                    int identification = 0;
                    int address = 0;
                    int days = 0;
                    int months = 0;
                    int years = 0;
                    Console.WriteLine("----------------------------------------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine("        Thank you for using our services. To pay, please fill in your");
                    Console.WriteLine("          credentials and contact our hotline to pursue the payment.");
                    Console.WriteLine();
                    Console.WriteLine("Please enter your details below");
                    Console.WriteLine("Gender : ");
                    sex = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("First name : ");
                    fname = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Last name : ");
                    lname = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Relationship status : ");
                    status = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Address : ");
                    gps = Console.ReadLine();
                    bool parse_ok = int.TryParse(gps, out address);
                    while (gps.Length >= 51)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Maximum address character limit is 50 characters");
                        Console.Write("Please enter your address again : ");
                        gps = Console.ReadLine();
                    }
                    Console.WriteLine("Entered address: {0}", gps);
                    Console.WriteLine();
                    Console.Write("Identification number / Passport number : ");
                    input = Console.ReadLine();
                    int.TryParse(input, out identification);
                    while (input.Length >= 16)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Please enter a valid identification number / passport number");
                        Console.Write("Please enter your 15 digit Identification number / Passport number : ");
                        input = Console.ReadLine();
                    }
                    Console.WriteLine("Entered number: {0}", input);
                    Console.WriteLine();
                    Console.WriteLine("Date of birth");
                    Console.WriteLine("Day :");
                    day = Console.ReadLine();
                    int.TryParse(day, out days);
                    while (day.Length >= 3)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Please enter a valid day");
                        day = Console.ReadLine();
                    }
                    Console.WriteLine("Entered day : {0}", day);
                    Console.WriteLine();
                    Console.WriteLine("Month : ");
                    month = Console.ReadLine();
                    int.TryParse(month, out months);
                    while (month.Length >= 10)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Please enter a valid month");
                        month = Console.ReadLine();
                    }
                    Console.WriteLine("Entered month : {0}", month);
                    Console.WriteLine();
                    Console.WriteLine("Year : ");
                    year = Console.ReadLine();
                    int.TryParse(year, out years);
                    while (year.Length >= 5)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Please enter a valid year");
                        year = Console.ReadLine();
                    }
                    Console.WriteLine("Entered year : {0}", year);
                    Console.WriteLine();
                    Console.WriteLine("Country : ");
                    country = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Email address : ");
                    email = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Contact number : ");
                    contact = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Job : ");
                    job = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Highest education level : ");
                    hedu = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Thank you for using Brunei's Car Rentals and Taxi Booking services.");
                    Console.WriteLine("Fullname : " + fname + " " + lname + ".");
                    Console.WriteLine("Gender : " + sex + ".");
                    Console.WriteLine("Relationship status : " + status + ".");
                    Console.WriteLine("Address : " + gps + ".");
                    Console.WriteLine("Identification number / Passport number : " + input + ".");
                    Console.WriteLine("Date of birth : " + day + " " + month + " " + year + ".");
                    Console.WriteLine("Country : " + country + ".");
                    Console.WriteLine("Email address : " + email + ".");
                    Console.WriteLine("Contact number : " + contact + ".");
                    Console.WriteLine("Job : " + job + ".");
                    Console.WriteLine("Highest education level : " + hedu + ".");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("All of your information will be stored for future activity");
                    Console.ReadLine();
                }   
    }
}
