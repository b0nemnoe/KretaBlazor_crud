using Kreta.Shared.Models.SchoolCitizens;
using Kreta.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.Shared.Dtos
{
    public class AddressDto
    {
        public Guid Id { get; set; }
        public Guid? PublicScapeID { get; set; }
        public string City { get; set; } = string.Empty;
        public string PublicSpaceName { get; set; } = string.Empty;
        public int House { get; set; }
        public int Floor { get; set; }
        public int Door { get; set; }
        public int PostalCode { get; set; }
        public Guid StudentId { get; set; }
        public Guid TeacherId { get; set; }
        public Guid ParentId { get; set; }
        public virtual Student? Student { get; set; }
        public virtual Teacher? Teacher { get; set; }
        public virtual Parent? Parent { get; set; }

    }
}
