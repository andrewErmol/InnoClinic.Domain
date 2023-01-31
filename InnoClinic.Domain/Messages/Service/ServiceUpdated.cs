using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoClinic.Domain.Messages.Service
{
    public class ServiceUpdated
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
