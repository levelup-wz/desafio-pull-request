﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public class TestaCliente
    {
        Cliente cliente1 = new Cliente(1, "Saulo", "Alves Magalhães", "99999999999", "99999999999", "Rua Luva De Pedreiro", "100", "Casa", "Ibotirama", "BA");

        public TestaCliente()
        {
            Console.WriteLine($" {cliente1.NomeCompleto()}\n{cliente1.EnderecoCompleto()}");
        }

    }
}