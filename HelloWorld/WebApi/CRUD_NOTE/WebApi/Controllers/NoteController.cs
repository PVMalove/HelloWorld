using BisinessLogic;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("Note")]
public class NoteController(INoteService noteService) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateNoteAsync(string text, CancellationToken cancellationToken = default)
    {
        await noteService.CreateAsync(text, cancellationToken);
        return NoContent();
    }
    
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetNoteAsync(int id, CancellationToken cancellationToken = default)
    {
        var result = await noteService.GetByIdAsync(id, cancellationToken);
        return Ok(result);
    }
    
    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateNoteAsync(int id, string newText, CancellationToken cancellationToken = default)
    {
        await noteService.UpdateAsync(id, newText, cancellationToken);
        return NoContent();
    }
    
    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteNoteAsync(int id, CancellationToken cancellationToken = default)
    {
        await noteService.DeleteAsync(id, cancellationToken);
        return NoContent();
    }
}