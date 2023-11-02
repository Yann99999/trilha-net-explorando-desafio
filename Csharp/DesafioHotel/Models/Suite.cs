using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioHotel.Models
{
    public class Suite
    {
        private string _TipoSuite;  

        public string TipoSuite    
        {
            get { return _TipoSuite; }    
            set { _TipoSuite = value; }   
        }
        private int _Capacidade;  

        public int Capacidade    
        {
            get { return _Capacidade; }    
            set { _Capacidade = value; }   
        }

        private decimal _ValorDiaria;  

        public decimal ValorDiaria    
        {
            get { return _ValorDiaria; }    
            set { _ValorDiaria = value; }   
        }

        public Suite() { }
        public Suite(int capacidade, decimal valorDiaria)
        {
            this.Capacidade = capacidade;
            this.ValorDiaria = valorDiaria;
        }
        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            this.TipoSuite = tipoSuite;
            this.Capacidade = capacidade;
            this.ValorDiaria = valorDiaria;
        }
    }
}