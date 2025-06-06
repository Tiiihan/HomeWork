//initialization of variables and input first order
Console.Write("Enter order number: ");
int orderNum = int.Parse(Console.ReadLine());
Console.Write("Enter client name: ");
string clientName = Console.ReadLine();
Console.Write("Enter type of product: ");
string product = Console.ReadLine();
Console.Write("Enter price of product: ");
double price = double.Parse(Console.ReadLine());
Console.Write("Enter client address: ");
string address = Console.ReadLine();

//output first order
Console.WriteLine($"\nOrder No {orderNum} \nClient: {clientName}. \nProduct: {product}, price {price} EUR. \nAddress: {address}.\n");

//input second order
Console.Write("Enter order number: ");
orderNum = int.Parse(Console.ReadLine());
Console.Write("Enter client name: ");
clientName = Console.ReadLine();
Console.Write("Enter type of product: ");
product = Console.ReadLine();
Console.Write("Enter price of product: ");
price = double.Parse(Console.ReadLine());
Console.Write("Enter client address: ");
address = Console.ReadLine();

//output second order
Console.WriteLine($"\nOrder No {orderNum} \nClient: {clientName}. \nProduct: {product}, price {price} EUR. \nAddress: {address}.\n");

//input third order
Console.Write("Enter order number: ");
orderNum = int.Parse(Console.ReadLine());
Console.Write("Enter client name: ");
clientName = Console.ReadLine();
Console.Write("Enter type of product: ");
product = Console.ReadLine();
Console.Write("Enter price of product: ");
price = double.Parse(Console.ReadLine());
Console.Write("Enter client address: ");
address = Console.ReadLine();

//output third order
Console.WriteLine($"\nOrder No {orderNum} \nClient: {clientName}. \nProduct: {product}, price {price} EUR. \nAddress: {address}.\n");