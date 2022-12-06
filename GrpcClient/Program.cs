using Grpc.Net.Client;
using GrpcClient;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.ReadKey();
        var channel = GrpcChannel.ForAddress("https://localhost:7089");
        var client = new One.OneClient(channel);
        var response = client.DoSth(new HelloRequest());
        Console.WriteLine(response.Message);


        Console.WriteLine(client.SecondMethod(new Input() { Value = "5" }));


        var client2 = new Second.SecondClient(channel);
        var response2 = client2.TestMethod(new Entry() { Name = "Value" });
        Console.WriteLine(response2);
    }
}