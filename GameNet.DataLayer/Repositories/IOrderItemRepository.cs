using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNet.DataLayer.Repositories
{
    public interface IOrderItemRepository
    {
        decimal calAmount(int orderitemId);

    }
}
