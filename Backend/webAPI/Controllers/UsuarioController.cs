﻿using Microsoft.AspNetCore.Mvc;
using System.Web.Http;

namespace webAPI.Controllers
{
    public class UsuarioController : ApiController
    {
        private readonly AppDbContext _context;

        public UsuariosController(AppDbContext context)
        {
            _context = context;
        }
        
        // GET: api/Usuarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuarios()
        {
            return await _context.Usuarios.ToListAsync();
        }
    }
    //GET, POST, PUT, DELETE
}
