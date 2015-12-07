﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace easyfis.Models
{
    public class MstUserForm
    {
        [Key]

        public Int32 Id { get; set; }
        public Int32 Userid { get; set; }
        public String User { get; set; }
        public String Form { get; set; }
        public Int32 FormId { get; set; }
        public Boolean CanAdd { get; set; }
        public Boolean CanEdit { get; set; }
        public Boolean CanDelete { get; set; }
        public Boolean CanLock { get; set; }
        public Boolean CanUnlock { get; set; }
        public Boolean CanPrint { get; set; }

    }
}