using AspNetCoreHero.Abstractions.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreHero.Boilerplate.Domain.Entities.Learn
{
   public class Class : AuditableEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        private ClassTeacher ClassTeacher { get; set; }
    }
}
