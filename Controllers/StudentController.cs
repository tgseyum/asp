using System.Diagnostics;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;
using studentmvc.Models;

namespace studentmvc.Controllers;

public class StudentController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Details()
    {
        return View();
    }
}