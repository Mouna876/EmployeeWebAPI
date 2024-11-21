using EmployeeWebAPI.Models;

namespace EmployeeWebAPI.Repositories
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetDepartments();
        Department GetDepartments(int departmentId);
    }
}
