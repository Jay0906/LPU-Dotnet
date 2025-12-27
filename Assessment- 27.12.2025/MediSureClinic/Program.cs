using System;
using MediSureClinic;

public class Program
{
    static PatientBill LastBill;
    static bool hasLastBill=false;

    public static void Main()
    {
        bool Next=true;

        while (Next == true)
        {
            Console.WriteLine("1. Create New Bill (Enter Patient Details)");
            Console.WriteLine("2. View Last Bill");
            Console.WriteLine("3. Clear Last Bill");
            Console.WriteLine("4. Exit");

            Console.Write("Enter you option: ");
            int op=Int32.Parse(Console.ReadLine()!);

            if (op == 4)
            {
                Next=false;
            }
            else if (op == 3)
            {
                LastBill=null;
                hasLastBill=false;
                Console.WriteLine("Bill Cleared Successfully");
            }
            else if (op == 2)
            {
                if(hasLastBill)
                {
                Console.WriteLine(" ");
                Console.WriteLine("--------------------------------------------------------------\n");

                Console.WriteLine("Bill ID: "+LastBill.BillID);

                Console.WriteLine("Enter Patient Name: "+LastBill.PatientName);
                
                Console.WriteLine("Insured: "+(LastBill.HasInsurance ? "Yes" : "No"));

                Console.WriteLine("Consultation Fee: "+LastBill.ConsultationFee);

                Console.WriteLine("Lab Charges: "+LastBill.LabCharges);

                Console.WriteLine("Medicine Charges: "+LastBill.MedicineCharges);

                Console.WriteLine($"Gross Amount: {LastBill.GrossAmount():F2}");

                Console.WriteLine($"Discount Amount: {LastBill.DiscountAmount():F2}");

                Console.WriteLine($"Final Payable: {LastBill.FinalPayable():F2}");

                Console.WriteLine("--------------------------------------------------------------\n");
                Console.WriteLine(" ");
                }
                else
                {
                    Console.WriteLine("No Last Bill");
                }

            }
            else if (op == 1)
            {
                PatientBill patientBill=new PatientBill();

                Console.Write("Enter Bill ID: ");
                patientBill.BillID=Console.ReadLine()!;

                Console.Write("Enter Patient Name: ");
                patientBill.PatientName=Console.ReadLine()!;

                Console.Write("Is the Patient insured? (Y/N): ");
                string ans=Console.ReadLine()!;
                if(ans=="Y") patientBill.HasInsurance=true;
                else patientBill.HasInsurance=false;

                Console.Write("Enter Consultation Fee: ");
                patientBill.ConsultationFee=double.Parse(Console.ReadLine()!);

                Console.Write("Enter Lab Charges: ");
                patientBill.LabCharges=double.Parse(Console.ReadLine()!);

                Console.Write("Enter Medicine Charges: ");
                patientBill.MedicineCharges=double.Parse(Console.ReadLine()!);

                LastBill=patientBill;
                hasLastBill=true;

                Console.WriteLine("Bill created successfully.");

                Console.WriteLine($"Gross Amount: {patientBill.GrossAmount():F2}");

                Console.WriteLine($"Discount Amount: {patientBill.DiscountAmount():F2}");

                Console.WriteLine($"Final Payable: {patientBill.FinalPayable():F2}");

                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine(" ");
            }
        } 

        Console.WriteLine("Thank you. Application closed normally.");
    }
}
