namespace GarageManager.Models
{
    public class OfficeStaff : Employee
    {
        public override void DoWork()
        {
            ManageOrders();
        }

        public void ManageOrders()
        {
            Console.WriteLine("Managing orders...");
        }
    }
}