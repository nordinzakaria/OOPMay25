// See https://aka.ms/new-console-template for more information

using System.Reflection.Metadata;

Console.WriteLine("Hello, World!");

float[] amount = new float[5];
string[] description = new string[5];
int[] day = new int[5], 
        month = new int[5], 
        year = new int[5];

int option;

int sz = 0;

while (true)
{
    Console.WriteLine("Options: 1) Read transaction " +
                    " 2) Print transactions " +
                    " 3) Calculate average");
    option = int.Parse(Console.ReadLine());


    if (option == 0)
    {
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
