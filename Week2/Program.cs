// See https://aka.ms/new-console-template for more information

/* Requirement
 * 1) We have multiple counters
 * 
 */

Console.WriteLine("Hello, World!");

const int NUM_COUNTER = 5;


Sale sale0 = new Sale(); // create a single object

// only a single array needed now
Sale[] sales = new Sale[NUM_COUNTER];   // creating an array of object



int option;

int sz = 0;

while (true) // infinite loop
{
    Console.WriteLine("Options: 1) Read transaction " +
                    " 2) Print transactions " + // complete this option
                    " 3) Calculate average");
    option = int.Parse(Console.ReadLine());


    if (option == 1)
    {
        Console.WriteLine("Enter desc, amount and day");

        // arrayname [ index ] . field 
        sales[sz].description = Console.ReadLine();
        sales[sz].amount = float.Parse(Console.ReadLine());
        sales[sz].day = int.Parse(Console.ReadLine());
        Console.WriteLine(" product sold: " + sales[sz].description);
        Console.WriteLine("     amount: " + sales[sz].amount);

        sz++;
    }
    else if (option == 2)
    {   // complete this
        for (int i = 0; i < sz; i++) {
        {
                sales[sz].Print();
        }

    }

}
