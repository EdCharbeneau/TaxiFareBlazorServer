using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TaxiFarePrediction.WebRc
{
    public class TaxiTripForm
    {
        [Required]
        [Range(0.01, 15)]
        public decimal TripDistance { get; set; }

        [Required]
        [Range(1, 4)]
        public int PassengerCount { get; set; }

        [Required]
        public string SelectedPaymentMethod { get; set; }

        [Required]
        public string SelectedVendor { get; set; }

        [Required]
        public string SelectedRateCode { get; set; }

        public int[] RateCodes => new int[] { 1, 2, 3, 4, 5, 6, 7 };

        public Dictionary<string, string> PaymentMethods =>
            new Dictionary<string, string>() {
                { "Cash", "CSH" },
                { "Credit", "CRD" }
            };

        public Dictionary<string, string> Vendors =>
            new Dictionary<string, string>() {
                { "Mello Cab", "CMT" },
                { "Uptown Limo", "VTS" }
            };

    }

}
