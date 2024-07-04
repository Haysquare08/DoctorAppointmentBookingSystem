using DoctorAppointmentBookingSystem.Enum;

namespace DoctorAppointmentBookingSystem.Entity
{
    public class Doctor : BaseEntity
    {
        public string Name { get; set; } = default;
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string? Address { get; set; }
        public List<DoctorAvailability> Availability  = new HashSet<DoctorAvailability>();
    }
}
