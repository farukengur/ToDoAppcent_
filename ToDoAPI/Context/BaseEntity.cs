﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace ToDoAPI.Context
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }

    }
}
