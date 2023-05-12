using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF010.CodeFirstMigration.Entities
{
    public class Enrollment
    {
        public int SectionId { get; set; }
        public int StudentId { get; set; }

        public Section Section { get; set; } = null!;
        public Student Student { get; set; } = null!;
    }
}
