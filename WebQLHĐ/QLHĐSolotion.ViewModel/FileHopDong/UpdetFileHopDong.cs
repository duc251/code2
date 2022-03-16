using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHĐSolotion.ViewModel.FileHopDong
{
    public class UpdetFileHopDong
    {
        public int id { get; set; }
        public int HopDongId { get; set; }
        public IFormFile FilePath { get; set; }
        public string Caption { get; set; }
        public bool IsDefault { get; set; }
        public DateTime DateCreate { get; set; }
        //public CtrHopDong CtrHopDong { get; set; }
        public long FileSize { get; set; }
    }
}
