using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuemPagaQuanto.Models;
using System.Security.Claims;

namespace QuemPagaQuanto.Controllers
{
    public class AuthController : Controller
    {
        private readonly AppDbContext _context;

        public AuthController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([Bind("Email,Senha")] LoginPayload login)
        {
            var dados = await _context.Usuarios.FirstOrDefaultAsync((u) => u.Email == login.Email);

            if (dados == null)
            {
                ViewBag.Message = "Usuário e/ou senha inválidos";
                return View();
            }

            bool senhaOk = BCrypt.Net.BCrypt.Verify(login.Senha, dados.Senha);

            if (!senhaOk)
            {
                ViewBag.Message = "Usuário e/ou senha inválidos";
                return View();
            }

            // Credenciais do login.
            var claims = new List<Claim>
            {
                new (ClaimTypes.Name, dados.Nome),
                new (ClaimTypes.NameIdentifier, dados.Id.ToString()),
                new (ClaimTypes.Role, dados.Perfil.ToString()),
            };

            var usuarioIdentity = new ClaimsIdentity(claims, "login");
            var principal = new ClaimsPrincipal(usuarioIdentity);

            // Propridades realacionadas a sessão do usuário.
            var props = new AuthenticationProperties
            {
                AllowRefresh = true,
                ExpiresUtc = DateTime.UtcNow.ToLocalTime().AddHours(8),
                IsPersistent = true,
            };

            await HttpContext.SignInAsync(principal, props);
            return RedirectToAction("Index", "Grupos");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register([Bind("Id,Nome,Email,Senha,ConfirmarSenha")] UsuarioPayload usuario)
        {
            usuario.Perfil = Perfil.Usuario;

            if (ModelState.IsValid)
            {
                usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);
                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return Redirect("/Auth/Login");
            }

            return View();
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login", "Auth");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
