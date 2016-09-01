using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Repository : IRepository
    {
        public List<Modal> GetAllModal(int all)
        {
            return new List<Modal>() {
                new Modal {ID=1,Name="pankaj",Desc="dhami" },
                new Modal {ID=2,Name="rahul",Desc="dhami" },
                new Modal {ID=3,Name="deepak",Desc="dhami" },
                new Modal {ID=4,Name="gaurav",Desc="dhami" }

            };
        }

        public Modal GetModal(Func<Modal, bool> predicate)
        {
            return GetAllModal(1).FirstOrDefault(predicate);
        }
    }
}
