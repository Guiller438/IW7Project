<<<<<<< HEAD
﻿    using IW7PP.Data;
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

                TempData.Clear();

                var cliente = await _context.ClientesProtesicos.FirstOrDefaultAsync(c => c.Id == clienteId);

                if (cliente == null)
                {
                    // Establecer indicador en TempData para redirección desde selección de tipo de amputación
                    TempData["FromSelectAmputationType"] = true;

                    // Guardar los IDs de amputación en TempData si están presentes
                    if (upperLimbAmputationId.HasValue && upperLimbAmputationId != Guid.Empty)
                    {
                        TempData["UpperLimbAmputationId"] = upperLimbAmputationId.Value;
                    }

                    if (lowerLimbAmputationId.HasValue && lowerLimbAmputationId != Guid.Empty)
                    {
                        TempData["LowerLimbAmputationId"] = lowerLimbAmputationId.Value;
                    }

                    // Redirigir a la acción de creación de cliente
                    return RedirectToAction("CreateCliente", "Cliente");
                }

                // Redirigir a la generación de prótesis de miembro superior si se proporciona el ID correspondiente
                if (upperLimbAmputationId.HasValue && upperLimbAmputationId != Guid.Empty)
                {
                    TempData["ClientId"] = cliente.Id;
                    return RedirectToAction("GenerateUpperProsthesis", new { amputationId = upperLimbAmputationId.Value, clienteId = cliente.Id });
                    
                }

                // Redirigir a la generación de prótesis de miembro inferior si se proporciona el ID correspondiente
                if (lowerLimbAmputationId.HasValue && lowerLimbAmputationId != Guid.Empty)
                {
                    TempData["ClientId"] = cliente.Id;
                    return RedirectToAction("GenerateLowerProsthesis", new { amputationId = lowerLimbAmputationId.Value, clienteId = cliente.Id });
                }

                // En caso de "No aplica" o ninguna selección, redirigir de nuevo o manejar según corresponda
                return RedirectToAction("Index");
            }

        [HttpGet]
        public async Task<IActionResult> GenerateUpperProsthesis(Guid amputationId, ProsthesisVM prosthesis)
        {
=======
﻿using IW7PP.Data;
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

            TempData.Clear();

            var cliente = await _context.ClientesProtesicos.FirstOrDefaultAsync(c => c.Id == clienteId);

            if (cliente == null)
            {
                // Establecer indicador en TempData para redirección desde selección de tipo de amputación
                TempData["FromSelectAmputationType"] = true;

                // Guardar los IDs de amputación en TempData si están presentes
                if (upperLimbAmputationId.HasValue && upperLimbAmputationId != Guid.Empty)
                {
                    TempData["UpperLimbAmputationId"] = upperLimbAmputationId.Value;
                }

                if (lowerLimbAmputationId.HasValue && lowerLimbAmputationId != Guid.Empty)
                {
                    TempData["LowerLimbAmputationId"] = lowerLimbAmputationId.Value;
                }

                // Redirigir a la acción de creación de cliente
                return RedirectToAction("CreateCliente", "Cliente");
            }

            // Redirigir a la generación de prótesis de miembro superior si se proporciona el ID correspondiente
            if (upperLimbAmputationId.HasValue && upperLimbAmputationId != Guid.Empty)
            {
                TempData["ClientId"] = cliente.Id;
                return RedirectToAction("GenerateUpperProsthesis", new { amputationId = upperLimbAmputationId.Value, clienteId = cliente.Id });
                    
            }

            // Redirigir a la generación de prótesis de miembro inferior si se proporciona el ID correspondiente
            if (lowerLimbAmputationId.HasValue && lowerLimbAmputationId != Guid.Empty)
            {
                TempData["ClientId"] = cliente.Id;
                return RedirectToAction("GenerateLowerProsthesis", new { amputationId = lowerLimbAmputationId.Value, clienteId = cliente.Id });
            }

            // En caso de "No aplica" o ninguna selección, redirigir de nuevo o manejar según corresponda
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> GenerateUpperProsthesis(Guid amputationId, ProsthesisVM prosthesis)
        {

>>>>>>> dd4246d5aaf16d5e50bee8b9cc5513e6243ce7c4
            if (amputationId == Guid.Empty)
            {
                return BadRequest("Amputation ID is required.");
            }

            var amputation = await _context.UpperLimbAmputations.FirstOrDefaultAsync(a => a.Id == amputationId);

<<<<<<< HEAD
=======


>>>>>>> dd4246d5aaf16d5e50bee8b9cc5513e6243ce7c4
            if (amputation == null)
            {
                return NotFound("Amputation not found.");
            }

            var amputationName = amputation.AmputationName;

<<<<<<< HEAD
            var allSockets = await _context.Sockets.OrderByDescending(s => s.Durability).Take(3).ToListAsync();
            var allLiners = await _context.Liners.OrderByDescending(l => l.Durability).Take(3).ToListAsync();
            var allTubes = await _context.Tubes.OrderByDescending(t => t.Durability).Take(3).ToListAsync();
            var allUnionSockets = await _context.UnionSockets.OrderByDescending(u => u.Durability).Take(3).ToListAsync();
            var allKneeArticulates = await _context.KneeArticulates.OrderByDescending(k => k.Durability).Take(3).ToListAsync();
            var allFeet = await _context.Feet.OrderByDescending(f => f.Durability).Take(3).ToListAsync();

            var prosthesisCombinations = new List<ProsthesisVM>();

            if (amputationName == "Transradial" || amputationName == "Hand Partial" || amputationName == "Elbow Disarticulation")
            {
                foreach (var socket in allSockets)
                {
                    foreach (var liner in allLiners)
                    {
                        foreach (var unionSocket in allUnionSockets)
                        {
                            var userProsthesis = new ProsthesisVM
                            {
                                SocketId = socket.Id,
                                LinerId = liner.Id,
                                TubeId = null,
                                UnionSocketId = unionSocket.Id,
                                KneeArticulateId = null,
                                FootId = null,
                                UpperLimbAmputationsiD = amputationId,
                            };

                            userProsthesis.Durability = CalculateDurability(userProsthesis);
                            userProsthesis.AverageDurability = await CalculateAverageDurability(userProsthesis);

                            prosthesisCombinations.Add(userProsthesis);
=======
            var allSockets = await _context.Sockets.ToListAsync();
            var allLiners = await _context.Liners.ToListAsync();
            var allTubes = await _context.Tubes.ToListAsync();
            var allUnionSockets = await _context.UnionSockets.ToListAsync();
            var allKneeArticulates = await _context.KneeArticulates.ToListAsync();
            var allFeet = await _context.Feet.ToListAsync();

            //Lista de componentes

            var topSockets = new List<Socket>();
            var topLiners = new List<Liner>();
            var topTubes = new List<Tube>();
            var topUnionSockets = new List<UnionSocket>();
            var topKneeArticulates = new List<KneeArticulate>();
            var topFeet = new List<Foot>();

            if (amputationName == "Transradial" || amputationName == "Hand Partial" || amputationName == "Elbow Disarticulation" )
            {
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
>>>>>>> dd4246d5aaf16d5e50bee8b9cc5513e6243ce7c4
                        }
                    }
                }
            }
<<<<<<< HEAD
            else if (amputationName == "Finger Partial" || amputationName == "Wrist Disarticulation" || amputationName == "Finger Complete")
            {
                foreach (var socket in allSockets)
                {
                    foreach (var liner in allLiners)
                    {
                        var userProsthesis = new ProsthesisVM
                        {
                            SocketId = socket.Id,
                            LinerId = liner.Id,
                            TubeId = null,
                            UnionSocketId = null,
                            KneeArticulateId = null,
                            FootId = null,
                            UpperLimbAmputationsiD = amputationId,
                        };

                        userProsthesis.Durability = CalculateDurability(userProsthesis);
                        userProsthesis.AverageDurability = await CalculateAverageDurability(userProsthesis);

                        prosthesisCombinations.Add(userProsthesis);
=======
            else if(amputationName == "Finger Partial" || amputationName == "Wrist Disarticulation" || amputationName == "Finger Complete")
            {
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
>>>>>>> dd4246d5aaf16d5e50bee8b9cc5513e6243ce7c4
                    }
                }
            }
            else
            {
                return BadRequest("No valid combination exists for the specified amputation type.");
<<<<<<< HEAD
=======

            }


            var prosthesisCombinations = new List<ProsthesisVM>();

            // Generar combinaciones solo con los componentes seleccionados y dejar los demás en null
            foreach (var socket in topSockets)
            {
                foreach (var liner in topLiners)
                {
                    var userProsthesis = new ProsthesisVM
                    {
                        SocketId = socket.Id,
                        LinerId = liner.Id,
                        TubeId = topTubes.Any() ? topTubes.First().Id : (int?)null,
                        UnionSocketId = topUnionSockets.Any() ? topUnionSockets.First().Id : (int?)null,
                        KneeArticulateId = topKneeArticulates.Any() ? topKneeArticulates.First().Id : (int?)null,
                        FootId = topFeet.Any() ? topFeet.First().Id : (int?)null,
                        UpperLimbAmputationsiD = amputationId,
                    };

                    userProsthesis.Durability = CalculateDurability(userProsthesis);
                    userProsthesis.AverageDurability = await CalculateAverageDurability(userProsthesis);

                    prosthesisCombinations.Add(userProsthesis);
                }
>>>>>>> dd4246d5aaf16d5e50bee8b9cc5513e6243ce7c4
            }

            var bestProsthesis = prosthesisCombinations.OrderByDescending(p => p.AverageDurability).FirstOrDefault();

            if (bestProsthesis == null)
            {
                return BadRequest("No valid prosthesis could be generated.");
            }

            ViewBag.AmputationName = amputation.AmputationName;
            ViewBag.Components = new
            {
<<<<<<< HEAD
                SocketDescription = allSockets.FirstOrDefault(s => s.Id == bestProsthesis.SocketId)?.Description,
                LinerName = allLiners.FirstOrDefault(l => l.Id == bestProsthesis.LinerId)?.Name,
                TubeName = allTubes.FirstOrDefault(t => t.Id == bestProsthesis.TubeId)?.Name,
                UnionSocketDescription = allUnionSockets.FirstOrDefault(u => u.Id == bestProsthesis.UnionSocketId)?.Description,
                KneeArticulateName = allKneeArticulates.FirstOrDefault(k => k.Id == bestProsthesis.KneeArticulateId)?.Name,
                FootName = allFeet.FirstOrDefault(f => f.Id == bestProsthesis.FootId)?.Name
=======
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
            ViewBag.ClienteId = TempData["ClientId"];
            if (ModelState.IsValid)
            {
                int? clienteId = TempData["ClientId"] as int?;

                var newProsthesis = new Prosthesis
                {
                    SocketId = model.SocketId ?? null,
                    LinerId = model.LinerId ?? null,
                    TubeId = model.TubeId ?? null,
                    UnionSocketId = model.UnionSocketId ?? null,
                    KneeArticulateId = model.KneeArticulateId ?? null,
                    FootId = model.FootId ?? null,
                    UpperLimbAmputationsiD = model.UpperLimbAmputationsiD,
                    LowerLimbAmputationsiD = model.LowerLimbAmputationsiD
                };

                newProsthesis.Durability = CalculateDurability(model);
                newProsthesis.AverageDurability = await CalculateAverageDurability(model);

                _context.Prostheses.Add(newProsthesis);
                await _context.SaveChangesAsync();


                // Asignar la prótesis al cliente
                if (clienteId.HasValue)
                {
                    var cliente = await _context.ClientesProtesicos.FirstOrDefaultAsync(c => c.Id == clienteId.Value);
                    if (cliente != null)
                    {
                        cliente.ProtesisId = newProsthesis.Id;
                        _context.Update(cliente);
                        await _context.SaveChangesAsync();
                    }
                }
                else
                {
                    var lastCliente = await _context.ClientesProtesicos.OrderByDescending(c => c.Id).FirstOrDefaultAsync();
                    if (lastCliente != null)
                    {
                        lastCliente.ProtesisId = newProsthesis.Id;
                        _context.Update(lastCliente);
                        await _context.SaveChangesAsync();
                    }
                    else
                    {
                        return RedirectToAction("Index");
                    }
                }
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

        //Generar recomendación para lower

        [HttpGet]
        public async Task<IActionResult> GenerateLowerProsthesis(Guid amputationId, ProsthesisVM prosthesis)
        {
            if (amputationId == Guid.Empty)
            {
                return BadRequest("Amputation ID is required.");
            }

            var amputation = await _context.LowerLimbAmputations.FirstOrDefaultAsync(a => a.Id == amputationId);

            if (amputation == null)
            {
                return NotFound("Amputation not found.");
            }

            var amputationName = amputation.AmputationName;

            var allSockets = await _context.Sockets.ToListAsync();
            var allLiners = await _context.Liners.ToListAsync();
            var allTubes = await _context.Tubes.ToListAsync();
            var allUnionSockets = await _context.UnionSockets.ToListAsync();
            var allKneeArticulates = await _context.KneeArticulates.ToListAsync();
            var allFeet = await _context.Feet.ToListAsync();

            var topSockets = new List<Socket>();
            var topLiners = new List<Liner>();
            var topTubes = new List<Tube>();
            var topUnionSockets = new List<UnionSocket>();
            var topKneeArticulates = new List<KneeArticulate>();
            var topFeet = new List<Foot>();

            if (amputationName == "Above Knee" || amputationName == "Hemipelvectomy" || amputationName == "Transfemoral" || amputationName == "Transtibial" || amputationName == "HipDisarticulation" || amputationName == "Below Knee" || amputationName == "HipDisarticulation" || amputationName == "KneeDisarticulation")
            {
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

                if(amputationName == "Above Knee" || amputationName == "Hemipelvectomy" || amputationName == "Transfemoral" || amputationName == "Transtibial" || amputationName == "HipDisarticulation" || amputationName == "KneeDesarticulation")
                {
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
                }

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

            }
            else if (amputationName == "Ankle Disarticulation" || amputationName == "Foot Partial" || amputationName == "Foot Complete" || amputationName == "ToePartial" || amputationName == "Lisfranc" || amputationName == "Chopart" || amputationName == "ToeComplete")
            {
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
            }
            else
            {
                return BadRequest("No valid combination exists for the specified amputation type.");
            }

            var prosthesisCombinations = new List<ProsthesisVM>();

            foreach (var socket in topSockets)
            {
                foreach (var liner in topLiners)
                {
                    var userProsthesis = new ProsthesisVM
                    {
                        SocketId = socket.Id,
                        LinerId = liner.Id,
                        TubeId = topTubes.Any() ? topTubes.First().Id : (int?)null,
                        UnionSocketId = topUnionSockets.Any() ? topUnionSockets.First().Id : (int?)null,
                        KneeArticulateId = topKneeArticulates.Any() ? topKneeArticulates.First().Id : (int?)null,
                        FootId = topFeet.Any() ? topFeet.First().Id : (int?)null,
                        LowerLimbAmputationsiD = amputationId,
                    };

                    userProsthesis.Durability = CalculateDurability(userProsthesis);
                    userProsthesis.AverageDurability = await CalculateAverageDurability(userProsthesis);

                    prosthesisCombinations.Add(userProsthesis);
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
>>>>>>> dd4246d5aaf16d5e50bee8b9cc5513e6243ce7c4
            };

            return View(bestProsthesis);
        }

<<<<<<< HEAD


        [HttpPost]
            public async Task<IActionResult> GenerateRecommendedProsthesis([Bind("Id,SocketId,LinerId,TubeId,FootId,UnionSocketId,KneeArticulateId,UpperLimbAmputationsiD,LowerLimbAmputationsiD,Durability,AverageDurability")] ProsthesisVM model)
            {
                ViewBag.ClienteId = TempData["ClientId"];
                if (ModelState.IsValid)
                {
                    int? clienteId = TempData["ClientId"] as int?;

                    var newProsthesis = new Prosthesis
                    {
                        SocketId = model.SocketId ?? null,
                        LinerId = model.LinerId ?? null,
                        TubeId = model.TubeId ?? null,
                        UnionSocketId = model.UnionSocketId ?? null,
                        KneeArticulateId = model.KneeArticulateId ?? null,
                        FootId = model.FootId ?? null,
                        UpperLimbAmputationsiD = model.UpperLimbAmputationsiD,
                        LowerLimbAmputationsiD = model.LowerLimbAmputationsiD
                    };

                    newProsthesis.Durability = CalculateDurability(model);
                    newProsthesis.AverageDurability = await CalculateAverageDurability(model);

                    _context.Prostheses.Add(newProsthesis);
                    await _context.SaveChangesAsync();


                    // Asignar la prótesis al cliente
                    if (clienteId.HasValue)
                    {
                        var cliente = await _context.ClientesProtesicos.FirstOrDefaultAsync(c => c.Id == clienteId.Value);
                        if (cliente != null)
                        {
                            cliente.ProtesisId = newProsthesis.Id;
                            _context.Update(cliente);
                            await _context.SaveChangesAsync();
                        }
                    }
                    else
                    {
                        var lastCliente = await _context.ClientesProtesicos.OrderByDescending(c => c.Id).FirstOrDefaultAsync();
                        if (lastCliente != null)
                        {
                            lastCliente.ProtesisId = newProsthesis.Id;
                            _context.Update(lastCliente);
                            await _context.SaveChangesAsync();
                        }
                        else
                        {
                            return RedirectToAction("Index");
                        }
                    }
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

            //Generar recomendación para lower
            [HttpGet]
            public async Task<IActionResult> GenerateLowerProsthesis(Guid amputationId, ProsthesisVM prosthesis)
            {
                if (amputationId == Guid.Empty)
                {
                    return BadRequest("Amputation ID is required.");
                }

                var amputation = await _context.LowerLimbAmputations.FirstOrDefaultAsync(a => a.Id == amputationId);
                if (amputation == null)
                {
                    return NotFound("Amputation not found.");
                }

                var amputationName = amputation.AmputationName;
                var allSockets = await _context.Sockets.OrderByDescending(s => s.Durability).Take(3).ToListAsync();
                var allLiners = await _context.Liners.OrderByDescending(l => l.Durability).Take(3).ToListAsync();
                var allTubes = await _context.Tubes.OrderByDescending(t => t.Durability).Take(3).ToListAsync();
                var allUnionSockets = await _context.UnionSockets.OrderByDescending(u => u.Durability).Take(3).ToListAsync();
                var allKneeArticulates = await _context.KneeArticulates.OrderByDescending(k => k.Durability).Take(3).ToListAsync();
                var allFeet = await _context.Feet.OrderByDescending(f => f.Durability).Take(3).ToListAsync();

                Tube bestTube = allTubes.FirstOrDefault();
                UnionSocket bestUnionSocket = allUnionSockets.FirstOrDefault();
                KneeArticulate bestKneeArticulate = allKneeArticulates.FirstOrDefault();
                Foot bestFoot = allFeet.FirstOrDefault();

                var prosthesisCombinations = new List<ProsthesisVM>();

                if (IsAboveKneeAmputation(amputationName))
                {
                    foreach (var socket in allSockets)
                    {
                        foreach (var liner in allLiners)
                        {
                            var userProsthesis = new ProsthesisVM
                            {
                                SocketId = socket.Id,
                                LinerId = liner.Id,
                                TubeId = bestTube?.Id,
                                UnionSocketId = bestUnionSocket?.Id,
                                KneeArticulateId = bestKneeArticulate?.Id,
                                FootId = bestFoot?.Id,
                                LowerLimbAmputationsiD = amputationId,
                            };

                            userProsthesis.Durability = CalculateDurability(userProsthesis);
                            userProsthesis.AverageDurability = await CalculateAverageDurability(userProsthesis);

                            prosthesisCombinations.Add(userProsthesis);
                        }
                    }
                }
                else if (IsBelowKneeAmputation(amputationName))
                {
                    foreach (var socket in allSockets)
                    {
                        foreach (var liner in allLiners)
                        {
                            foreach (var foot in allFeet)
                            {
                                var userProsthesis = new ProsthesisVM
                                {
                                    SocketId = socket.Id,
                                    LinerId = liner.Id,
                                    TubeId = bestTube?.Id,
                                    UnionSocketId = bestUnionSocket?.Id,
                                    FootId = bestFoot?.Id,
                                    LowerLimbAmputationsiD = amputationId,
                                };

                                userProsthesis.Durability = CalculateDurability(userProsthesis);
                                userProsthesis.AverageDurability = await CalculateAverageDurability(userProsthesis);

                                prosthesisCombinations.Add(userProsthesis);
                            }
                        }
                    }
                }
                else
                {
                    return BadRequest("No valid combination exists for the specified amputation type.");
                }

                var bestProsthesis = prosthesisCombinations.OrderByDescending(p => p.AverageDurability).FirstOrDefault();

                if (bestProsthesis == null)
                {
                    return BadRequest("No valid prosthesis could be generated.");
                }

                ViewBag.AmputationName = amputation.AmputationName;
                ViewBag.Components = new
                {
                    SocketDescription = allSockets.FirstOrDefault(s => s.Id == bestProsthesis.SocketId)?.Description,
                    LinerName = allLiners.FirstOrDefault(l => l.Id == bestProsthesis.LinerId)?.Name,
                    TubeName = allTubes.FirstOrDefault(t => t.Id == bestProsthesis.TubeId)?.Name,
                    UnionSocketDescription = allUnionSockets.FirstOrDefault(u => u.Id == bestProsthesis.UnionSocketId)?.Description,
                    KneeArticulateName = allKneeArticulates.FirstOrDefault(k => k.Id == bestProsthesis.KneeArticulateId)?.Name,
                    FootName = allFeet.FirstOrDefault(f => f.Id == bestProsthesis.FootId)?.Name
                };

                return View(bestProsthesis);
            }

            private bool IsAboveKneeAmputation(string amputationName)
            {
                var aboveKneeAmputations = new List<string>
                {
                    "AboveKnee", "Hemipelvectomy", "Transfemoral",
                    "Transtibial", "HipDisarticulation", "Below Knee",
                    "KneeDisarticulation"
                };

                return aboveKneeAmputations.Contains(amputationName);
            }

            private bool IsBelowKneeAmputation(string amputationName)
            {
                var belowKneeAmputations = new List<string>
                {
                    "Ankle Disarticulation", "FootPartial", "FootComplete",
                    "ToePartial", "Lisfranc", "Chopart", "ToeComplete"
                };

                return belowKneeAmputations.Contains(amputationName);
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

            public async Task<double> ObtenerPromedioDesgasteUltimoCliente()
            {
                var lastCliente = await _context.ClientesProtesicos
                                                .OrderByDescending(c => c.Id)
                                                .FirstOrDefaultAsync();
                if (lastCliente != null)
                {
                    var lifeStyle = await _context.LifeStyles
                                                  .Where(ls => ls.Id == lastCliente.LifeStyleId)
                                                  .FirstOrDefaultAsync();
                    if (lifeStyle != null)
                    {
                        return lifeStyle.promedioDesgaste;
                    }
                }
                return 1; // Devuelve 1 si no se encuentra ningún cliente o estilo de vida para evitar multiplicar por 0
            }
            private async Task<double> CalculateAverageDurability(ProsthesisVM prosthesis)
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

                AddDurability(await _context.Sockets
                    .Where(s => s.Id == prosthesis.SocketId)
                    .Select(s => (double?)s.Durability)
                    .FirstOrDefaultAsync());

                AddDurability(await _context.Liners
                    .Where(l => l.Id == prosthesis.LinerId)
                    .Select(l => (double?)l.Durability)
                    .FirstOrDefaultAsync());

                AddDurability(await _context.Tubes
                    .Where(t => t.Id == prosthesis.TubeId)
                    .Select(t => (double?)t.Durability)
                    .FirstOrDefaultAsync());

                AddDurability(await _context.Feet
                    .Where(f => f.Id == prosthesis.FootId)
                    .Select(f => (double?)f.Durability)
                    .FirstOrDefaultAsync());

                AddDurability(await _context.UnionSockets
                    .Where(u => u.Id == prosthesis.UnionSocketId)
                    .Select(u => (double?)u.Durability)
                    .FirstOrDefaultAsync());

                AddDurability(await _context.KneeArticulates
                    .Where(k => k.Id == prosthesis.KneeArticulateId)
                    .Select(k => (double?)k.Durability)
                    .FirstOrDefaultAsync());

                double promedioDesgasteUltimoCliente = await ObtenerPromedioDesgasteUltimoCliente();

                return componentCount > 0 ? (totalDurability / componentCount) * promedioDesgasteUltimoCliente : 0;
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
=======
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

        public async Task<double> ObtenerPromedioDesgasteUltimoCliente()
        {
            var lastCliente = await _context.ClientesProtesicos
                                            .OrderByDescending(c => c.Id)
                                            .FirstOrDefaultAsync();
            if (lastCliente != null)
            {
                var lifeStyle = await _context.LifeStyles
                                              .Where(ls => ls.Id == lastCliente.LifeStyleId)
                                              .FirstOrDefaultAsync();
                if (lifeStyle != null)
                {
                    return lifeStyle.promedioDesgaste;
                }
            }
            return 1; // Devuelve 1 si no se encuentra ningún cliente o estilo de vida para evitar multiplicar por 0
        }
        private async Task<double> CalculateAverageDurability(ProsthesisVM prosthesis)
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

            AddDurability(await _context.Sockets
                .Where(s => s.Id == prosthesis.SocketId)
                .Select(s => (double?)s.Durability)
                .FirstOrDefaultAsync());

            AddDurability(await _context.Liners
                .Where(l => l.Id == prosthesis.LinerId)
                .Select(l => (double?)l.Durability)
                .FirstOrDefaultAsync());

            AddDurability(await _context.Tubes
                .Where(t => t.Id == prosthesis.TubeId)
                .Select(t => (double?)t.Durability)
                .FirstOrDefaultAsync());

            AddDurability(await _context.Feet
                .Where(f => f.Id == prosthesis.FootId)
                .Select(f => (double?)f.Durability)
                .FirstOrDefaultAsync());

            AddDurability(await _context.UnionSockets
                .Where(u => u.Id == prosthesis.UnionSocketId)
                .Select(u => (double?)u.Durability)
                .FirstOrDefaultAsync());

            AddDurability(await _context.KneeArticulates
                .Where(k => k.Id == prosthesis.KneeArticulateId)
                .Select(k => (double?)k.Durability)
                .FirstOrDefaultAsync());

            double promedioDesgasteUltimoCliente = await ObtenerPromedioDesgasteUltimoCliente();

            return componentCount > 0 ? (totalDurability / componentCount) * promedioDesgasteUltimoCliente : 0;
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
>>>>>>> dd4246d5aaf16d5e50bee8b9cc5513e6243ce7c4
