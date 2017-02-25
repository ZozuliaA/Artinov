using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HADatabaseEntity
{
    public abstract class IdEntity
    {
        [Key]
        public Guid Id { get; protected set; }

        protected IdEntity()
        {
            Id = Guid.NewGuid();
        }

    }
}
