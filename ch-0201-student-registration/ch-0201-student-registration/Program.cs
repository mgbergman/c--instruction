using System;

namespace ch_0201_student_registration
{
    class Program
    {
        private static object firstName;
        private static string lastName;
        

        static void Main(string[] args)
        {
            double yearBirth;
            Console.WriteLine("Student Registration Form");

            Console.Write("Enter first name:  ");
            firstName = (Console.ReadLine());
            Console.Write("Enter last name:  ");
            lastName = (Console.ReadLine());
            Console.Write("Enter year of birth  ");
            yearBirth = Double.Parse(Console.ReadLine());
            Console.Write("Welcome "+ firstName + " " + lastName);
            Console.Write("Your registration is complete. ");
            Console.Write("Your temporary password is: " + firstName + "*" + yearBirth);
        }
    }
}
