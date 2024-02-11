using Microsoft.AspNetCore.Mvc;

namespace note_wing.api.Controllers;

public class TempPageController : Controller
{
    public IActionResult NoteManagement()
    {
        return View();
    }
}