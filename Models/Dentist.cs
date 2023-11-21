using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DentalAppointment.Models
{
    public class Dentist
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
    }
}
