using OCPLibrary;
using System;
using System.Collections.Generic;

namespace O___Open_Closed_principle
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> applicants = new List<PersonModel>
            {
                new PersonModel {FirstName = "Tim", LastName = "Corey"},
                new PersonModel {FirstName = "Dor", LastName = "Lugasi" ,TypeOfEmployee=EmployeeType.Manager},
                new PersonModel {FirstName = "Polina", LastName = "Bogatikov", TypeOfEmployee=EmployeeType.Executive},
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();
            Accounts accountProcessor = new Accounts();

            foreach (var person in applicants)
            {
                employees.Add(accountProcessor.Create(person));
            }
            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.EmailAddress} IsManager: {emp.IsManager}, IsExecutive: {emp.IsExecutive}");
            }

            Console.ReadLine();
        }
    }
}
