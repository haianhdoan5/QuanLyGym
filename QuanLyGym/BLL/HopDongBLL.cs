using Microsoft.EntityFrameworkCore; // Thư viện để dùng hàm Include
using QuanLyGym.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyGym.BLL
{
    public class HopDongBLL
    {
        // 1. Lấy toàn bộ danh sách Hợp Đồng
        public List<HopDong> GetAll()
        {
            using (var context = new GymDbContext()) // Tên DbContext của bạn có thể là GymDbContext
            {
                // Trả về toàn bộ danh sách hợp đồng
                return context.HopDong.ToList();
            }
        }

        // 2. Thêm mới Hợp Đồng
        public string Insert(HopDong hd)
        {
            using (var context = new GymDbContext())
            {
                try
                {
                    // Kiểm tra trùng mã Hợp đồng (nếu MaHD của bạn là tự nhập)
                    var kiemTra = context.HopDong.Find(hd.MaHd);
                    if (kiemTra != null)
                    {
                        return "Mã hợp đồng này đã tồn tại!";
                    }

                    // Thêm vào DbSet
                    context.HopDong.Add(hd);

                    // Lưu xuống Database
                    context.SaveChanges();

                    return "Success";
                }
                catch (Exception ex)
                {
                    return "Lỗi khi thêm: " + ex.Message;
                }
            }
        }

        // 3. Cập nhật Hợp Đồng
        public string Update(HopDong hdSua)
        {
            using (var context = new GymDbContext())
            {
                try
                {
                    // Tìm hợp đồng cũ trong Database
                    var hdCu = context.HopDong.Find(hdSua.MaHd);
                    if (hdCu == null)
                    {
                        return "Không tìm thấy hợp đồng để cập nhật!";
                    }

                    // Gán các giá trị mới từ UI vào Hợp đồng cũ
                    hdCu.NoiDung = hdSua.NoiDung;
                    hdCu.MaHv = hdSua.MaHv;
                    hdCu.MaGoi = hdSua.MaGoi;
                    hdCu.MaNv = hdSua.MaNv;
                    // hdCu.MaKM = hdSua.MaKM;

                    // Lưu thay đổi
                    context.SaveChanges();

                    return "Success";
                }
                catch (Exception ex)
                {
                    return "Lỗi khi cập nhật: " + ex.Message;
                }
            }
        }

        // 4. Xóa Hợp Đồng
        public string Delete(string maHD) // Đổi kiểu dữ liệu của maHD thành int nếu ID hợp đồng của bạn là số
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

                    // Xóa vật lý khỏi Database
                    context.HopDong.Remove(hd);
                    context.SaveChanges();

                    // *Lưu ý: Nếu muốn xóa mềm (chỉ đổi trạng thái), dùng code sau thay cho Remove:
                    // hd.TrangThai = false;
                    // context.SaveChanges();

                    return "Success";
                }
                catch (Exception ex)
                {
                    return "Lỗi khi xóa: " + ex.Message;
                }
            }
        }
    }
}
