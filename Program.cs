//Load sample data
using MlApp;

var sampleData = new Santimentmodel.ModelInput()
{
    Col0 = @"Crust is not good.",
};

//Load model and predict output
var result = Santimentmodel.Predict(sampleData);
var sentiment=result.PredictedLabel==1? "Positive " : " Negative";
Console.WriteLine($"Text{sampleData.Col0}\n Sentiment{sentiment}");