namespace BeautySalonOOP
{
    public class Reservation
    {
        public string CustomerName { get; }
        public Service Service { get; }
        public DateTime Date { get; }

        public Reservation(string customerName, Service service, DateTime date)
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
