using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository_Mf_Hub;

namespace Services_MF
{
    public class PriorityService : IPriorityService
    {
        private readonly Mf_Hub_model _context;

        public PriorityService(Mf_Hub_model context)
        {
            _context = context;
        }
        public IEnumerable<Priority> GetPriorities()
        {
            return _context.Priorities;
        }
    }
}
