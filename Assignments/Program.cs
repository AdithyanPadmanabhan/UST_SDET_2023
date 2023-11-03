
//assignment 18-10-2023
using Assignments;
using Assignments.ExceptionHandling;
/*
Student student = new Student("Amal", 26, 30, 45);
Console.WriteLine("Average score of " + student.studentName + " " + "is" + " " + student.CalculateAverage());
Student student1 = new Student("Vimal", 55, 40, 65);
Console.WriteLine("Average score of " + student1.studentName + " " + "is" + " " + student1.CalculateAverage());
Student student2 = new Student("Sahal", 65, 70, 45);
Console.WriteLine("Average score of " + student2.studentName + " " + "is" + " " + student2.CalculateAverage());

*/

//assignment-1 19-10-23 

//Product[] products = new Product[3];
//products[0] = new Product("Product 1", 500.00, 2);
//products[1] = new Product("Product 2",200.00,5);
//products[2] = new Product("Product 3", 400.00,7);
//products[0].SetPrice(550);


//foreach(Product product in products)
//{
//    product.DisplayProduct();
//    Console.WriteLine("Product Total Value:" + product.ProductValue());
//    Console.WriteLine();
//}

// assignmnet -2 19-10-23

//Student[] student =new Student[3];
//student[0] = new Student("Amal", new int[] { 20, 30, 40 },"A");
//student[1] = new Student("Vimal", new int[] { 50, 45, 67 },"B");
//student[2] = new Student("Zahal", new int[] { 25, 50, 45 }, "C");


//foreach (Student student2 in student)
//{
//    student2.DisplayStudentInfo();
//    student2.CalculateAverage();
//    student2.GetMarkSummary();
//    Console.WriteLine();
//}


// assignment-1 20-10-2023 

//ElectronicProduct ep = new(2, "Apple", 25000, 1);
//ep.DisplayProduct();
//ep.DisplayWarrantyPeriod();
//Console.WriteLine();

// assignment-2 20-10-2023 


//DigitalProduct dp = new DigitalProduct("PDF", 2, "samsung", 50000, 3);
//dp.DisplayProduct();
//dp.DisplayWarrantyPeriod();
//dp.DisplayDigitalProduct();




//Console.WriteLine("1. Electronic Product 2. Digital Product 3. Clothing Product");

//switch (Convert.ToInt32(Console.ReadLine()))
//{

//    case 1:
//        ElectronicProduct ep = new(2, "Apple", 25000, 1);
//        ep.DisplayProduct();
//        ep.DisplayWarrantyPeriod();
//        break;

//        case 2:
//        DigitalProduct dp = new DigitalProduct("PDF", 2, "S23 Ultra", 50000, 1);
//        dp.DisplayProduct();
//        dp.DisplayWarrantyPeriod();
//        dp.DisplayDigitalProduct();
//        break;
//        case 3:
//        ClothingProduct cp = new("Large", "Shirt", 1000, 2);
//        cp.DisplayProduct();
//        cp.DisplayClothingProduct();
//        break;





//}
//Assignment 23-10-23

//Employee employee = new("Adithyan","Padmanabhan",14,1);
//employee.DisplayInfo();




//Circle circle = new() ;
//circle.Radius = 10;

//Rectangle rectangle = new();
//rectangle.Width = 10;
//rectangle.Length = 10;

//circle.Draw();
//rectangle.Draw();

//Assigmnet -1 25-10-2023
//InsurancePolicy insurancePolicy = new("Healthcare", 2001, 2000);
//Console.WriteLine("Intial PremiumAmount:");

//insurancePolicy.Display();
//insurancePolicy.RenewPolicy(2050);
//insurancePolicy.RenewPolicy();

// Assignment -2 25-10-2023
//LifeInsurance lifeInsurance = new LifeInsurance("LIC",1,3500,23);
//Console.WriteLine("PremiumAmount of Life Insurance: {0}",lifeInsurance.CalculatePremium());


//CarInsurance carInsurance = new CarInsurance("Third Party", 2, 4500, "Heavy");
//Console.WriteLine("PremiumAmount of Car Insurance: {0}", carInsurance.CalculatePremium());

////Assignment -1, 26-10-2023
//Customer customer1 = new(123, "Amal", 8921, 2000);
//Customer customer2 = new(456, "Akash", 7202, 3000);
//Customer customer3 = new(233, "Anu", 1234, 4000);

//List<Customer> list = new List<Customer>();
//list.Add(customer1);   
//list.Add(customer2);
//list.Add(customer3);


// void SearchNumber(long phoneNumber)
//{
//    foreach (var item in list)
//    {
//        if(item.PhoneNumber == phoneNumber)
//        {
//            Console.WriteLine(item.CustomerName);
//            Console.WriteLine(item.Balance);
//            break;
//        }
//        else
//        {
//            Console.WriteLine("Customer was not found");
//            break;
//        }
//    }

//}
//Console.WriteLine("Ente the number to search");


//var n =Convert.ToInt64( Console.ReadLine());
//SearchNumber(n);


//void CustomerDetailsDisplay()
//{
//    foreach (var item in list)
//    {
//        Console.WriteLine("CustomerId: {0} \t CustomerName: {1} \t Phone Number: {2}\t Balance: {3}",item.CustomerId,
//            item.CustomerName,item.PhoneNumber,item.Balance);
//    }
//}

//CustomerDetailsDisplay();

// assignment -2 26-10-2023


//CallRecord callRecord1 = new(123, 1.5, 8921287202);
//CallRecord callRecord2 = new(456, 2.5, 8921287202);
//CallRecord callRecord3 = new(567, 3.5, 7202);

//List<CallRecord> callRecords = new()
//{
//    callRecord1, callRecord2, callRecord3
//};

//void CallHistory(long phonumber)
//{
//    foreach (var item in callRecords)
//    {
//        if(item.PhoneNumber == phonumber)
//        {
//            Console.WriteLine("CallID: {0}\t CallTime: {1}",item.CallId,item.CallTime);
//            break;

//        }
//        else { Console.WriteLine("Phone Number not found");
//            break;
//        }
//    }

//}

//CallHistory(8921);

//Console.WriteLine("Ente the number to search");


//var n =Convert.ToInt64( Console.ReadLine());
//CallHistory(n);
//TotalCalls();


//void TotalCalls()
//{
//    Dictionary<long, int> num = new();
//    int count = 1;
//    foreach (var item in callRecords)
//    {
//        if (!num.ContainsKey(item.PhoneNumber))
//        {
//            num[item.PhoneNumber] = count;
//        }
//        else
//        {
//            num[item.PhoneNumber] += 1;
//        }
//    }
//    foreach (var item in num)
//    {
//        Console.WriteLine("Phone Number: {0} Number of Calls: {1}", item.Key, item.Value);
//    }
//}


//Patient patients = new(1,"",23,"Cold");
//try
//{
//    patients.AddPatient(patients);
//}
//catch(ArgumentException ex)
//{
//    Console.WriteLine(ex.Message);
//}

// assignment -1 27-10-2023

//MedicalRecord medicalRecord = new(123, "Hari", 33, "Cold", 456, -1);
//try
//{
//    medicalRecord.MedicalRecordDetails(medicalRecord);
//}
//catch(InvalidPatientDataException pd)
//{
//    Console.WriteLine(pd.Message);
//}
//catch(InvalidMedicalRecordException mr)
//{
//    Console.WriteLine(mr.Message);
//}


// assignment 2- 27-10-2023
//int option, choice;
//do
//{
//    Console.WriteLine("1.Add Patient \n 2. View Patient Details\n 3.Exit Order");
//    Console.WriteLine("Choose option");
//    choice = Convert.ToInt32(Console.ReadLine());

//    switch (choice)
//    {
//        case 1:

//            Console.WriteLine("Enter PatientID:");
//            int id = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter Patient Name:");
//            string? name = Console.ReadLine();
//            Console.WriteLine("Enter Age");
//            int age = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter diagnosis");
//            string? diagnosis = Console.ReadLine();
//            Patient patient = new(id, name, age, diagnosis);
//            patient.PatientsDetails(patient);


//            break;

//        case 2:
//            Patient.ViewDetails();
//            break;

//        case 3:
//            Environment.Exit(0);
//            break;
//    }
//    Console.WriteLine("Do You Want To Continue Press 1 for continue");
//    option = Convert.ToInt32(Console.ReadLine());
//} while (option == 1);


// assignment -3 27-10-23


//MedicalHistory medicalHistory = new(123, 432, "Cold", "20-10-23");

//MedicalHistory medicalHistory1 = new(453, 1232, "Vomiting", "21-01-22");

//MedicalHistory medicalHistory2 = new(6783, 332, "Heart Attack", "13-03-21");
//int option, choice;
//do
//{

//    Console.WriteLine("1.Add Medical Details \n 2. View Patient Details\n 3.Exit Order");
//    Console.WriteLine("Choose option");
//    choice = Convert.ToInt32(Console.ReadLine());

//    switch (choice)
//    {
//        case 1:

//            MedicalHistory.MedicalHistoryDetails(medicalHistory1);
//            MedicalHistory.MedicalHistoryDetails(medicalHistory2);
//            MedicalHistory.MedicalHistoryDetails(medicalHistory);

//            break;

//        case 2:


//            MedicalHistory.ViewDetails();
//            break;

//        case 3:
//            Environment.Exit(0);
//            break;
//    }
//    Console.WriteLine("Do You Want To Continue Press 1 for continue");
//    option = Convert.ToInt32(Console.ReadLine());
//} while (option == 1);


//Assignment -1 30-10-2023

//var typ1 = "single";
//var typ2 = 2;
//RoomReservation<string>.BookRoom(123, ref typ1);
////RoomReservation<int>.BookRoom(101, ref typ2);
//RoomReservation<string>.CancelRoom(101);


//assignment -2 -30-10-2023

//var typ1 = "MI";
//var typ2 = 1010;
//var typ3 = "OnePlus";
//Product<string>.AddProduct(1, ref typ1, 100, 2);
//Product<int>.AddProduct(2, ref typ2, 50, 3);
//Product<string>.UpdateProduct(1, typ3);
//Product<string>.DeleteProduct(2);
//Product<string>.SearchProduct(1);

//Assignments -1 -31-10-2023
//public delegate double Emp1(double perfrate);

//class Program
//{
//    public static void Main(string[] args)
//    {
//    repeat:
//        Console.WriteLine("Enter Employee ID:");
//        int id = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Enter Employee Name:");
//        string? name = Console.ReadLine();
//        Employees employee = new();
//        employee.EmployeeId = id;
//        employee.Name = name;
//        Console.WriteLine("Bonus Calculation Method:");
//        Console.WriteLine("1. Performance Threshold 2. Department Specific Rules");
//        string? choose = Console.ReadLine();
//        if (choose == "1")
//        {
//            Emp1 emp1 = Employees.BonusCalculationOne;
//            Console.WriteLine("Enter Performance Threshold:");
//            Console.WriteLine(emp1.Invoke(Convert.ToDouble(Console.ReadLine())));
//        }
//        else if (choose == "2")
//        {
//            Emp1 emp1 = Employees.BonusCalculationTwo; 
//            Console.WriteLine("Enter Department Specific Rule Rate:");
//            Console.WriteLine(emp1.Invoke(Convert.ToDouble(Console.ReadLine())));
//        }
//        Console.WriteLine("Do you want to continue? (y/n)");
//        string? titleread = Console.ReadLine();
//        if (titleread == "y")
//        {
//            goto repeat;
//        }
//    }
//}
//public delegate void Hotels();

//class Program
//{
//    public static void Main(string[] args)
//    {

//        HotelEvent hotelEvent = new HotelEvent("haloween", DateOnly.Parse("31-10-23"), "kochi", 500);
//        HotelEvent hotelEvent1 = new HotelEvent("Birthday Party", DateOnly.Parse("29-10-23"), "Trivandrum", 400);
//        HotelEvent.AddEvent(hotelEvent);
//        HotelEvent.AddEvent(hotelEvent1);
//        Hotels hotelevent2 = HotelEvent.RegisterEvent;
//        Hotels hotelevent3 = HotelEvent.Statusreg;
//        Hotels objall = hotelevent2 + hotelevent3;
//        objall.Invoke();
//    }
//}


//assignment -1 - 1-11-2023

//TourismDestination.touristList.Add(new TourismDestination("TajMahal", "India", 5));
//TourismDestination.touristList.Add(new TourismDestination("Zuzi", "Pattaya", 2.5));
//TourismDestination.touristList.Add(new TourismDestination("RedFort", "Mumbai", 1.5));
//TourismDestination.touristList.Add(new TourismDestination("WhiteFort", "USA",3.5));
//TourismDestination.touristList.Add(new TourismDestination("Hari Tower", "Uganda", 2));
//TourismDestination.SortBy();

//TouristDestination.TouristDest();


//assignment -1 02-11-2023

//    Hotel hotel1 = new Hotel("Tajmahal", "India", 3.5, 5, "Thamara");

//    Hotel hotel2 = new Hotel("Burkhalifa", "Dubai", 2.5, 10, "Novotel");


//    Console.WriteLine("Available rooms at Hotel{0} is {1}",hotel1.Hotelname,hotel1.AvailableRooms);
//    Console.WriteLine("Available rooms at Hotel{0} is {1}", hotel2.Hotelname, hotel2.AvailableRooms);
//    await HotelBooking(hotel1,3);
//    await HotelBooking(hotel2, 4);


//    Console.WriteLine("Available rooms at Hotel{0} is {1}", hotel1.Hotelname, hotel1.AvailableRooms);
//    Console.WriteLine("Available rooms at Hotel{0} is {1}", hotel2.Hotelname, hotel2.AvailableRooms);


//static async Task  HotelBooking(Hotel hotel, int reqrooms)
//{
//    await hotel.HotelBooK(reqrooms);
//}

//Assignment -2 ---02-11-2023


//TourPackage package = new TourPackage(1, "Wayanad", "02-11-2025", 1300);
//TourPackage package1 = new TourPackage(2, "Ernakulam", "12-1-2024", 1400);
//TourPackage package2 = new TourPackage(3, "kannur", "12-12-2023", 1500);

//TourPackage.tourPackages.Add(package1);
//TourPackage.tourPackages.Add(package2);
//TourPackage.tourPackages.Add(package);


//Thread thread = new Thread(TourPackage.HotelReservation);

//Thread thread1 = new Thread(TourPackage.HotelReservation);

//thread.Start();
//thread.Join();
//thread1.Start();



//Assignment -1 03-11-2023
//TaskItem ts = new TaskItem(1, "Birthday", false);
//TaskItem ts1 = new TaskItem(2, "Game", true);
//TaskItem ts2 = new TaskItem(3, "gym", true);
//TaskItem ts3 = new TaskItem(4, "work", false);

//TaskItem.TaskItems.Add(ts);
//TaskItem.TaskItems.Add(ts1);
//TaskItem.TaskItems.Add(ts2);
//TaskItem.TaskItems.Add(ts3);

//TaskItem.Display();
//Console.WriteLine(" Enter the id to change");
//int id = Convert.ToInt32(Console.ReadLine());
//var status = TaskItem.TaskItems.Find(x => x.TaskId == id);
//if (status != null)
//{
//    status.IsCompleted = true;
//    Console.WriteLine("Status has been changed");
//}
//else
//    Console.WriteLine("id not found");
//Console.WriteLine("Enter the id to remove Task");
//int remove = Convert.ToInt32(Console.ReadLine());
//TaskItem.TaskItems.RemoveAll(x => x.TaskId == remove);
//Console.WriteLine("Task removed succeessfully");

//Console.WriteLine("Total Tasks Are");
//TaskItem.FilteringTask();


//Assignment -2 03-11-2023

FamilyMember grandparent = new FamilyMember("Grandparent", 60);
FamilyTree familyTree = new FamilyTree(grandparent);

FamilyMember parent1 = new FamilyMember("Parent 1", 65);
FamilyMember parent2 = new FamilyMember("Parent 2", 50);
FamilyMember child1 = new FamilyMember("Child 1", 28);
FamilyMember child2 = new FamilyMember("Child 2", 26);
FamilyMember grandchild1 = new FamilyMember("Grandchild 1", 11);


grandparent.AddChild(parent1);
grandparent.AddChild(parent2);
parent1.AddChild(child1);
parent1.AddChild(child2);
child1.AddChild(grandchild1);

Console.WriteLine("Family Tree:");
familyTree.DisplayFamilyTree();





















