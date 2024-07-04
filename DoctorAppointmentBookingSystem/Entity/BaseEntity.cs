namespace DoctorAppointmentBookingSystem.Entity
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string createdDate { get; set; }
        public string createdBy { get; set; }
        public DateTime createdOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
