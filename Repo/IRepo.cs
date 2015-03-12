using System;
using System.Collections.Generic;
using Devices;
using System.Data;

namespace Repo
{
    public interface IRepo
    {
        void Save(Device device);
        Device Find(string deviceName);
        DataTable Find();
        void Remove(string deviceName);
        void Update(string deviceName);
    }
}
