using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository_Mf_Hub;

namespace Services_MF
{
    public class StatusService : IStatusService
    {
        private readonly Mf_Hub_model _context;

        public StatusService(Mf_Hub_model context)
        {
            _context = context;
        }
        public IEnumerable<Status> GetStatus()
        {
            return _context.Statuses;
        }
    }
}
