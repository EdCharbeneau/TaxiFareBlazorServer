using TaxiFarePrediction.DataStructures;

namespace TaxiFarePrediction.Service
{
    public interface ITaxiFarePredictionService
    {
        string ModelPath { get; }

        TaxiTripFarePrediction PredictFare(TaxiTrip taxiTrip);
    }
}