using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
    public class CtrCongNo
    {

        public int Id { set; get; }

        public string? IdCongNo { set; get; }

        public decimal TongNo { set; get; }

        public decimal DaThanhToan { set; get; }

        public DateTime NgayThanhToan { set; get; }

        public decimal DuNo { set; get; }

        public decimal KhauTru { set; get; }

        public DateTime Kyhan { set; get; }

        public string? GhiChu { set; get; }

        public bool Trangthai { get; set; }

        //public int DoitacId { get; set; }
        public CtrDoiTac? CtrDoiTac { get; set; }
    }
}
