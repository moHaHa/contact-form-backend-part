using Microsoft.AspNetCore.Mvc;


namespace ContactAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
     {
        private readonly DataContext _context;
        public ContactController(DataContext context )
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Contact>>> Get()
        {
            return Ok(await _context.Contacts.ToListAsync());
        }
        [HttpPost]
        public async Task<ActionResult<List<Contact>>> AddContact(Contact contact)
        {
            _context.Contacts.Add(contact);
            await _context.SaveChangesAsync();

            return Ok(await _context.Contacts.ToListAsync());
        }

    

    }
}