
namespace ShadowComputing.Catalog.ApplicationLayer.Wrappers
{
    public class ServiceResponse<T>
    {
        public ServiceResponse(T message)
        {
            Message = message;
        }

        public T Message { get; set; }
    }
}
