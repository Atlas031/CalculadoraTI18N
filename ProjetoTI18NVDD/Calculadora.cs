using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTI18NVDD
{
    internal class Calculadora
    {
        //variáeis globais
        private double num1;
        private double num2;

        //Método construtor -> Instância as variavéis na memória do computador
        public Calculadora
        
            num1 = 0;
            num2 = 0;

        }//Fim do método construtor

        //Métodos Modificadores = GET e SET
        public double ConsultarNum1
        { 
            get { return this num1; }
            set { this num1 = value; }
        }

            public double ConsultarNum2
            {
                get { return this num2; }
                set {   this num2 = value; }
            }

            //métodos
            public double Somar()
            {
                return ConsultarNum1 + ConsultarNum2        
            }//fim do somar

            public double Subtrair()
            {
                return ConsultaNum1 - ContultarNum2
            }

            public double Multiplicar()
             {
                return ConsultaNum1 * ContultarNum2
             }

            public double Dividir()
            {
                return ConsultaNum1 / ContultarNum2
            }

}

