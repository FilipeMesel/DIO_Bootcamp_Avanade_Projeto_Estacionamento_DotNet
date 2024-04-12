using System;

namespace Sistema_para_estacionamento_com_c_.Estacionamento
{
    public class Carro
    {
        public string Placa;
        public string Modelo { get; set; }

        private DateTime dataHora;

        public string GetPlaca()
        {
            return this.Placa;
        }

        public void SetPlaca(string p)
        {
            this.Placa = p;
        }

        public DateTime GetDataHora()
        {
            return dataHora;
        }

        public void SetDataHora(DateTime value)
        {
            dataHora = value;
        }

        public Carro(string placa, string modelo)
        {
            this.Placa = placa;
            this.Modelo = modelo;
            this.dataHora = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Placa: {Placa}, Modelo: {Modelo}, Hora de entrada: {dataHora}";
        }
    }
}
