using SmartPad.Models;

namespace SmartPad.Data;

public interface IActiveNoteRepository
{
    Task<IEnumerable<ActiveNote>> GetAllAsync();
    Task<ActiveNote> GetByIdAsync(int id);
    Task AddAsync(ActiveNote note);
    Task UpdateAsync(ActiveNote note);
    Task DeleteAsync(ActiveNote note);
    Task DeleteAllAsync();
}