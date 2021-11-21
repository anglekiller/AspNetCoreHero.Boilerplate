using AspNetCoreHero.Abstractions.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreHero.Boilerplate.Domain.Entities.Learn
{
  public  class Student: AuditableEntity
    {
    
        public string Name { get; set; }
        public int Age { get; set; }

        public List<Teacher> Teachers { get; set; }
    }
}
