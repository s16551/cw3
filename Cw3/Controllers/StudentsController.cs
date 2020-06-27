using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;
using Cw3.DAL;
using Cw3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cw3.Controllers
{

    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {
        private readonly IDbService _dbService;

        private const string ConString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog = db - mssql; Integrated Security = True;";

        public StudentsController(IDbService dbService)
        {
            _dbService = dbService;
        }
        
        [HttpGet]
        public IActionResult GetStudents()
        {
            using (SqlConnection con = new SqlConnection(ConString))

            using (SqlCommand com = new SqlCommand())
            {
                com.Connection = con;
                com.CommandText = "select * from dbo.students";

                con.Open();
                SqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {

                }
            }

                


           

            return Ok();
        }

        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            student.IndexNumber = $"s{new Random().Next(1, 20000)}";

            return Ok(student);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent(Student student)
        {
            return Ok("Aktualizacja dokończona");
        }

        [HttpDelete("{id}")] 
        IActionResult DeleteStudent(Student student)
        {
            //executenon query
            return Ok("Usuwanie ukonczone");
        }
    }
}