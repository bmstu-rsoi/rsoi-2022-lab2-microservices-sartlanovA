using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIGateway.ModelsDTO;
using ModelsDTO.Rentals;
using ModelsDTO.Cars;

namespace APIGateway
{

    public interface IRentalsRepository
    {
        Task<List<RentalsDTO>?> GetAllAsyncByUsername(string username);
        Task<RentalsDTO> GetAsyncByUsernameAndRentalUid(string username, Guid rentalUid);
        Task<RentalsDTO> CreateAsync(RentalsDTO rentalDTO);
        Task ProcessRent(string username, Guid rentalUid, string status);
    }
}
