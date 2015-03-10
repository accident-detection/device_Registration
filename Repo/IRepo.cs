using System;
using System.Collections.Generic;
using Devices;

namespace Repo
{
    public interface IRepo
    {
        void Save(Device device);
        List<Device> Find();
        List<Device> Find(string deviceName);
    }
}
