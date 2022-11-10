using DentistAppointment.Business.Domain;
using DentistAppointment.Business.Services;
using Xunit;

namespace DentistAppointment.Test
{
    public class AppointmentServiceTest
    {
        private AppointmentService _appointmentService = new();

        [Fact]
        public void Name_Shouldnt_BeNull()
        {
            Assert.NotNull(_appointmentService.Get().Name);
        }

        [Fact]
        public void Should_ReturnOneAppointment()
        {
            Assert.IsType<Appointment>(_appointmentService.Get());
        }
    }
}