﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Words
    {
        protected List<string> WordList { get; set; } = new List<string>();

        protected string CurrentWord { get; set; } = string.Empty;
    }
}
