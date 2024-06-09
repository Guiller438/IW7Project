using IW7PP.Data;
using IW7PP.Models.Cliente;
using IW7PP.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace IW7PP.Controllers.Cliente
{
    public class ClienteController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LifeStyleController _LifeStyle; 

        public ClienteController(ApplicationDbContext context,LifeStyleController lifestyle )
        {
            _context = context;
            _LifeStyle = lifestyle;
        }
        public IActionResult Index()
        {
            var clienteList = _context.ClientesProtesicos
                    .Include(p => p.Prosthesis)
                    .Include(p => p.LifeStyle)
                    .ToList();

            return View(clienteList);
        }

        public IActionResult LifeStyleView()
        {
            return _LifeStyle.Lifestyleview();
        }

        [HttpGet]

        public IActionResult CreateCliente()
        {
            if (TempData["LifeStyleId"] == null)
            {
                return RedirectToAction("AssignLifestyle"); // Si el estilo de vida no se ha asignado, redirigir a AssignLifestyle
            }

            var model = new ClienteVM
            {
                LifeStyleId = TempData["LifeStyleId"] != null ? (int)TempData["LifeStyleId"] : 0
            };

            ViewData["ProsthesisId"] = new SelectList(_context.Prostheses, "Id", "Id");
            ViewData["LifeStyleId"] = new SelectList(_context.LifeStyles, "Id", "Description");

            return View(model);
        }

        [HttpPost]

        public async Task<IActionResult> CreateCliente([Bind("Id, Name, LastName, PhoneNumber, ProtesisId, LifeStyleId ")] ClienteVM cliente) 
        {


            if (ModelState.IsValid)
            {
                // Verificar si ya existe un cliente con el mismo ProtesisId
                bool exists = _context.ClientesProtesicos.Any(c => c.ProtesisId == cliente.ProtesisId);
                if (exists)
                {
                    ModelState.AddModelError("ProtesisId", "Ya existe un cliente con esta prótesis.");
                    ViewData["ProsthesisId"] = new SelectList(_context.Prostheses, "Id", "Id");
                    ViewData["LifeStyleId"] = new SelectList(_context.LifeStyles, "Id", "Description");
                    return View(cliente);
                }

                var clienteNuevo = new ClientesProtesicos
                {
                    Name = cliente.Name,
                    LastName = cliente.LastName,
                    PhoneNumber = cliente.PhoneNumber,
                    ProtesisId = cliente.ProtesisId,
                    LifeStyleId = cliente.LifeStyleId,
                };

                _context.ClientesProtesicos.Add(clienteNuevo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Cliente");
            }
            else
            {
                ViewData["ProsthesisId"] = new SelectList(_context.Prostheses, "Id", "Id");
                ViewData["LifeStyleId"] = new SelectList(_context.LifeStyles, "Id", "Description");
                return View(cliente);
            }
        }

        //Delete
        [HttpPost]
        public async Task<IActionResult> DeleteCliente(int id)
        {
            var cliente = _context.ClientesProtesicos.FirstOrDefault(a => a.Id == id);
            if (cliente == null)
            {
                return RedirectToAction("Index", "Cliente");
            }
            else
            {
                _context.ClientesProtesicos.Remove(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Cliente");
            }

        }

        // Assign Lifestyle based on questions
        [HttpGet]
        public IActionResult AssignLifestyle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AssignLifestyle(int score)
        {
            var lifeStyleId = _LifeStyle.AssignLifestyle(score);
            TempData["LifeStyleId"] = lifeStyleId;
            return RedirectToAction("CreateCliente");
        }

    }
}
