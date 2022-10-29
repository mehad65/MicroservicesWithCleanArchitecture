using Ordering.Application.Models;
using Ordering.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Infrastructure.Persistence
{
    internal static class OrderSeed
    {
        public static Order[] Orders
        {
            get
            {
                return new Order[]
                {
                    new Order
                    {
                        Id = -1,
                        CreatedBy = "Mihadul",
                        CreatedDate = DateTime.Now,
                        LastModifiedBy = "DemoUser",
                        LastModifiedDate = DateTime.Now,
                        UserName = "swn",
                        FirstName = "Mihadul", 
                        LastName = "Islam", 
                        EmailAddress = "mehad65@gmail.com", 
                        AddressLine = "Mirpur, Dhaka", 
                        Country = "Bangladesh", 
                        CVV = "3245",
                        CardName = "MidlandBank",
                        CardNumber = "3435454565435",
                        Expiration = "44",
                        State = "Dhaka",
                        PaymentMethod = 4,
                        ZipCode = "4535",
                        TotalPrice = 400
                    }
                };
            }
        }
    }
}
