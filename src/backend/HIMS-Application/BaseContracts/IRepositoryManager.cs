using HIMS_Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIMS_Application.BaseContracts
{
    public interface IRepositoryManager
    {
        IPatientRepository Patient { get; }
        IDepartmentRepository Department { get; }
        IAppointmentRepository Appointment { get; }
        IEmployeeRepository Employee { get; }
        Task SaveAsync();
    }
}
