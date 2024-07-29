using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using InscripcionesU.App.Services;
using InscripcionesU.Models;
using InscripcionesU.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using System.Diagnostics;

namespace  InscripcionesU.Controllers{
    public class AccessController : Controller{
        private readonly IStudentRepository _studentRepository;

        public AccessController(IStudentRepository studentRepository){
            _studentRepository = studentRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        // Acción para iniciar el proceso de autenticación con Google
        public IActionResult GoogleLogin()
        {
            // Configura las propiedades de autenticación, estableciendo la redirección al método GoogleResponse después de la autenticación
            var properties = new AuthenticationProperties { RedirectUri = Url.Action("GoogleResponse") };
            // Inicia el desafío de autenticación con Google, utilizando las propiedades configuradas
            return Challenge(properties, GoogleDefaults.AuthenticationScheme);
        }

        // Acción para manejar la respuesta de Google después de la autenticación
        public async Task<IActionResult> GoogleResponse()
        {
            // Intenta autenticar al usuario utilizando el esquema de cookies
            // Esto verifica si el usuario ya ha sido autenticado y tiene una cookie válida
            var result = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            /* Verificar si se autentico correctamente */
            if(result.Succeeded){
                return RedirectToAction("Index", "Home");
            }
            else{
                return RedirectToAction("Index", "Access");
            }
        }
        
        public async Task<IActionResult> LogOut(){
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Access");
        }

    }

}