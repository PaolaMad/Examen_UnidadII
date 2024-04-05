using examenUnidadII_backend.Database;
using examenUnidadII_backend.Dto;
using examenUnidadII_backend.Dto.Resultados;

namespace examenUnidadII_backend.Services
{
    public class ImcServices: IImcServices
    {
        private readonly ImcListDbContext _Context;

        public ImcServices(
            ImcListDbContext context
            ) 
        {
            _Context = context;
        }

        public ImcListDbContext ImcListDbContext { get; }

        public async Datos<ResponseDto<ImcDto>> CreateAsync(ImcCreateDto model)
        {
            return new ResponseDto<ImcDto> 
            {
                
            }
        }


    }
}
