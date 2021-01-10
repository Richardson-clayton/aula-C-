using System;
nomespace aulac_
{
    public class pilha
    {
        Posicao primeiro;
        public void Empilha(objet item)
        {
            primeiro = new Posicao (primeiro, item);
        }
        public objet Desempilha()
        {
            if (primeiro == null)
            {
                thow new InvalidOperationException("A pilha tá vazia!");
            }
            objet reultado = primeiro.item;
            primeiro = primeiro.proximo;
            return resultado;
        }
        class Posicao
        {
            public Posicao proximo;
            public objet item;
            public Posicao(Posicao proximo, object item);
            {
                this.proximo = proximo;
                this.item = item;
            }
        }
    }
}