using Assignments.ExceptionHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class MedicalRecord : Patient
    {
     
        public MedicalRecord(int patientId, string? patientName, int age, string? diagnosis,
            int recordId, double treatmentCost) : base(patientId, patientName, age, diagnosis)
        {
            RecordId = recordId;
            TreatmentCost = treatmentCost;

        }
        public int RecordId { get; set; }
        public double TreatmentCost { get; set; }

        static List<MedicalRecord> recordList = new List<MedicalRecord>();

        public void MedicalRecordDetails(MedicalRecord records)
        {
            
                if
                    (records.PatientName == "" || records.Diagnosis == "")
                {

                    throw new InvalidPatientDataException(ExceptionHandles.excepMeassage[1]);
                }

                else if (records.TreatmentCost<0)
             {
                throw new InvalidMedicalRecordException(ExceptionHandles.excepMeassage[2]);
              }

                else
                {
                recordList.Add(records);

                    Console.WriteLine("Record details  added");

                }
            }
        }

    }

