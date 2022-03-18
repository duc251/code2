using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using ViewModels.HopDong;

namespace Application.Client.HopDong
{
    public interface IPublicHopDongServicer
    {
        //Task<PagedResult<HopDongViewModels>> GetAllByCategoryId(GetPublicKhachHangPagingRequest request);

        Task<List<HopDongViewModel>> GetAll();
        Task<int> Create(HopDongCreateRequest request);

        Task<int> Update(HopDongUpdateRequest request);

        Task<int> Delete(int HopDongID);


        //List<DoiTacViewModels> GetAll();
        Task<HopDongViewModel> GetById(int HopDongID);
        List<HopDongViewModel> GetAllPaging(string keywork, int pageIndex, int pageSize);
    }
}
