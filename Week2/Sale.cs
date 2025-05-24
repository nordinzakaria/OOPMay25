using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Sale   // think of this as a struct
                    // To represent a single Sale
 {
    //  fields
    public string description;  
    public float amount;
    public int day;
    public int month;
    public int year;

    public void Print()
    {
        Console.WriteLine("description: " + description);
        Console.WriteLine(amount);
        Console.WriteLine(day);
        Console.WriteLine(month);
        Console.WriteLine(year);
        Console.WriteLine("***************");
    }

}
