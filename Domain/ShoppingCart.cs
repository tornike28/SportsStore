using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Domain
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public DateTime OrderRegistrationDate { get; set; }
        public int UserId { get; set; }
        public IdentityUser User { get; set; }
    }
}
