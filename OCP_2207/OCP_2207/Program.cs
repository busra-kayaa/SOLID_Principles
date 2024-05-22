using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using OCP_2207;

namespace OCP_2207
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Doctor_OCP_2207> doctors = new List<Doctor_OCP_2207>();

            Doctor_OCP_2207.AddDoctor(doctors, "Dr. Büşra", "Kaya", "Dahiliye", "BK12345", "5559876543");
            Doctor_OCP_2207.AddDoctor(doctors, "Dr. Betül", "Badem", "Ortopedi", "BB12345", "5379874533");
            Doctor_OCP_2207.AddDoctor(doctors, "Dr. Şaziye", "Dağ", "Kardiyoloji", "ŞD12345", "5779874551");
            Doctor_OCP_2207.AddDoctor(doctors, "Dr. Ömer Faruk", "Kaya", "Dermatoloji", "ÖFK12345", "5329874573");
            Doctor_OCP_2207.AddDoctor(doctors, "Dr. Hasan Basri", "Kaya", "Nefroloji", "HBK12345", "5879773299");
            Doctor_OCP_2207.AddDoctor(doctors, "Dr. Ayşe Nur", "Dönmez", "Nefroloji", "AND12345", "5171272217");
            Console.WriteLine();

            foreach (var doctor in doctors)
            {
                doctor.DisplayInfo();
            }
            Console.WriteLine();

            Doctor_OCP_2207.RemoveDoctor(doctors, "ŞD12345");
            Console.WriteLine();

            foreach (var doctor in doctors)
            {
                doctor.DisplayInfo();
            }
            Console.WriteLine();
            
            List<Patient_OCP_2207> patients = new List<Patient_OCP_2207>();

            Patient_OCP_2207.AddPatient(patients, "Sema", "Kaya", 44, "Kadın", "62345645260", "5351234757");
            Patient_OCP_2207.AddPatient(patients, "Osman", "Kaya", 47, "Erkek", "18307578950", "5745237567");
            Patient_OCP_2207.AddPatient(patients, "Ömer", "Şahin", 21, "Erkek", "72753669300", "5961854586");
            Patient_OCP_2207.AddPatient(patients, "Osman Can", "Ceylan", 22, "Erkek", "01345678900", "5451218567");
            Patient_OCP_2207.AddPatient(patients, "Mahmut", "Peker", 27, "Erkek", "12314475100", "5329876543");
            Patient_OCP_2207.AddPatient(patients, "Furkan Atakan", "Bozkurt", 27, "Erkek", "98714475100", "5149576753");
            Patient_OCP_2207.AddPatient(patients, "Selim", "Yaman", 27, "Erkek", "75711235100", "5855876375");
            Console.WriteLine();

            foreach (var patient in patients)
            {
                patient.DisplayInfo();
            }
            Console.WriteLine();

            Patient_OCP_2207.RemovePatient(patients, "12314475100");
            Patient_OCP_2207.RemovePatient(patients, "75711235100");
            Console.WriteLine();

            foreach (var patient in patients)
            {
                patient.DisplayInfo();
            }
            Console.WriteLine();

            List<Medication__OCP_2207> Medications = new List<Medication__OCP_2207>();

            Medication__OCP_2207.AddMedication(Medications, "Parol", "1", "Sabah akşam", 10.0, 50);
            Medication__OCP_2207.AddMedication(Medications, "Dolorex", "2", "Sabah ", 30.0, 40);
            Medication__OCP_2207.AddMedication(Medications, "DVitamini", "2", "Öğlen", 20.0, 20);
            Console.WriteLine();

            foreach (var medication in Medications)
            {
                medication.DisplayInfo();
            }

            Console.WriteLine();
            Medication__OCP_2207.RemoveMedication(Medications, "Parol");
            Console.WriteLine();

            foreach (var medication in Medications)
            {
                medication.DisplayInfo();
            }
            Console.WriteLine();


            Patient_OCP_2207 Patient = patients[0];
            List<string> medications = new List<string> { "Parol" };
            List<string> dosages = new List<string> { "1" };
            List<string> instructions = new List<string> { "Sabah akşam" };
            string prescriptionNumber = "RX123456";


            Patient_OCP_2207 Patient1 = patients[4];
            List<string> medications1 = new List<string> { "Dolorex" };
            List<string> dosages1 = new List<string> { "2" };
            List<string> instructions1 = new List<string> { "Öğlen" };
            string prescriptionNumber1 = "EX123456";


            List<Prescription_OCP_2207> prescriptions = new List<Prescription_OCP_2207>();
            Prescription_OCP_2207.CreatePrescription(prescriptions, Patient, medications, dosages, instructions, prescriptionNumber);
            Prescription_OCP_2207.CreatePrescription(prescriptions, Patient1, medications1, dosages1, instructions1, prescriptionNumber1);
            Console.WriteLine();

            foreach (var prescription in prescriptions)
            {
                prescription.DisplayInfo();
            }

            List<Clinic_OCP_2207> clinics = new List<Clinic_OCP_2207>();
            Clinic_OCP_2207.AddClinic(clinics, "Şehir", "Dahiliye", "Rüzgar Sokak No:1", "5551112233");
            Clinic_OCP_2207.AddClinic(clinics, "Merkez1", "Kardiyoloji", "Güneşevler Sokak No:9", "5252157232");
            Clinic_OCP_2207.AddClinic(clinics, "Merkez", "Dermatoloji", "Bayrak Sokak No:5", "5371012838");
            Clinic_OCP_2207.AddClinic(clinics, "Dışkapı", "Ortopedi", "Bayrak Sokak No:5", "5371012838");
            Clinic_OCP_2207.AddClinic(clinics, "Dışkapı", "Nefroloji", "Bayrak Sokak No:5", "5371012838");

            Console.WriteLine();

            foreach (var clinic in clinics)
            {
                clinic.DisplayInfo();
            }
            Console.WriteLine();
            Clinic_OCP_2207.RemoveClinic(clinics, "Merkez1");
            Console.WriteLine();

            foreach (var clinic in clinics)
            {
                clinic.DisplayInfo();
            }
            Console.WriteLine();


            Patient_OCP_2207 P = patients[3];
            Doctor_OCP_2207 Doctor = doctors[2];
            Clinic_OCP_2207 Clinic = clinics[2];
            DateTime dateTime = new DateTime(2024, 4, 10, 14, 0, 0);
            string time = "10:00";
            string appointmentNumber = "AP123456";

            Patient_OCP_2207 P1 = patients[1];
            Doctor_OCP_2207 Doctor1 = doctors[1];
            Clinic_OCP_2207 Clinic1 = clinics[3];
            DateTime dateTime1 = new DateTime(2024, 5, 12);
            string time1 = "15:00";
            string appointmentNumber1 = "AP234567";

            Patient_OCP_2207 P2 = patients[4];
            Doctor_OCP_2207 Doctor2 = doctors[3];
            Clinic_OCP_2207 Clinic2 = clinics[3];
            DateTime dateTime2 = new DateTime(2024, 8, 22);
            string time2 = "12:00";
            string appointmentNumber2 = "PA234567";

            Patient_OCP_2207 P3 = patients[2];
            Doctor_OCP_2207 Doctor3 = doctors[4];
            Clinic_OCP_2207 Clinic3 = clinics[3];
            DateTime dateTime3 = new DateTime(2024, 6, 10);
            string time3 = "11:00";
            string appointmentNumber3 = "CP234567";


            List<Appointment_OCP_2207> appointments = new List<Appointment_OCP_2207>();
            Appointment_OCP_2207.CreateAppointment(appointments, P, Doctor, Clinic, dateTime, time, appointmentNumber);
            Appointment_OCP_2207.CreateAppointment(appointments, P1, Doctor1, Clinic1, dateTime1, time1, appointmentNumber1);
            Appointment_OCP_2207.CreateAppointment(appointments, P2, Doctor2, Clinic2, dateTime2, time2, appointmentNumber2);
            Appointment_OCP_2207.CreateAppointment(appointments, P3, Doctor3, Clinic3, dateTime3, time3, appointmentNumber3);
            Console.WriteLine();

            foreach (var appointment in appointments)
            {
                appointment.DisplayInfo();
            }

            Console.WriteLine();
            Appointment_OCP_2207.CancelAppointment(appointments, "AP234567");
            Appointment_OCP_2207.CancelAppointment(appointments, "A5234567");
            Console.WriteLine();

            foreach (var appointment in appointments)
            {
                appointment.DisplayInfo();
            }
            List<Patient_Examination_OCP_2207> examinations = new List<Patient_Examination_OCP_2207>();

            List<string> findings = new List<string> { "Ateş", "Öksürük" };
            List<string> diagnoses = new List<string> { "Grip", "Üst Solunum Yolu Enfeksiyonu" };

            Patient_OCP_2207 patientt = patients[0];
            Doctor_OCP_2207 doctorr = doctors[0];
            DateTime examinationDate = DateTime.Now;
            string firstFinding = findings[0];
            string firstDiagno = diagnoses[0];
            Patient_Examination_OCP_2207 examination = new Patient_Examination_OCP_2207(patientt, doctorr, examinationDate, firstFinding, firstDiagno);
            examinations.Add(examination);

            Patient_OCP_2207 patientt1 = patients[2];
            Doctor_OCP_2207 doctorr1 = doctors[1];
            DateTime examinationDate1 = DateTime.Now;
            string secondFinding = findings[1];
            string secondDiagno = diagnoses[1];
            Patient_Examination_OCP_2207 examination1 = new Patient_Examination_OCP_2207(patientt1, doctorr1, examinationDate1, secondFinding, secondDiagno);
            examinations.Add(examination1);
            Console.WriteLine();

            Console.WriteLine("Muayene Bilgileri:");
            foreach (var exam in examinations)
            {
                exam.DisplayInfo();
            }
            Console.WriteLine();

            Patient_Examination_OCP_2207.CancelExamination(examinations, patientt1);
            Console.WriteLine();

            Doctor_OCP_2207 newDoctor = new Doctor_OCP_2207("Dr. Mehmet", "Yılmaz", "Cerrahi", "CM54321", "5551234567");
            Patient_Examination_OCP_2207.ReferPatient(examinations, patientt, newDoctor);
            Console.WriteLine();
            Console.WriteLine("Uygulama Başarılıyla Çalıştı");

        }
    }
}
