﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.exceptions
{
    public class LimiteDeEstoqueExcedidoException : Exception
    {
        public LimiteDeEstoqueExcedidoException() { }
        public LimiteDeEstoqueExcedidoException(string mensagem) : base(mensagem){}
        public LimiteDeEstoqueExcedidoException(string mensagem, Exception excecaoInterna) : base(mensagem, excecaoInterna)
        { 

        }
            


        }
}