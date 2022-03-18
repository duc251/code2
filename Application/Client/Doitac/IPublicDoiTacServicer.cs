using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ViewModels.Doitac.Dtos;

namespace Application.Client.Doitac
{
    public interface IPublicDoiTacServicer
    {
        //Task<PagedResult<DoiTacViewModels>> GetAllByCategoryId(GetPublicDoiTacPagingRequest request);

        Task<List<DoiTacViewModels>> GetAll();
        Task<int> Create(CtrDoiTacCreateRequest request);

        Task<int> Update(CtrDoiTacUpdateRequest request);

        Task<int> Delete(int doitacID);

        Task<DoiTacViewModels> GetById(int productId);
        //List<DoiTacViewModels> GetAll();
        //List<DoiTacViewModels> GetAllPaging(String keywork, int pageIndex, int pageSize);
    }

}
