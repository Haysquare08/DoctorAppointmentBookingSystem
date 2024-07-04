using DoctorAppointmentBookingSystem.Enum;

namespace DoctorAppointmentBookingSystem.Entity
{
    public class Patient : BaseEntity
    {
        public int patientId { get; set; }
        public string Name { get; set; } = default;
        public string address { get; set; }
        public string medicalHistory { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }

    }
}
