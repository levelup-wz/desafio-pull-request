﻿using Comex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public class Estoque
    {
        
         public int Capacidade { get; private set; } = 1000;
        public int Ocupacao { get; private set; } = 1000;
         public decimal Montante { get; private set; }
        public Produto Produto { get; set; }

        

        public void RegistarEntrada(Produto produto)
        {
            if (produto.Quantidade >= 1000)
            {
                throw new EstoqueException("Estoque Cheio");
                
            }
            if(Ocupacao >= 1000)
            {
                throw new EstoqueException("Ocupação excedida");
            }
            else
            {
                Capacidade -= produto.Quantidade;
                Ocupacao += produto.Quantidade;
                Montante += Convert.ToDecimal(produto.ValorEstoque());


            }



            /* Capacidade -= produto.Quantidade;
             Ocupacao += produto.Quantidade;
             Montante += Convert.ToDecimal(produto.ValorEstoque());*/
        }

        public void RegistarSaida(Produto produto)
        {
            if (Ocupacao<=0) 
            {
                throw new EstoqueException("Estoque vazio");
            }
            else
            {
                Capacidade += produto.Quantidade;
                Ocupacao -= produto.Quantidade;
                Montante -= Convert.ToDecimal(produto.ValorEstoque());
            }
           
        }

        public string RetornarInfosEstoque()
        {

            return $"Capacidade {Capacidade} \n " +
                $"Ocupação {Ocupacao} \n" +
                $"Montante {Montante} \n";

        }

    }

       

        

    
}



  

