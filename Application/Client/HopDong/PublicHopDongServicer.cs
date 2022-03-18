
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Data.EF;
using ViewModels.HopDong;
using Data.Entiti;
using Utilities;

namespace Application.Client.HopDong
{
    public class PublicHopDongServicer : IPublicHopDongServicer
    {

        private readonly CodeDbContext _context;
        //private readonly IStorageService _storageService;

        public PublicHopDongServicer(CodeDbContext context/*, IStorageService storageService*/)
        {
            _context = context;
            //_storageService= storageService;
        }
        public async Task<List<HopDongViewModel>> GetAll()
        {
            var query = from dt in _context.CtrHopDongs
                        select dt;
            var doitac = await query.Select(x => new HopDongViewModel()
            {

                IdHd = x.IdHd,
                TenHopDong = x.TenHopDong,
                NoiDungHD = x.NoiDungHD,
                NgayLap = x.NgayLap,
                NgayNghiemThu = x.NgayNghiemThu,
                NguoiPhuTrachHopDong = x.NguoiPhuTrachHopDong,
                GiaTriGoiDV = x.GiaTriGoiDV,
                CtrDoiTacID = x.CtrDoiTacID,
                CtrKhachHangID = x.CtrKhachHangID,

                TrangThai = x.TrangThai
            }).ToListAsync();

            return doitac;
        }

        //public Task<PagedResult<HopDongViewModels>> GetAllByCategoryId(GetPublicKhachHangPagingRequest request)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<int> Create(HopDongCreateRequest x)
        {

            var khachHang = new CtrHopDong()
            {

                TenHopDong = x.TenHopDong,
                NoiDungHD = x.NoiDungHD,
                NgayLap = x.NgayLap,
                NgayNghiemThu = x.NgayNghiemThu,
                NguoiPhuTrachHopDong = x.NguoiPhuTrachHopDong,
                GiaTriGoiDV = x.GiaTriGoiDV,
                CtrDoiTacID = x.CtrDoiTacID,
                CtrKhachHangID = x.CtrKhachHangID,
                TrangThai = x.TrangThai

            };
            _context.CtrHopDongs.Add(khachHang);
            await _context.SaveChangesAsync();
            return khachHang.Id;
        }

        public async Task<int> Delete(int KhachHangID)
        {

            var khachhang = await _context.CtrHopDongs.FindAsync(KhachHangID);
            if (khachhang == null) throw new CodeException($"Cannot find a product: {KhachHangID}");

            //var images = _context.ProductImages.Where(i => i.ProductId == productId);
            //foreach (var image in images)
            //{
            //    await _storageService.DeleteFileAsync(image.ImagePath);
            //}

            _context.CtrHopDongs.Remove(khachhang);

            return await _context.SaveChangesAsync();
        }

        //public List<DoiTacViewModels> GetAll()
        //{
        //    throw new NotImplementedException();
        //}

        public List<HopDongViewModel> GetAllPaging(string keywork, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Update(HopDongUpdateRequest x)
        {
            var product = await _context.CtrHopDongs.FindAsync(x.Id);
            if (product == null) throw new CodeException($"Cannot find a product with id: {x.Id}");

            {
                {
                    product.Id = x.Id;
                  
                    product.TenHopDong = x.TenHopDong;
                    product.NoiDungHD = x.NoiDungHD;
                    product.NgayLap = x.NgayLap;
                    product.NgayNghiemThu = x.NgayNghiemThu;
                    product.NguoiPhuTrachHopDong = x.NguoiPhuTrachHopDong;
                    product.GiaTriGoiDV = x.GiaTriGoiDV;
                    product.CtrDoiTacID = x.CtrDoiTacID;
                    product.CtrKhachHangID = x.CtrKhachHangID;
                    _context.CtrHopDongs.Update(product);
                    await _context.SaveChangesAsync();
                    return product.CtrKhachHangID;

                }

            }
        }
        public async Task<HopDongViewModel> GetById(int id)
        {
            var x = await _context.CtrHopDongs.FindAsync(id);
            //if (request == null)
            //    throw new eshopexception($"cannot find an image with id {id}");

            var viewModel = new HopDongViewModel()
            {
                IdHd = x.IdHd,
                TenHopDong = x.TenHopDong,
                NoiDungHD = x.NoiDungHD,
                NgayLap = x.NgayLap,
                NgayNghiemThu = x.NgayNghiemThu,
                NguoiPhuTrachHopDong = x.NguoiPhuTrachHopDong,
                GiaTriGoiDV = x.GiaTriGoiDV,
                CtrDoiTacID = x.CtrDoiTacID,
                CtrKhachHangID = x.CtrKhachHangID,
                TrangThai = x.TrangThai
            };


            return viewModel;
        }
    }
}

