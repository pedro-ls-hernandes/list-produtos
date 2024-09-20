﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listprodutos
{
    public class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }

    public Produto(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public void Exibir()
    {
        Console.WriteLine($"Produto: {Nome}\nPreço: {Preco}");
    }
}
}
