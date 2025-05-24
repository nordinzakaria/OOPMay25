// See https://aka.ms/new-console-template for more information

/* Requirement
 * 1) We have multiple counters
 * 
 */

Console.WriteLine("Hello, World!");

const int NUM_COUNTER = 5;
float[] amount = new float[NUM_COUNTER];
string[] description = new string[NUM_COUNTER];

int[] day = new int[2];  // you change to this after coming back from holiday
int[] month = new int[NUM_COUNTER];


int[] year = new int[NUM_COUNTER];

int option;

int sz = 0;

while (true) // infinite loop
{
    Console.WriteLine("Options: 1) Read transaction " +
                    " 2) Print transactions " +
                    " 3) Calculate average");
    option = int.Parse(Console.ReadLine());


    if (option == 1)
    {
        Console.WriteLine("Enter desc, amount and day");
        description[sz] = Console.ReadLine();
        amount[sz] = float.Parse(Console.ReadLine());
        day[sz] = int.Parse(Console.ReadLine());
        Console.WriteLine(" product sold: " + description);
        Console.WriteLine("     amount: " + amount);

        sz++;
    }
    else if (option == 1)
    {


    }

}
