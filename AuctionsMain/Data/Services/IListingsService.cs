﻿using AuctionsMain.Models;

namespace AuctionsMain.Data.Services
{
    public interface IListingsService
    {
        IQueryable<Listing> GetAll();
        Task Add(Listing listing);
        Task<Listing> GetById(int? id);
    }
}