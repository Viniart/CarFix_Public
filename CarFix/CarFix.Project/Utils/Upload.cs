using Microsoft.AspNetCore.Http;
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
                var fileExtension = Path.GetExtension(file.FileName);
                
                if(fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".jfif" 
                || fileExtension == ".png" || fileExtension == ".svg")
                {
                    if (file.Length > 0)
                    {
                        var fileName = new string(Path.GetFileNameWithoutExtension(file.FileName).ToArray()).Replace(' ', '-');
                        fileName = fileName + DateTime.Now.ToString("yymmssfff") + Path.GetExtension(file.FileName);

                        var extension = Path.GetExtension(file.FileName);
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
