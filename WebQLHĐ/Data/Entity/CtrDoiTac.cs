using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{

    public class CtrDoiTac
    {


        public int Id { get; set; }



        public string? IdDoitac { get; set; }

        public string? TenDoiTac { get; set; }

        public string? DiaChi { get; set; }

        public int MaSoThueDT { get; set; }

        public int DienThoai { get; set; }

        public DateTime NgayDangKy { get; set; }

        public DateTime NgayCapNhat { get; set; }

        public bool TrangThai { get; set; }

        
        public List<CtrHopDong>? CtrHopDong { get; set; }
        public List<CtrCongNo>? ctrCongNos { get; set; }
    }
}
