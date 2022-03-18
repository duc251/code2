using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.Doitac.Common;

namespace ViewModels.KhachHang.KH
{
    public class GetPublicKhachHangPagingRequest : PagingRequestBase
    {
        public Guid CtrHopDongID { get; set; }
    }
}
