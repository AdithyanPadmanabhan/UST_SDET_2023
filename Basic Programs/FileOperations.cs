using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class FileOperations
    {
        public void CreateFile()
        { 
        FileInfo fi = new FileInfo("C:\\Users\\Administrator\\Desktop\\Files\\Demo.txt"); 
            using StreamWriter str =fi.CreateText();
            Console.WriteLine("File Has been created");
            str.WriteLine("hello");
            str.WriteLine("welcome");
            Console.Write("Done");
        
        }

        public void WriteData() {
            FileStream fs = new FileStream("C:\\Users\\Administrator\\Desktop\\Files\\Demo2.txt"
                , FileMode.CreateNew, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Console.WriteLine("Enter the text which" + "You want to write to the file");
            string? str =Console.ReadLine();
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
            fs.Close();
        
        }

        public void ReadData()
        {
            FileStream fs = new FileStream("C:\\Users\\Administrator\\Desktop\\Files\\Demo2.txt"
                , FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string? str =sr.ReadToEnd();
            while(str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }
        public void CopyAndMoveFile()
        {
            FileInfo fi = new FileInfo("C:\\Users\\Administrator\\Desktop\\Files\\Sample.txt");
            FileInfo fi1 = new FileInfo("C:\\Users\\Administrator\\Desktop\\Files\\Sample.txt");
            fi.CopyTo("C:\\Users\\Administrator\\Desktop\\Files\\Temp " + "Sample.txt");
            fi1.MoveTo("C:\\Users\\Administrator\\Desktop\\Files\\Temp1" + "Sample.txt");
            
        }
        public void Deletedata()
        {
            FileInfo fi = new FileInfo("C:\\Users\\Administrator\\Desktop\\Files\\Demo.txt");
            fi.Delete();
        }
        public void FileProperties()
        {
            FileInfo fi = new FileInfo("C:\\Users\\Administrator\\Desktop\\Files\\" +"Sample.txt");
            Console.WriteLine(fi.Name);
            Console.WriteLine(fi.FullName);
            Console.WriteLine(fi.Extension);
        }
    }
}
