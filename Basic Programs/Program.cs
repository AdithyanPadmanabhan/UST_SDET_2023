// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Enter two numbers");
int num1, num2, answer;
num1= Convert.ToInt32(Console.ReadLine()); 
num2= Convert.ToInt32(Console.ReadLine());
answer = num1 + num2;
Console.WriteLine(answer);*/


//driver
/*
using Basic_Programs;

Calculation calculation = new Calculation();
int num1=Convert.ToInt32(Console.ReadLine());   
int num2=Convert.ToInt32(Console.ReadLine());

double res =calculation.Add(num1,num2);
Console.WriteLine(res);
*/



/*
string? s1  ="";

string? s2 = "";
string s3;
s1 =Console.ReadLine();
s2 =Console.ReadLine();
s3 = s1 + " " + s2;
Console.WriteLine(s3);
Console.WriteLine(s1.Equals(s2)); 
Console.WriteLine(s1.ToUpper());
Console.WriteLine(s1.ToLower());
Console.WriteLine(s1.Substring(3));*/

/* int x = 3;
switch(x)
{
    case 1:
        Console.WriteLine("1");
        break;
    case 2:
        Console.WriteLine("2");
        break;
    case 3:
           Console.WriteLine("3");
        break;
    default: Console.WriteLine("4");
        break; 


}*/
/*
using Basic_Programs;

Electricity electricity = new Electricity(1234, 9000, 9300, "amal");
//double billamount = electricity.CalculateBill();
Console.WriteLine(electricity.CalculateBill());
Console.WriteLine(electricity.currentReading);
Console.WriteLine("Consumer name:" + " " + electricity.consumerName);
Electricity electricity1 = new Electricity(45634, 9000, 9400, "vimal");
Console.WriteLine(electricity1.CalculateBill());
*/

using Basic_Programs;
using Basic_Programs.ExceptionMessages;
/*
Employee employee = new(111, "Adhi", "HR", 50000);
Console.WriteLine(" Employee ID: {0}\n Name :{1} \n Department :{2} \n Basic Pay : {3}\n", employee.Eid, employee.Name, employee.Department,
employee.BasicPay);
Console.WriteLine("Net pay : {0}", employee.CalculateSalary());
*/

//ArrayExample example = new ArrayExample();
//example.Onedimension();
//example.Twodimension();
//example.Jaggered();
//StudentMarks marks = new(121, "amal", "Kochi", 98, 97, 100,0,0.0);
//StudentMarks marks = new ();
//marks.RollNo = 1;
//marks.StudentName = "Test";
//marks.Mark1 = 100;
//marks.Mark2 = 97;
//marks.Mark3 = 78;

//marks.DisplayStudentDetails();
//Console.WriteLine("Average: "+marks.CalculateAverage());
//Console.WriteLine("Total: "+marks.CalculateTotal());

//StudentGrade grade = new();

//grade.RollNo = 1;
//grade.StudentName = "Test";
//grade.Mark1 = 100;
//grade.Mark2 = 97;
//grade.Mark3 = 78;


//grade.CalculateGrade();
//Console.WriteLine("Grade: " + grade.CalculateGrade());
//Console.WriteLine("Average: " + grade.CalculateAverage());
//Console.WriteLine("Total: " + grade.CalculateTotal());

// hierachy inheritence

//Console.WriteLine("1. TS 2. NTS 3. S");
//switch (Convert.ToInt32(Console.ReadLine()))
//{

//    case 1:
//        TeachingStaff ts = new TeachingStaff();
//        ts.StaffId = 111;
//        ts.Name = "asasr";
//        ts.Depat = "IT";
//        ts.Sem = 4;
//        ts.Specialization = "EEE";
//        ts.DisplayStaffDetails();

//        ts.DisplayTSStaffDetails();
//        break;

//    case 2:
//        NonTeachinStaff nts= new NonTeachinStaff();
//        nts.StaffId = 121;
//       nts.Name = "fasasr";
//        nts.Depat = "HR";
//        nts.Respnsibilities = "manager";
//       nts.Experience = 5;
//        nts.DisplayNTStaffDetails();
//        nts.DisplayStaffDetails();
//        break;
//        case 3: 
//        StudentDetails s = new StudentDetails();
//        s.StudentName = "Adhi";
//        s.City = "Tvm";
//        s.CollegeId = 1;
//        s.CollegeName = "Cusat";
//        s.DisplayStudentDetails();
//        s.DisplayCollegeDetails();
//        break;

//}
//

// EV ev =new EV();
//ev.VehicleNumber = 1234;
//ev.BrandName = "Honda";
//ev.Model = "2019";
//ev.Display();
//Console.WriteLine(ev.setTypeForVehicle());



//PetrolVehicle pv = new PetrolVehicle();
//pv.VehicleNumber = 369;
//pv.BrandName = "Honda Petrol";
//pv.Model = "2023";
//pv.Display();
//Console.WriteLine(pv.setTypeForVehicle());


//21-10-23
//interface

//Doctor doctor = new Doctor();
//doctor.AddNewDoctor(123,"saho");
//doctor.DisplayDoctorDetails();
//doctor.ModifyDoctor(456,"Samar");
//doctor.DisplayDoctorDetails();
//doctor.BookApp(765, "vasu");
//doctor.DelApp("vasu");

//polymorphism with overloading and overriding
//BankDetails bank = new(1234, 1234456777, "hari", "Inactive");

//BankDetailsNew bank4 = new(1738,1000000,"VYshnav");
//bank4.WelcomeMessage();//overriding

//BankDetails bank2 = new();
//BankDetails bank3 = new(789,7890,"Adhi");
//Console.WriteLine("1.cust id 2.accnumb 3.name");
//int ch = Convert.ToInt32(Console.ReadLine());
//switch (ch)
//{
//    case 1:
//        Console.WriteLine("Custid : ");

//        bank4.GetAccountDetails(Convert.ToInt32(Console.ReadLine()));
//        break;
//    case 2:

//        Console.WriteLine("AccNum : ");
//        bank4.GetAccountDetails(Convert.ToInt64(Console.ReadLine()));
//        break;
//    case 3:
//        Console.WriteLine("Name: ");
//        bank4.GetAccountDetails(Console.ReadLine());
//        break;
//    default:
//        Console.WriteLine("Enter between 1-3");
//        break;



//}
//BankDetails.ExitMessge();




// 25-10-2023


//NonGenericCollectionsEX nGc = new NonGenericCollectionsEX();
//nGc.ArraryListHandling();
//nGc.StackHandling();
//nGc.QueueHandling();
//nGc.HashTableHandlingExample();
//nGc.SortedListHandling();


//GenericCollectionEx genericCollectionEx = new GenericCollectionEx();
////genericCollectionEx.ListHandling();
////genericCollectionEx.StackHandling();
////genericCollectionEx.QueueHandling();
////genericCollectionEx.DictionaryHandlingExample();
//genericCollectionEx.SortedListHandling();

//ExceptionhandlingEX ex = new(10, 101);
//try
//{
//    ex.Numcheck();
//}
//catch(Number1Exception exs)
//{
//    Console.WriteLine(exs.Message);

//}
//try
//{
//    ex.NumcheckTwo();
//}
//catch (Number2Exception exs)
//{
//    Console.WriteLine(exs.Message);

//}

////try
////{
////    ex.Divide();

//catch (ArithmeticException exs)
//{
//    Console.WriteLine(MyExceptions.excepMeassage[0]);


//    //    Console.WriteLine(ex.Message);
//    //    Console.WriteLine(ex.StackTrace);
//    //    Console.WriteLine(ex.Source);
//}
//catch (IndexOutOfRangeException exs)
//{
//    Console.WriteLine(MyExceptions.excepMeassage[1]);
//}
//catch (Exception exs)
//{
//    Console.WriteLine(MyExceptions.excepMeassage[2]);
//}
//finally
//{
//    Console.WriteLine("Done");
//}


//FileOperations fileOperations = new FileOperations();
//fileOperations.CreateFile();
//fileOperations.WriteData();
//fileOperations.ReadData();
//fileOperations.CopyAndMoveFile();
//fileOperations.Deletedata();
//fileOperations.FileProperties();


//30-10-2023 generic

//GenEX<int> g1 = new GenEX<int> (1, 2);
//Console.WriteLine (g1.Val1 + " " +g1.Val2);



//GenEX<string> g2 = new GenEX<string>("Adhi","amal");
//Console.WriteLine(g2.Val1 + " " + g2.Val2);



//GenEX<double> g3 = new GenEX<double>(1.2, 2.5);
//Console.WriteLine(g3.Val1 + " " + g3.Val2);


//GenEX<bool> g4 = new GenEX<bool>(true, true);
//Console.WriteLine(g4.Val1 + " " + g4.Val2);

//GenEX<int> ga = new GenEX<int>(new int[3] {1,2,3});
//ga.Display();
//static void Swap<T>(ref T num1, ref T num2)
//{
//    T temp;
//    temp = num1;
//    num1 = num2;
//    num2 = temp;

//}
//int n1 =10, n2 = 20;
//char c1 = 'A', c2 = 'B';
//Swap<int>(ref n1, ref n2);
//Swap<char>(ref c1, ref c2);

//Console.WriteLine("A = {0} B ={1}",n1,n2);
//Console.WriteLine("c = {0} d ={1}", c1, c2);




//31-10-2023

public delegate void Del1();
public delegate void Del2(string message);
public delegate void Del3(int n1,int n2);
public delegate int Del4(int n1, int n2);

//declare the delegate
class Program
{
    public static void Main(string[] args)
    {
        Del1 dobj1 = DelegateEx.MethodA; 
        //bind target method

        dobj1.Invoke();  //invoke


       Del2 dobj2 = DelegateEx.MethodB;
        dobj2.Invoke("Hi guys");

        DelegateEx delEx = new();
        Del3 dobj3 = delEx.Add;
        Del3 dobj4 = delEx.Sub;
        Del3 dobjall = dobj3 + dobj4;// multicasting


        dobjall(10, 20);

        //Del4 dobj4 = delEx.AddR;
        //Console.WriteLine(dobjall(12, 13));

    }
}



















