using DataAccess;

namespace BisinessLogic;

public class NoteService(INoteRepository NoteRepository) : INoteService
{
    public async Task CreateAsync(string text, CancellationToken cancellationToken = default)
    {
        var note = new Note
        {
            Text = text
        };
        await NoteRepository.CreateAsync(note, cancellationToken);
    }

    public async Task<string> GetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        var note = await NoteRepository.GetByIdAsync(id, cancellationToken);
        if (note is null)
            throw new Exception("Note not found");
        
        return note.Text;
    }

    public async Task UpdateAsync(int id, string newText, CancellationToken cancellationToken = default)
    {
        var note = await NoteRepository.GetByIdAsync(id, cancellationToken);
        if (note is null)
            throw new Exception("Note not found");
        
        note.Text = newText;
        await NoteRepository.UpdateAsync(note, cancellationToken);
    }
    
    public async Task DeleteAsync(int id, CancellationToken cancellationToken = default)
    {
        var note = await NoteRepository.GetByIdAsync(id, cancellationToken);
        if (note is null)
            throw new Exception("Note not found");
        
        await NoteRepository.DeleteAsync(note, cancellationToken);
    }
}