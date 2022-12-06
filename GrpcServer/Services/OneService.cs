using Grpc.Core;
using System.Reflection.Metadata.Ecma335;
using static GrpcServer.One;

namespace GrpcServer.Services
{
    public class OneService : OneBase
    {
        public OneService()
        {

        }

        public override Task<HelloReply> DoSth(HelloRequest request, ServerCallContext context)
        {
            return Task.Run(() =>
            {
                return new HelloReply() { Message = "test" };
            });
        }

        public override Task<Output> SecondMethod(Input request, ServerCallContext context)
        {
            return Task.Run(() =>
            {
                return new Output() { Value = "1231231" };
            });
        }
    }
}
