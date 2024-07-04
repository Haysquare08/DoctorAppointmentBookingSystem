namespace DoctorAppointmentBookingSystem.Entity
{
    public class DoctorAvailability : BaseEntity
    {
        public Doctor Doctor { get; set; }
        public int DoctorId { get; set; }
        public DateTime DayOfTheWeek { get; set; }
        public DateTime StartTIme { get; set; }
        public DateTime EndTIme { get; set; }
    }
}

