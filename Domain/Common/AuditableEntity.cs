using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common;
public class AuditableEntity
{
    public required string CreatedBy { get; set; }

    public DateTime Created { get; set; }

    public required string LastModifiedBy { get; set; }

    public DateTime? LastModified { get; set; }
}
