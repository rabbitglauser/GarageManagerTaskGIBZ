using GarageManager.Interfaces;

namespace GarageManager.Models
{
    public abstract class Employee : IWorkable
    {
        public string Name { get; set; }
        public string Role { get; set; }

        public abstract void DoWork();
    }
}