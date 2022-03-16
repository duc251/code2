using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLHĐSolotion.Application.FileHopdong;
using QLHĐSolotion.ViewModel.Doitac.Dtos;
using QLHĐSolotion.ViewModel.FileHopDong;

namespace QLHĐSolotion.BackEndAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileHopDongController : ControllerBase
    {
        //private readonly testDbontext _context;
        private readonly IPulicFileHopDong _FileHopDongService;
        //private readonly IDoitacService _doitacService;
        public FileHopDongController(IPulicFileHopDong FileHopDongService)/*, testDbontext context*/
        {
            //_context = context;
            _FileHopDongService = FileHopDongService;

        }
        [HttpGet]

        public async Task<IActionResult> Get()
        {
            var FileHopDong = await _FileHopDongService.GetAll();
            return Ok(FileHopDong);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromForm] FileHopDongRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var FileHopDong = await _FileHopDongService.AddImage(request);
      
            if (FileHopDong == 0)
                return BadRequest();

           
            return Ok(FileHopDong);
        }

        [HttpPut]

        public async Task<IActionResult> Update( [FromBody] UpdetFileHopDong request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //request.CtrDoiTacID = productId;
            var affectedResult = await _FileHopDongService.Update(request);
            if (affectedResult == 0)
                return BadRequest();
            return Ok(affectedResult);
        }
        [HttpDelete("{ID}")]
        //[Authorize]
        public async Task<IActionResult> Delete(int ID)
        {
            var affectedResult = await _FileHopDongService.Delete(ID);
            if (affectedResult == 0)
                return BadRequest();
            return Ok();
        }

    }
}
