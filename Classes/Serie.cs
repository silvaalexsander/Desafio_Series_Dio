using System;
using Cadastro.Clsses;
namespace Cadastro
{
    public class Serie : EntidadeBase
    {
        private Genero gender { get; set; }
        private string title { get; set; }
        private string description { get; set; }
        private int year { get; set; }
        public bool Excluido { get; set; }

        public Serie(int Id, Genero gender, string title, string description, int year)
    {
            this.Id = Id;
            this.gender = gender;
            this.title = title;
            this.description = description;
            this.year = year;
            this.Excluido = false;
    }

        public Serie()
        {

        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Genero: " + this.gender + Environment.NewLine;
            retorno += "Titulo: " + this.title + Environment.NewLine;
            retorno += "Descricao: " + this.description + Environment.NewLine;
            retorno += "Ano: " + this.year + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido + Environment.NewLine;
            return retorno;
        }
        public string retornaTitulo()
        {
            return this.title;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }

         public bool retornaExcluido()
		{
			return this.Excluido;
		}

    }


}