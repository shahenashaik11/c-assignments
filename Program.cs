using System;

namespace _09nov2018
{
    class Program
    {

        static void Main(string[] args)
        {

            string P_name1 = "Rekha", P_name2 = "Ramesh", P_name3 = "Kartik", P_name4 = "Vinay ", P_name5 = "Raj";
            int P_age1 = 22, P_age2 = 25, P_age3 = 27, P_age4 = 28, P_age5 = 30;
            int P_id1 = 1, P_id2 = 2, P_id3 = 3, P_id4 = 4, P_id5 = 5;
            string P_disease1 = "Cold       ", P_disease2 = "Cough      ", P_disease3 = "HeartAttack", P_disease4 = "Cold       ", P_disease5 = "SkinDisease";
           
            string d_name1 = "Amit   ", d_name2 = "Hitesh ", d_name3 = "Shubham";
            string d_specialization1 = "cardiologist ", d_specialization2 = "dermatologist", d_specialization3 = "Radiologist      ";
            string d_A1 = "A", d_A2 = "A", d_A3 = "A";
            int cost = 0;

            string doctor;
            Console.WriteLine("Welcome to sagar Hospital..");
            Console.WriteLine("Please Enter Your Choice");
            int choice;
            int choice2;
            int P_C_id;
            Console.WriteLine("Press 1 for Doctor");
            Console.WriteLine("Press 2 for Patients");
            choice = Convert.ToInt32(Console.ReadLine());


            if (choice == 1)
            {
                Console.Clear();
                
                Console.WriteLine("Welcome to doctors Database.");
                Console.WriteLine(" ");
                Console.WriteLine("Doctor's Name                    Doctor's specialization                             Availability");
                Console.WriteLine(d_name1 + "                           " + d_specialization1 + "                                          " + d_A1);
                Console.WriteLine(d_name2 + "                           " + d_specialization2 + "                                          " + d_A2);
                Console.WriteLine(d_name3 + "                           " + d_specialization3 + "                                          " + d_A3);
                Console.Read();
            }
            else if (choice == 2)
            {
                Console.Clear();
                Console.WriteLine("Please select a option below");
                Console.WriteLine("Select 1 for viewing the all patient");
                Console.WriteLine("select 2 for for entering new details");
                choice2 = Convert.ToInt32(Console.ReadLine());
                if (choice2 == 1)
                {
                    Console.WriteLine("What is your patient ID");
                    P_C_id = Convert.ToInt32(Console.ReadLine());
                    switch (P_C_id)
                    {

                        case 1:
                            Console.WriteLine("Patient's Name            Patient's Age               Patient's Problem              Patient's ID");
                            Console.WriteLine(" ");
                            Console.WriteLine(P_name1 + "                     " + P_age1 + "                             " + P_disease1 + "                        " + P_id1);
                            break;
                        case 2:
                            Console.WriteLine("Patient's Name            Patient's Age               Patient's Problem              Patient's ID");
                            Console.WriteLine(" ");
                            Console.WriteLine(P_name2 + "                     " + P_age2 + "                             " + P_disease2 + "                        " + P_id2);
                            break;
                        case 3:
                            Console.WriteLine("Patient's Name            Patient's Age               Patient's Problem              Patient's ID");
                            Console.WriteLine(" ");
                            Console.WriteLine(P_name3 + "                     " + P_age3 + "                             " + P_disease3 + "                        " + P_id3);
                            break;
                        case 4:
                            Console.WriteLine("Patient's Name            Patient's Age               Patient's Problem              Patient's ID");
                            Console.WriteLine(" ");
                            Console.WriteLine(P_name4 + "                     " + P_age4 + "                             " + P_disease4 + "                        " + P_id4);
                            break;
                        case 5:
                            Console.WriteLine("Patient's Name            Patient's Age               Patient's Problem              Patient's ID");
                            Console.WriteLine(" ");
                            Console.WriteLine(P_name5 + "                     " + P_age5 + "                             " + P_disease5 + "                        " + P_id5);

                            break;
                        
                        default:
                            Console.WriteLine("record not present");
                            break;

                    }





                }
         
                else if (choice2 == 2)
                {
                    Console.WriteLine("Enter the Patients Name");
                    string Patient_1 = Console.ReadLine();
                    Console.WriteLine("Enter patients age");
                    int P_Age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter date");
                    string date = Console.ReadLine();
                    Console.WriteLine("Enter Patients Problem");
                    string Problem = Console.ReadLine();
                    Console.WriteLine("Enter the Diagnosis Required");
                    Console.WriteLine("1. X ray");
                    Console.WriteLine("2. Blood Test");
                    Console.WriteLine("3. ECG");

                    int j = Convert.ToInt32(Console.ReadLine());
                    switch (j)
                    {
                        case 1:
                            cost = 1500;
                            doctor = d_name1;
                            break;
                        case 2:
                            cost = 1000;
                            doctor = d_name2;
                            break;
                        case 3:
                            cost = 1600;
                            doctor = d_name3;
                            break;
                    }
                    Console.Clear();
                    Console.WriteLine("                         SAGAR HOSPITAL");
                    Console.WriteLine("----------------------------------------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Patient Name:" + Patient_1);
                    Console.WriteLine("");
                    Console.WriteLine("Age:   " + P_Age);
                    Console.WriteLine("");
                    Console.WriteLine("Consultation Date:" + date);
                    Console.WriteLine("");
                    Console.WriteLine("Doctors Name:" + d_name1);
                    Console.WriteLine("");
                    Console.WriteLine("cost     " + cost);
                    Console.WriteLine("");


                    string Procedure = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Enter a valid option");
                }


                Console.Read();
            }
        }
    }
}
