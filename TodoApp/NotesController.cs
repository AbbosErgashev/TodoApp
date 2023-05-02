using TodoListApp.Persistence;
using Microsoft.AspNetCore.Mvc;
using TodoListApp.Models;

namespace TodoListApp.Controllers;

public class NotesController : Controller
{
    private readonly ApplicationDbContext _db;

    public NotesController(ApplicationDbContext db)
    {
        this._db = db;
    }
    public IActionResult Index()
    {
        ViewBag.Notes = _db.Notes;
        return View();
    }
    
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Create(Note note)
    {
        _db.Notes.Add(note);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
}