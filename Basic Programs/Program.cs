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

using Basic_Programs;

Electricity electricity = new Electricity(1234, 9000, 9300, "amal");
//double billamount = electricity.CalculateBill();
Console.WriteLine(electricity.CalculateBill());
Console.WriteLine(electricity.currentReading);
Console.WriteLine("Consumer name:" + " " + electricity.consumerName);
Electricity electricity1 = new Electricity(45634, 9000, 9400, "vimal");
Console.WriteLine(electricity1.CalculateBill());








