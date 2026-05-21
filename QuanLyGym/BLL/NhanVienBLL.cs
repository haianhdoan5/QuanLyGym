using QuanLyGym.Models;  // Thư mục chứa class NhanVien
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;

namespace QuanLyGym.BLL
{
    public class NhanVienBLL
    {
        // 1. Lấy danh sách Nhân Viên
        public List<NhanVien> GetAll()
        {
            using (var context = new GymDbContext())
            {
                return context.NhanVien.ToList();
            }
        }

        // 2. Thêm Nhân Viên
        public string Insert(NhanVien nv)
        {
            using(var context = new GymDbContext())
            {
                try
                {
                    var check = context.NhanVien.Find(nv.MaNv);
                    if (check != null) return "Mã nhân viên này đã tồn tại!";

                    context.NhanVien.Add(nv);
                    context.SaveChanges();
                    return "Success";
                }
                catch (Exception ex)
                {
                    return "Lỗi thêm: " + ex.Message;
                }
            }
        }

        // 3. Cập nhật Nhân Viên
        public string Update(NhanVien nvSua)
        {
            using (var context = new GymDbContext())
            {
                try
                {
                    var nvCu = context.NhanVien.Find(nvSua.MaNv);
                    if (nvCu == null) return "Không tìm thấy nhân viên để cập nhật!";

                    // Cập nhật 3 trường (Không có giới tính)
                    nvCu.TenNv = nvSua.TenNv;
                    nvCu.Sdt = nvSua.Sdt;
                    nvCu.ChucVu = nvSua.ChucVu;

                    context.SaveChanges();
                    return "Success";
                }
                catch (Exception ex)
                {
                    return "Lỗi cập nhật: " + ex.Message;
                }
            }
        }

        // 4. Xóa Nhân Viên
        public string Delete(string maNV)
        {
            using (var context = new GymDbContext())
            {
                try
                {
                    var nv = context.NhanVien.Find(maNV);
                    if (nv == null) return "Nhân viên không tồn tại!";

                    context.NhanVien.Remove(nv);
                    context.SaveChanges();
                    return "Success";
                }
                catch (Exception ex)
                {
                    if (ex.InnerException != null && ex.InnerException.Message.Contains("REFERENCE"))
                    {
                        return "Không thể xóa! Nhân viên này đã từng lập Hợp đồng.";
                    }
                    return "Lỗi xóa: " + ex.Message;
                }
            }
        }
    }
}