using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Entities
{
    public class Director : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public ICollection<Film> Films { get; set; }
    }
}
