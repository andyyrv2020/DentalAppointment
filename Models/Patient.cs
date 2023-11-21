using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DentalAppointment.Models
{
    public class Patient
    {
        [Key]
        [Required(ErrorMessage = "The Id field is required.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        [StringLength(50, ErrorMessage = "First Name must not exceed 50 characters.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        [StringLength(50, ErrorMessage = "Last Name must not exceed 50 characters.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Age is required.")]
        [Range(1, 150, ErrorMessage = "Please enter a valid Age.")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Date of Birth is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        // Remove the virtual keyword to break the cycle
        public ICollection<Appointment> Appointments { get; set; }

        [Required(ErrorMessage = "Primary Dentist is required.")]
        [Display(Name = "Primary Dentist")]
        public int PrimaryDentistId { get; set; }

        public virtual Dentist PrimaryDentist { get; set; }
    }
}
