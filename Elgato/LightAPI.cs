using System.IO;
using System.Net.Http;
using System.Text;

namespace Elgato
{
    public class LightApi
    {

        // Red - Hue: 0, Saturation: 100, Brightness: 100
        // Green - Hue: 107, Saturation: 100, Brightness: 100

        private readonly string _endpointUrl;
        private readonly HttpClient _httpClient = new();

        public LightApi(string hostName, int portNumber)
        {
            _endpointUrl = $"http://{hostName}:{portNumber}/elgato/lights";
        }

        private string SendRequest(string requestJSON)
        {
            var requestContent = new StringContent(requestJSON, Encoding.UTF8, "application/json");

            var webRequest = new HttpRequestMessage(HttpMethod.Put, _endpointUrl)
            {
                Content = new StringContent(requestJSON, Encoding.UTF8, "application/json")
            };

            var response = _httpClient.Send(webRequest);
            using var reader = new StreamReader(response.Content.ReadAsStream());
            return reader.ReadToEnd();
        }

        public string SendLightStatusOnOff(bool lightOn)
        {
            var onValue = lightOn ? "1" : "0";
            var requestJSON =
                $"{{\"numberOfLights\":1,\"lights\":[{{\"on\":{onValue},\"hue\":0,\"saturation\":100,\"brightness\":100}}]}}";

            return SendRequest(requestJSON);
        }

        public string SendLightStatusColor(bool lightOn, int hue, int saturation, int brightness)
        {
            var onValue = lightOn ? "1" : "0";
            var requestJSON =
                $"{{\"numberOfLights\":1,\"lights\":[{{\"on\":{onValue},\"hue\":{hue.ToString()},\"saturation\":{saturation.ToString()},\"brightness\":{brightness.ToString()}}}]}}";

            return SendRequest(requestJSON);
        }
    }
}