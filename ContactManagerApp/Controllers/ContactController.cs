using ContactManagerApp.Models;
using ContactManagerApp.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ContactManagerApp.Controllers
{
    public class ContactController : Controller
    {
        private readonly IRepository<Contact, int> repo;

        public ContactController(IRepository<Contact, int> repo)
        {
            this.repo = repo;
        }

        public async Task<IActionResult> Index()
        {
            return View(await repo.GetAllAsync());
        }

        public async Task<IActionResult> AddContact([FromBody] Contact contact)
        {
            int id = await repo.CreateAsync(contact);

            return Ok(new
            {
                id = id
            });
        }
    }
}
