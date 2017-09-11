using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SafeHavenAPI.Data;
using SafeHavenAPI.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SafeHavenAPI.Controllers
{
    public class CustomerController : Controller
    {
        private SafeHavenAPIContext _context;
        public CustomerController(SafeHavenAPIContext ctx)
        {
            _context = ctx;
        }

        [HttpGet]
        public IActionResult Get()
        {

            var users = _context.User.ToList();
                                
            if (users == null)
            {
                return NotFound();
            }

            return Ok(users);  
        }

        // GET Single Customer
        // http://localhost:5000/Customer/{id} will return info on a single customer based on ID, with theor products nested in the JSON
        [HttpGet("{id}", Name = "GetSingleCustomer")]

        // Will run Get based on the id from the url route. 
        public IActionResult Get([FromRoute] int id)
        {
            // If you request anything other than an Id you will get a return of BadRequest. 
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var user = _context.User.SingleOrDefault(x => x.UserID == id);
                if (user == null)
                {
                    return NotFound();
                }
                return Ok(user);
            }
            //if the try statement fails for some reason, will return error of what happened. 
            catch (System.InvalidOperationException ex)
            {
                return NotFound(ex);
            }
        }

        // public IActionResult Post([FromBody] User newUser)
        // {
        //     // Probably needs Identity/Auth working
        // }
        
        private bool UserExists(int userid)
        {
          return _context.User.Count(e => e.UserID == userid) > 0;
        }

        // [HttpPut("{id}")]
        // public IActionResult Put(int id, [FromBody] User modifiedCustomer)
        // {
        //     //Proably requires user/auth   
        // }
    }
}