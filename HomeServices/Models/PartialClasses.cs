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

    [MetadataType(typeof(ServiceMetadata))]
    public partial class Service
    {

    }

    [MetadataType(typeof(OrderMetadata))]
    public partial class Order
    {

    }
}