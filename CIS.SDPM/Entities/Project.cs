using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS.SDPM.Entities
{
    class Project
    {
        public int id { get; set; }
        public string projectTitle { get; set; }
        public DateTime createdOn { get; set; }
        public string createdBy { get; set; } //FirstName + LastName
    }
}
