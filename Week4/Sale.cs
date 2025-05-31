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
    public Date date;

    public Sale()
    {
        description = string.Empty;
        amount = 0;
        date = new Date();
    } 

    public Sale(string description, float amount, Date date)
    {
        this.description = description;
        this.amount = amount;
        this.date = date;
    }

    // method
    public void Print()
    {
        Console.WriteLine("description: " + description);
        Console.WriteLine(amount);
        Console.WriteLine(date.day);
        Console.WriteLine(date.month);
        Console.WriteLine(date.year);
        Console.WriteLine("***************");
    }

}
