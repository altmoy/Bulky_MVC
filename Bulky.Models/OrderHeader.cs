using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.Models
{
    public class OrderHeader
    {
        public int Id { get; set; }
        public string ApplcationUserId { get; set; }
        [ForeignKey("ApplicationUserId")]
        [ValidateNever]
        public ApplicationUser ApplcationUser { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShippingDate { get; set; }
        public double OrderTotal { get; set; }
        public string? OrderStatus { get; set; }
        public string? PaymentStatus { get; set; }
        public String? TrackingNumber { get; set; }
        public string? Carrier { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateOnly PaymentDue { get; set; } //This is a feature of ASP.NET 8.0 and above.  Must use DateTime in 7 or below
        public string? SessionId { get; set; }
        public string? PaymentIntentId { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Name { get; set;}
        [Required]
        public string StreetAddress { get; set;}
        [Required]
        public string City { get; set;}
        [Required]
        public string State { get; set;}
        [Required]
        public string PostalCode { get; set;}


    }
}
