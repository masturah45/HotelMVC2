using System.Collections.Generic;
using Hotel_MVC2.Models;

namespace Hotel_MVC2.Interfaces
{
    public interface IRoomServices
    {
        Room CreateRoom (Room room);
        Room UpdateRoom (Room room);
        void DeleteRoomUsingId (string roomNumber);
        Room GetRoomById (string roomNumber);
        IList<Room> GetAllRoom ();
    }
}