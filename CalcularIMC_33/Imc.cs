using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularIMC_33
{
    internal class Imc
    {
        private double peso;
        private double altura;
        //CONTROL + R + E (com a classe selecionada)

        //Criando classe pública (Caso seja privada, só subistituir o "public" por "private")
        public double Peso { 
            get => peso;
            set { if (value >= 1) { this.peso = value; } else { throw new Exception("O peso mínimo deve ser de 1.00kg"); } }
        }
        public double Altura { 
            get => altura;
            set { if (value >= 1) { this.altura = value; } else { throw new Exception("A altura mínima deve ser de 1.00m"); } } 
        }

        //Criando função pública (Caso seja privada, só subistituir o "public" por "private")
        public string CalcularIMC() {

            double imc = this.Peso / (this.altura * this.altura);
            string stats = "";
            if(imc < 18.5 ){
                stats = "Você está abaixo do peso ideial.";
            }else if(imc < 25)
            {
                stats = "Parabéns - Você está no seu peso normal!";
            }else if(imc < 30)
            {
                stats = "Você está acima do seu peso ideal (sobrepeso)";
            }else if(imc < 35)
            {
                stats = "Obesidade grau I";
            }
            else if (imc < 40)
            {
                stats = "Obesidade grau II";
            }
            else if (imc > 40)
            {
                stats = "Obesidade grau III";
            }

            //Retornar valores da função
            return "Seu IMC é de: " + imc + "\n\n" + stats; 
        
        }

    }
}

