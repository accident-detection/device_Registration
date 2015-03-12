using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devices;
using System.Data;

namespace Repo.Implementations
{
    public class StaticRepo : IRepo
    {
        List<Device> list;
        public StaticRepo()
        {
            list = new List<Device>();
        }

        public void Save(Device device)
        {
            list.Add(device);
        }

        public Device Find(string deviceName)
        {
            throw new NotImplementedException();
        }

        public DataTable Find()
        {
            DataTable data = new DataTable();
            data.Columns.Add("Name");
            data.Columns.Add("API");
            data.Columns.Add("Active");

            foreach (var item in list)
            {
                data.Rows.Add(item.Name, item.API, item.Active);
            }

            return data;
        }
    }
}
