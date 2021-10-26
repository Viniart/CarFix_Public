]using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarFix.Project.Domains
{
    public class Vehicle : Entity
    {
        public Vehicle(string placa, string nomeModelo, string marca, int ano, string cor, int userId)
        {
            Placa = placa;
            NomeModelo = nomeModelo;
            Marca = marca;
            Ano = ano;
            Cor = cor;
            UserId = userId;
        }

        public string Placa { get; private set; }
        public string NomeModelo { get; private set; }
        public string Marca { get; private set; }
        public int Ano { get; private set; }
        public string Cor { get; private set; }
        public string ImagemVeiculo { get; private set; }

        // Compositions
        public int UserId { get; private set; }
        public virtual User User { get; private set; }
    }
}
