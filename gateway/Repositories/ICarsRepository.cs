using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModelsDTO.Cars;

namespace APIGateway
{

    public interface ICarsRepository
    {
        Task<PaginationCarResponse> GetAllAsync(int page, int size, bool showAll);
        Task<CarResponse> GetAsyncByUid(Guid carUid);
        Task<CarResponse> ReserveCar(Guid carUid, bool availability);
    }
}
