﻿namespace Comex.Models
{
    public class LimiteDeEstoqueExcedidoException : Exception
    {
        public LimiteDeEstoqueExcedidoException() { }
        public LimiteDeEstoqueExcedidoException(string message) : base(message) { }
        public LimiteDeEstoqueExcedidoException(string message, Exception innerException) : base(message, innerException) { }

    }
}
