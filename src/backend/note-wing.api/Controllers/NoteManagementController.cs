using Microsoft.AspNetCore.Mvc;
using note_wing.api.Models.Domains;
using note_wing.api.Models.NoteManagement;
using note_wing.api.Repositories;

namespace note_wing.api.Controllers;

[Route("api")]
public class NoteManagementController(IUserNoteRepository userNoteRepository) : ControllerBase
{
    [HttpPost("v1/note")]
    public IActionResult Add([FromBody] NewNoteRequest request)
    {
        if (ModelState.IsValid)
        {
            userNoteRepository.Add(new UserNote
            {
                TypeId = request.NoteType,
                Content = request.Content
            });

            return Ok();
        }

        return BadRequest();
    }
    
    [HttpGet("v1/note")]
    public IActionResult Get()
    {
        var notes = userNoteRepository.Get();
        return Ok(notes);
    }
}