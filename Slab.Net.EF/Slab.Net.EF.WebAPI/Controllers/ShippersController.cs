using Slab.Net.EF.Entities.Model.DTOS;
using Slab.Net.EF.Entities.Model.Mapper;
using Slab.Net.EF.Logic;
using System;
using System.Net;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Slab.Net.EF.WebAPI.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class ShippersController : ApiController
    {
        readonly ShippersLogic logic = new ShippersLogic();
        readonly ShipperMapper mapper = new ShipperMapper();

        public ShippersController()
        {
        }

        // GET: api/Shippers
        public IHttpActionResult GetShippers()
        {
            try
            {
                var ship = logic.GetAll();
                var shippers = mapper.Map(ship);
                return Ok(shippers);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        // GET: api/Shippers/{id}
        public IHttpActionResult Get(int id)
        {
            try
            {
                var shipper = mapper.Map(logic.Get(id));
                return Ok(shipper);
            }
            catch(Exception)
            {
                return NotFound();
            }
        }

        // POST: api/Shippers/
        public IHttpActionResult Create([FromBody] ShipperDTO shipperRequest)
        {
            try
            {
                var shipper = mapper.Map(shipperRequest);
                logic.Add(shipper);
                return Content(HttpStatusCode.Created, mapper.Map(shipper));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }


        // POST: api/Shippers/5
        public IHttpActionResult Edit(int id, [FromBody] ShipperRequestDTO shipperRequest)
        {
            try
            {
                var shipper = mapper.Map(shipperRequest, id);
                logic.Update(shipper);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }


        // DELETE: api/Shippers/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                logic.Remove(id);
                return Ok();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
    }
}
