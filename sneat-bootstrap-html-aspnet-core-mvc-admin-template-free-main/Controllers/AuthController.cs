using Microsoft.AspNetCore.Mvc;
using AspnetCoreMvcFull.Models;
using AspnetCoreMvcFull.Data;
using System.Threading.Tasks;

namespace AspnetCoreMvcFull.Controllers
{
  public class AuthController : Controller
  {
    private readonly ApplicationDbContext _context;

    public AuthController(ApplicationDbContext context)
    {
      _context = context;
    }

    public IActionResult ForgotPasswordBasic() => View();
    public IActionResult LoginBasic() => View();

    public IActionResult RegisterBasic()
    {
      return View();
    }

    // Existing POST method for handling form submission
    [HttpPost]
    public async Task<IActionResult> RegisterBasic(UserRegistration userRegistration)
    {
      if (ModelState.IsValid)
      {
        _context.UserRegistrations.Add(userRegistration);
        await _context.SaveChangesAsync();
        return RedirectToAction("LoginBasic"); // Redirect upon successful registration
      }
      return View(userRegistration); // Return view with validation errors
    }
  }
}
