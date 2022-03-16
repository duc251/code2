using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
    public class FileHopDong
    {
        public int Id { get; set; }
        public int HopDongId { get; set; }
        public string? FilePath { get; set; }
        public string? Caption { get; set; }
        public bool IsDefault { get; set; }
        public DateTime DateCreate { get; set; }
        public CtrHopDong? CtrHopDong { get; set; }
        public long FileSize { get; set; }
    }
}
