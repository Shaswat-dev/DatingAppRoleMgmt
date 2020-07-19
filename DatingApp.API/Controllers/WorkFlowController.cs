using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using DatingApp.API.Data;
using DatingApp.API.Dtos;
using DatingApp.API.Helpers;
using DatingApp.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers
{

    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class WorkFlowController : ControllerBase
    {
        private readonly IMapper _mapper;

        private readonly IDatingRepository _repo;
        public  WorkFlowController (IDatingRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }
        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetStateId(int id)
        {
            //var value = await _context.Values.ToListAsync();
           // var processId = id;
            
            var value = await _repo.GetStartingState(id);
             var StateId = _mapper.Map<List<StateIdLocatorDto>>(value);


            //var StateId = value.

            return Ok(StateId);
        }
    }
}