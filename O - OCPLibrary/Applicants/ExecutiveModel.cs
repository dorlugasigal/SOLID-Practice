using O___Open_Closed_principle;
using OCPLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O___Open_Closed_principle
{
    public class ExecutiveModel : IApplicantModel
    {
        public string FirstName { get ; set ; }
        public string LastName { get; set; }
        public IAccounts AccountProcessor { get; set; } = new ExecutiveAccounts();
    }
}
