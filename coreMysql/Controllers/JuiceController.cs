using System;
using System.Linq;
using coreMysql.Model;
using Microsoft.AspNetCore.Mvc;

namespace coreMysql.Controllers
{
    [Route("api/[controller]/[action]")]
    public class JuiceController:Controller
    {
		private readonly JuiceitdbContext db;
		public JuiceController(JuiceitdbContext db)
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
