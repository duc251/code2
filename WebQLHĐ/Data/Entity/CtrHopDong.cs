using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
    public class CtrHopDong
    {
        public int Id { get; set; }

        public string? IdHd { get; set; }

        public string? TenHopDong { get; set; }


        public string? NoiDungHD { get; set; }


        public DateTime NgayLap { get; set; }


        public DateTime NgayNghiemThu { get; set; }


        public string? NguoiPhuTrachHopDong { get; set; }

        public decimal GiaTriGoiDV { get; set; }

        public int CtrDoiTacID { get; set; }

        public int CtrKhachHangID { get; set; }
        //public int CtrCongNoID { set; get; }
        public bool TrangThai { get; set; }

        //public string TenDoiTac { get; set; }
        //public string TenKhachHang { get; set; }
        //public Guid KhachangId { get; set; }
        public CtrKhachHang? CtrKhachHang { get; set; }

        public List<FileHopDong>? FileHopDongs { get; set; }
        public List<CtrCongNo>? ctrCongNos { get; set; }
       
    }
}
