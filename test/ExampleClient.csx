using Grpc.Net.Client;
using g8kpr.proto;
using System;   
using System.Threading.Tasks;

namespace g8kpr.test
{  
    class ExampleClient
    {
        public static async Task Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5190");
            var client = new TrackManager.TrackManagerClient(channel);

            var request = new TrackInfoRequest { TrackName = "exampleTrack" };

            var response = await client.GetTrackInfoAsync(request);

            Console.WriteLine($"Track Duration: {response.Duration}");
            Console.WriteLine($"Track BPM: {response.Bpm}");
            Console.WriteLine("Dance Sequence:");
            foreach (var beat in response.Dance)
            {
                Console.WriteLine(beat);
            }
        }
    }
}
