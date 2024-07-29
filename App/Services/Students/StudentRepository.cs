using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InscripcionesU.Models;
using InscripcionesU.Context;
using InscripcionesU.App.Services;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;

namespace InscripcionesU.App.Services
{
    public class StudentRepository : IStudentRepository
    {
        public readonly InscripcionesContext _context;

        public StudentRepository(InscripcionesContext context)
        {
            _context = context;
        }
/* 
        public Task<AuthenticationProperties> ConfigureExternakAuthenticationProperties(string provider, string redirectUrl)
        {
            var properties = new AuthenticationProperties {RedirectUri = redirectUrl};
            return Task.FromResult(properties);

        }

        public async Task<IEnumerable<Claim>> HandleExternalLogin()
        {
            // Autentica al usuario utilizando el esquema de cookies
            var result = await 
            _context.HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            // Extrae las reclamaciones del usuario autenticado (como el correo electrónico, el nombre, etc.)
            var claims = result.Principal.Identities
            .FirstOrDefault()?.Claims.Select(claim => new
            {
                claim.Issuer, // Emisor de la reclamación (Google en este caso)
                claim.OriginalIssuer, // Emisor original de la reclamación
                claim.Type, // Tipo de reclamación (por ejemplo, nombre, correo electrónico)
                claim.Value // Valor de la reclamación
            });
            return claims;
            
        } */
    }
}