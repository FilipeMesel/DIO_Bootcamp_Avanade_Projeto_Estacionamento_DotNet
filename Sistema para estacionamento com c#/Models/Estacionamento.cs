using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_para_estacionamento_com_c_.Estacionamento
{
    public class Estacionamento
    {
        public static List<Carro> Carros = new List<Carro>();
        public double Preco { get; set; }
        public string Nome { get; set; }

        public Estacionamento(string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }

        public static void AddCarro(Carro c)
        {
            Carros.Add(c);
        }

        public static void RemoverCarro(Carro c)
        {
            Carros.Remove(c);
        }
    }
}
