using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Data
{
    interface CollegaInterface
    {
        Task<Collega[]> GetCollega();
    }
}
