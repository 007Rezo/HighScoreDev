﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighScoreModels
{
    public class Details
    {
        public  DateTime Entry { get; set; }
        public DateTime Exit { get; set; }
        public bool isActive { get; set; }
        public string Notes { get; set; } = string.Empty;

    }
}
