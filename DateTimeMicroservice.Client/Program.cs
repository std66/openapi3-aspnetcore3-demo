using DateTimeMicroservice.Client.OpenApiGenerated.Api;
using DateTimeMicroservice.Client.OpenApiGenerated.Client;
using DateTimeMicroservice.Client.OpenApiGenerated.Model;
using System;
using System.Threading.Tasks;

namespace DateTimeMicroservice.Client {
    class Program {
        static async Task Main(string[] args) {
            const string serverUrl = "http://localhost:5000";

            IDateTimeApi api = new DateTimeApi(serverUrl);

            try {
                DateTimeObject response = await api.GetUtcDateTimeAsync();
                Console.WriteLine($"Server date-time: {response.DateTime}");
            }
            catch (ApiException ex) {
                Console.Error.WriteLine($"Unexpected error occurred: {ex.Message}");
            }
        }
    }
}
