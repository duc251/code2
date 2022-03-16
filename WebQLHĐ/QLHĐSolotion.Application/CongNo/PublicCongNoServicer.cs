using QLHĐSolotion.Data.EF;
using QLHĐSolotion.Data.Entity;
using QLHĐSolotion.Data.Extensions;
using QLHĐSolotion.ViewModel.CongNo;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entity;
using Data.Extensions;

namespace QLHĐSolotion.Application.CongNo
{
    public class PublicCongNoService : IPublicCongNoServicer
    {
        private readonly AppDbContext _context;
        //private readonly IStorageService _storageService;

        public PublicCongNoService(AppDbContext context/*, IStorageService storageService*/)
        {
            _context = context;
            //_storageService= storageService;
        }
        public async Task<List<CongNoViewModel>> GetAll()
        {
            var query = from dt in _context.CtrCongNos
                        select dt;
            var _congno = await query.Select(x => new CongNoViewModel()
            {
                CtrCongNoID = x.Id                ,
                MaCongNo = x.IdCongNo,
                TongNo = x.TongNo,
                DaThanhToan = x.DaThanhToan,
                NgayThanhToan = x.NgayThanhToan,
                DuNo = x.DuNo,
                KhauTru = x.KhauTru,
                Kyhan = x.Kyhan,
                GhiChu = x.GhiChu,
                Trangthai = x.Trangthai
            }).ToListAsync();

            return _congno;
        }

        //public Task<PagedResult<DoiTacViewModels>> GetAllByCategoryId(GetPublicDoiTacPagingRequest request)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<int> Create(CongNoCreateRequest x)
        {    /*  request.CtrDoiTacID = Guid.NewGuid();*/
            var doitac = new CtrCongNo()
            {
                //CtrCongNoID = x.CtrCongNoID,
                IdCongNo = x.MaCongNo,
                TongNo = x.TongNo,
                DaThanhToan = x.DaThanhToan,
                NgayThanhToan = x.NgayThanhToan,
                DuNo = x.DuNo,
                KhauTru = x.KhauTru,
                Kyhan = x.Kyhan,
                GhiChu = x.GhiChu,
                Trangthai = x.Trangthai
            };
            _context.CtrCongNos.Add(doitac);
            await _context.SaveChangesAsync();
            return doitac.Id;
        }

        public async Task<int> Delete(int CongNoID)
        {

            var _congno = await _context.CtrCongNos.FindAsync(CongNoID);
            if (_congno == null) throw new AddException($"Cannot find a product: {CongNoID}");

            //var images = _context.ProductImages.Where(i => i.ProductId == productId);
            //foreach (var image in images)
            //{
            //    await _storageService.DeleteFileAsync(image.ImagePath);
            //}

            _context.CtrCongNos.Remove(_congno);

            return await _context.SaveChangesAsync();
        }

        //public List<DoiTacViewModels> GetAll()
        //{
        //    throw new NotImplementedException();
        //}

        public List<CongNoViewModel> GetAllPaging(string keywork, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Update(CongNoUpdateRequest x)
        {
            var _congno = await _context.CtrCongNos.FindAsync(x.CtrCongNoID);
            if (_congno == null) throw new AddException($"Cannot find a product with id: {x.CtrCongNoID}");
            {
                _congno.Id = x.CtrCongNoID;
                _congno.IdCongNo = x.MaCongNo;
                _congno.TongNo = x.TongNo;
                _congno.DaThanhToan = x.DaThanhToan;
                _congno.NgayThanhToan = x.NgayThanhToan;
                _congno.DuNo = x.DuNo;
                _congno.KhauTru = x.KhauTru;
                _congno.Kyhan = x.Kyhan;
                _congno.GhiChu = x.GhiChu;
                _congno.Trangthai = x.Trangthai;
                _context.CtrCongNos.Update(_congno);
                await _context.SaveChangesAsync();
                return _congno.Id;

            }

        }
        public async Task<CongNoViewModel> GetById(int id)
        {
            var x = await _context.CtrCongNos.FindAsync(id);
            //if (request == null)
            //    throw new eshopexception($"cannot find an image with id {id}");

            var viewModel = new CongNoViewModel()
            {
                CtrCongNoID = x.Id,
                MaCongNo = x.IdCongNo,
                TongNo = x.TongNo,
                DaThanhToan = x.DaThanhToan,
                NgayThanhToan = x.NgayThanhToan,
                DuNo = x.DuNo,
                KhauTru = x.KhauTru,
                Kyhan = x.Kyhan,
                GhiChu = x.GhiChu,
                Trangthai = x.Trangthai
            };


            return viewModel;
        }
    }
}
