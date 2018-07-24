using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS.SDPM.Entities
{
    class Project
    {
        public int projectId { get; set; }
        public string projectTitle { get; set; }
        public int sprintId { get; set; }
        public string sprintTitle { get; set; }
        public int cardId { get; set; }
        public string cardCode { get; set; }
        public DateTime createdOn { get; set; }
        public string createdBy { get; set; } //FirstName + LastName
    }
}
