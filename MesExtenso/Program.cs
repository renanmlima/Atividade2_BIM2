using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesExtenso
{
    internal class Program
    {
        public static string mesConverte(DateTime atual)
        {
            
            /* |====================================================| */
            /* |* AUTOR: RENAN LIMA | RA: 6321300 ******************| */
            /* |* DATA DE CRIAÇÃO: 16.JUN.2022 *********************| */
            /* |* PROVA FECHAMENTO DE NOTA DO 2 BIMESTRE ***********| */
            /* |* MATÉRIA: LÓGICA DE PROGRAMAÇÃO *******************| */
            /* |* SEMESTRE: 1 | INSTITUIÇÃO: UNIFAAT ATIBAIA *******| */
            /* |* CURSO: ANÁLISE E DESENVOLVIMENTO DE SISTEMAS *****| */
            /* |====================================================| */

            //variavel que irá armazenar o número do mês, utilizando a função .Month
            int mes = atual.Month;

            //array que armazena os meses em extenso
            string[] mes_extenso = new string[12] { "Janeiro", "Fevereiro", "Março",
            "Abril", "Maio", "Junho", "Julho","Agosto","Setembro","Outubro","Novembro", "Dezembro"};

            //aqui será mostrado o mês em extenso, onde pegamos o
            //valor da variavel mês e subtraimos por 1, para localizar a posição no array.
            return (mes_extenso[mes - 1]);
        }

        static void Main(string[] args)
        {
            Console.Write("Por favor, insira um data no formato DD/MM/AAAA. Nós te apresentaremos o mês escrito em extenso: ");
            //variavel responsavel por armazenar a data atual inserida pelo usuário

            string cidade = "";
            var data_atual = Convert.ToDateTime(Console.ReadLine());int cont;

            Console.WriteLine();

            int dia = data_atual.Day;
            int ano = data_atual.Year;

            Console.Write("Olá, selecione uma das seguintes cidades:\n\n1 - Atibaia\n2 - Bragança Paulista\n3 - Mairiporã" +
                "\n4 - Nazaré\n5 - Terra Preta\n6 - Extrema\n7 - Vargem \n->");

            cont = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            switch (cont)
            {
                case 1:
                    cidade = "Atibaia";
                    break;

                case 2:
                    cidade = "Bragança Paulista";
                    break;

                case 3:
                    cidade = "Mairiporã";
                    break;

                case 4:
                    cidade = "Nazaré";
                    break;

                case 5:
                    cidade = "Terra Preta";
                    break;

                case 6:
                    cidade = "Extrema";
                    break;

                case 7:
                    cidade = "Vargem";
                    break;

            }

            Console.WriteLine(cidade+", " +dia +" de " +mesConverte(data_atual) +" de " +ano);

            Console.ReadKey();
