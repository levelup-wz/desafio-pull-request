﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Comex.Models
{
    public class CPF
    {
        public string Cpf { get; private set; }
        public CPF(string cpf)
        {
            Cpf = cpf;
        }

        public string Formatar()
        {
            return $"{Cpf.Substring(0, 3)}.{Cpf.Substring(3, 3)}.{Cpf.Substring(6, 3)}-{Cpf.Substring(9, 2)}";
        }

        public string FormatarComRegex()
        {
            return Regex.Replace(Cpf, @"(.{3})(.{3})(.{3})(.{2})", @"$1.$2.$3-$4");
        }

        public override string ToString()
        {
            return Cpf;
        }
    }
}
