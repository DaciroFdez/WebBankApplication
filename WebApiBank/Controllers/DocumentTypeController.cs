using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WebApiBank.DataBase;
using WebApiBank.DTOs;
using WebApiBank.Models;

namespace WebApiBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentTypeController : ControllerBase
    {
        private readonly BankApiDB _dbContext;

        public DocumentTypeController(BankApiDB dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public async Task<IActionResult> CreateTypeDocument([FromBody] DocumentTypeDTO documentTypeDTO)
        {
            try
            {
                var documentType = new DocumentType
                {
                    DocumentName = documentTypeDTO.DocumentName,
                    Initial = documentTypeDTO.Initial
                    //CreatedDate = DateTime.Now,
                    //CreatedBy = "User",
                    //UpdatedDate = DateTime.Now,
                    //UpdatedBy = "User",
                    //IsActive = 0,
                    //IsDelete = 0
                };

                _dbContext.DocumentTypes.Add(documentType);
                await _dbContext.SaveChangesAsync();
                return Ok("Creado");
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }
        }
    }
}
