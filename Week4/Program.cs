
// Application code - just create objects and call methods

// how to create a Sale object
Sale sale = new Sale();
sale.amount = 10;
sale.description = "Flowers";
                    // make sure the parameters correspond to the actual ordering
sale.date = new Date(5, 31, 2025); ;

// how to create a SaleTransaction object
SaleTransactions transaction = new SaleTransactions();

// how to add the Sale obj to the SaleTransactions
transaction.Add(sale);