using MauiAppdoMilhao.Models;
using MauiAppdoMilhao;
using MauiAppdoMilhao.Models;

namespace MauiAppdoMilhao
{
    public partial class App : Application
    {


        List<Pergunta> perguntas_faceis = new()
            {
                new Pergunta
                {
                    Id = 1,
                    Enunciado = "Qual é o nome dado ao estado da água em forma de gelo?",
                    Alternativas = new()
                    {
                        new Alternativa { Correta = false, Descricao = "LÍQUIDO" },
                        new Alternativa { Correta = true, Descricao = "SÓLIDO" },
                        new Alternativa { Correta = false, Descricao = "GASOSO" },
                        new Alternativa { Correta = false, Descricao = "VAPOROSO" }
                    }
                },
                new Pergunta
                {
                    Id= 2,
                    Enunciado = "Quem é a namorada do Mickey?",
                    Alternativas = new()
                    {
                        new Alternativa {Correta = false, Descricao = "MARGARIDA"},
                        new Alternativa {Correta = true, Descricao = "MINNIE"},
                        new Alternativa {Correta = false, Descricao = "A PEQUENA SEREIA"},
                        new Alternativa {Correta = false, Descricao = "OLÍVIA PALITO"}
                    }
                },
                new Pergunta
                {
                    Id= 3,
                    Enunciado = "Qual era o apelido da cantora Elis Regina?",
                    Alternativas = new()
                    {
                        new Alternativa {Correta = false, Descricao = "GAUCHINHA"},
                        new Alternativa {Correta = false, Descricao = "PAULISTINHA"},
                        new Alternativa {Correta = true, Descricao = "PIMENTINHA"},
                        new Alternativa {Correta = false, Descricao = "ANDORINHA"}
                    }
                },
                new Pergunta
                {
                    Id= 4,
                    Enunciado = "Quem proclamou a república no Brasil em 1889?",
                    Alternativas = new()
                    {
                        new Alternativa {Correta = false, Descricao = "DUQUE DE CAXIAS"},
                        new Alternativa {Correta = false, Descricao = "MARECHAL RONDON"},
                        new Alternativa {Correta = false, Descricao = "DON PEDRO II"},
                        new Alternativa {Correta = true, Descricao = "MARECHAL DEODORO"}
                    }
                },
            
                new Pergunta
                {
                    Id= 5,
                    Enunciado= "Qual é o personagem dofolclore brasileiro que tem uma perna só?",
                    Alternativas= new()
                    {
                        new Alternativa{Correta = false, Descricao= "CUCA" },
                        new Alternativa{Correta = false, Descricao= "NEGRINHO DO PASTOREIO" },
                        new Alternativa{Correta = false, Descricao= "BOITATÁ" },
                        new Alternativa{Correta = true, Descricao= "SACI-PERERÊ" }
                    }
                     
                },
                new Pergunta
                {
                    Id= 6,
                    Enunciado= "O que era Frankenstein, de Mary Shelley?",
                    Alternativas= new()
                    {
                        new Alternativa{Correta = true, Descricao= "MONSTRO" },
                        new Alternativa{Correta = false, Descricao= "GORILA" },
                        new Alternativa{Correta = false, Descricao= "PRÍNCIPE" },
                        new Alternativa{Correta = false, Descricao= "SAPO" }
                    }
                },         
                new Pergunta
                {
                    Id= 7,
                    Enunciado= "Quando é comemorado o dia da independência do Brasil?",
                    Alternativas= new()
                    {
                        new Alternativa{Correta = false, Descricao= "21 DE ABRIL" },
                        new Alternativa{Correta = false, Descricao= "12 DE OUTUBRO" },
                        new Alternativa{Correta = true, Descricao= "7 DE SETEMBRO" },
                        new Alternativa{Correta = false, Descricao= "25 DE DEZEMBRO" }
                    }
                     
                   
                },
                new Pergunta
                {
                    Id= 8,
                    Enunciado= "Quantos signos formam o zodíaco?",
                    Alternativas= new()
                    {
                        new Alternativa{Correta = false, Descricao= "NOVE" },
                        new Alternativa{Correta = false, Descricao= "DEZ" },
                        new Alternativa{Correta = false, Descricao= "ONZE" },
                        new Alternativa{Correta = true, Descricao= "DOZE" }
                    }

                },
                new Pergunta
                {
                    Id= 9,
                    Enunciado= "Qual é o nome dado ao pneu reserva do carro?",
                    Alternativas= new()
                    {
                        new Alternativa{Correta = false, Descricao= "CALOTA" },
                        new Alternativa{Correta = true, Descricao= "ESTEPE" },
                        new Alternativa{Correta = false, Descricao= "MACACO" },
                        new Alternativa{Correta = false, Descricao= "CHAVE DE RODA" }
                    }
                },
                new Pergunta
                {

                    Id= 10,
                    Enunciado= "Quantas dentições naturais tem o ser humano durante a vida?",
                    Alternativas= new()
                    {
                        new Alternativa{Correta = false, Descricao= "UMA" },
                        new Alternativa{Correta = false, Descricao= "DUAS" },
                        new Alternativa{Correta = false, Descricao= "TRÊS" },
                        new Alternativa{Correta = false, Descricao= "QUATRO" }
                    }
                },
                new Pergunta
                {



                    Id= 11,
                    Enunciado= "Quem é o inimigo do Piu-Piu nos desenhos animados?",
                    Alternativas= new()
                    {
                        new Alternativa{Correta = false, Descricao= "FÉLIX" },
                        new Alternativa{Correta = false, Descricao= "TOM" },
                        new Alternativa{Correta = false, Descricao= "FRAJOLA" },
                        new Alternativa{Correta = false, Descricao= "MINGAU" }
                    }
                },
                new Pergunta
                {
                    Id= 12,
                    Enunciado= "Qual é a pedra preciosa mais dura encontrada na natureza?",
                    Alternativas= new()
                    {
                        new Alternativa{Correta = false, Descricao= "ESMERALDA" },
                        new Alternativa{Correta = false, Descricao= "RUBI" },
                        new Alternativa{Correta = false, Descricao= "PEROLA" },
                        new Alternativa{Correta = false, Descricao= "DIAMANTE" }
                    }
                },
                new Pergunta
                {
                    Id= 13,
                    Enunciado= "Qual é o réptil que muda de cor conforme o lugar em que está?",
                    Alternativas= new()
                    {
                        new Alternativa{Correta = false, Descricao= "SAPO" },
                        new Alternativa{Correta = false, Descricao= "CAMALEÃO" },
                        new Alternativa{Correta = false, Descricao= "LAGARTO" },
                        new Alternativa{Correta = false, Descricao= "JACARÉ" }




                    }
                         
                },
                new Pergunta
                {
                     Id= 14,
                     Enunciado= "O dromedário tem quantas corcovas???",
                     Alternativas= new()
                     {


                        new Alternativa{Correta = false, Descricao= "UMA" },
                        new Alternativa{Correta = false, Descricao= "DUAS" },
                        new Alternativa{Correta = false, Descricao= "TRES" },
                        new Alternativa{Correta = false, Descricao= "QUATRO" }

                     }
                },
                new Pergunta
                {
                     Id= 15,
                     Enunciado= "O violoncelo é um tipo de instrumento de??",
                     Alternativas= new()
                     {
                        new Alternativa{Correta = false, Descricao= "SOPRO" },
                        new Alternativa{Correta = false, Descricao= "CORDA" },
                        new Alternativa{Correta = false, Descricao= "PERCUSSÃO" },
                        new Alternativa{Correta = false, Descricao= "REPERCUSSÃO" }
                     }
                },
                new Pergunta
                {
                     Id= 16,
                     Enunciado= "Qual é o livro dividido em Velho Testamento e Novo Testamento?",
                     Alternativas= new()
                     {
                        new Alternativa{Correta = false, Descricao= "BIBLIA" },
                        new Alternativa{Correta = false, Descricao= "ENCICLOPEDIA" },
                        new Alternativa{Correta = false, Descricao= "DICIONARIO" },
                        new Alternativa{Correta = false, Descricao= "ATLAS" }
                     }
                },
                new Pergunta
                {
                     Id= 17,
                     Enunciado= "Quem tem por lema a frase:“Sempre alerta”?",
                     Alternativas= new()
                     {
                        new Alternativa{Correta = false, Descricao= "MEDICOS" },
                        new Alternativa{Correta = false, Descricao= "ESCOTEIROS" },
                        new Alternativa{Correta = false, Descricao= "BOMBEIROS" },
                        new Alternativa{Correta = false, Descricao= "POLICIAIS" }
                     }
                 },
                new Pergunta
                {
                     Id= 18,
                     Enunciado= "Qual é a cor que se associa com os grupos ecológicos?",
                     Alternativas= new()
                     {
                        new Alternativa{Correta = false, Descricao= "PRETA" },
                        new Alternativa{Correta = false, Descricao= "VERMELHA" },
                        new Alternativa{Correta = false, Descricao= "AZUL" },
                        new Alternativa{Correta = false, Descricao= "VERDE" }
                     }
                },
                new Pergunta
                {
                     Id= 19,
                     Enunciado= "O churrasco é considerado uma comida típica de qual estado?",
                     Alternativas= new()
                     {
                        new Alternativa{Correta = false, Descricao= "CEARA" },
                        new Alternativa{Correta = false, Descricao= "RIO GRANDE DO SUL" },
                        new Alternativa{Correta = false, Descricao= "PARÁ" },
                        new Alternativa{Correta = false, Descricao= "MARANHÃO" }
                     }
                },
                new Pergunta
                {
                     Id= 20,
                     Enunciado= "Como se chama o lugar onde se guardam vinhos?",
                     Alternativas= new()
                     {
                        new Alternativa{Correta = false, Descricao= "ADEGA" },
                        new Alternativa{Correta = false, Descricao= "BIBLIOTECA" },
                        new Alternativa{Correta = false, Descricao= "SÓTÃO" },
                        new Alternativa{Correta = false, Descricao= "SALA" }
                     }
                },
        }
         List<Pergunta> perguntas_medias = new()
         {
              new Pergunta
              {
                     Id= 1,
                     Enunciado= "Qual é o país do tango?",
                     Alternativas= new()
                     {
                        new Alternativa{Correta = false, Descricao= "URUGUAI" },
                        new Alternativa{Correta = false, Descricao= "ARGENTINA" },
                        new Alternativa{Correta = false, Descricao= "PARAGUAI" },
                        new Alternativa{Correta = false, Descricao= "ESPANHA" }
                     }
              },
              new Pergunta
              {
                     Id= 2,
                     Enunciado= "Sashimi é um prato originário de qual país?",
                     Alternativas= new()
                     {
                        new Alternativa{Correta = false, Descricao= "JAPÃO" },
                        new Alternativa{Correta = false, Descricao= "CHINA" },
                        new Alternativa{Correta = false, Descricao= "ÍNDIA" },
                        new Alternativa{Correta = false, Descricao= "INDONÉSIA" }
                     }
              },
              new Pergunta
              {
                     Id= 3,
                     Enunciado= "Qual é o ponto mais alto da Terra?",
                     Alternativas= new()
                     {
                        new Alternativa{Correta = false, Descricao= "EVEREST" },
                        new Alternativa{Correta = false, Descricao= "MONTE SINAI" },
                        new Alternativa{Correta = false, Descricao= "MONTE CASTELO" },
                        new Alternativa{Correta = false, Descricao= "MONT BLANC" }
                     }
              },
              new Pergunta
              {
                     Id= 4,
                     Enunciado= "Quantos quilates tem o ouro puro?",
                     Alternativas= new()
                     {
                        new Alternativa{Correta = false, Descricao= "18" },
                        new Alternativa{Correta = false, Descricao= "20" },
                        new Alternativa{Correta = false, Descricao= "24" },
                        new Alternativa{Correta = false, Descricao= "30" }
                     }
              },
              new Pergunta
              {
                     Id= 4,
                     Enunciado= "Qual cantor ficou conhecido como “O rei da voz”?",
                     Alternativas= new()
                     {
                        new Alternativa{Correta = false, Descricao= "ORLANDO SILVA" },
                        new Alternativa{Correta = false, Descricao= "VICENTE CELESTINO" },
                        new Alternativa{Correta = false, Descricao= "FRANCISCO ALVES" },
                        new Alternativa{Correta = false, Descricao= "CARLOS GALHARDO" }
                     }
              },
















