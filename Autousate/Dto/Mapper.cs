using Autousate.Data;
using Autousate.Dto;

namespace Autousate.Dto {
    public class Mapper
    {
        public ClienteDto MapBaseEntityToDto(Cliente entity)
        {
            ClienteDto dto = new ClienteDto()
            {
                Id = entity.Id,
                Nome = entity.Nome,
                Cognome = entity.Cognome,
                IdConcessionaria = entity.IdConcessionaria,
                Email = entity.Email,
                Password = entity.Password,

            };
            return dto;
        }
        public ClienteDto MapEntityToDto(Cliente entity)
        {
            ClienteDto dto = MapBaseEntityToDto(entity);

            return dto;
        }

        public Cliente MapDtoToEntity(ClienteDto dto)
        {
            Cliente entity = new Cliente()
            {
                Id = dto.Id,
                Nome = dto.Nome,
                Cognome = dto.Cognome,
                IdConcessionaria= dto.IdConcessionaria,
                Email= dto.Email,
                Password = dto.Password


            };
            return entity;
        }

        public AutoDto MapAutoBaseEntityToDto(Auto entity)
        {
            AutoDto dto = new AutoDto()
            {
                IdAuto = entity.IdAuto,
                IdCliente = entity.IdCliente,
                Produttore = entity.Produttore,
                Modello = entity.Modello,
                DataPrimaImmatricolazione = entity.DataPrimaImmatricolazione,
                NumeroKm = entity.NumeroKm,
                Prezzo = entity.Prezzo,
            };
            return dto;
        }

        public AutoDto MapEntityToDto(Auto entity)
        {
            AutoDto dto = MapAutoBaseEntityToDto(entity);

            return dto;
        }
        public ConcessionariaDto MapCaBaseEntityToDto(Concessionaria entity)
        {
            ConcessionariaDto dto = new ConcessionariaDto()
            {
                IdConcessionaria = entity.IdConcessionaria,
                Nome = entity.Nome,
            };
            return dto;
        }
        public ConcessionariaDto MapCaEntityToDto(Concessionaria entity)
        {
            ConcessionariaDto dto = MapCaBaseEntityToDto(entity);
            return dto;
        }
        public Auto MapDtoToEntity(AutoDto dto)
        {
            return new Auto
            {
               
                Produttore = dto.Produttore,
                Modello = dto.Modello,
                NumeroKm = dto.NumeroKm,
                Prezzo = dto.Prezzo,
                IdCliente = dto.IdCliente,
                Targa = dto.Targa,
                
            };
        }

    }
        }
        