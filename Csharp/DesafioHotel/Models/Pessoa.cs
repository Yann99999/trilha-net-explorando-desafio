using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioHotel.Models
{
    public class Pessoa
    {
        private string _Nome; // field

        public string Nome   
        {
            get { return _Nome; }   
            set { _Nome = value; }  
        }

        private string _Sobrenome;

        public string Sobrenome   
        {
            get { return _Sobrenome; }   
            set { _Sobrenome = value; }  
        }

        public Pessoa(){}
        public Pessoa(string nome, string sobrenome){
            this.Nome = nome;
            this.Sobrenome = sobrenome;
        }
    }
}