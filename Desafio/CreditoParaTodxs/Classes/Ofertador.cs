using System;

namespace CreditoParaTodxs.Classes
{
    public class Ofertador : EntidadeBase
    {
        private Instituicao Instituicao {get; set;}

        private string Descricao {get; set;}

        private double Valor {get; set;}

        private double Taxa {get; set;}

        private bool Ativo {get; set;}

        private bool Contratado{get; set;}


        public Ofertador(int id, Instituicao instituicao , string descricao, double valor, double taxa){
            this.Id = id;
            this.Instituicao  = instituicao ;
            this.Descricao = descricao;
            this.Valor = valor;
            this.Taxa = taxa;
            this.Ativo = true;
            this.Contratado = false;
        }
         public string retornaOferta(){
            return this.Instituicao + " " + this.Valor + " " + this.Descricao ;
        }

        public int retornaId(){
            return this.Id;
        }

        public bool retronaExcluido(){
            return this.Ativo = false;
        }

        public void Excluir(){
            this.Ativo = false;
        }
    }
}