using System;
using System.Linq;
using coreMysql.Model;
using Microsoft.AspNetCore.Mvc;

namespace coreMysql.Controllers
{
    [Route("api/[controller]")]
    public class JuiceController:Controller
    {
        private readonly JuiceContext db;
        public JuiceController(JuiceContext db)
        {
            this.db = db;
        }
        [HttpGet]
        public JsonResult GetBugs()
        {
            
            var result = db.Bug.Select(x => x).ToList();
            return Json(result);
        }
    }
}
