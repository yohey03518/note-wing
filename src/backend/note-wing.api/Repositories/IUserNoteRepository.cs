using note_wing.api.Models.Domains;

namespace note_wing.api.Repositories;

public interface IUserNoteRepository
{
    void Add(UserNote userNote);
    List<UserNote> Get();
}