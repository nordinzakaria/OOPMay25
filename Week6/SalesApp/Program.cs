
// Application code - just create objects and call methods

// how to create a Sale object
Sale sale = new Sale("Flowers", 1, new Date(1, 1, 2025));


// how to create a SaleTransaction object
SaleTransactions transaction = new SaleTransactions();

sale.SetAmount(-10);


// how to add the Sale obj to the SaleTransactions
transaction.Add(sale);