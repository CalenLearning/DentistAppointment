using DentistAppointment.Business.Domain;
using DentistAppointment.Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace DentistAppointment.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppointmentController : ControllerBase
    {
        private AppointmentService _appointmentService = new();


        [HttpGet(Name = "GetAppointment")]
        public Appointment Get()
        {
            return _appointmentService.Get();
        }
    }
}