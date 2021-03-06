﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySite.Shared.Models.About
{
    public class Award
    {
        public string AwardId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Company { get; set; }

        public DateTime AwardDate { get; set; }

        public byte[] Photo { get; set; }

        public virtual Team Team { get; set; }
    }
}
