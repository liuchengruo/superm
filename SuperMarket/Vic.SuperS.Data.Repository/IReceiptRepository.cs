using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vic.SuperS.Data.Model;

namespace Vic.SuperS.Data.Repository
{
    public interface IReceiptRepository
    {

        Receipt Create();
        Receipt GetById(int id);
        Receipt Update(int id, Receipt newValue);
    }
}
