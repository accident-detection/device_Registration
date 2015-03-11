using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Implementations
{
    class StaticRepo : IRepo
    {
        public void Save(Device device)
        {
            throw new NotImplementedException();
        }

        public List<Device> Find()
        {
            throw new NotImplementedException();
        }

        public List<Device> Find(string deviceName)
        {
            throw new NotImplementedException();
        }
    }
}
