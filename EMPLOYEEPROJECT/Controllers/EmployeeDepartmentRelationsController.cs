using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EMPLOYEEPROJECT.Data;
using EMPLOYEEPROJECT.Models;
using Microsoft.AspNet.OData;

namespace EMPLOYEEPROJECT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeDepartmentRelationsController : ControllerBase
    {
        private readonly EmployeeDbContext _context;

        public EmployeeDepartmentRelationsController(EmployeeDbContext context)
        {
            _context = context;
        }

        // GET: api/EmployeeDepartmentRelations
        [HttpGet]
        [EnableQuery]
        public IEnumerable<EmployeeDepartmentRelation> GetEmployeeDepartmentRelations()
        {
            return _context.EmployeeDepartmentRelations;
        }

        // GET: api/EmployeeDepartmentRelations/5
        [HttpGet("{id}")]
        [EnableQuery]
        public async Task<IActionResult> GetEmployeeDepartmentRelation([FromRoute] long id)
        {
            
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var employeeDepartmentRelation = await _context.EmployeeDepartmentRelations.FindAsync(id);
            
            if (employeeDepartmentRelation == null)
            {
                return NotFound();
            }

            return Ok(employeeDepartmentRelation);
            
        }

        // PUT: api/EmployeeDepartmentRelations/5
        [HttpPut("{id}")]
        [EnableQuery]
        public async Task<IActionResult> PutEmployeeDepartmentRelation([FromRoute] long id, [FromBody] EmployeeDepartmentRelation employeeDepartmentRelation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != employeeDepartmentRelation.Id)
            {
                return BadRequest();
            }

            _context.Entry(employeeDepartmentRelation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeDepartmentRelationExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/EmployeeDepartmentRelations
        [HttpPost]
        [EnableQuery]
        public async Task<IActionResult> PostEmployeeDepartmentRelation([FromBody] EmployeeDepartmentRelation employeeDepartmentRelation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.EmployeeDepartmentRelations.Add(employeeDepartmentRelation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmployeeDepartmentRelation", new { id = employeeDepartmentRelation.Id }, employeeDepartmentRelation);
        }

        // DELETE: api/EmployeeDepartmentRelations/5
        [HttpDelete("{id}")]
        [EnableQuery]
        public async Task<IActionResult> DeleteEmployeeDepartmentRelation([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var employeeDepartmentRelation = await _context.EmployeeDepartmentRelations.FindAsync(id);
            if (employeeDepartmentRelation == null)
            {
                return NotFound();
            }

            _context.EmployeeDepartmentRelations.Remove(employeeDepartmentRelation);
            await _context.SaveChangesAsync();

            return Ok(employeeDepartmentRelation);
        }

        private bool EmployeeDepartmentRelationExists(long id)
        {
            return _context.EmployeeDepartmentRelations.Any(e => e.Id == id);
        }
    }
}