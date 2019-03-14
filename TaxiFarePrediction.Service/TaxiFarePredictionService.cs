using Microsoft.ML;
using System.IO;
using TaxiFarePrediction.DataStructures;

namespace TaxiFarePrediction.Service
{
    public class TaxiFarePredictionService : ITaxiFarePredictionService
    {
        public string ModelPath { get; }
        public TaxiFarePredictionService(string modelPath) => ModelPath = modelPath;

        public TaxiTripFarePrediction PredictFare(TaxiTrip taxiTrip)
        {
            MLContext mlContext = new MLContext(seed: 0);

            ITransformer trainedModel;

            using (var stream = new FileStream(ModelPath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                trainedModel = mlContext.Model.Load(stream);
            }

            // Create prediction engine related to the loaded trained model
            var predEngine = trainedModel.CreatePredictionEngine<TaxiTrip, TaxiTripFarePrediction>(mlContext);

            //Score
            return predEngine.Predict(taxiTrip);
        }
    }
}
