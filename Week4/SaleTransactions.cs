using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SaleTransactions  
    // what does it represent? a collection of sales
    {
    // field
    const int NUM_COUNTER = 5;
    Sale[] sales = new Sale[NUM_COUNTER];   // creating an array of object
    int sz = 0;
    string staffId;


    // methods
    public float CalcAverage()
    {
        float sum = 0;
        for (int i = 0; i < sz; i++)
        {
            sum += sales[i].amount;
        }
        float avg = sum / sz;

        return avg;
    }

    public float CalcMax()
    {
        return 0;
    }

    public float CalcMin()
    {
        return 0;
    }

    public void Add(Sale sale)
    {
        sales[sz++] = sale;
    }

    public void Display() // print all the transactions to console
    {

    }
}
