using AspNetCoreHero.Abstractions.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreHero.Boilerplate.Domain.Entities.Learn
{
    public class Teacher: AuditableEntity
    {
        public string Name { get; set; }
        public Student Student { get; set; }
     private ClassTeacher classTeacher { get; set; }
    }
}
