using System;
using System.Collections.Generic;
using System.Text;

namespace prjCovidVac
{
    class capture
    {
        public void getPatient_Details()
        {
            Info i = new Info();

            Console.Clear();
            //Used to loop the size of patients set in the array
            for(int x = 0; x < i.size(); x++)//Size of the amount of patients entered into the array
            {
                Console.WriteLine("Please enter the patient " + (x + 1) + "name :");
                String name = Console.ReadLine();

                Console.WriteLine("Please enter the patient's surname :");
                String surname = Console.ReadLine();

                Console.WriteLine("Please enter the patient's ID Number :");
                String id = Console.ReadLine();

                Console.WriteLine("Please enter the patient's Medical AID :");
                String medicalAID = Console.ReadLine();

                Console.WriteLine("Please enter the patient's blood type :");
                char bloodType = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Please enter the patient's allergies :");
                String allergies = Console.ReadLine();

                Console.WriteLine("Please enter the patient's Doctor name :");
                String referingDr = Console.ReadLine();

                Console.WriteLine("Is the patient Covid positive, enter (True/False) :");
                Boolean covidTest = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Please enter the patient's surname :");
                String vaccine = Console.ReadLine();

                i.addPerson(id, medicalAID, name, surname, referingDr, bloodType, allergies, covidTest, vaccine);
            }
        }
    }
}