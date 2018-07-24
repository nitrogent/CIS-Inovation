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
        public string cardTitle { get; set; }
        public string createdBy { get; set; } //FirstName + LastName
        public DateTime createdOn { get; set; }
        public string updatedBy { get; set; }
        public DateTime updateOn { get; set; }
        public int rowStatus { get; set; }
    }
}
