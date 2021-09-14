using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sadaka.Models
{
    public class Donation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string PickUpAddress { get; set; }
        public int ItemId { get; set; }
        public int locationId { get; set; }
    }
}
