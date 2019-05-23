using O___Open_Closed_principle;

namespace OCPLibrary
{
    public class ExecutiveAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();
            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{person.FirstName.Substring(0, 1)}{person.LastName}@gmailExecutive.com";

            output.IsManager = true;
            output.IsExecutive = true;
            return output;
        }
    }
}