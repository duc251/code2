using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHĐSolotion.ViewModel.Doitac.Dtos
{
    public class DoiTacViewModels
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


    }
}
