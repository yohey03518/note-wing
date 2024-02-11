namespace note_wing.api.Models.NoteManagement;

public class NewNoteRequest
{
    public int NoteType { get; set; }
    public string? Content { get; set; }
}