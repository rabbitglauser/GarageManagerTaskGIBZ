using GarageManager.Models;
using GarageManager.Services;

namespace GarageManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var workshop = new Workshop();

            // Adding employees
            workshop.Employees.Add(new TireSpecialist { Name = "John", Role = "Tire Specialist" });
            workshop.Employees.Add(new BodyTechnician { Name = "Jane", Role = "Body Technician" });

            // Adding vehicles
            workshop.Vehicles.Add(new Car());
            workshop.Vehicles.Add(new HeavyCommercialVehicle());

            // Adding orders
            workshop.Orders.Add(new Order { OrderId = 1, Description = "Replace tires", AssignedEmp = workshop.Employees[0] });

            // Simulate work
            foreach (var employee in workshop.Employees)
            {
                employee.DoWork();
            }
        }
    }
}