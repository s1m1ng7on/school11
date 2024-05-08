using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreEFCoreProject.Entities
{
    public interface IIdentifiable
    {
        public int Id { get; set; }
    }
}
