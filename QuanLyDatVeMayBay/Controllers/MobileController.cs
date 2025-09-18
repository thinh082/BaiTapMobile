using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanLyDatVeMayBay.Models.Entities;

namespace QuanLyDatVeMayBay.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MobileController : ControllerBase
    {
        private readonly ThinhContext _context;
        public MobileController(ThinhContext context)
        {
            _context = context;
        }
        [HttpGet("LabI")]
        public async Task<IActionResult> LabI()
        {
            var data = _context.IThucHanhs.ToList();
            return Ok(data);
        }
        [HttpGet("LabII")]
        public async Task<IActionResult> LabII()
        {
            var data = _context.IiThucHanhs.ToList();
            return Ok(data);
        }
        [HttpGet("LabIII")]
        public async Task<IActionResult> LabIII()
        {
            var data = _context.IiiThucHanhs.ToList();
            return Ok(data);
        }
        [HttpPost("ThemLabIII")]
        public async Task<IActionResult> ThemLabIII(IiiThucHanh model)
        {
            _context.IiiThucHanhs.Add(model);
            _context.SaveChanges();
            return Ok(model);
        }
        [HttpPost("SuaLabIII")]
        public async Task<IActionResult> SuaLabIII([FromBody] IiiThucHanh model)
        {
            if (model == null || model.Id == 0)
                return BadRequest("Id không hợp lệ");

            var existingRecord = await _context.IiiThucHanhs
                                               .FirstOrDefaultAsync(x => x.Id == model.Id);
            if (existingRecord == null)
                return NotFound("Không tìm thấy bản ghi");

            // Gán giá trị mới
            existingRecord.Mssv = model.Mssv;
            existingRecord.Ten = model.Ten;
            existingRecord.SoDienThoai = model.SoDienThoai;

            await _context.SaveChangesAsync();
            return Ok(existingRecord);
        }
        [HttpPost("XoaLabIII")]
        public async Task<IActionResult> XoaLabIII(int id)
        {
            if (id == 0)
            {
                return BadRequest("Id khong hop le");
            }
            var existingRecord = _context.IiiThucHanhs.FirstOrDefault(x => x.Id == id);
            if (existingRecord == null)
            {
                return NotFound("Khong tim thay ban ghi");
            }
            _context.IiiThucHanhs.Remove(existingRecord);
            _context.SaveChanges();
            return Ok("Xoa thanh cong");
        }
    }
}
