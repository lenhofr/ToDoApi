using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public Person GetPerson()
        {
            Person person = new Person();
            person.firstName = "Maggie";
            person.lastName = "Len";
            person.age = 28;
            person.birthDate = new DateTime(1990, 4, 26);

            return person;
        }

        //ToDo need to add some more controllers

        [HttpPost]
        public Person CreatePerson([FromBody] Person person)
        {
            return person;
        }

        [HttpGet("{firstName}")]
        public Person GetPerson([FromQuery] string firstName)
        {
            Person person = new Person();

            person.firstName = firstName;
            person.lastName = "surname";
            person.age = 69;
            person.birthDate = DateTime.Now;

            return person;

        }

    }
}
