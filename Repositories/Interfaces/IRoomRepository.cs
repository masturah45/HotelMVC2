using System.Collections.Generic;
using Hotel_MVC2.Models;

namespace Hotel_MVC2.Repositories
{
    public interface IRoomRepository
    {
        Room CreateRoom (Room room);
        Room UpdateRoom (Room room);
        void DeleteRoomUsingId (Room roomNumber);
        Room GetRoomById (string roomNumber);
        IList<Room> GetAllRoom ();
    }
}