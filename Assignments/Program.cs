
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

Student[] student =new Student[3];
student[0] = new Student("Amal", new int[] { 20, 30, 40 },"A");
student[1] = new Student("Vimal", new int[] { 50, 45, 67 },"B");
student[2] = new Student("Zahal", new int[] { 25, 50, 45 }, "C");


foreach (Student student2 in student)
{
    student2.DisplayStudentInfo();
    student2.CalculateAverage();
    student2.GetMarkSummary();
    Console.WriteLine();
}






