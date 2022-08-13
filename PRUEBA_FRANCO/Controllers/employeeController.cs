using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PRUEBA_FRANCO.Data;

namespace PRUEBA_FRANCO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class employeeController : ControllerBase
    {
        public readonly DataContext DCData;

        public employeeController(DataContext dCData)
        {
            DCData = dCData;
        }

        [HttpGet]
        public async Task<ActionResult<List<employee>>> Get()
        {

            // return Ok(await DCData.employee.ToListAsync());
            return Ok(await DCData.Set<employee>().ToListAsync());
        }

        [HttpPost]

        public async Task<ActionResult<List<employee>>> Add(employee addemploy)
        {

            DCData.Set<employee>().Add(addemploy);
            await DCData.SaveChangesAsync();
            return Ok(await DCData.Set<employee>().ToListAsync());

        }

        [HttpPut]

        public async Task<ActionResult<List<employee>>> Update(employee updemployee)
        {

            var employee = await DCData.Set<employee>().FindAsync(updemployee.id);
            if (employee == null) return BadRequest("X");
            employee.name = updemployee.name;
            employee.document_number = updemployee.document_number;
            employee.salary = updemployee.salary;
            employee.age = updemployee.age;
            employee.profile = updemployee.profile;
            employee.email = updemployee.email;
            employee.address = updemployee.address;

            await DCData.SaveChangesAsync();
            return Ok(employee);

        }


        [HttpDelete("{idemployee}")]

        public async Task<ActionResult<employee>> Delete(int idemployee)
        {

            var employee = await DCData.Set<employee>().FindAsync(idemployee);
            if (employee == null) return BadRequest("X");
            DCData.Set<employee>().Remove(employee);
            await DCData.SaveChangesAsync();

            return Ok(employee);

        }
    }
}
