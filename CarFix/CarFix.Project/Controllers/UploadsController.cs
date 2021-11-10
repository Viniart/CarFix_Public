using CarFix.Project.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarFix.Project.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UploadsController : ControllerBase
    {
        [HttpPost, DisableRequestSizeLimit]
        public IActionResult Upload()
        {
            Upload up = new();

            string[] imagens = new string[Request.Form.Files.Count];

            for (int i = 0; i < Request.Form.Files.Count; i++)
            {
                var imagem = up.UploadFile(Request.Form.Files[i]);
                imagens[i] = imagem;
            }

            return Ok(imagens);
        }
    }
}
