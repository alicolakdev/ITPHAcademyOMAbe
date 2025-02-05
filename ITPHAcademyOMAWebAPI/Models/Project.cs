﻿using System;
using System.Collections.Generic;

namespace ITPHAcademyOMAWebAPI.Models
{
    public partial class Project
    {
        public Project()
        {
            Tasks = new HashSet<Task>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int CustomerId { get; set; }

        public virtual User Customer { get; set; } = null!;
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
