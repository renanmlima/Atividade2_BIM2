# Mês em Extenso a Partir de uma Data Inserida

### Criado por Renan Lima | Centro Universitário UNIFAAT - Atibaia | 16.06.2022


- Objetivo:

  - Receber uma data do usuário no formato DD/MM/AAAA;
  - Apresentar ao usuário o mês escrito em extenso, referente à data inserida.
    
    - Exemplo: Usuário insere a data 22/04/1998 e é retornado Abril no console.
                   
------------------------------------------------------------------------------------------------------ 

- Desenvolvimento: 

  - Foi utilizado Console com .Net Framework;
  - Para armazenar os valores do mês foi utilizado um array com 12 índices:
  
              string[] mes_extenso = new string[12] { "Janeiro", "Fevereiro", "Março", "Abril", "Maio",
                                                    "Junho", "Julho","Agosto","Setembro","Outubro","Novembro", "Dezembro"};
                                                    
  - Para buscar o valor dentro do array, foi utilizado uma variável de nome "mes", que coleta o mês a partir da função .Month.

------------------------------------------------------------------------------------------------------ 

- Utilizando Switch:

Há também uma outra forma de realizar o armazenamento dos meses, o Switch Case.
O código ficaria um pouco diferente. Veja um exemplo:

               switch (mes)
               {
                  case 1:
                     mesExtenso = "Janeiro";
                     break;
                  case 6:
                     mesExtenso = "Junho";
                     break;
               }
               
               
Novamente a variável "mes" irá coletar o mês a partir da função .Month, porém agora, será comparado dentro do Switch.              
                    
                    
                    
