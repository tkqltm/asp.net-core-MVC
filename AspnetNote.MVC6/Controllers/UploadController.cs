using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspnetNote.MVC6.Controllers
{
    public class UploadController : Controller
    {
        private readonly IHostingEnvironment _environment;

        public UploadController(IHostingEnvironment environment)
        {
            _environment = environment;
        }

        public IActionResult ImageUpload(IFormFile file)
        {
            // #이미지나 파일을 업로드 할 때 필요한 구성
            // 1. Path(경로) - 어디에다 저장할지 결정
            var path = Path.Combine()
            // 2. Name(이름) - DateTime, GUID + GUID
            // 3. Extension(확장자) - jpg, png... txt
        }
    }
}
