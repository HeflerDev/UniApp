using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using UniApp.Models;

namespace UniApp.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ClientController : Controller
{
    private readonly ApplicationDbContext _context;

    public ClientController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public dynamic Get()
    {
        var clients = _context?.Client?.ToList();

        if (clients is not null)
        {
            return clients;
        }

        return NoContent();
    }

    [HttpGet("{id}")]
    public Client Get(int id)
    {
        return _context.Client.Single(c => c.ClientId == id);
    }
    
    [HttpPost]
    public async Task<ActionResult<Client>> Post([FromBody] Client client){
        if (ModelState.IsValid)
        {
            _context.Client.Add(client);
            await _context.SaveChangesAsync();
            return client;
        }

        return NotFound();
    }

    [HttpPut("{id}")]
    public StatusCodeResult Put([FromBody] Client client, int id)
    {
        var entity = _context.Client.First(c => c.ClientId == id);

        if (entity is not null)
        {
            entity.Name = client.Name;
            entity.Email = client.Email;
            _context.SaveChanges();
            return Ok();
        }

        return new BadRequestResult();
    }

    [HttpDelete("{id}")]
    public StatusCodeResult Delete(int id)
    {
        var client= _context.Client.FirstOrDefault(c => c.ClientId == id);
        if (client is not null)
        {
            _context.Client.Remove(client);
            _context.SaveChanges();
            return Ok();
        }

        return NotFound();
    }
    
}