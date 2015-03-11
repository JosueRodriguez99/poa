using Application.Poa.Dto;

namespace Application.Poa.Mappers
{
    public static class PoaMapper
    {
        public static Domain.Poa.Poa ToEntity(this PoaDto dto)
        {
            var poa = new Domain.Poa.Poa();
            poa.Id = dto.Id;
 
            return poa;
        }
    }
}
