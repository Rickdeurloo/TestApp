using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Data
{
    public class CollegaServices : CollegaInterface
    {
        public Task<Collega[]> GetCollega()
        {
            List<Collega> collegas = new List<Collega> { new Collega("Rick", "test", "test"), new Collega("Jordy", "test2", "test2") };
            return Task.FromResult(collegas.ToArray());
        }
    }
}



