using System;

namespace ConsoleApp6
{

    class Person
    {
        public string name;

    }
    class Doctor : Person
    {
        public string specialization;

    }
    class Patient : Person
    {
        public int age, fees;
        public Treatment[] t = new Treatment[3];

    }
    class Hospital
    {
        public Patient[] p = new Patient[3];
        public Doctor[] d = new Doctor[3];

    }
    class Treatment
    {
        public string diagnosis;
        public int diagnosiscode;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Hospital h = new Hospital();
            Patient[] p = new Patient[3];
            Doctor[] d = new Doctor[3];
            Treatment[] t = new Treatment[3];

        }
    }
}
