using BudalaceanCiprianLab7.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BudalaceanCiprianLab7.Data
{
    public class AppDatabase
    {
        private List<Service> _services = new List<Service>();
        private List<Appointment> _appointments = new List<Appointment>();

        public Task<List<Service>> GetServicesAsync() => Task.FromResult(_services);

        public Task SaveServiceAsync(Service service)
        {
            if (!_services.Contains(service))
                service.ServiceId = _services.Count + 1;

            _services.Add(service);
            return Task.CompletedTask;
        }

        public Task<List<Appointment>> GetAppointmentsAsync() => Task.FromResult(_appointments);

        public Task SaveAppointmentAsync(Appointment appointment)
        {
            if (!_appointments.Contains(appointment))
                appointment.AppointmentId = _appointments.Count + 1;

            _appointments.Add(appointment);
            return Task.CompletedTask;
        }

        public Task DeleteAppointmentAsync(Appointment appointment)
        {
            _appointments.Remove(appointment);
            return Task.CompletedTask;
        }
    }
}
