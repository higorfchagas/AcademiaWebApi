﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademiaWebApi.Models
{
    public class Produto
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public Decimal Valor { get; set; }

        public int Quantidade { get; set; }
    }
}
