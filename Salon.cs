namespace BeautySalonOOP
{

    // Klasa e sallonit qe mban sherbimet dhe rezervimet
    public class Salon
    {
        private IService haircut = new Service("Haircut", 30.00m);
        private IService makeup = new Service("Makeup", 50.00m);
        private IService skincare = new Service("Skincare", 40.00m);
        private IService manicure = new Service("Manicure", 20.00m);

        private Reservation reservation1;
        private Reservation reservation2;
        private Reservation reservation3;
        private Reservation reservation4;
        private Reservation reservation5;

        // Metoda per mi marr sherbimet ne baze te emrit 
        private IService GetServiceByName(string serviceName)
        {
            if (serviceName == haircut.Name) return haircut;
            if (serviceName == makeup.Name) return makeup;
            if (serviceName == skincare.Name) return skincare;
            if (serviceName == manicure.Name) return manicure;
            return null;
        }

        // Metoda per me kontrollu a ka vend per rezervime dhe a ekzistojne ato sherbime 
        public void BookReservation(string customerName, string serviceName, DateTime date)
        {
            IService selectedService = GetServiceByName(serviceName);

            if (selectedService == null)
            {
                Console.WriteLine("Service not found. Please choose Haircut, Makeup, Skincare or Manicure.");
                return;
            }

            //  Rezervimet
            if (reservation1 == null)
                reservation1 = new Reservation(customerName, selectedService, date);
            else if (reservation2 == null)
                reservation2 = new Reservation(customerName, selectedService, date);
            else if (reservation3 == null)
                reservation3 = new Reservation(customerName, selectedService, date);
            else if (reservation4 == null)
                reservation4 = new Reservation(customerName, selectedService, date);
            else if (reservation5 == null)
                reservation5 = new Reservation(customerName, selectedService, date);
            else
            {
                Console.WriteLine("No available slots for reservations.");
                return;
            }

            Console.WriteLine($"Reservation confirmed for {customerName} - {selectedService.Name} on {date:yyyy-MM-dd}.");
        }

        // Mi shfaqe te gjitha rezervimet
        public void ShowReservations()
        {
            Console.WriteLine("\n--- Current Reservations ---");
            if (reservation1 != null) reservation1.DisplayReservation();
            if (reservation2 != null) reservation2.DisplayReservation();
            if (reservation3 != null) reservation3.DisplayReservation();
            if (reservation4 != null) reservation4.DisplayReservation();
            if (reservation5 != null) reservation5.DisplayReservation();

            if (reservation1 == null && reservation2 == null && reservation3 == null && reservation4 == null && reservation5 == null)
                Console.WriteLine("No reservations available.");
        }
    }
}
