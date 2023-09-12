using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Comum
{
    public abstract class EntidadeBase
    {
        public int Id { get; set; }
        public DateTime CriadoEm { get; set; }
        public string CriadoPor { get; set; }
        public DateTime AleradoEm { get; set; }
        public string AlteradoEm { get; set; }
    }
}
