using System.ComponentModel.DataAnnotations;

namespace note_wing.api.Models.NoteManagement;

public class NewNoteRequest
{
    public int NoteType { get; set; }
    [Required]
    public string? Content { get; set; }
}