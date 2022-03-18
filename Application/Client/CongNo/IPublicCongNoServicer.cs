
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.CongNo;

namespace Application.Client.CongNo
{
    public interface IPublicCongNoServicer
    {
        //Task<PagedResult<CongNoViewModel>> GetAllByCategoryId(GetPublicCongNoPagingRequest request);

        Task<List<CongNoViewModel>> GetAll();
        Task<int> Create(CongNoCreateRequest request);

        Task<int> Update(CongNoUpdateRequest request);

        Task<int> Delete(int CongNoID);

        Task<CongNoViewModel> GetById(int CongNoID);
        //List<DoiTacViewModels> GetAll();
        List<CongNoViewModel> GetAllPaging(string keywork, int pageIndex, int pageSize);
    }
}
