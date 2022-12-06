using Grpc.Core;
using static GrpcServer.Second;

namespace GrpcServer.Services
{
    public class TwoService : SecondBase
    {

        public TwoService()
        {

        }

        public override Task<Out> TestMethod(Entry request, ServerCallContext context)
        {
            return Task.Run(() => { return new Out() { Message = "TestMessage" };});
        }
    }
}
