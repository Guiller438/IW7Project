using IW7PP.Data;
using IW7PP.Models.ProsthesisM;
using IW7PP.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace IW7PP.Controllers.ComponentsControllers
{
    [Authorize(Roles = "Administrador, Protesista")]
    public class ProtesistaController : Controller
    {

        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _context;
        ProsthesisController _ProsthesisMethods;

        public ProtesistaController(ApplicationDbContext context, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, ProsthesisController prosthesisMethods)
        {
            _userManager = userManager;
            _context = context;
            _roleManager = roleManager;
            _ProsthesisMethods = prosthesisMethods;
        }
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            var roles = await _userManager.GetRolesAsync(user);
            var roleName = roles.FirstOrDefault();
            ViewBag.RoleName = roleName;
            return View(user);
        }

        [HttpGet]
        public IActionResult CreateProtesisManual()
        {
            return View();
        }

        [HttpGet]

        public IActionResult SelectProsthesisCreationMethod() 
        {
            return View();
        }

        [HttpGet]
        public IActionResult SelectAmputationType(int clienteId)
        {
            ViewBag.UpperLimbAmputations = new SelectList(_context.UpperLimbAmputations, "Id", "AmputationName");
            ViewBag.LowerLimbAmputations = new SelectList(_context.LowerLimbAmputations, "Id", "AmputationName");
            ViewBag.ClienteId = clienteId;
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> SelectAmputationType(Guid? upperLimbAmputationId, Guid? lowerLimbAmputationId, int clienteId)
        {
            var cliente = await _context.ClientesProtesicos.FirstOrDefaultAsync(c => c.Id == clienteId );

            if (cliente == null)
            {
                TempData["FromSelectAmputationType"] = true;

                if (upperLimbAmputationId.HasValue && upperLimbAmputationId != Guid.Empty)
                {
                    TempData["UpperLimbAmputationId"] = upperLimbAmputationId.Value;
                }
                if (lowerLimbAmputationId.HasValue && lowerLimbAmputationId != Guid.Empty)
                {
                    TempData["LowerLimbAmputationId"] = lowerLimbAmputationId.Value;
                }

                return RedirectToAction("CreateCliente", "Cliente");
            }

            if (upperLimbAmputationId.HasValue && upperLimbAmputationId != Guid.Empty)
            {
                return RedirectToAction("GenerateUpperProsthesis", new { amputationId = upperLimbAmputationId.Value, clienteId = cliente.Id });
            }

            if (lowerLimbAmputationId.HasValue && lowerLimbAmputationId != Guid.Empty)
            {
                return RedirectToAction("GenerateLowerProsthesis", new { amputationId = lowerLimbAmputationId.Value, clienteId = cliente.Id });
            }

            // En caso de "No aplica" o ninguna selección, redirigir de nuevo o manejar según corresponda
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> GenerateUpperProsthesis(Guid amputationId, ProsthesisVM prosthesis)
        {

            if (amputationId == Guid.Empty)
            {
                return BadRequest("Amputation ID is required.");
            }

            var amputation = await _context.UpperLimbAmputations.FirstOrDefaultAsync(a => a.Id == amputationId);

            if (amputation == null)
            {
                return NotFound("Amputation not found.");
            }


            var allSockets = await _context.Sockets.ToListAsync();
            var allLiners = await _context.Liners.ToListAsync();
            var allTubes = await _context.Tubes.ToListAsync();
            var allUnionSockets = await _context.UnionSockets.ToListAsync();
            var allKneeArticulates = await _context.KneeArticulates.ToListAsync();
            var allFeet = await _context.Feet.ToListAsync();

            // Select top 3 based on durability manually
            var topSockets = new List<Socket>();
            foreach (var socket in allSockets)
            {
                if (topSockets.Count < 3)
                {
                    topSockets.Add(socket);
                }
                else
                {
                    var minDurabilitySocket = topSockets.OrderBy(s => s.Durability).First();
                    if (socket.Durability > minDurabilitySocket.Durability)
                    {
                        topSockets.Remove(minDurabilitySocket);
                        topSockets.Add(socket);
                    }
                }
            }

            var topLiners = new List<Liner>();
            foreach (var liner in allLiners)
            {
                if (topLiners.Count < 3)
                {
                    topLiners.Add(liner);
                }
                else
                {
                    var minDurabilityLiner = topLiners.OrderBy(l => l.Durability).First();
                    if (liner.Durability > minDurabilityLiner.Durability)
                    {
                        topLiners.Remove(minDurabilityLiner);
                        topLiners.Add(liner);
                    }
                }
            }

            var topTubes = new List<Tube>();
            foreach (var tube in allTubes)
            {
                if (topTubes.Count < 3)
                {
                    topTubes.Add(tube);
                }
                else
                {
                    var minDurabilityTube = topTubes.OrderBy(t => t.Durability).First();
                    if (tube.Durability > minDurabilityTube.Durability)
                    {
                        topTubes.Remove(minDurabilityTube);
                        topTubes.Add(tube);
                    }
                }
            }

            var topUnionSockets = new List<UnionSocket>();
            foreach (var unionSocket in allUnionSockets)
            {
                if (topUnionSockets.Count < 3)
                {
                    topUnionSockets.Add(unionSocket);
                }
                else
                {
                    var minDurabilityUnionSocket = topUnionSockets.OrderBy(u => u.Durability).First();
                    if (unionSocket.Durability > minDurabilityUnionSocket.Durability)
                    {
                        topUnionSockets.Remove(minDurabilityUnionSocket);
                        topUnionSockets.Add(unionSocket);
                    }
                }
            }

            var topKneeArticulates = new List<KneeArticulate>();
            foreach (var kneeArticulate in allKneeArticulates)
            {
                if (topKneeArticulates.Count < 3)
                {
                    topKneeArticulates.Add(kneeArticulate);
                }
                else
                {
                    var minDurabilityKneeArticulate = topKneeArticulates.OrderBy(k => k.Durability).First();
                    if (kneeArticulate.Durability > minDurabilityKneeArticulate.Durability)
                    {
                        topKneeArticulates.Remove(minDurabilityKneeArticulate);
                        topKneeArticulates.Add(kneeArticulate);
                    }
                }
            }

            var topFeet = new List<Foot>();
            foreach (var foot in allFeet)
            {
                if (topFeet.Count < 3)
                {
                    topFeet.Add(foot);
                }
                else
                {
                    var minDurabilityFoot = topFeet.OrderBy(f => f.Durability).First();
                    if (foot.Durability > minDurabilityFoot.Durability)
                    {
                        topFeet.Remove(minDurabilityFoot);
                        topFeet.Add(foot);
                    }
                }
            }

            var prosthesisCombinations = new List<ProsthesisVM>();

            foreach (var socket in topSockets)
            {
                foreach (var liner in topLiners)
                {
                    foreach (var tube in topTubes)
                    {
                        foreach (var unionSocket in topUnionSockets)
                        {
                            foreach (var kneeArticulate in topKneeArticulates)
                            {
                                foreach (var foot in topFeet)
                                {
                                    var userProsthesis = new ProsthesisVM
                                    {
                                        SocketId = socket.Id,
                                        LinerId = liner.Id,
                                        TubeId = tube.Id,
                                        UnionSocketId = unionSocket.Id,
                                        KneeArticulateId = kneeArticulate.Id,
                                        FootId = foot.Id,
                                        UpperLimbAmputationsiD = amputationId,
                                    };

                                    userProsthesis.Durability = CalculateDurability(userProsthesis);
                                    userProsthesis.AverageDurability = CalculateAverageDurability(userProsthesis);

                                    prosthesisCombinations.Add(userProsthesis);
                                }
                            }
                        }
                    }
                }
            }

            var bestProsthesis = prosthesisCombinations.OrderByDescending(p => p.AverageDurability).FirstOrDefault();

            if (bestProsthesis == null)
            {
                return BadRequest("No valid prosthesis could be generated.");
            }

            ViewBag.AmputationName = amputation.AmputationName;
            ViewBag.Components = new
            {
                SocketDescription = topSockets.FirstOrDefault(s => s.Id == bestProsthesis.SocketId)?.Description,
                LinerName = topLiners.FirstOrDefault(l => l.Id == bestProsthesis.LinerId)?.Name,
                TubeName = topTubes.FirstOrDefault(t => t.Id == bestProsthesis.TubeId)?.Name,
                UnionSocketDescription = topUnionSockets.FirstOrDefault(u => u.Id == bestProsthesis.UnionSocketId)?.Description,
                KneeArticulateName = topKneeArticulates.FirstOrDefault(k => k.Id == bestProsthesis.KneeArticulateId)?.Name,
                FootName = topFeet.FirstOrDefault(f => f.Id == bestProsthesis.FootId)?.Name
            };


            return View(bestProsthesis);
        }

        [HttpPost]
        public async Task<IActionResult> GenerateRecommendedProsthesis([Bind("Id,SocketId,LinerId,TubeId,FootId,UnionSocketId,KneeArticulateId,UpperLimbAmputationsiD,LowerLimbAmputationsiD,Durability,AverageDurability")] ProsthesisVM model)
        {
            if (ModelState.IsValid)
            {
                var newProsthesis = new Prosthesis
                {
                    SocketId = model.SocketId ?? 0,
                    LinerId = model.LinerId ?? 0,
                    TubeId = model.TubeId ?? 0,
                    UnionSocketId = model.UnionSocketId ?? 0,
                    KneeArticulateId = model.KneeArticulateId ?? 0,
                    FootId = model.FootId ?? 0,
                    UpperLimbAmputationsiD = model.UpperLimbAmputationsiD,
                    LowerLimbAmputationsiD = null
                };

                newProsthesis.Durability = CalculateDurability(model);
                newProsthesis.AverageDurability = CalculateAverageDurability(model);

                _context.Prostheses.Add(newProsthesis);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            // Si hay un error en el modelo, recargar la vista con los componentes correctos
            var amputation = await _context.UpperLimbAmputations.FirstOrDefaultAsync(a => a.Id == model.UpperLimbAmputationsiD);
            if (amputation != null)
            {
                ViewBag.AmputationName = amputation.AmputationName;
            }

            return View(model);
        }

        private double CalculateDurability(ProsthesisVM prosthesis)
        {
            double totalDurability = 0;

            totalDurability += _context.Sockets
                .Where(s => s.Id == prosthesis.SocketId)
                .Select(s => (double?)s.Durability)
                .FirstOrDefault() ?? 0;

            totalDurability += _context.Liners
                .Where(l => l.Id == prosthesis.LinerId)
                .Select(l => (double?)l.Durability)
                .FirstOrDefault() ?? 0;

            totalDurability += _context.Tubes
                .Where(t => t.Id == prosthesis.TubeId)
                .Select(t => (double?)t.Durability)
                .FirstOrDefault() ?? 0;

            totalDurability += _context.Feet
                .Where(f => f.Id == prosthesis.FootId)
                .Select(f => (double?)f.Durability)
                .FirstOrDefault() ?? 0;

            totalDurability += _context.UnionSockets
                .Where(u => u.Id == prosthesis.UnionSocketId)
                .Select(u => (double?)u.Durability)
                .FirstOrDefault() ?? 0;

            totalDurability += _context.KneeArticulates
                .Where(k => k.Id == prosthesis.KneeArticulateId)
                .Select(k => (double?)k.Durability)
                .FirstOrDefault() ?? 0;

            return totalDurability;
        }

        private double CalculateAverageDurability(ProsthesisVM prosthesis)
        {
            var componentCount = 0;
            double totalDurability = 0;

            void AddDurability(double? durability)
            {
                if (durability.HasValue)
                {
                    totalDurability += durability.Value;
                    componentCount++;
                }
            }

            AddDurability(_context.Sockets
                .Where(s => s.Id == prosthesis.SocketId)
                .Select(s => (double?)s.Durability)
                .FirstOrDefault());

            AddDurability(_context.Liners
                .Where(l => l.Id == prosthesis.LinerId)
                .Select(l => (double?)l.Durability)
                .FirstOrDefault());

            AddDurability(_context.Tubes
                .Where(t => t.Id == prosthesis.TubeId)
                .Select(t => (double?)t.Durability)
                .FirstOrDefault());

            AddDurability(_context.Feet
                .Where(f => f.Id == prosthesis.FootId)
                .Select(f => (double?)f.Durability)
                .FirstOrDefault());

            AddDurability(_context.UnionSockets
                .Where(u => u.Id == prosthesis.UnionSocketId)
                .Select(u => (double?)u.Durability)
                .FirstOrDefault());

            AddDurability(_context.KneeArticulates
                .Where(k => k.Id == prosthesis.KneeArticulateId)
                .Select(k => (double?)k.Durability)
                .FirstOrDefault());

            return componentCount > 0 ? totalDurability / componentCount : 0;
        }

        public async Task<IActionResult> SearchCliente(string query)
        {
            var clientes = await _context.ClientesProtesicos
                .Where(c => c.Name.Contains(query) || c.LastName.Contains(query))
                .ToListAsync();

            return PartialView("_ClienteSearchResults", clientes);
        }


    }
}
