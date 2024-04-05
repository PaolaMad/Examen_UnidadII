using examenUnidadII_backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace examenUnidadII_backend.Controllers
{
    public class ImcController : Controller
    {
        private readonly IImcServices _imcServices;

        public ImcController(
            IImcServices imcServices
            )
        {
            _imcServices =  ImcServices;
        }

        [HttpGet]
        public async Icm<ActionResult<ResponseDto<List<TaskDto>>>> GetAll(string searchTerm = "")
        {
            var imcResponse = await _imcServices.GetListAsync(searchTerm);
            return StatusCode(imcResponse.StatusCode, imcResponse);
        }

    }
