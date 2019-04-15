using System;
using System.Collections.Generic;
using System.Text;

namespace MyRoom.Domain.Core.Models
{
    public abstract class BaseModel
    {
        public Guid Id { get; set; }
    }
}
