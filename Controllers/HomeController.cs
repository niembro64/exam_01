using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using exam_01.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace exam_01.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;
    private MyContext _context;

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
      _logger = logger;
      _context = context;
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    public IActionResult Index()
    {
      return Redirect("/login");
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    [HttpGet("/login")]
    public IActionResult Login()
    {
      ViewBag.AllUsers = _context.Users.OrderBy(a => a.Name).ToList();
      ViewBag.AllMeetups = _context.Meetups.OrderBy(a => a.Date).ToList();
      ViewBag.Session_UserId = HttpContext.Session.GetInt32("Session_UserId");
      ViewBag.Session_Name = HttpContext.Session.GetString("Session_Name");
      return View();
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    [HttpGet("/logout")]
    public IActionResult LogOut()
    {
      // need to clear session
      HttpContext.Session.Clear();

      return Redirect("/login");
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    [HttpGet("/meetups")]
    public IActionResult Meetups()
    {
      ViewBag.AllUsers = _context.Users.OrderBy(a => a.Name).ToList();
      ViewBag.AllMeetups = _context.Meetups.OrderBy(a => a.Date).ToList();
      ViewBag.Session_UserId = HttpContext.Session.GetInt32("Session_UserId");
      ViewBag.Session_Name = HttpContext.Session.GetString("Session_Name");
      return View();
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    [HttpGet("/new")]
    public IActionResult NewMeetup()
    {
      ViewBag.AllUsers = _context.Users.OrderBy(a => a.Name).ToList();
      ViewBag.AllMeetups = _context.Meetups.OrderBy(a => a.Date).ToList();
      ViewBag.Session_UserId = HttpContext.Session.GetInt32("Session_UserId");
      ViewBag.Session_Name = HttpContext.Session.GetString("Session_Name");
      return View();
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    [HttpPost("meetups/add")]
    public IActionResult AddMeetup(Meetup newMeetup)
    {
      if (ModelState.IsValid)
      {
        _context.Meetups.Add(newMeetup);
        _context.SaveChanges();

        ViewBag.AllUsers = _context.Users.OrderBy(a => a.Name).ToList();
        ViewBag.AllMeetups = _context.Meetups.OrderBy(a => a.Date).ToList();
        ViewBag.Session_UserId = HttpContext.Session.GetInt32("Session_UserId");
        ViewBag.Session_Name = HttpContext.Session.GetString("Session_Name");

        return RedirectToAction("Meetups");
      }
      else
      {
        ViewBag.AllUsers = _context.Users.OrderBy(a => a.Name).ToList();
        ViewBag.AllMeetups = _context.Meetups.OrderBy(a => a.Date).ToList();
        ViewBag.Session_UserId = HttpContext.Session.GetInt32("Session_UserId");
        ViewBag.Session_Name = HttpContext.Session.GetString("Session_Name");
        return View("MewMeetup");
      }
    }
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// 
    [HttpPost("users/login")]
    public IActionResult LogUser(LoginUser loggedIn)
    {
      Console.WriteLine("--------------------------LogUser");
      if (ModelState.IsValid)
      {
        Console.WriteLine("--------------------------ModelStateIsValid");
        User userInDb = _context.Users.FirstOrDefault(a => a.Email == loggedIn.LoginEmail);
        if (userInDb == null)
        {
          Console.WriteLine("--------------------------== null");
          ModelState.AddModelError("LoginEmail", "Invalid login attempt");
          return View("Login");
        }
        Console.WriteLine("--------------------------Hashing Passwords");
        var hasher = new PasswordHasher<LoginUser>();
        var result = hasher.VerifyHashedPassword(loggedIn, userInDb.Password, loggedIn.LoginPassword);
        if (result == 0)
        {
          Console.WriteLine("--------------------------result == 0");
          ModelState.AddModelError("LoginEmail", "Invalid login attempt");
          return View("Login");
        }
        Console.WriteLine("--------------------------Redirecting to Meetups");

        HttpContext.Session.SetString("Session_Name", userInDb.Name);
        HttpContext.Session.SetInt32("Session_UserId", userInDb.UserId);
        return RedirectToAction("Meetups");
      }
      Console.WriteLine("--------------------------ModelState Invalid");

      return View("Login");

    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    [HttpPost("users/add")]
    public IActionResult AddUser(User newUser)
    {
      if (ModelState.IsValid)
      {

        // Duplicate Emails
        if (_context.Users.Any(s => s.Email == newUser.Email))
        {
          ModelState.AddModelError("Email", "This email already in use.");
          return View("Login");
        }

        // Hash Pass
        PasswordHasher<User> Hasher = new PasswordHasher<User>();
        newUser.Password = Hasher.HashPassword(newUser, newUser.Password);

        _context.Users.Add(newUser);
        _context.SaveChanges();

        HttpContext.Session.SetString("Session_Name", newUser.Name);
        HttpContext.Session.SetInt32("Session_UserId", newUser.UserId);
        return RedirectToAction("Meetups");
      }
      else
      {
        return View("Login");
      }
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
