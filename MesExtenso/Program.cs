using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesExtenso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Por favor, insira um data no formato DD/MM/AAAA. Nós te apresentaremos o mês escrito em extenso: ");
            //variavel responsavel por armazenar a data atual inserida pelo usuário
            var data_atual = Convert.ToDateTime(Console.ReadLine());

            //variavel que irá armazenar o número do mês, utilizando a função .Month
            int mes = data_atual.Month;

            //array que armazena os meses em extenso
            string[] mes_extenso = new string[12] { "Janeiro", "Fevereiro", "Março",
            "Abril", "Maio", "Junho", "Julho","Agosto","Setembro","Outubro","Novembro", "Dezembro"};

            //aqui será mostrado o mês em extenso, onde pegamos o valor da variavel mês e subtraimos por 1, para localizar a posição no array.
            Console.WriteLine(mes_extenso[mes - 1]);

            Console.ReadKey();

        }
    }
}
