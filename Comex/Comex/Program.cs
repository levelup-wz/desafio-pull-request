﻿using Comex.Testes;
using System;

class Program
{
    static void Main()
    {
        string op = "";

        while (op != "20")
        {
            Console.Clear();
            Console.WriteLine("Testes: \n[1] Testa Categoria \n[2] Testa Produto \n[3] Testa Pedido \n[4] Testa Produto Isento" +
                "\n[5] Testa Entrada de Produto no Estoque \n[6] Testa Saída de Produto no Estoque \n[7] Testa Validações de Estoque" +
                "\n[8] Testa Validação de Categoria \n[9] Testa Validação de Produto \n[10] Testa Frete \n[11] Testa Cpf" +
                "\n[12] Testa Vestuário \n[13] Testa Itens do Pedido");
            op = Console.ReadLine();

            switch (op)
            {
                case "1":
                    TestaCategoria.ExecutarTeste(); break;
                case "2":
                    TestaProduto.ExecutarTeste(); break;
                case "3":
                    TestaPedido.ExecutarTeste(); break;
                case "4":
                    TestaProdutoIsento.ExecutarTeste(); break;
                case "5":
                    TestaEntradaDeProdutoNoEstoque.ExecutarTeste(); break;
                case "6":
                    TestaSaidaDeProdutoNoEstoque.ExecutarTeste(); break;
                case "7":
                    TestaCategoria.ExecutarTeste(); break;
                case "8":
                    TestaCategoria.ExecutarTeste(); break;
                case "9":
                    TestaCategoria.ExecutarTeste(); break;
                case "10":
                    TestaCategoria.ExecutarTeste(); break;
                case "11":
                    TestaCategoria.ExecutarTeste(); break;
                case "12":
                    TestaCategoria.ExecutarTeste(); break;
                case "13":
                    TestaCategoria.ExecutarTeste(); break;
            }
        }
    }
}
