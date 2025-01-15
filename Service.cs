namespace BeautySalonOOP
{
    public interface IService
    {
        void DisplayService();
        string Name { get; set; }
        decimal Price { get; set; }
    }

    public class Service : IService
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Service(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public virtual void DisplayService()
        {
            Console.WriteLine($"{Name} - ${Price}");
        }
    }

    public class HaircutService : IService
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public HaircutService()
        {
            Name = "Haircut";
            Price = 30.00m;
        }

        public void DisplayService()
        {
            Console.WriteLine($"{Name} - ${Price} for a haircut.");
        }
    }

    public class SkincareService : IService
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public SkincareService()
        {
            Name = "Skincare";
            Price = 40.00m;
        }

        public void DisplayService()
        {
            Console.WriteLine($"{Name} - ${Price} for a skincare service.");
        }
    }
}
