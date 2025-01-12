using GarageManager.Models;
using System.Collections.Generic;

namespace GarageManager.Services
{
    public class Workshop
    {
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public List<Order> Orders { get; set; } = new List<Order>();
        public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();

        public Workshop()
{
    Employees = new List<Employee>
    {
        new TireSpecialist { Name = "John", Role = "Tire Specialist" },
        new BodyTechnician { Name = "Jane", Role = "Body Technician" }
    };

    Vehicles = new List<Vehicle>
    {
        new Car(),
        new HeavyCommercialVehicle()
    };

    Orders = new List<Order>
    {
        new Order { OrderId = 1, Description = "Replace tires", AssignedEmp = Employees[0] }
    };
}
    }
}