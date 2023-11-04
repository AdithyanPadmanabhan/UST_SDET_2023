//caseStudy _21-10-2023
using CaseStudy;
using System.Reflection;



    //Console.WriteLine("BOOK STORE:");
    //Console.WriteLine("1.Add Book \n 2.Add Customer\n 3. Place Order\n 4.Exit Order");
    //Console.WriteLine("Choose option");
    //Order order = new Order();
    //int option = Convert.ToInt32(Console.ReadLine());
    //BookType[] bookType = new BookType[]
    //{
    //    new("Winter Days","Amal",32,400,"yes","Fiction"),
    //    new("Sunny Days","Azal",42,600,"yes","Fiction")
    //};

    //switch (option)
    //{
    //    case 1:
    //        Console.WriteLine("Books Added");
    //        foreach (BookType bookType1 in bookType)
    //        {
    //            bookType1.DiplayBookDetails();
    //        }
    //        break;

    //    case 2:

    //        Console.WriteLine("Enter Customer id");
    //       int customerid = Convert.ToInt32(Console.ReadLine());
    //        Console.WriteLine("Enter Customer name");
    //        string? customername = Console.ReadLine();
    //        Console.WriteLine("Enter Contact details:");
    //        double contactDetails =Convert.ToDouble(Console.ReadLine());   
    //        Customer customer = new Customer(customername,contactDetails,customerid);
    //        customer.DisplayCustomer();
    //        break;

    //    case 3:
    //        Console.WriteLine("Enter the Title of the book");
    //       string? title = Console.ReadLine();
    //        foreach (var book in bookType)
    //        {
    //            if (book.Title.Equals(title))
    //            {
    //                Console.WriteLine("Enter Order Date:");
    //                order.OrderDate =Console.ReadLine();
    //                Console.WriteLine("Order confirmed");
    //                Console.WriteLine("Book Title {0} Book Price:{1} Book Availability:{2}",book.Title,book.Price,
    //                    book.Availability);
    //                order.TotalCost = book.Price;
    //                Console.WriteLine("Total cost is:{0}",order.TotalCost);

    //            }
    //            else
    //            {
    //                Console.WriteLine("Book is not Available");
    //            }
    //        }


    //        break;
    //    case 4:
    //        Environment.Exit(0);
    //        break;
    //        default:

    //        Console.WriteLine("Do you want to continue");
    //        int num = Convert.ToInt32(Console.ReadLine());

    //        break; 





    //}


    //28-10-2023

    //Customer1 customerOne = new Customer1();
    //customerOne.CustomerID = 1;
    //customerOne.CustomerName = "Amal";
    //customerOne.CustomerEmail = "Amal@ust";
    //Customer1.customers.Add(customerOne);
    //Customer1 customerTwo = new Customer1();
    //customerTwo.CustomerID = 2;
    //customerTwo.CustomerName = "Ajal";
    //customerTwo.CustomerEmail = "Ajal@ust";
    //Customer1.customers.Add(customerTwo);
    //Customer1 customerThree = new Customer1();
    //customerThree.CustomerID = 3;
    //customerThree.CustomerName = "Hari";
    //customerThree.CustomerEmail = "Hari@ust";
    //Customer1.customers.Add(customerThree);

    //while (true)
    //{
    //    Console.WriteLine("choose your option\n1.User\n2.Admin");
    //    int option = Convert.ToInt32(Console.ReadLine());

    //    if (option == 1)

    //    {
    //        Console.WriteLine("Enter the customer id");
    //        int cusId = Convert.ToInt32(Console.ReadLine());
    //        if (Customer1.customers.Find(x => x.CustomerID == cusId) == null)
    //        {
    //            Console.WriteLine("Customer not found");
    //            break;
    //        }
    //        while (true)
    //        {
    //            Console.WriteLine("choose your option\n1.Add product to cart\n2.view all product\n3.place order\n4.Support\n5.view orders");
    //            int optionuser = Convert.ToInt32(Console.ReadLine());

    //            switch (optionuser)
    //            {

    //                case 1:

    //                    Console.WriteLine("Enter Product id for add to cart");
    //                    int productId = Convert.ToInt32(Console.ReadLine());
    //                    Customer1 customer1 = Customer1.customers.Find(x => x.CustomerID == cusId);
    //                    if (DigitalProduct.Products.Find(x => x.ProductId == productId) == null)
    //                    {
    //                        if (PhysicalProduct.Products.Find(x => x.ProductId == productId) == null)
    //                        {
    //                            Console.WriteLine("invalid product id");
    //                        }
    //                        else
    //                        {
    //                            customer1.ordersphy.Add(PhysicalProduct.Products.Find(x => x.ProductId == productId));
    //                            Console.WriteLine("product added to cart");
    //                        }
    //                    }
    //                    else
    //                    {
    //                        customer1.orders.Add(DigitalProduct.Products.Find(x => x.ProductId == productId));
    //                        Console.WriteLine("product added to cart");
    //                    }
    //                    break;
    //                case 2:
    //                    Console.WriteLine("Products are");
    //                    if (DigitalProduct.Products.Count == 0 && PhysicalProduct.Products.Count == 0)
    //                    {
    //                        Console.WriteLine("No Product Found found");
    //                    }
    //                    foreach (var item in DigitalProduct.Products)
    //                    {
    //                        Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tFileFormat:{4}\tDownloadlink:{5}", item.ProductId,
    //                            item.ProductName, item.Price, item.ProductQuantity, item.FileFormat, item.DownloadLink);
    //                    }
    //                    foreach (var item in PhysicalProduct.Products)
    //                    {
    //                        Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tWeight:{4}" +
    //                            "\tDimension:{5}", item.ProductId,
    //                            item.ProductName, item.Price, item.ProductQuantity, item.ProductQuantity, item.Dimension);
    //                    }
    //                    break;
    //                case 3:
    //                    Customer1 customer = Customer1.customers.Find(x => x.CustomerID == cusId);
    //                    if (customer.orders.Count == 0 && customer.ordersphy.Count == 0)
    //                    {
    //                        Console.WriteLine("no product found in cart");
    //                    }
    //                    else
    //                    {
    //                        foreach (var item in customer.orders)
    //                        {
    //                            Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tFileFormat:{4}\tDownloadlink:{5}", item.ProductId,
    //                             item.ProductName, item.Price, item.ProductQuantity, item.FileFormat, item.DownloadLink);
    //                            item.PlacingOrder();
    //                            item.ProcessingPayment();
    //                            item.DeliveringProduct();

    //                        }
    //                        foreach (var item in customer.ordersphy)
    //                        {
    //                            Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tWeight:{4}" +
    //                           "\tDimension:{5}", item.ProductId,
    //                           item.ProductName, item.Price, item.ProductQuantity, item.ProductQuantity, item.Dimension);
    //                            item.PlacingOrder();
    //                            item.ProcessingPayment();
    //                            item.DeliveringProduct();
    //                        }
    //                        Console.WriteLine("do you want to place all the order\n1.yes\n2.no");
    //                        int confirm = Convert.ToInt32(Console.ReadLine());
    //                        if (confirm == 1)
    //                        {
    //                            customer.confirmedorders.AddRange(customer.orders);
    //                            customer.orders.Clear();
    //                            customer.confirmedordersphy.AddRange(customer.ordersphy);
    //                            customer.ordersphy.Clear();
    //                            Console.WriteLine("order placed successfully");
    //                        }
    //                        else
    //                        {
    //                            Console.WriteLine("removing everything in cart");
    //                        }


    //                    }



    //                    break;
    //                case 4:
    //                    Console.WriteLine("For customer support call to 8921287202");
    //                    break;
    //                case 5:
    //                    Customer1 customer2 = Customer1.customers.Find(x => x.CustomerID == cusId);
    //                    if (customer2.confirmedorders.Count == 0 && customer2.confirmedordersphy.Count == 0)
    //                    {
    //                        Console.WriteLine("no order details found");
    //                    }
    //                    else
    //                    {
    //                        Console.WriteLine("Orders are");
    //                        foreach (var item in customer2.confirmedorders)
    //                        {
    //                            Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tFileFormat:{4}\tDownloadlink:{5}", item.ProductId,
    //                            item.ProductName, item.Price, item.ProductQuantity, item.FileFormat, item.DownloadLink);
    //                        }
    //                        foreach (var item in customer2.confirmedordersphy)
    //                        {
    //                            Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tWeight:{4}" +
    //                           "\tDimension:{5}", item.ProductId,
    //                           item.ProductName, item.Price, item.ProductQuantity, item.ProductQuantity, item.Dimension);
    //                        }
    //                    }
    //                    break;
    //                default:
    //                    Console.WriteLine("invalid input");

    //                    break;
    //            }

    //            Console.WriteLine("do you want to continue as user\n1.yes\n2.no");
    //            int optuser = Convert.ToInt32(Console.ReadLine());
    //            if (optuser == 1)
    //            {
    //                continue;
    //            }
    //            else if (optuser == 2)
    //            {
    //                break;
    //            }
    //            else
    //            {
    //                Console.WriteLine("invalid input");
    //            }
    //        }


    //    }

    //    else if (option == 2)
    //    {
    //        Console.WriteLine("choose option\n1.Add Product\n2.View report");
    //        int optionadmin = Convert.ToInt32(Console.ReadLine());
    //        if (optionadmin == 1)
    //        {
    //            Console.WriteLine("choose the option \n1.Digital Product\n2.Physical Product");
    //            int optionProduct = Convert.ToInt32(Console.ReadLine());
    //            if (optionProduct == 1)
    //            {
    //                Console.WriteLine("Enter Product id");
    //                int productid = Convert.ToInt32(Console.ReadLine());
    //                Console.WriteLine("Enter Product Name");
    //                string? productName = Console.ReadLine();
    //                Console.WriteLine("enter the price");
    //                double productCost = Convert.ToDouble(Console.ReadLine());
    //                Console.WriteLine("Enter the fileformat");
    //                string? fileFormat = Console.ReadLine();
    //                Console.WriteLine("Enter downloadLink");
    //                string? downloadLink = Console.ReadLine();
    //                Console.WriteLine("Enter the Quantity");
    //                int quantity = Convert.ToInt32(Console.ReadLine());


    //                DigitalProduct digitalProduct = new DigitalProduct();
    //                digitalProduct.ProductName = productName;
    //                digitalProduct.ProductId = productid;
    //                digitalProduct.FileFormat = fileFormat;
    //                digitalProduct.DownloadLink = downloadLink;
    //                digitalProduct.Price = productCost;
    //                digitalProduct.ProductQuantity = quantity;
    //                DigitalProduct.Products.Add(digitalProduct);
    //            }
    //            else if (optionProduct == 2)
    //            {
    //                Console.WriteLine("Enter Product id");
    //                int productid = Convert.ToInt32(Console.ReadLine());
    //                Console.WriteLine("Enter Product Name");
    //                string? productName = Console.ReadLine();
    //                Console.WriteLine("enter the price");
    //                double productCost = Convert.ToDouble(Console.ReadLine());
    //                Console.WriteLine("Enter the Weight");
    //                int weight = Convert.ToInt32(Console.ReadLine());
    //                Console.WriteLine("Enter dimension");
    //                string? dimension = Console.ReadLine();
    //                Console.WriteLine("Enter the Quantity");
    //                int quantity = Convert.ToInt32(Console.ReadLine());

    //                PhysicalProduct physicalProduct = new PhysicalProduct();
    //                physicalProduct.ProductName = productName;
    //                physicalProduct.ProductId = productid;
    //                physicalProduct.Price = productCost;
    //                physicalProduct.Dimension = dimension;
    //                physicalProduct.Weight = weight;
    //                physicalProduct.ProductQuantity = quantity;


    //                PhysicalProduct.Products.Add(physicalProduct);
    //            }
    //            else
    //            {
    //                Console.WriteLine("Invalid");
    //            }
    //        }
    //    }
    //    else
    //    {
    //        Console.WriteLine("invalid option");
    //    }
    //    Console.WriteLine("do you want to continue\n1.yes\n2.no");
    //    int opt = Convert.ToInt32(Console.ReadLine());
    //    if (opt == 1)
    //    {
    //        continue;
    //    }
    //    else if (opt == 2)
    //    {
    //        Environment.Exit(0);
    //    }
    //    else
    //    {
    //        Console.WriteLine("invalid input");
    //    }

    //}

    // 04-11-2023

    public delegate void EnrollementHandler(Student student, Course course);
    public delegate void EnrollmentHandler(EnrollementRecord enrollrec);

    class Program
    {
        public static void Main(string[] args)
        {
            Student studentrecord = new();
            Course course1 = new Course()
            {
                CourseCode = 123,
                Title = "BTech",
                Instructor = "Amar"
            };
            Course course2 = new Course()
            {
                CourseCode = 144,
                Title = "MSC",
                Instructor = "Sarath"
            };
            Course course3 = new Course()
            {
                CourseCode = 125,
                Title = "MBA",
                Instructor = "Vikram"
            };
            Course course4 = new Course()
            {
                CourseCode = 146,
                Title = "BA",
                Instructor = "Azal"
            };
            EnrollementRecord.courses.Add(course1);
            EnrollementRecord.courses.Add(course2);
            EnrollementRecord.courses.Add(course3);
            EnrollementRecord.courses.Add(course4);
        repeat1:
        repeat2:
            Console.WriteLine("1.Admin 2.student");
            string? option = Console.ReadLine();
            if (option == "1")
            {
            repeat:
                Console.WriteLine("1.Add Course 2.View Course 3.Remove Course 4.Students List 5.Go Back");
                string? option1 = Console.ReadLine();
                if (option1 == "1")
                {
                    Course courserecord5 = new Course()
                    {
                        CourseCode = 127,
                        Title = "BTech",
                        Instructor = "Rolex"
                    };
                    EnrollementRecord.courses.Add(courserecord5);
                    Console.WriteLine("Courses Added Successfully");
                }
                else if (option1 == "2")
                {
                    Console.WriteLine("Courses:");
                    foreach (var crse in EnrollementRecord.courses)
                    {
                        Console.WriteLine("Course Code: {0}, Course Name: {1}, Instructor: {2}", crse.CourseCode, crse.Title, crse.Instructor);
                    }
                }
                else if (option1 == "3")
                {
                    EnrollementRecord.courses.Remove(course4);
                    Console.WriteLine("Courses are Removed Successfully");
                }
                else if (option1 == "4")
                {
                    Console.WriteLine("Courses");
                    foreach (var crse in EnrollementRecord.enrollementRecords)
                    {
                        Console.WriteLine("Course Code: {0}, Course Name: {1}, Instructor: {2}, StudentID:{3}, Student Name: {4}, Email: {5}", crse.Course.CourseCode, crse.Course.Title, crse.Course.Instructor, crse.Student.StudentID, crse.Student.Name, crse.Student.Email);
                    }
                }
                else if (option1 == "5") { goto repeat1; }
                goto repeat;
            }
            else if (option == "2")
            {
            repeat3:
                Console.WriteLine("1. Register student 2. Course Registration 3. Course Withdrawal");
                string? option2 = Console.ReadLine();
                if (option2 == "1")
                {
                    Console.WriteLine("Enter student ID:");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter student Name:");
                    string? name = Console.ReadLine();
                    Console.WriteLine("Enter Email:");
                    string? email = Console.ReadLine();
                    studentrecord = new()
                    {
                        StudentID = id,
                        Name = name,
                        Email = email
                    };
                    EnrollementRecord.students.Add(studentrecord);
                    goto repeat3;
                }
                else if (option2 == "2")
                {
                    Console.WriteLine("Courses:");
                    foreach (var crse in EnrollementRecord.courses)
                    {
                        Console.WriteLine("Course Code: {0}, Course Name: {1}, Instructor: {2}", crse.CourseCode, crse.Title, crse.Instructor);
                    }
                    try
                    {
                        Console.WriteLine("Course for Registration:");
                        int regcourse = Convert.ToInt32(Console.ReadLine());
                        Course regstrcourse = EnrollementRecord.courses.FirstOrDefault(c => c.CourseCode == regcourse);
                        EnrollAsync(studentrecord, regstrcourse);
                        Console.WriteLine("Enrolled in course");
                        Console.WriteLine("Course Details:");
                    }
                    catch (EnrollmentException ex) { Console.WriteLine(ex.Message); }

                }
                else if (option2 == "3")
                {
                    Console.WriteLine("Courses:");
                    foreach (var crse in EnrollementRecord.courses)
                    {
                        Console.WriteLine("Course Code: {0}, Course Name: {1}, Instructor: {2}", crse.CourseCode, crse.Title, crse.Instructor);
                    }
                    try
                    {
                        Console.WriteLine("Course for deletion");
                        int regcourse = Convert.ToInt32(Console.ReadLine());
                        EnrollementRecord record = EnrollementRecord.enrollementRecords.FirstOrDefault(c => c.Course.CourseCode == regcourse);
                        WihtdrawAsync(record);
                        Console.WriteLine("Removed from course");
                    }
                    catch (EnrollmentException ex) { Console.WriteLine(ex.Message); }
                }
            }
            Console.WriteLine("Do you want to continue? (Y/N)");
            string? titleread = Console.ReadLine();
            if (titleread == "y")
            {
                goto repeat2;
            }
        }
        public static async Task EnrollAsync(Student student, Course course)
        {
            await Task.Delay(100);
            EnrollementHandler enrolhand = course.CourseRegistration;
            enrolhand.Invoke(student, course);
        }
        public static async Task WihtdrawAsync(EnrollementRecord enrollrec)
        {
            await Task.Delay(100);
            Course coure = new();
            EnrollmentHandler enrolhand1 = coure.CourseWithdrawal;
            enrolhand1.Invoke(enrollrec);
        }
    }
