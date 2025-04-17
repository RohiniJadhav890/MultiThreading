using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace MultiThreading
{
    public class BookMyShow {
        int availabletickets = 8;
        public void BookTicket(int wticket,string tname)
        {
            // lock (this)
            Monitor.Enter(this);
            {
                if (wticket < availabletickets)
                {
                    Console.WriteLine("Tickets are available");
                    Console.WriteLine(wticket + " Tickets booked by " + tname);
                    availabletickets -= wticket;

                }
                else {
                    Console.WriteLine("Tickets are not available for "+ tname);
                }
            }
            Monitor.Exit(this);
        }
        public void Booking()
        {
            string name = Thread.CurrentThread.Name;
            if (name.Equals("Thread1"))
            {
                BookTicket(3,name);
            }
            else if (name.Equals("Thread2"))
            {
                BookTicket(3, name);
            }
            else if (name.Equals("Thread3"))
            {
                BookTicket(4, name);
            }
        }
    }
    internal class Syncronation
    {
        public  void Method1()
        {
            lock (this)
            {
                // lock(this)
                Console.WriteLine("[ Welcome to TQ");
                Thread.Sleep(1000);
                Console.WriteLine("Let learn c# ]");
            }
        }
    }
}