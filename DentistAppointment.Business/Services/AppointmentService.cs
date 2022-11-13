using DentistAppointment.Business.Domain;

namespace DentistAppointment.Business.Services
{
    public class AppointmentService
    {
        private Random random = new();

        public Appointment Get()
        {
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
                    Date = DateTime.Now.AddDays(3),
                },
                new Appointment()
                {
                    Name = "Kees",
                    Date = DateTime.Now.AddDays(7),
                }
            };

            return appointments[r];
        }
    }
}
