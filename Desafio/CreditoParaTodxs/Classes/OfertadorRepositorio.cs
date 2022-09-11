using System.Collections.Generic;
using CreditoParaTodxs.Interfaces;

namespace CreditoParaTodxs.Classes
{
    public class OfertadorRepositorio : IRepositorio<Ofertador>
    {
       private List<Ofertador> listaOfertas = new List<Ofertador>();

        public void Atualiza(int id, Ofertador objeto)
        {
            listaOfertas[id] = objeto;
        }

        public void Excluir(int id)
        {
            listaOfertas[id].Excluir();
        }

        public void Insere(Ofertador objeto)
        {
            listaOfertas.Add(objeto);
        }

        public List<Ofertador> Lista()
        {
            return listaOfertas;
        }

        public int ProximoId()
        {
            return listaOfertas.Count;
        }

        public Ofertador RetornaPorId(int id)
        {
            return listaOfertas[id];
        }
    }
}