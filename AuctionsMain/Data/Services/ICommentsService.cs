using AuctionsMain.Models;

namespace AuctionsMain.Data.Services;

public interface ICommentsService
{
    Task Add(Comment  comment);
}