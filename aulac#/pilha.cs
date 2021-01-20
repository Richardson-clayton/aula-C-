using System;

namespace aulac_
{
    public class NewBaseType
    {
        Posicao primeiro;
        public object Desempilha()
        {
            primeiro = new Posicao (primeiro, item);
        }
        public objet Desempilha()
        {
            if (primeiro == null)
            {
                throw new InvalidOperationException("A pilha tá vazia!");
            }
            object resultado = primeiro.item;
            primeiro = primeiro.proximo;
            return resultado;
        }
        public void Empilha(object item)
        {
            primeiro = new Posicao (primeiro, item);
        }
    }

    public class pilha : NewBaseType
    {
        class Posicao
        {
            public Posicao proximo;
            public object item;
        private Posicao primeiro;

        public Posicao(Posicao primeiro, object item)
        {
            this.primeiro = primeiro;
            this.item = item;
        }

            public override bool Equals(object obj)
            {
                return base.Equals(obj);
            }

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            public override string ToString()
            {
                return base.ToString();
            }
        }
}