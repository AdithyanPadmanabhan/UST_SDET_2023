using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Patient
    {
        public Patient(int patientId, string? patientName, int age, string? diagnosis)
        {
            PatientId = patientId;
            PatientName = patientName;
            Age = age;
            Diagnosis = diagnosis;
        }

        public int PatientId { get; set; }
        public string? PatientName { get; set; }
        public int Age { get; set; }
        public string? Diagnosis { get; set; }

        List<Patient> patientsDetails = new List<Patient>();
        public void AddPatient(Patient patient)
        {
            if ((patient.Age <0 || patient.Age > 120))
            {
                throw new ArgumentException("Age should be between 0 and 120");
            }
            else if
                (patient.PatientName == "" || patient.Diagnosis == "")
            {

                throw new ArgumentException("Patient name and Diagnosiss should not be null");
            }
            else
            {
                patientsDetails.Add(patient);
                Console.WriteLine("Patient details added");

            }
        }

        public void CreateFile()
        {
            FileStream fs = new FileStream("D:\\Training Works\\Basic Programs\\Assignments\\PatientRecords\\PatientDetail.txt"
                , FileMode.Create, FileAccess.Write);
            fs.Close();
        }
        public void PatientsDetails(Patient patient)
        {
            FileInfo fi = new FileInfo("D:\\Training Works\\Basic Programs\\Assignments\\PatientRecords\\PatientDetail.txt");
            if (!fi.Exists)
            {
                CreateFile();
            }
            else
            {
                patientsDetails.Add(patient);
                Console.WriteLine("Patient details added");
                FileStream fs = new FileStream("D:\\Training Works\\Basic Programs\\Assignments\\PatientRecords\\PatientDetail.txt"
                   , FileMode.Append, FileAccess.Write);
               
               
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(patient.PatientId + "\t");
                sw.Write(patient.PatientName + "\t");

                sw.Write(patient.Age + "\t");
                sw.Write(patient.Diagnosis + "\t");
                sw.Write(" ");
                sw.Flush();
                sw.Close();
                fs.Close();
            }
           

        }
        public static void ViewDetails()
        {
            FileStream fs = new FileStream("D:\\Training Works\\Basic Programs\\Assignments\\PatientRecords\\PatientDetail.txt"
                , FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string? str = sr.ReadToEnd();
            while (str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }
    }
}
