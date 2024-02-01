namespace LifeTime.Service
{
    public class TransientServices:ITransientServices
    {
        private readonly Guid id;
        public TransientServices()
        {
            id= Guid.NewGuid();
        }
        public string GetServiceName()
        {
            return id.ToString();

        }
    }
}
