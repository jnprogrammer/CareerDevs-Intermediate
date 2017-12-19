using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Intermediate_Exercies
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating(excludeOrders: true);
            if (rating == 0)
            {
                Console.WriteLine("Promote to Lv1");
            }
            else
            {
                Console.WriteLine("Promote to Lv2");
            }
        }

        public int CalculateRating(bool excludeOrders)
        {
            return 0;
        }
    }

    public class GoldCustomer : Customer
    {
        public void OfferVouchar()
        {
            this.Promote
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();

        }
    }
}
