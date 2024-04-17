namespace Assignment4;


public class Passenger
{
    public string FirstName { get; set; }

    public string LastName { get; set; }
    
    public string SeatPref { get; set; }

    public string Initials { get; set; } 

    
 public string Name { get; set; }
    

    public List<Seat> Seats { get; set; }

    public List<Row> Rows { get; set; }

    

    

  public void passengerInfo()
    {
        System.Console.WriteLine("Please enter your first name.");
        FirstName = Console.ReadLine();
        
        System.Console.WriteLine("Please enter your last name.");
        LastName = Console.ReadLine();

        

       
        
        

        

      

        System.Console.WriteLine("Pleast enter your Seat Preference(Window Seat or Aisle): ");
        System.Console.WriteLine("Enter 1 for Window seat.");
        System.Console.WriteLine("Enter 2 for Aisle seat.");
        System.Console.WriteLine(" Or, Just hit enter for the first Available seat.");

         SeatPref = Console.ReadLine();

         
        Seat seat = new Seat();
        
         
        
        switch(SeatPref)
        {
            case "1":
              //  System.Console.WriteLine("For now press something else other than 1 or 2.");
              foreach(var row in Rows)
              {
                foreach(var seatLabel in row.Seats)
                {
                    if((seatLabel.Slabel == Slabel.A || seatLabel.Slabel == Slabel.D) && !seatLabel.IsBooked)
                    {
                        seatLabel.IsBooked = true;
                        seatLabel.Initials = FirstName[0]+""+LastName[0];
                        System.Console.WriteLine($"{row.Id}{seatLabel.Slabel} is Booked, it is a window seat.");

                       
                        return;
                    }
                }
              }
                System.Console.WriteLine("Sorry, all windows seats are currently booked. Please book an aisle seat.");
                break;

            case "2":
                foreach(var row in Rows)
                {
                    foreach(var seatLabel in row.Seats)
                    {
                        if((seatLabel.Slabel == Slabel.B || seatLabel.Slabel == Slabel.C) && !seatLabel.IsBooked)
                        {
                            seatLabel.IsBooked = true;
                            seatLabel.Initials = FirstName[0]+""+LastName[0];
                            System.Console.WriteLine($"{row.Id}{seatLabel.Slabel} is Booked, it is an aisle seat.");
                            return;
                        }
                    }
                }
                System.Console.WriteLine("Sorry, all aisle seats are currently booked. Please book a window seat.");
                break;
            
            default:
            foreach(var row in Rows)
            {
                foreach(var seatLabel in row.Seats)
                {
                    if(!seatLabel.IsBooked)
                    {
                        seatLabel.IsBooked = true;
                        seatLabel.Initials = FirstName[0]+""+LastName[0];
                        System.Console.WriteLine($"{row.Id}{seatLabel.Slabel} is Booked.");
                        return;
                    }
                }
            } 
            System.Console.WriteLine("No seats are availbel, its a fully booked.");  
            break;
        }

        

        
    }

            

   

    

   
    
}
