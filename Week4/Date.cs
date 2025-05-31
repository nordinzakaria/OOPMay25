using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Date
  {
    public int year;
    public int month;
    public int day;

    public Date() // constructor
    {
        day = 1;
        month = 1;
        year = 2000;
        Console.WriteLine("In constructor; initialized values");
    }

    public Date(int day_, int month_, int year_) // constructor ver 2
    {   // make use of the parameters to initialize the attributes
        day = day_;
        month = month_;
        year = year_;
        Console.WriteLine("In constructor ver 2; initialized values");
    }
}
