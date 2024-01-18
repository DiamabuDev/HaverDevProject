//Catalin Spirleanu
//Revised January 18, 2024

using System.ComponentModel.DataAnnotations;

namespace HaverDevProject.Models
{
    public class Ncr
    {
        public int ID { get; set; }

        public string Number { get; set; }

        public bool Status { get; set; }

        public DateTime? LastModified { get; set; }

        public string? QualityDepartment { get; set; }

    }
}
