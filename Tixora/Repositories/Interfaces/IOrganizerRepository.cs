using Microsoft.AspNetCore.Mvc.Rendering;
using Tixora.Models;

namespace Tixora.Repositories.Interfaces
{
    public interface IOrganizerRepository : IRepository<Organizer>
    {
        Task<Organizer> GetById(int id);
        Task<List<Organizer>> GetAll();
        Task Delete(int id);
        public List<SelectListItem> GetOrganizers();
    }
}
