using System;
using System.Data;
using System.Data.Common;
using System.Globalization;
using System.Reflection.Emit;
using System.Collections.Generic;

namespace Assignment4;

public class Program
{
    public static void Main(string[] args)
    {
        Application();
       
    }
    



    public static void Application()
    {

        bool appStatus = true;  
        Passenger newObj = new Passenger
        {
            Rows = new List<Row>
            {
                new Row
                {
                   Id = "1", 
                   Seats = new List<Seat>
                   { 
                    
                     new Seat{Slabel = Slabel.A},
                     new Seat{Slabel = Slabel.B},
                     new Seat{Slabel = Slabel.C},
                     new Seat{Slabel = Slabel.D}
                   }
                },

                new Row
                {
                    Id = "2",
                    Seats = new List<Seat>
                    {
                     new Seat{Slabel = Slabel.A},
                     new Seat{Slabel = Slabel.B},
                     new Seat{Slabel = Slabel.C},
                     new Seat{Slabel = Slabel.D}
                    }
                },

                new Row
                {
                    Id = "3",
                    Seats = new List<Seat>
                    {
                     new Seat{Slabel = Slabel.A},
                     new Seat{Slabel = Slabel.B},
                     new Seat{Slabel = Slabel.C},
                     new Seat{Slabel = Slabel.D}
                    }
                   
                },

                new Row
                {
                    Id = "4",
                    Seats = new List<Seat>
                    {
                     new Seat{Slabel = Slabel.A},
                     new Seat{Slabel = Slabel.B},
                     new Seat{Slabel = Slabel.C},
                     new Seat{Slabel = Slabel.D}
                    }
                   
                },

                new Row
                {
                    Id = "5",
                    Seats = new List<Seat>
                    {
                     new Seat{Slabel = Slabel.A},
                     new Seat{Slabel = Slabel.B},
                     new Seat{Slabel = Slabel.C},
                     new Seat{Slabel = Slabel.D}
                    }
                   
                },

                new Row
                {
                    Id = "6",
                    Seats = new List<Seat>
                    {
                     new Seat{Slabel = Slabel.A},
                     new Seat{Slabel = Slabel.B},
                     new Seat{Slabel = Slabel.C},
                     new Seat{Slabel = Slabel.D}
                    }
                   
                },

                new Row
                {
                    Id = "7",
                    Seats = new List<Seat>
                    {
                     new Seat{Slabel = Slabel.A},
                     new Seat{Slabel = Slabel.B},
                     new Seat{Slabel = Slabel.C},
                     new Seat{Slabel = Slabel.D}
                    }
                   
                },

                new Row
                {
                    Id = "8",
                    Seats = new List<Seat>
                    {
                     new Seat{Slabel = Slabel.A},
                     new Seat{Slabel = Slabel.B},
                     new Seat{Slabel = Slabel.C},
                     new Seat{Slabel = Slabel.D}
                    }
                   
                },

                new Row
                {
                    Id ="9",
                    Seats = new List<Seat>
                    {
                     new Seat{Slabel = Slabel.A},
                     new Seat{Slabel = Slabel.B},
                     new Seat{Slabel = Slabel.C},
                     new Seat{Slabel = Slabel.D}
                    }
                   
                },

                new Row
                {
                    Id = "10",
                    Seats = new List<Seat>
                    {
                     new Seat{Slabel = Slabel.A},
                     new Seat{Slabel = Slabel.B},
                     new Seat{Slabel = Slabel.C},
                     new Seat{Slabel = Slabel.D}
                    }
                   
                },

                new Row
                {
                    Id = "11",
                    Seats = new List<Seat>
                    {
                     new Seat{Slabel = Slabel.A},
                     new Seat{Slabel = Slabel.B},
                     new Seat{Slabel = Slabel.C},
                     new Seat{Slabel = Slabel.D}
                    }
                   
                },

                new Row
                {
                    Id = "12",
                    Seats = new List<Seat>
                    {
                     new Seat{Slabel = Slabel.A},
                     new Seat{Slabel = Slabel.B},
                     new Seat{Slabel = Slabel.C},
                     new Seat{Slabel = Slabel.D}
                    }
                   
                },
                
            }
            
        };

       

      
        
// https://codebuns.com/csharp-basics/while-loop/#:~:text=editor%3A%20Code%20Playground-,Syntax,result%20of%20true%20or%20false.
        while(appStatus)      // This is how I run the app. 
        {
            System.Console.WriteLine("Welcome to Emirates Airlines. Please choose one of the following options.");
            System.Console.WriteLine("");
            System.Console.WriteLine("Please enter 1 to book a ticket.");
            System.Console.WriteLine("Please enter 2 to see the seating chart.");
            System.Console.WriteLine("Please enter 3 to exit the application.");

            string options = Console.ReadLine();              // the reason I didnt convert it to int is because if a user press an alphabet then the console crashes.

            switch(options)
            {
                case "1":
                    System.Console.WriteLine("You have chosen option 1.");
                    newObj.passengerInfo();
                  // row.checkSeatAvailability();
                    break;

                case "2":
                    System.Console.WriteLine("You have chosen option 2. View the Seating chart below");
           /*         foreach(var passenger in newObj.Rows)
                    {
                        if(passenger == null)
                        {
                            continue;
                        }
                        System.Console.WriteLine($"Row: {passenger.Id}");
                        foreach(var seatLabel in passenger.Seats)
                        {
                            if(seatLabel == null)
                            {
                                continue;
                            }
        // https://stackoverflow.com/questions/16106181/why-am-i-getting-system-collections-generic-list1system-string-instead-of-the
                   //        string arrangedSeat = string.Join(" ",seatLabel.Slabel);
                            System.Console.Write(seatLabel.Slabel + " ");
                        }
                        System.Console.WriteLine();
                      
                    } */
                    foreach(var passenger in newObj.Rows)
                    {
                        if(passenger == null)
                        {
                            continue;
                        }
                        System.Console.WriteLine($"Row: {passenger.Id}");
                        foreach(var seatLabel in passenger.Seats)
                        {   
                            if(!seatLabel.IsBooked)
                            {
                            System.Console.Write($"{seatLabel.Slabel}  ");
                            }
                            else
                            {
                                System.Console.Write($"{seatLabel.Initials} ");
                            }   
                        }
                        System.Console.WriteLine();
                    }
                   
                    break;

                case "3":
                    System.Console.WriteLine("You have chosen option 3.");
                    System.Console.WriteLine("Exiting the application. See you again next time.");
                    appStatus = false;           //Application closes if User press 3.
                    break;

                default:
                    System.Console.WriteLine("Error, Please choose from the following options.");
                    break;
            }
            
        }
    }

        
       
}




