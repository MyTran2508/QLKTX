using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKyTucXa.Models;
using QuanLyKyTucXa.Services;

namespace QuanLyKyTucXa.Controllers
{
    class StudentController
    {
        StudentService ss = new StudentService();
        private StudentModel CreateStudent(string maSinhVien, string maPhong, string hoTenSV, bool gioiTinh, string diaChi, string cCCD, Int16 nienKhoa)
        {
            StudentModel student = new StudentModel(maSinhVien, maPhong, hoTenSV, gioiTinh, diaChi, cCCD, nienKhoa);
            return student;
        }

        public StudentModel FindBy(string maSinhVien, ref string error)
        {
            StudentModel st = null;
            try
            {
                if (maSinhVien == "")
                {
                    error = "Missing parameter";
                    return st;
                }
                st = ss.FindBy(maSinhVien);
                if (st != null)
                {
                    error = "Get Student Success!!!";
                }
                else
                {
                    error = "Get Student Failed!!!";
                }
            }
            catch
            {
                error = "Something Was Wrong When Get Student!!!";
            }
            return st;
        }

        public List<StudentModel> FindAll(ref string error)
        {

            try
            {
                var students = ss.FindAll().ToList();
                if (students != null)
                {
                    error = "Get All Students Success!!!";
                    return students;
                }
                else
                {
                    error = "Get All Students Fail!!!";
                    return null;
                }
            }
            catch
            {
                error = "Sonething Was Wrong When Get Students!!!";
                return null;
            }
        }
        // Insert Room
        public bool InsertStudent
        (
            string StudentId,
            string RoomId,
            string StudentName,
            bool gender,
            string address,
            string cccd,
            Int16 SchoolYear,
            ref string error)
        {
            try
            {
                if (StudentId == ""
                    || RoomId == ""
                    || StudentName == ""
                    || address == ""
                    || cccd == ""
                   )
                {
                    error = "Missing parameter";
                    return false;
                }
                var room = this.
                    CreateStudent(StudentId, RoomId, StudentName, gender, address, cccd, SchoolYear);
                if (room != null)
                {
                    bool isInsert = ss.Insert(room);
                    if (isInsert)
                    {
                        error = "Add Student Success!!!";
                        return true;
                    }
                    else
                    {
                        error = "Add Student fail";
                        return false;
                    }
                }
                error = "Student Invalid!!!";
                return false;
            }
            catch
            {
                error = "Something Was Wrong When Add Student!!!";
                return false;
            }
        }

        // Update Student
        public bool UpdateStudent
        (
               string StudentId,
            string RoomId,
            string StudentName,
            bool gender,
            string address,
            string cccd,
            Int16 SchollYear,
            ref string error)
        {
            try
            {
                if (StudentId == ""
                    || RoomId == ""
                    || StudentName == ""
                    || address == ""
                    || cccd == ""
                   )
                {
                    error = "Missing parameter";
                    return false;
                }

                var room = this.
                     CreateStudent(StudentId, RoomId, StudentName, gender, address, cccd, SchollYear);
                if (room != null)
                {
                    bool isInsert = ss.Update(room);
                    if (isInsert)
                    {
                        error = "Update Student Success!!!";
                        return true;
                    }
                    else
                    {
                        error = "Update Student fail";
                        return false;
                    }
                }
                error = "Student Invalid!!!";
                return false;
            }
            catch
            {
                error = "Something Was Wrong When Add Student!!!";
                return false;
            }
        }

        //Delete Student
        public bool RemoveStudent(string Id, ref string error)
        {
            try
            {
                bool numOfState = ss.Remove(Id);
                if (numOfState)
                {
                    error = "Remove Student Success!!!";
                    return true;
                }
                else
                {
                    error = "Remove Student Failure!!!";
                    return false;
                }
            }
            catch
            {
                error = "Something Was Wrong When Remove Student!!!";
                return false;
            }
        }
    }
}
