﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ilknur.Core.Domain.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public bool? IsActive { get; set; }

        public BaseEntity()
        {
            IsActive = true;
        }
    }
}