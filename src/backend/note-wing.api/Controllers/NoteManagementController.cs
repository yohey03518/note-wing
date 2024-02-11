using Microsoft.AspNetCore.Mvc;
using note_wing.api.Models.NoteManagement;

namespace note_wing.api.Controllers;

[Route("api")]
public class NoteManagementController: ControllerBase
{
    [HttpPost("v1/note")]
    public IActionResult Add([FromBody] NewNoteRequest request)
    {
        return Ok();
    }
}