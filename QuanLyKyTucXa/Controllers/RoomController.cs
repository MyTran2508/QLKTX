using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKyTucXa.Models;
using QuanLyKyTucXa.Services;

namespace QuanLyKyTucXa.Controllers
{
    class RoomController
    {
        RoomService rs = new RoomService();
        private RoomModel CreateRoom(string Roomid, string EmployeeId, string RoomStatus, Int16 NumberofStudent, string KindofRoom)
        {
            RoomModel room = new RoomModel(Roomid, EmployeeId, RoomStatus, NumberofStudent, KindofRoom);
            return room;
        }

        public List<RoomModel> FindAll(ref string error)
        {

            try
            {
                var rooms = rs.FindAll().ToList();
                if (rooms != null)
                {
                    error = "Get All Rooms Success!!!";
                    return rooms;
                }
                else
                {
                    error = "Get All Rooms Fail!!!";
                    return null;
                }
            }
            catch
            {
                error = "Sonething Was Wrong When Get Room!!!";
                return null;
            }
        }
       
        // Insert Room
        public bool InsertRoom
        (
            string Roomid, 
            string EmployeeId,
            string RoomStatus, 
            Int16 NumberofStudent, 
            string KindofRoom,
            ref string error)
        {
            try
            {
                if (Roomid == ""
                    || EmployeeId== ""
                    || RoomStatus == ""
                    || KindofRoom == ""
                   )
                {
                    error = "Missing parameter";
                    return false;
                }
                var room = this.
                    CreateRoom(Roomid, EmployeeId, RoomStatus, NumberofStudent, KindofRoom);
                if (room != null)
                {
                    bool isInsert = rs.Insert(room);
                    if (isInsert)
                    {
                        error = "Add Room Success!!!";
                        return true;
                    }
                    else
                    {
                        error = "Add Room fail";
                        return false;
                    }
                }
                error = "Room Invalid!!!";
                return false;
            }
            catch
            {
                error = "Something Was Wrong When Add Room!!!";
                return false;
            }
        }

        // Update Room
        public bool UpdateRoom
        (
            string Roomid,
            string EmployeeId,
            string RoomStatus,
            Int16 NumberofStudent,
            string KindofRoom,
            ref string error)
        {
            try
            {
                if (Roomid == ""
                    || EmployeeId == ""
                    || RoomStatus == ""
                    || KindofRoom == ""
                   )
                {
                    error = "Missing parameter";
                    return false;
                }

                var room = this.
                    CreateRoom(Roomid, EmployeeId, RoomStatus, NumberofStudent, KindofRoom);
                if (room != null)
                {
                    bool isInsert = rs.Update(room);
                    if (isInsert)
                    {
                        error = "Update Room Success!!!";
                        return true;
                    }
                    else
                    {
                        error = "Update Room fail";
                        return false;
                    }
                }
                error = "Room Invalid!!!";
                return false;
            }
            catch
            {
                error = "Something Was Wrong When Add Room!!!";
                return false;
            }
        }

        //Delete Room
        public bool RemoveRoom(string Id, ref string error)
        {
            try
            {
                bool numOfState = rs.Remove(Id);
                if (numOfState)
                {
                    error = "Remove Room Success!!!";
                    return true;
                }
                else
                {
                    error = "Remove Room Failure!!!";
                    return false;
                }
            }
            catch
            {
                error = "Something Was Wrong When Remove Room!!!";
                return false;
            }
        }
        // Get Room By Id
        public RoomModel GetRoomById(string id, ref string error)
        {
            try
            {

                var room = rs.GetRoomById(id);
                if (room != null)
                {
                    error = "Add Room Success!!!";
                    return room;
                }
                else
                {
                    error = "Add Room fail";
                    return null;
                }

            }
            catch
            {
                error = "Something Was Wrong When Add Room!!!";
                return null;
            }
        }
    }
}
