﻿using AuctionsMain.Models;

namespace Auctions.Data.Services
{
    public interface IBidsService
    {
        Task Add(Bid bid);
        IQueryable<Bid> GetAll();
    }
}