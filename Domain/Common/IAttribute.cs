using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    interface IAttribute
    {
        int Id { get; set; }
        string Descripcion { get; set; }
    }
}
