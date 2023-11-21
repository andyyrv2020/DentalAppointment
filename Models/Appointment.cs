using System.ComponentModel.DataAnnotations;

namespace DentalAppointment.Models
{
    public class Appointment
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int DurationInMinutes { get; set; }

        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }

        public int DentistId { get; set; }
        public virtual Dentist Dentist { get; set; }

        public string Description { get; set; }
    }
}
