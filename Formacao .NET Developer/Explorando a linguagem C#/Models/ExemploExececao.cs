using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propriedades__Metodos_e_Contrutores.Models
{
    public class ExemploExececao
    {
        public void Metodo1()
        {
            Metodo2();
        }
        public void Metodo2()
        {
            try
            {
                Metodo3();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message} \nExcecao tradada");
            }
        }
        public void Metodo3()
        {
            Metodo4();
        }
        public void Metodo4()
        {
            throw new Exception("Ocorreu uma excecao");
        }
    }
}