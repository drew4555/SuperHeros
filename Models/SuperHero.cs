﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Supers.Models
{
    public class SuperHero
    {
        public int Id { get; set; }
        public string SuperHeroName { get; set; }
        public string AlterEgo { get; set; }
        public string PrimaryAbility { get; set; }
        public string SecondaryAbility { get; set; }
        public string Catchphrase { get; set; }
    }
}
