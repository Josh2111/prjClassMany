using System;

namespace prjCovidVac
{
    class Program
    {
        static void Main(string[] args)
        {
            Info i = new Info();

            Console.Write("Please enter the hospital's name :");
            i.setHospital_Name(Console.ReadLine());

            Console.Write("Please enter the address :");
            i.setAddress(Console.ReadLine());

            Console.Write("Please enter if the hospital is Public or Private :");
            i.setHospitalType(Console.ReadLine());

            Console.Write("Please enter the hospital's province :");
            i.setProvince(Console.ReadLine());

            Console.Write("Please enter the hospital's province :");
            i.setArray(Convert.ToInt32(Console.ReadLine()));

            capture c = new capture();
            c.getPatient_Details();

            
        }
    }
}