﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace funcionalfitness.BD.datos.entidades
{
    
    public class ZonaCorporal
    {
        public int id { get; set; }
        public string nombre { get; set; } = string.Empty;
    }
}
