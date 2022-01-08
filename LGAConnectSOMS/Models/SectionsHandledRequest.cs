using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGAConnectSOMS.Models
{
    public class SectionsHandledRequest
    {
        public IEnumerable<SectionsHandled> SectionsHandled { get; set; }

        public int TeacherId { get; set; }
    }
}
