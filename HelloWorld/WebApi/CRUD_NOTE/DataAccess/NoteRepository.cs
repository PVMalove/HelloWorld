using Microsoft.EntityFrameworkCore;

namespace DataAccess;


internal class NoteRepository(AppContext context) : INoteRepository
{
    public async Task CreateAsync(Note note, CancellationToken cancellationToken = default)
    {
        note.Create = DateTime.UtcNow;
        await context.Notes.AddAsync(note, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);
    }

    public async Task<Note?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        return await context.Notes.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }

    public async Task UpdateAsync(Note note, CancellationToken cancellationToken = default)
    {
        note.Update = DateTime.UtcNow;
        context.Notes.Update(note);
        await context.SaveChangesAsync(cancellationToken);
    }

    public Task DeleteAsync(Note note, CancellationToken cancellationToken = default)
    {
        context.Notes.Remove(note);
        return context.SaveChangesAsync(cancellationToken);
    }
}