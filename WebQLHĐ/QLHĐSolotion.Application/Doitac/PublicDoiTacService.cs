using Data.EF;
using QLHĐSolotion.Data.Entity;
using QLHĐSolotion.ViewModel.Doitac.Dtos;
//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;
using QLHĐSolotion.Application.Doitac.Dtos;
using QLHĐSolotion.Data.Extensions;
using Microsoft.Xrm.Sdk.Workflow;
using QLHĐSolotion.Data.EF;
using Data.Entity;
using Data.Extensions;

namespace QLHĐSolotion.Application.Doitac
{
    public class PublicDoiTacService : IPublicDoiTacServicer
    {
        private readonly AppDbContext _context;
        //private readonly IStorageService _storageService;

        public PublicDoiTacService(AppDbContext context/*, IStorageService storageService*/)
        {
            _context = context;
            //_storageService= storageService;
        }
        public async Task<List<DoiTacViewModels>> GetAll()
        {
            var query = from dt in _context.CtrDoiTacs
                        select dt;
            var doitac = await query.Select(x => new DoiTacViewModels()
            {
                Id = x.Id,
                IdDoitac = x.IdDoitac,
                TenDoiTac = x.TenDoiTac,
                DiaChi = x.DiaChi,
                MaSoThueDT = x.MaSoThueDT,
                DienThoai = x.DienThoai,
                NgayDangKy = x.NgayDangKy,
                NgayCapNhat= x.NgayCapNhat,
                TrangThai= x.TrangThai,
            }).ToListAsync();

            return doitac;
        }

        public Task<PagedResult<DoiTacViewModels>> GetAllByCategoryId(GetPublicDoiTacPagingRequest request)
        {
            throw new NotImplementedException();
        }
      
        public async Task<int> Create(CtrDoiTacCreateRequest request)
        {    /*  request.CtrDoiTacID = Guid.NewGuid();*/
            var doitac = new CtrDoiTac()
            {
                //CtrDoiTacID = request.CtrDoiTacID,
                IdDoitac = request.IdDoitac,
                TenDoiTac = request.TenDoiTac,
                DiaChi = request.DiaChi,
                MaSoThueDT = request.MaSoThueDT,
                DienThoai = request.DienThoai,
                NgayDangKy = request.NgayDangKy,
                NgayCapNhat = request.NgayCapNhat,
                TrangThai = request.TrangThai,
            };
            _context.CtrDoiTacs.Add(doitac);
            await _context.SaveChangesAsync();
            return doitac.Id;
        }

        public async Task<int> Delete(int doitacID)
        {

            var doitac = await _context.CtrDoiTacs.FindAsync(doitacID);
            //if (doitac == null) throw new EShopException($"Cannot find a product: {doitacID}");

            //var images = _context.ProductImages.Where(i => i.ProductId == productId);
            //foreach (var image in images)
            //{
            //    await _storageService.DeleteFileAsync(image.ImagePath);
            //}

            _context.CtrDoiTacs.Remove(doitac);

            return await _context.SaveChangesAsync();
        }

        //public List<DoiTacViewModels> GetAll()
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<DoiTacViewModels> GetById(int id)
        {
            var request = await _context.CtrDoiTacs.FindAsync(id);
            //if (request == null)
            //    throw new eshopexception($"cannot find an image with id {id}");

            var viewModel = new DoiTacViewModels()
            {
                Id = request.Id,
                IdDoitac = request.IdDoitac,
                TenDoiTac = request.TenDoiTac,
                DiaChi = request.DiaChi,
                MaSoThueDT = request.MaSoThueDT,
                DienThoai = request.DienThoai,
                NgayDangKy = request.NgayDangKy,
                NgayCapNhat = request.NgayCapNhat,
                TrangThai = request.TrangThai,
            };


            return viewModel;
        }

        public async Task<int> Update(CtrDoiTacUpdateRequest request)
        {
            var product = await _context.CtrDoiTacs.FindAsync(request.Id);
            if (product == null) throw new AddException($"Cannot find a product with id: {request.Id}");
            {
                product.IdDoitac = request.IdDoitac;
                product.TenDoiTac = request.TenDoiTac;
                product.DiaChi = request.DiaChi;
                product.MaSoThueDT = request.MaSoThueDT;
                product.DienThoai = request.DienThoai;
                product.NgayDangKy = request.NgayDangKy;
                product.NgayCapNhat = request.NgayCapNhat;
                product.TrangThai = request.TrangThai;
                _context.CtrDoiTacs.Update(product);
                await _context.SaveChangesAsync();
                return product.Id;

            }
          
        }
    }
}

