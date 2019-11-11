using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository_Mf_Hub;

namespace Services_MF
{
    public interface IStatusService
    {
        IEnumerable<Status> GetStatus();
    }
}
