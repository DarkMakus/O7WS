namespace Angkor.O7Common.Domain
{
    public class DomainManager
    {
        private static DomainManager _manager;

        private DomainManager ( )
        {
        }

        public static DomainManager Instance => _manager ?? (_manager = new DomainManager());

        public SecurityDomain SecurityDomain => new SecurityDomain();
    }
}