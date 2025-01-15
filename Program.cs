using System;

namespace BeautySalonOOP
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Salon salon = new Salon();

            Console.WriteLine("\n--- Beauty Salon Reservation System ---");

            
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"\nReservation {i + 1}:");

               
                Console.Write("Enter customer name: ");
                string customerName = Console.ReadLine();

               
                string serviceName = null;
                while (true)
                {
                    Console.Write("Enter service name (Haircut, Makeup, Skincare, Manicure): ");
                    serviceName = Console.ReadLine();

                    
                    if (serviceName == "Haircut" || serviceName == "Makeup" || serviceName == "Skincare" || serviceName == "Manicure")
                    {
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("Invalid service name. Please try again.");
                    }
                }

                
                DateTime reservationDate;
                while (true)
                {
                    Console.Write("Enter reservation date (yyyy-MM-dd): ");
                    string dateInput = Console.ReadLine();

                    
                    if (DateTime.TryParseExact(dateInput, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out reservationDate))
                    {
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("Invalid date format. Please try again.");
                    }
                }

                
                salon.BookReservation(customerName, serviceName, reservationDate);
            }

           
            Console.WriteLine("\nFinal Reservations:");
            salon.ShowReservations();
        }
    }
}
