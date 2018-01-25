using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities.Dtos
{
    public class DefaultMessageDto
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
    }
}
