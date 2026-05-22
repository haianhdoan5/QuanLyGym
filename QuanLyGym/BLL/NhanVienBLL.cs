using QuanLyGym.Models;  // Thư mục chứa class NhanVien
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;

namespace QuanLyGym.BLL
{

    public class NhanVienBLL
    {
        private GymDbContext db = new GymDbContext();
        // 1. Lấy danh sách Nhân Viên
        public List<NhanVien> GetNhanVien()
        {
            using (var context = new GymDbContext())
            {
                return context.NhanVien.ToList();
            }
        }

        public NhanVien GetById(string maNV) => db.NhanVien.FirstOrDefault(n => n.MaNv == maNV);
        // 2. Thêm Nhân Viên
        public bool AddNhanVien(NhanVien nv)
        {
            try
            {
                var check = db.NhanVien.Find(nv.MaNv);
                if (check != null) return false;

                db.NhanVien.Add(nv);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
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

        public string GetNextMaNV()
        {
            using (var context = new GymDbContext())
            {
                // Lấy tất cả mã NV, cắt bỏ chữ "NV", ép sang kiểu số, tìm số lớn nhất
                var maxId = context.NhanVien.ToList()
                    .Where(n => n.MaNv.StartsWith("NV"))
                    .Select(n => int.Parse(n.MaNv.Substring(2)))
                    .DefaultIfEmpty(0)
                    .Max();

                // Cộng 1 và format lại thành dạng NV01, NV02...
                return "NV" + (maxId + 1).ToString("D2");
            }
        }
    }
}