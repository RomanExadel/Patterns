using System;
using System.Collections.Generic;

namespace Singleton
{
    class LoadBalancer
    {
        public static LoadBalancer _instance;
        private readonly List<string> _servers = new();
        private readonly Random _random = new();

        private static object syncLock = new();

        protected LoadBalancer()
        {
            _servers.Add("ServerI");
            _servers.Add("ServerII");
            _servers.Add("ServerIII");
            _servers.Add("ServerIV");
            _servers.Add("ServerV");
        }

        public static LoadBalancer GetLoadBalancer()
        {
            if (_instance != null) return _instance;

            lock (syncLock)
            {
                _instance ??= new LoadBalancer();
            }

            return _instance;
        }

        public string Server => _servers[_random.Next(_servers.Count)];
    }
}
