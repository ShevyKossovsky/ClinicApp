using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace Solid.Core.Entities
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateBorn { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool Status { get; set; }
        public int AppointmentId { get; set; }
        public Appointment Appointment { get; set; }

       



    }
}
