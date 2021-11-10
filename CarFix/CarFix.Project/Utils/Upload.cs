﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace CarFix.Project.Utils
{
    public class Upload
    {
        public string UploadFile(IFormFile file)
        {

            try
            {
                var folderName = Path.Combine("Images");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);

                if (file.Length > 0)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, fileName);

                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }

                    return fileName;

                }
                else
                {
                    return "";
                }

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }


        }
    }
}
