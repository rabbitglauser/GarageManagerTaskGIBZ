namespace GarageManager.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Description { get; set; }
        public Employee AssignedEmp { get; set; }

        public void AddTask()
{
    Console.WriteLine("Task added successfully.");
}
    }
}