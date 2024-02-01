namespace LifeTime.Service
{
    public class SingletonServices:ISingletonServices
    {
        private readonly Guid id;
        public SingletonServices()
        {
            id = Guid.NewGuid();
        }
        public string GetServiceName()
        {
            return id.ToString();

        }
    }
}
