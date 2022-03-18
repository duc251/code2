using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.FileHopDong
{
    public class FileHopDongRequest
    {

       
      
        public IFormFile FileDoc { get; set; }
        public string Caption { get; set; }
        public bool IsDefault { get; set; }
        public DateTime DateCreate { get; set; }
   
       
    }
}
