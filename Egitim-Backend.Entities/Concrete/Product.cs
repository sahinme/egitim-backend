using System;
using System.Collections.Generic;
using System.Text;
using Egitim_Backend.Core.Entities;

namespace Egitim_Backend.Entities.Concrete
{
    public class Product:IEntity
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }
    }
}
