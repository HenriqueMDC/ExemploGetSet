using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploGetSet
{
    class Cachorro
    {
        private string Nome;
        private double Altura;
        private double Peso;
        private string Raca;

        public void SetNome(string nome)
        {
            if (nome.Count() < 3)
            {
                throw new Exception("Nome deve conter 3 letras");
            }

            if (nome.Count() > 40)
            {
                throw new Exception("Nome deve conteer no máximo 40 caracteres");
            }
            Nome = nome;
        }

        public void SetAltura(double altura)
        {
            if (altura <= 0)
            {
                throw new Exception("Altura deve ser maior que 0");
            }

            if (altura > 2)
            {
                throw new Exception("Altura deve ser menor que 2");
            }
            Altura = altura;
        }

        public void SetPeso(double peso)
        {
            if (peso <= 0)
            {
                throw new Exception("Peso deve ser maior que 0");
            }

            if (peso > 150)
            {
                throw new Exception("Peso deve ser menor que 150");
            }

            Peso = peso;
        }

        public void SetRaca(string raca)
        {
            if (raca.Count() < 3)
            {
                throw new Exception("Raça deve conter mais de 3 caracteres");
            }

            if (raca.Count() > 40)
            {
                throw new Exception("Raça deve conter menos de 40 caracteres");
            }

            Raca = raca;
        }

        public string GetNome()
        {
            return Nome;
        }

        public string GetRaca()
        {
            return Raca;
        }

        public double GeteAltura()
        {
            return Altura;
        }

        public double GetPeso()
        {
            return Peso;
        }
    }
}
