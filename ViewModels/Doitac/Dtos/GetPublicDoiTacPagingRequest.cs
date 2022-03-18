using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.Doitac.Common;

namespace ViewModels.Doitac.Dtos
{
    public class GetPublicDoiTacPagingRequest : PagingRequestBase
    {
        public int Id { get; set; }
    }
}
