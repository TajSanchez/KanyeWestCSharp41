// Create a HTTPClient instance, this is what actually makes the api call

using Newtonsoft.Json.Linq;
for (int i = 1; i <= 5; i++)
{
    var client = new HttpClient();

    //Build an api URL from where the api call comes from
    var kanyeURL = "https://api.kanye.rest/";
    var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

    //Using the HTTPClient instance we created above
    //Send and GET request to the URL created above, this will give us back a string of JSON
    var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
    var ronResponse = client.GetStringAsync(ronURL).Result;

    //Parsing the JSON response we just got back into a JObject, we do this so we can access certain pieces of the JSON
    //In this case we will be getting the value of "quote" which will be the actual quote itself and not the whole JSON body
    //Without ToString() it will be of type JToken, so we could never use it as a string

    //var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
    //var kanyeQuote = JObject.Parse(kanyeResponse)["quote"].ToString();
    // var ronQuote = JObject.Parse(ronResponse).GetValue("quote").ToString();

    Console.WriteLine();
    Console.WriteLine("Kanye says:");
    Console.WriteLine(kanyeResponse);
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Ron says:");
    Console.WriteLine(ronResponse);
}

//using an api key
// Grab appsettings file
//var apiKeyObj = File.ReadAllText("appsettings.json");

//Get api key from the appsettings file using the name "apiKey"
//var apiKey = JObject.Parse(apiKeyObj).GetValue("apiKey").ToString();

//Build the api URL using theprovised params you chose along with the apiKey instead of your actual key
//Build an api url from where the call comes from
