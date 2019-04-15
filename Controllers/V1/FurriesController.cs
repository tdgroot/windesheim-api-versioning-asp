using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using api_versioning_asp.Models;

namespace api_versioning_asp.Controllers.V1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class FurriesController : Controller
    {
        private Furry[] _hardcodedData;

        public FurriesController()
        {
            _hardcodedData = new Furry[] {
                new Furry() {Id=1, Name="Furry A"},
                new Furry() {Id=3, Name="Furry M"},
                new Furry() {Id=5, Name="Furry X"},
            };
        }

        // GET api/v1/values
        [HttpGet]
        public JsonResult Get()
        {
            return Json(_hardcodedData);
        }

        // GET api/v1/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Json(_hardcodedData.Where(x => x.Id == id).FirstOrDefault());
        }
    }
}
