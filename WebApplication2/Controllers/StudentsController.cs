using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {


        public StudentsController() { }  //contructor gol

        [HttpGet]
        public IEnumerable<Studentt> Get()
        {
            return StudentsRepository.Students; //pt ca e static, se poate returna direct
        }

        [HttpGet("{Id}")]
    public Studentt Get(int Id)//trimite un id prin ruta httpGet
        {
        return StudentsRepository.Students.FirstOrDefault(s => s.Id == Id);  // ca in DB "select all from studenti where id==id,//gasim studentul pe baza acestui id
        }


        [HttpDelete("{Id}")]
        public Studentt DELETE(int Id)  
        {
            return StudentsRepository.Students.FirstOrDefault(s => s.Id == Id);  
        }

        [HttpPost]
        public string Post([FromBody] Studentt student)
        {
            StudentsRepository.Students.Add(student);

        }


    }

}
