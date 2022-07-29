using CompanyCustomerApi.Core.BaseModel;
using CompanyCustomerApi.Services.Services;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CompanyCustomerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TEntity, TDto> : ControllerBase
        where TEntity : IBase
        where TDto : IBaseDto
    {
        protected readonly IBaseService<TEntity, TDto> _services;

        public BaseController(IBaseService<TEntity, TDto> services)
        {
            _services = services;
        }

        [HttpGet]
        [EnableQuery]
        public virtual IActionResult Get()
        {
            var query = _services.AsQuery();
            return Ok(query);
        }

        [HttpGet("Query")]
        public virtual async Task<IActionResult> Query(ODataQueryOptions<TEntity> queryOptions)
        {
            var query = _services.AsQuery();

            var odataQuery = queryOptions.ApplyTo(query).Cast<TEntity>();

            var result = await _services.ProjectToDto(odataQuery);

            return Ok(result);
        }

        [HttpGet("{id}")]
        public virtual async Task<IActionResult> GetById([FromRoute] int id)
        {
            var result = await _services.GetByIdAsync(id);

            if (result is false)
                return NotFound($"The record with id {id} was not found");

            return Ok(result);
        }
        [HttpPost]
        public virtual async Task<IActionResult> Post([FromBody] TDto dto)
        {
            var result = await _services.AddAsync(dto);

            if (result.IsSuccess is false)
                return UnprocessableEntity(result);

            return CreatedAtAction(WebRequestMethods.Http.Get, new { id = result.Entity.Id, result.Entity });
        }

        [HttpPut("{id}")]
        public virtual async Task<IActionResult> Put([FromRoute] int id, [FromBody] TDto dto)
        {
            var result = await _services.UpdateAsync(id, dto);

            if (result is null)
                return NotFound($"The record with id {id} was not found");

            if (result.IsSuccess is false)
                return UnprocessableEntity(result);

            return Ok(result);
        }

        [HttpDelete]
        public virtual async Task<IActionResult> Delete([FromBody] int id)
        {
            var result = await _services.DeleteByAsync(id);

            if (result is null)
                return NotFound($"The record with id {id} was not found");

            return Ok(result);
        }
    }
}
