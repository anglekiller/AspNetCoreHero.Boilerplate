using AspNetCoreHero.Abstractions.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreHero.Boilerplate.Domain.Entities.Learn
{
    class ClassTeacher: AuditableEntity
    {
        public int ClassId { get; set; }
        public int TeacherId { get; set; }
       public List<Class> Classes { get; set; }
       public List<Teacher> Teachers { get; set; }


    }
}
