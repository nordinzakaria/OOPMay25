
// Application code - just create objects and call methods

// how to create a Sale object
Sale sale = new Sale();
sale.amount = 10;
sale.description = "FLowers";
sale.date = 

// how to create a SaleTransaction object
SaleTransactions transaction = new SaleTransactions();

// how to add the Sale obj to the SaleTransactions
transaction.Add(sale);