﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIGateway.ModelsDTO;
using ModelsDTO.Rentals;

namespace APIGateway.Domain
{

    public interface IRentalsService
    {
        Task<List<RentalResponse>?> GetAllAsync(string username);
        Task<RentalResponse> GetAsyncByUid(string username, Guid rentalUid);
        Task<CreateRentalResponse> RentCar(string username, CreateRentalRequest request);
        Task FinishRent(string username, Guid rentalUid);
        Task CancelRent(string username, Guid rentalUid);
    }
}
