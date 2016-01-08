using HomeServices.Models;
using System;
using System.Linq;

namespace HomeServices.AppServices
{
    public class JobAssigner
    {
        private HomeServicesEntities db = new HomeServicesEntities();

        public void AssignJob(int orderId)
        {
            
            var order = db.GetOrderById(orderId).FirstOrDefault();
            var employee = GetMinimumJobsEmployee(order.ServiceId);

            db.EmployeePlanifications.Add(new EmployeePlanification()
            {
                EmployeeId = employee.Id,
                OrderId = order.Id,
                NumberOfHours = Convert.ToInt32((order.EndDateTime - order.BeginDateTime).TotalHours)
            });

            db.SaveChanges();
        }

        private Employee GetMinimumJobsEmployee(int serviceId)
        {
            var employees = db.GetServiceEmployees(serviceId).ToList();

            int count = employees.First().EmployeePlanifications.Count;
            Employee e = employees.First();

            foreach(var employee in employees)
            
                if (employee.EmployeePlanifications.Count < count)
                {
                    count = employee.EmployeePlanifications.Count;
                    e = employee;
                }

            return e;
        }
    }
}