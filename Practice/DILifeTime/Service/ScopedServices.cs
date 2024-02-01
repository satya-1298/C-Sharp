using System;

namespace LifeTime.Service
{
    public class ScopedServices:IScopedServices
    {
        private readonly Guid id;
        public ScopedServices()
        {
            id = Guid.NewGuid();
        }
        public string GetServiceName()
        {
            return id.ToString();

        }
    }
}
