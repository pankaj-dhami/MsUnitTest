using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public interface IRepository
    {
        List<Modal> GetAllModal();

        Modal GetModal(Func<Modal, bool> predicate);


        
    }
}
