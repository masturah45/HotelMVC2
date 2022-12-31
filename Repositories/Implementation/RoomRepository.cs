using System.Collections.Generic;
using System.Linq;
using Hotel_MVC2.ApplicationContext;
using Hotel_MVC2.Models;

namespace Hotel_MVC2.Repositories.Implementation
{
    public class RoomRepository : IRoomRepository
    {
        private readonly ContextClass _context;

        public RoomRepository (ContextClass context)
        {
            _context = context;
        }

        public Room CreateRoom(Room room)
        {
            _context.Rooms.Add(room);
            _context.SaveChanges();
            return room;
        }

        public void DeleteRoomUsingId(Room roomNumber)
        {
            _context.Rooms.Remove(roomNumber);
            _context.SaveChanges();
        }

        public IList<Room> GetAllRoom()
        {
            return _context.Rooms.ToList();
        }

        public Room GetRoomById(string roomNumber)
        {
            var room = _context.Rooms.SingleOrDefault(a => a.RoomNumber == roomNumber);
            return room;
        }

        public Room UpdateRoom(Room room)
        {
            _context.Rooms.Update(room);
            _context.SaveChanges();
            return room;
        }
    }
}