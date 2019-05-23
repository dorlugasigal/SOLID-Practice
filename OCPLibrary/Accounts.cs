namespace O___Open_Closed_principle
{
    public class Accounts
    {
        public EmployeeModel Create(PersonModel person)
        {
            EmployeeModel output = new EmployeeModel();
            output.LastName = person.LastName;
            output.FirstName = person.FirstName;

            output.EmailAddress = $"{person.FirstName.Substring(0, 1)}{person.LastName}@gmail.com";
            
            return output;
        }
    }
}