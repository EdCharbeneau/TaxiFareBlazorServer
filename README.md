# Blazor ML Mashup

This project uses Razor Components with ML.NET to show how to implement ML.NET as a service.

# Taxi Fare Model

The Taxi Fares are predicted using a modified version of the sample code found on the ML.NET docs site.
https://docs.microsoft.com/en-us/dotnet/machine-learning/tutorials/taxi-fare

More details are in this repo's ML-README.md file.

## Building the Model

To build the model select and run the TaxiFarePrediction console application. You may need to modify the paths according to where the file are stored on your system. This seem to work without issue from Visual Studio, but the command line may need some tweaking of the `RootPath` setting in Program.cs.

Once the model is built the web application `TaxiFarePrediction.WebRc` can be set as the startup app and ran.

# TaxiFarePrediction.BlazorServer

This is a full stack C# web application using Blazor Server-Side. Currently, ML.NET is incompatible with WASM, so Blazor Client-Side is not an option.

When training a new Taxi Model, LibMan may be used to import the new trained model. This model is in the form of a ZIP file in the console application's `MLModels` folder. LibMan has a relative path reference to the file and will import it into the web application.

The model's loading path can be adjusted from `Startup.cs`

# TaxiFarePrediction.Service

The service project is where the trained model is executed and provides a prediction. This service is used in both the Console and Web applications to exercise the trained model (ZIP).

