using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Egitim_Backend.Core.Entities
{
    public interface IEntity
    {
        [Key]
         long Id { get; set; }

    }
}
