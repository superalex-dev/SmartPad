using Microsoft.EntityFrameworkCore;
using SmartPad.Models;

namespace SmartPad.Data;

public class ActiveNoteRepository : IActiveNoteRepository
{
    private readonly NotesContext _context;

    public ActiveNoteRepository(NotesContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<ActiveNote>> GetAllAsync()
    {
        return await _context.ActiveNotes.ToListAsync();
    }

    public async Task<ActiveNote> GetByIdAsync(int id)
    {
        return await _context.ActiveNotes.FindAsync(id);
    }

    public async Task AddAsync(ActiveNote note)
    {
        _context.ActiveNotes.Add(note);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(ActiveNote note)
    {
        _context.ActiveNotes.Update(note);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(ActiveNote note)
    {
        _context.ActiveNotes.Remove(note);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAllAsync()
    {
        _context.ActiveNotes.RemoveRange(_context.ActiveNotes);
        await _context.SaveChangesAsync();
    }
}