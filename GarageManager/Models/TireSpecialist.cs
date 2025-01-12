namespace GarageManager.Models
{
    public class TireSpecialist : Employee
    {
        public override void DoWork()
        {
            MountTires();
        }

        public void MountTires()
{
    Console.WriteLine("Tires have been mounted successfully.");
}
    }
}