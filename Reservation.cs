namespace BeautySalonOOP
{
    public class Reservation
    {
        public string CustomerName { get; }
        public IService Service { get; }
        public DateTime Date { get; }

        public Reservation(string customerName, IService service, DateTime date)
        {
            CustomerName = customerName;
            Service = service;
            Date = date;
        }

        public void DisplayReservation()
        {
            Console.WriteLine($"Customer: {CustomerName}, Service: {Service.Name}, Date: {Date:yyyy-MM-dd}");
        }
    }
}
