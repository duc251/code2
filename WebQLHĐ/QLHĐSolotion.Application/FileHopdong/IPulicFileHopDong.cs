using QLHĐSolotion.ViewModel.Doitac.Dtos;
using QLHĐSolotion.ViewModel.FileHopDong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;

namespace QLHĐSolotion.Application.FileHopdong
{
    public interface IPulicFileHopDong
    {
        //Task<PagedResult<FileHopDongViewModels>> GetAllByCategoryId(GetPublicDoiTacPagingRequest request);

        Task<List<FileHopDongViewModel>> GetAll();
        //Task<int> Create(FileHopDongRequest request);

        Task<int> Update(UpdetFileHopDong request);

        Task<int> Delete(int doitacID);

        Task<int> AddImage( FileHopDongRequest request);
        //Task<int> UpdateImage(int imageId, FileHopDongRequest request);

        Task<FileHopDongViewModel> GetImageById(int imageId);
        //List<DoiTacViewModels> GetAll();
        //List<FileHopDongViewModels> GetAllPaging(String keywork, int pageIndex, int pageSize);
    }
}
