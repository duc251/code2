using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{

    public class CtrKhachHang
    {


        public int CtrKhachHangID { get; set; }

        public string? MaKH { get; set; }

        public string? TenKhachHang { get; set; }

         public int MaSothueKH { get; set; }

        public string? Diachi { get; set; }

        public int Dienthoai { get; set; }


        public string? Skype { get; set; }


        public string? Email { get; set; }

        public DateTime NgayDangKy { get; set; }

        public DateTime NgayCapNhat { get; set; }

        public bool TrangThai { get; set; }

        public List<CtrHopDong>? CtrHopDongs { get; set; }
        public List<CtrCongNo>? CtrCongNos { get; set; }
    }
}
