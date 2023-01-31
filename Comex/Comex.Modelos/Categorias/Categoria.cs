﻿using System;

namespace Comex.Modelos.Categorias;

public class Categoria
{
    public static int Quantidade { get; private set; }
    public int Id { get; private set; }
    public string Nome { get; }
    public string Status { get; }

    /// <summary>
    /// Cria uma categoria nova
    /// </summary>
    /// <param name="nome"> <see cref="Nome"/> da categoria necessário e maior que 3 caracteres </param>
    /// <param name="status"> <see cref="Status"/> (ATIVA / INATIVA) </param>
    /// <exception cref="ArgumentException"></exception>
    public Categoria(string nome, string status)
    {
        Quantidade++;
        Id = Quantidade;
        
        if (nome.Length <= 3) 
        {
            throw new ArgumentException("Nome deve ser maior que 3 caracteres", nameof(nome));
        }
        if (status != "ATIVA" && status != "INATIVA")
        {
            throw new ArgumentException("Status deve ser somente ATIVA ou INATIVA", nameof(status));
        }
        
        Nome = nome;
        Status = status;
    }

    public override string ToString()
    {
        return $"{Nome} ({Id} - {Status})";
    }
}
