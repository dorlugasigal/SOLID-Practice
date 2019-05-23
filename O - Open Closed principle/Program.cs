using OCPLibrary;
using System;
using System.Collections.Generic;

namespace O___Open_Closed_principle
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IApplicantModel> applicants = new List<IApplicantModel>
            {
                new PersonModel {FirstName = "Tim", LastName = "Corey"},
                new ManagerModel {FirstName = "Dor", LastName = "Lugasi" },
                new ExecutiveModel {FirstName = "Polina", LastName = "Bogatikov"},
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();

            foreach (var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person));
            }
            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.EmailAddress} IsManager: {emp.IsManager}, IsExecutive: {emp.IsExecutive}");
            }

            Console.ReadLine();
        }
    }
}
