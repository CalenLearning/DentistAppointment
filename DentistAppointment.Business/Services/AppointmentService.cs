using DentistAppointment.Business.Domain;

namespace DentistAppointment.Business.Services
{
    public class AppointmentService
    {
        public Appointment GetAppointment()
        {
            Random random = new();
            int r = random.Next(0, 3);

            List<Appointment> appointments = new()
            {
                new Appointment()
                {
                    Name = "Jan",
                    Date = DateTime.Now,
                },
                new Appointment()
                {
                    Name = "Anna",
                    Date = DateTime.Now.AddDays(3).AddHours(1),
                },
                new Appointment()
                {
                    Name = "Kees",
                    Date = DateTime.Now.AddDays(7).AddHours(2),
                }
            };

            Appointment a = appointments[r];

            return appointments[r];
        }
    }
}
