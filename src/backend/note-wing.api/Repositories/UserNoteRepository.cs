using note_wing.api.Models.Domains;

namespace note_wing.api.Repositories;

public class UserNoteRepository: IUserNoteRepository
{
    private static readonly List<UserNote> UserNotes = [];
    public void Add(UserNote userNote)
    {
        UserNotes.Add(userNote);
    }

    public List<UserNote> Get()
    {
        return UserNotes;
    }
}