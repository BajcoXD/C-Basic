using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyMenagment.Domain.Models
{
    public class BaseEntity
    {
        public int id { get; set; }
        public DateTime DateCreated { get; set; }

    }
}
