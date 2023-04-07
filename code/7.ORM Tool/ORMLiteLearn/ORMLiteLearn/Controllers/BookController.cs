using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ORMLiteLearn.Models;
using ServiceStack.Data;
using ServiceStack.OrmLite;

namespace ORMLiteLearn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        //private readonly OrmLiteConnectionFactory _dbFactory = new OrmLiteConnectionFactory("Server = localhost; Database = BookDB; User = root; Password = Admin;", MySqlDialect.Provider);

        private readonly IDbConnectionFactory _dbFactory;

        public BookController(IDbConnectionFactory dbConnection)
        {
            _dbFactory = dbConnection;
        }

        [HttpGet]
        public IActionResult SelectAPI()
        {
            using(var db = _dbFactory.Open())
            {
                var books = db.Select<Book>();
                
                return Ok(books);
            }
        }
    }
}
