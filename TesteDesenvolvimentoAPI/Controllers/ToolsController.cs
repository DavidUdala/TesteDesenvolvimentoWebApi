using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteDesenvolvimentoAPI.Models;

namespace TesteDesenvolvimentoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToolsController : ControllerBase
    {
        private readonly DbTesteContext _context;
        public ToolsController(DbTesteContext context)
        {
            _context = context;
        }
       
        [HttpGet("{id}")]
        //GET: api/PaymentDetail/id
        public IActionResult GetTool(int id)
        {
            Tool tool = _context.Tools.Find(id);
            if (tool == null)
                return NotFound();
            return Ok(tool);
        }

        [HttpGet]
        public IActionResult GetTools()
        {
            return Ok(_context.Tools.ToList());
        }

        [HttpPost]
        public IActionResult PostTool([FromBody] Tool tool)
        {
            _context.Tools.Add(tool);
            _context.SaveChanges();

            return Created("GetTools", tool);
        }

        [HttpDelete("{id}")]
        //DELETE: api/Tool/id
        public IActionResult DeletePaymentDetail(int id)
        {
            var obj = _context.Tools.Find(id);
            if (obj != null)
            {
                _context.Tools.Remove(obj);
                _context.SaveChanges();

                return NoContent();
            }
            return NotFound();
        }

        [HttpPut]
        //PUT: api/Tool
        public IActionResult PutPaymentDetail([FromBody] Tool tool)
        {
            Tool obj = _context.Tools.Find(tool.id);
            if (obj != null)
            {
                obj.link = tool.link;
                obj.name = tool.name;
                obj.description = tool.description;

                _context.Tools.Update(obj);
                _context.SaveChanges();
                return Ok();
            }
            return NotFound();
        }
    }
}
