﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaForms
{
    public class Livros
    {
        public List<Livro> Acervo { get; set; } = new List<Livro>();
        public List<Livro> listaLivros = new List<Livro>();

        public void Adicionar(Livro livro)
        {
            Acervo.Add(livro);
        }

        public List<Livro> ObterTodos()
        {
            return Acervo;
        }

        public Livro Pesquisar(int isbn)
        {
            return Acervo.Find(l => l.Isbn == isbn);
        }
    }
}
