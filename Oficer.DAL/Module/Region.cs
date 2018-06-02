using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Officer.DAL.Module
{
    [Serializable]
    public class Region
    {
        public int IdRegion { get; set; }
        public List<Department> Departments = new List<Department>();
      
    }
}
