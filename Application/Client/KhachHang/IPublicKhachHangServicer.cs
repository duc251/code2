using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ViewModels.Common;
using ViewModels.KhachHang.KH;

namespace Application.Client.KhachHang
{
    public interface IPublicKhachHangServicer
    {
        Task<PagedResult<KhachHangViewModels>> GetAllByCategoryId(GetPublicKhachHangPagingRequest request);

        Task<List<KhachHangViewModels>> GetAll();
        Task<int> Create(CtrKhachHangCreateRequest request);

        Task<int> Update(CtrKhachHangUpdateRequest request);

        Task<int> Delete(int doitacID);

        Task<KhachHangViewModels> GetById(int KhachHangID);
        //List<DoiTacViewModels> GetAll();
        List<KhachHangViewModels> GetAllPaging(string keywork, int pageIndex, int pageSize);
    }

}
