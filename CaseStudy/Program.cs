//caseStudy _21-10-2023
using CaseStudy;
using System.Reflection;

Console.WriteLine("BOOK STORE:");
Console.WriteLine("1.Add Book \n 2.Add Customer\n 3. Place Order\n 4.Exit Order");
Console.WriteLine("Choose option");
Order order = new Order();
int option = Convert.ToInt32(Console.ReadLine());
BookType[] bookType = new BookType[]
{
    new("Winter Days","Amal",32,400,"yes","Fiction"),
    new("Sunny Days","Azal",42,600,"yes","Fiction")
};

switch (option)
{
    case 1:
        Console.WriteLine("Books Added");
        foreach (BookType bookType1 in bookType)
        {
            bookType1.DiplayBookDetails();
        }
        break;

    case 2:
       
        Console.WriteLine("Enter Customer id");
       int customerid = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Customer name");
        string? customername = Console.ReadLine();
        Console.WriteLine("Enter Contact details:");
        double contactDetails =Convert.ToDouble(Console.ReadLine());   
        Customer customer = new Customer(customername,contactDetails,customerid);
        customer.DisplayCustomer();
        break;

    case 3:
        Console.WriteLine("Enter the Title of the book");
       string? title = Console.ReadLine();
        foreach (var book in bookType)
        {
            if (book.Title.Equals(title))
            {
                Console.WriteLine("Enter Order Date:");
                order.OrderDate =Console.ReadLine();
                Console.WriteLine("Order confirmed");
                Console.WriteLine("Book Title {0} Book Price:{1} Book Availability:{2}",book.Title,book.Price,
                    book.Availability);
                order.TotalCost = book.Price;
                Console.WriteLine("Total cost is:{0}",order.TotalCost);

            }
            else
            {
                Console.WriteLine("Book is not Available");
            }
        }


        break;
    case 4:
        Environment.Exit(0);
        break;
        default:

        Console.WriteLine("Do you want to continue");
        int num = Convert.ToInt32(Console.ReadLine());
        
        break; 
   




}