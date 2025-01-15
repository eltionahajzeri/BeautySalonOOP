namespace BeautySalonOOP
{
    public class Service
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

    public class HaircutService : Service
    {
        public HaircutService() : base("Haircut", 30.00m) { }
    }

    public class SkincareService : Service
    {
        public SkincareService() : base("Skincare", 40.00m) { }
    }

}
