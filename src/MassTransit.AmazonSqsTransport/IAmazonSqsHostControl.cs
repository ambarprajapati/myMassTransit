namespace MassTransit.AmazonSqsTransport
{
    using System.Threading.Tasks;
    using Transports;

    //AMBAR Git TEST 10/30/2019
    public interface IAmazonSqsHostControl :
        IBusHostControl,
        IAmazonSqsHost
    {
        Task<ISendTransport> CreateSendTransport(AmazonSqsEndpointAddress address);

        Task<ISendTransport> CreatePublishTransport<T>()
            where T : class;
    }
}
