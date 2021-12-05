using System.ServiceModel;

namespace RestApi
{
    [ServiceContract]
    public interface IService : IDoc, ISearch, ICounteragent, IKiz
    {
        // Implement inner interfaces...
    }
}