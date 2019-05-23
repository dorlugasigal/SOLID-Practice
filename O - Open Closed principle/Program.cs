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
                new PersonModel {FirstName = "Dor", LastName = "Lugasi"},
                new PersonModel {FirstName = "Polina", LastName = "Bogatikov"},
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();
            Accounts accountProcessor = new Accounts();

            foreach (var person in applicants)
            {
                employees.Add(accountProcessor.Create(person));
            }
            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.EmailAddress}");
            }

            Console.ReadLine();
        }
    }
}
