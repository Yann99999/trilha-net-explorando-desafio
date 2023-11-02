using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioHotel.Models
{
    public class Reserva
    {
        private int _DiasReservados;    

        public int DiasReservados       
        {
            get { return _DiasReservados; }        
            set { _DiasReservados = value; }       
        }
        private List<Pessoa> _Hospedes;    

        public List<Pessoa> Hospedes       
        {
            get { return _Hospedes; }       
            set { _Hospedes = value; }      
        }
        private Suite _Suite;    

        public Suite Suite       
        {
            get { return _Suite; }        
            set { _Suite = value; }       
        }

        public Reserva(){}
        public Reserva(int diasReservados){
            DiasReservados = diasReservados;
        }
        public void FazerReserva(Suite suite, List<Pessoa> hospedes)
        {
            Suite = suite;
            if(Suite.Capacidade >= hospedes.Count){
                Hospedes = hospedes;
            }else{
                throw new Exception($"A suíte {Suite.TipoSuite} não tem capacidade suficiente para {hospedes.Count} pessoas!");
            }
        }
        public int ObterQuantidadeHospedes()
        {
            int quantidadeHospedes = Hospedes.Count;
            return quantidadeHospedes;
        }

        public decimal CalcularValorHospedagem()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;

            if(DiasReservados >= 10){
                return valor * 90/100;
            }
            return valor;
        }
    }
}