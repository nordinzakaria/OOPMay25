using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SaleTransactions  
    // what does it represent? a collection of sales
    {
    // field
    List<Sale> sales = new List<Sale>();   // creating an array of object
    string staffId;


    // methods
    public float CalcAverage()
    {
        float sum = 0;
        for (int i = 0; i < sales.Count; i++)
        {
            sum += sales[i].amount;
        }
        float avg = sum / sales.Count;

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
        sales.Add(sale);
    }

    public void Display() // print all the transactions to console
    {

    }
}
