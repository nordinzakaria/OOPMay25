using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Sale   // think of this as a struct
                    // To represent a single Sale
 {
    //  fields
    private string description;  
    private float amount;
    //public DateTime date;
    private Date date;

    // constructors
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


    // setter & getter

    public void SetAmount(float amount)
    {
        if (amount < 0)
        {

        }
        this.amount = amount;
    }

    public float GetAmount()
    {
        return this.amount;
    }

    public Date GetDate()
    {
        return this.date;
    }

    public void SetDate(Date date)
    {
        this.date = date;
    }



    // methods
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
