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

 EV ev =new EV();
ev.VehicleNumber = 1234;
ev.BrandName = "Honda";
ev.Model = "2019";
ev.Display();
Console.WriteLine(ev.setTypeForVehicle());



PetrolVehicle pv = new PetrolVehicle();
pv.VehicleNumber = 369;
pv.BrandName = "Honda Petrol";
pv.Model = "2023";
pv.Display();
Console.WriteLine(pv.setTypeForVehicle());














