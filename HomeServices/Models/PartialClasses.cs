using System.ComponentModel.DataAnnotations;

namespace HomeServices.Models
{
    [MetadataType(typeof(EmployeeMetadata))]
    public partial class Employee
    {
        
    }

    [MetadataType(typeof(DepartmentMetadata))]
    public partial class Department
    {

    }
}