
//assignment 18-10-2023
using Assignments;
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


CallRecord callRecord1 = new(123, 1.5, 8921287202);
CallRecord callRecord2 = new(456, 2.5, 8921287202);
CallRecord callRecord3 = new(567, 3.5, 7202);

List<CallRecord> callRecords = new()
{
    callRecord1, callRecord2, callRecord3
};

void CallHistory(long phonumber)
{
    foreach (var item in callRecords)
    {
        if(item.PhoneNumber == phonumber)
        {
            Console.WriteLine("CallID: {0}\t CallTime: {1}",item.CallId,item.CallTime);
            break;
           
        }
        else { Console.WriteLine("Phone Number not found");
            break;
        }
    }

}

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


Patient patients = new(1,"Amal",23,"Cold");
try
{
    patients.AddPatient(patients);
}
catch(ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}















