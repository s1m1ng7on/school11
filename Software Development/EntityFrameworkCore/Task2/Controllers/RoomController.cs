using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Data;
using Task2.Data.Entities;
using Task2.Views;

namespace Task2.Controllers
{
    public class RoomController
    {
        public RoomController()
        {
            Context context = new Context();

            RoomView roomView = new RoomView();

            Room newRoom = new Room()
            {
                Id = Guid.NewGuid().ToString(),
                Number = roomView.Number,
                RoomType = roomView.
            }
        }
    }
}
