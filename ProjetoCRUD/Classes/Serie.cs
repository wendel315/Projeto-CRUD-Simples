using System;
using ProjetoCRUD.Enum;

namespace ProjetoCRUD.Classes
{
    public class Serie : EntityBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            Id = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Excluido = false;
        }

        public string retornaTitulo()
        {
            return Titulo;
        }

        public int retornaId()
        {
            return Id;
        }

        public void Excluir()
        {
            Excluido = true;
        }

        public bool retornaExcluido()
        {
            return Excluido;
        }

        public override string ToString()
        {
            return ""
                 + "Gênero: " + Genero + Environment.NewLine
                 + "Título: " + Titulo + Environment.NewLine
                 + "Descrição: " + Descricao + Environment.NewLine
                 + "Ano de Início: " + Ano
                 + "Excluído: " + Excluido;
                 
        }

        
    }
}
