namespace TaxiFarePrediction.DataStructures
{
    public class SingleTaxiTripSample
    {
        public static readonly TaxiTrip TestTrip = new TaxiTrip
        {
            VendorId = "VTS",
            RateCode = "1",
            PassengerCount = 1,
            //TripTime = 1140,
            TripDistance = 2.21f,
            PaymentType = "CRD",
            FareAmount = 0 // To predict. Actual/Observed = 9.97
        };
        //{
        //    VendorId = "VTS",
        //    RateCode = "1",
        //    PassengerCount = 1,
        //    //TripTime = 1140,
        //    TripDistance = 3.75f,
        //    PaymentType = "CRD",
        //    FareAmount = 0 // To predict. Actual/Observed = 15.5
        //};
    }
}