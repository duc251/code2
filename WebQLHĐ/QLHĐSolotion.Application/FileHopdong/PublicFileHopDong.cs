using QLHĐSolotion.ViewModel.Doitac.Dtos;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entity;
using QLHĐSolotion.Data.EF;
using QLHĐSolotion.Data.Entity;

using QLHĐSolotion.ViewModel.FileHopDong;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Http;
using Data.Extensions;
using System.Data.Entity;

namespace QLHĐSolotion.Application.FileHopdong
{
    public class PublicFileHopDong : IPulicFileHopDong
    {
    
        private readonly AppDbContext _context;

        private readonly IPulicFileHopDong _storageService;
        private readonly IStorageService _torageService;
        private const string USER_CONTENT_FOLDER_NAME = "user-content";

        public PublicFileHopDong(AppDbContext context)
        {
            _context = context;
            
        }
        public  async Task<int> AddImage( FileHopDongRequest request)
        {
            var HDFile = new FileHopDong();
            {
                HDFile.HopDongId = request.HopDongId;
                HDFile.DateCreate = DateTime.Now;
                 HDFile.Caption = request.Caption;
                HDFile.IsDefault = request.IsDefault;
             

            };

            if (request.FilePath != null)
            {
                HDFile.FilePath = await this.SaveFile(request.FilePath);
                HDFile.FileSize = request.FilePath.Length;
            }
            _context.FileHopDongs.Add(HDFile);
            await _context.SaveChangesAsync();
            return HDFile.Id;
        }
        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            await _torageService.SaveFileAsync(file.OpenReadStream(), fileName);
            return "/" + USER_CONTENT_FOLDER_NAME + "/" + fileName;
        }
        //    public Task<int> Create(FileHopDongRequest request)
        //{
        //    throw new NotImplementedException();
        //}


        public async Task<int> Delete(int doitacID)
        {
           

                var FileHopDong = await _context.FileHopDongs.FindAsync(doitacID);
                //if (doitac == null) throw new EShopException($"Cannot find a product: {doitacID}");

                //var images = _context.ProductImages.Where(i => i.ProductId == productId);
                //foreach (var image in images)
                //{
                //    await _storageService.DeleteFileAsync(image.ImagePath);
                //}

                _context.FileHopDongs.Remove(FileHopDong);

                return await _context.SaveChangesAsync();
            }
        

        public async Task<List<FileHopDongViewModel>> GetAll()
        {

            var query = from dt in _context.FileHopDongs
                        select dt;
            var FileHopDong = await query.Select(x => new FileHopDongViewModel()
            {
                 HopDongId = x.HopDongId,
                 DateCreate = DateTime.Now,
                 Caption = x.Caption,
                 IsDefault = x.IsDefault,
                 FilePath = x.FilePath,
                 FileSize = x.FileSize,
        }).ToListAsync();

            return FileHopDong;
        }

        public  async Task<FileHopDongViewModel> GetImageById(int imageId)
        {
            var request = await _context.FileHopDongs.FindAsync(imageId);
            if (request == null)
                throw new AddException($"cannot find an image with id {imageId}");

            var viewModel = new FileHopDongViewModel()
            {
                HopDongId = request.HopDongId,
                DateCreate = DateTime.Now,
                Caption = request.Caption,
                IsDefault = request.IsDefault,
                FilePath = request.FilePath,
                FileSize = request.FileSize
            };
            return viewModel;
        }

        public async Task<int> Update(UpdetFileHopDong request)
        {
            var HDFile = await _context.FileHopDongs.FindAsync(request.id);
            if (HDFile == null) throw new AddException($"Cannot find a product with id: {request.id}");
            {
                {
                    HDFile.HopDongId = request.HopDongId;
                    HDFile.DateCreate = DateTime.Now;
                    HDFile.Caption = request.Caption;
                    HDFile.IsDefault = request.IsDefault;


                };

                if (request.FilePath != null)
                {
                    HDFile.FilePath = await this.SaveFile(request.FilePath);
                    HDFile.FileSize = request.FilePath.Length;
                }
                await _context.SaveChangesAsync();
                return HDFile.Id;
            }
        }
        //public Task<int> UpdateImage(int imageId, FileHopDongRequest request)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
