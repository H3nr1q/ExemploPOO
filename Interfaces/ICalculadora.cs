using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Interfaces
{
    public interface ICalculadora
    {
        //metodos obrigatorios para implementação
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);

        //metodo que contem corpo é opcional de implementação
        int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}