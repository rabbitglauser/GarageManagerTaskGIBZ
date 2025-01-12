namespace GarageManager.Models
{
    public class BodyTechnician : Employee
    {
        public override void DoWork()
        {
            Repair();
        }

        public void Repair()
        {
            Console.WriteLine("Performing body repair...");
        }
    }
}