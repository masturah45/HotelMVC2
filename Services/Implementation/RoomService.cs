using System;
using System.Collections.Generic;
using System.IO;
using Hotel_MVC2.Interfaces;
using Hotel_MVC2.Models;
using Hotel_MVC2.Repositories;

namespace Hotel_MVC2.Services.Implementation
{
    public class RoomService : IRoomServices
    {
        private readonly IRoomRepository _repo;

        public RoomService (IRoomRepository repo)
        {
            _repo = repo;
        }

        public Room CreateRoom(Room room)
        {
            var rand = new Random();
            room.RoomNumber = "FIVESTARS-Room-"+rand.Next(0, 9).ToString()+rand.Next(50, 99);
            return _repo.CreateRoom(room);
        }

        public void DeleteRoomUsingId(string roomNumber)
        {
            var room = _repo.GetRoomById(roomNumber);
            _repo.DeleteRoomUsingId(room);
        }

        public IList<Room> GetAllRoom()
        {
            return _repo.GetAllRoom();
        }

        public Room GetRoomById(string roomNumber)
        {
            return _repo.GetRoomById(roomNumber);
        }

        public Room UpdateRoom(Room room)
        {
            var romm = _repo.GetRoomById(room.RoomNumber);
            
            if (romm ==  null)
            {
                throw new DirectoryNotFoundException();
            }

            romm.Amount = room.Amount != romm.Amount? room.Amount : romm.Amount;
            romm.Type = room.Type;
            return _repo.UpdateRoom(romm);
        }
    }
}