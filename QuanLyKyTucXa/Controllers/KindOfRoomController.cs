using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKyTucXa.Models;
using QuanLyKyTucXa.Services;

namespace QuanLyKyTucXa.Controllers
{
    class KindOfRoomController
    {
        KindOfRoomService krs = new KindOfRoomService();
        public List<KindOfRoomModel> FindAll(ref string error)
        {

            try
            {
                var kors = krs.FindAll().ToList();
                if (kors != null)
                {
                    error = "Get All Kind Of Rooms Success!!!";
                    return kors;
                }
                else
                {
                    error = "Get All Kind Of Rooms Fail!!!";
                    return null;
                }
            }
            catch
            {
                error = "Sonething Was Wrong When Get Kind Of Room!!!";
                return null;
            }

        }
    }
}
