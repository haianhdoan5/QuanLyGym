using Microsoft.EntityFrameworkCore; // Thư viện để dùng hàm Include
using QuanLyGym.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyGym.BLL
{
    public class HopDongBLL
    {
       public List<HopDong> GetAll()
        {
            using (var context = new GymDbContext()) 
            {
               return context.HopDong.ToList();
            }
        }

        // Thêm mới Hợp Đồng
        public string Insert(HopDong hd)
        {
            using (var context = new GymDbContext())
            {
                try
                {
                    var kiemTra = context.HopDong.Find(hd.MaHd);
                    if (kiemTra != null)
                    {
                        return "Mã hợp đồng này đã tồn tại!";
                    }

                    context.HopDong.Add(hd);
                    context.SaveChanges();

                    return "Success";
                }
                catch (Exception ex)
                {
                    return "Lỗi khi thêm: " + ex.Message;
                }
            }
        }

        //Cập nhật Hợp Đồng
        public string Update(HopDong hdSua)
        {
            using (var context = new GymDbContext())
            {
                try
                {
                    var hdCu = context.HopDong.Find(hdSua.MaHd);
                    if (hdCu == null)
                    {
                        return "Không tìm thấy hợp đồng để cập nhật!";
                    }

                    hdCu.NoiDung = hdSua.NoiDung;
                    hdCu.MaHv = hdSua.MaHv;
                    hdCu.MaGoi = hdSua.MaGoi;
                    hdCu.MaNv = hdSua.MaNv;
                    context.SaveChanges();

                    return "Success";
                }
                catch (Exception ex)
                {
                    return "Lỗi khi cập nhật: " + ex.Message;
                }
            }
        }

        // Xóa Hợp Đồng
        public string Delete(string maHD)
        {
            using (var context = new GymDbContext())
            {
                try
                {
                    var hd = context.HopDong.Find(maHD);
                    if (hd == null)
                    {
                        return "Hợp đồng không tồn tại!";
                    }

                    context.HopDong.Remove(hd);
                    context.SaveChanges();

                    return "Success";
                }
                catch (Exception ex)
                {
                    return "Lỗi khi xóa: " + ex.Message;
                }
            }
        }

        // Mã Hợp Đồng tự tăng
        public string GetNextMaHD()
        {
            using (var context = new GymDbContext())
            {
                var maxId = context.HopDong.ToList()
                    .Where(h => h.MaHd.StartsWith("HD"))
                    .Select(h => int.Parse(h.MaHd.Substring(2)))
                    .DefaultIfEmpty(0)
                    .Max();

                return "HD" + (maxId + 1).ToString("D2");
            }
        }
    }
}
