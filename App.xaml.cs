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
              new Pergunta
              {
                     Id= 5,
                     Enunciado= "Quantos jogadores um jogo de vôlei reúne na quadra?",
                     Alternativas= new()
                     {
                        new Alternativa{Correta = false, Descricao= "SEIS" },
                        new Alternativa{Correta = false, Descricao= "OITO" },
                        new Alternativa{Correta = false, Descricao= "DEZ" },
                        new Alternativa{Correta = false, Descricao= "DOZE" }
                     }
              },
              new Pergunta
              {
                     Id= 6,
                     Enunciado= "Como é chamado quem nasce em Milão, na Itália?",
                     Alternativas= new()
                     {
                        new Alternativa{Correta = false, Descricao= "MILANESE" },
                        new Alternativa{Correta = false, Descricao= "MILANOSO" },
                        new Alternativa{Correta = false, Descricao= "MILISTA" },
                        new Alternativa{Correta = false, Descricao= "MILANÊS" }
                     }
              },
              new Pergunta
              {
                     Id= 7,
                     Enunciado= "Que profissional usa uma ferramenta chamada formão??",
                     Alternativas= new()
                     {
                        new Alternativa{Correta = false, Descricao= "CARPINTEIRO" },
                        new Alternativa{Correta = false, Descricao= "RELOJOEIRO" },
                        new Alternativa{Correta = false, Descricao= "CONFEITEIRO" },
                        new Alternativa{Correta = false, Descricao= "BOMBEIRO" }
                     }
              },
              new Pergunta
              {
                     Id= 8,
                     Enunciado= "Peroba é uma espécie de?",
                     Alternativas= new()
                     {
                        new Alternativa{Correta = false, Descricao= "INSETO" },
                        new Alternativa{Correta = true, Descricao= "ARVORE" },
                        new Alternativa{Correta = false, Descricao= "VERME" },
                        new Alternativa{Correta = false, Descricao= "VERDURA" }
                     }
              },
              new Pergunta
              {
                     Id= 9,
                     Enunciado= "O alpinismo é praticado em que lugar?",
                     Alternativas= new()
                     {
                        new Alternativa{Correta = false, Descricao= "MAR" },
                        new Alternativa{Correta = true, Descricao= "MONTANHA" },
                        new Alternativa{Correta = false, Descricao= "RIO" },
                        new Alternativa{Correta = false, Descricao= "PRAIA" }
                     }
              },
              new Pergunta
              {
                     Id= 10,
                     Enunciado= "O Coliseu é um monumento histórico de que cidade européia?",
                     Alternativas= new()
                     {
                        new Alternativa{Correta = false, Descricao= "PARIS" },
                        new Alternativa{Correta = true, Descricao= "COPENHAGUE" },
                        new Alternativa{Correta = false, Descricao= "ROMA" },
                        new Alternativa{Correta = false, Descricao= "LONDRES" }
                     }
              },
              new Pergunta
              {
                     Id= 11,
                     Enunciado= "Qual é a raça do personagem principal do filme “Beethoven”?",
                     Alternativas= new()
                     {
                        new Alternativa{Correta = false, Descricao= "FILA" },
                        new Alternativa{Correta = true, Descricao= "PASTOR ALEMÃO" },
                        new Alternativa{Correta = false, Descricao= "POODLE" },
                        new Alternativa{Correta = true, Descricao= "SÃO BERNARDO" }
                     }
              },
               new Pergunta
              {
                     Id= 12,
                     Enunciado= "Segundo a crença popular, a mula-sem-cabeça é mulher de quem?",
                     Alternativas= new()
                     {
                        new Alternativa{Correta = false, Descricao= "DO COROINHA" },
                        new Alternativa{Correta = true, Descricao= "DO PADRE" },
                        new Alternativa{Correta = false, Descricao= " DO SACRISTÃO" },
                        new Alternativa{Correta = false, Descricao= "DO BISPO" }
                     }
              },
               new Pergunta
              {
                     Id= 13,
                     Enunciado= "Que atriz protagonizou o filme “Titanic?",
                     Alternativas= new()
                     {
                        new Alternativa{Correta = false, Descricao= "CAMERON DIAZ" },
                        new Alternativa{Correta = true, Descricao= " KATE WINSLET" },
                        new Alternativa{Correta = false, Descricao= "BRIDGET FONDA" },
                        new Alternativa{Correta = false, Descricao= " CATHERINE ZETTA JONES" }
                     }
              },
               new Pergunta
              {
                     Id= 14,
                     Enunciado= "Como é chamada a doença que causa perda desigual da melanina?",
                     Alternativas= new()
                     {
                        new Alternativa{Correta = false, Descricao= "ASTIGMATISMO" },
                        new Alternativa{Correta = true, Descricao= " TENDINITE" },
                        new Alternativa{Correta = false, Descricao= "VITILIGO" },
                        new Alternativa{Correta = false, Descricao= " VITINGA" }
                     }
              },
               new Pergunta
              {
                     Id= 15,
                     Enunciado= "Qual é a moeda oficial da Alemanha?",
                     Alternativas= new()
                     {
                        new Alternativa{Correta = false, Descricao= "LIRA" },
                        new Alternativa{Correta = true, Descricao= " MARCO" },
                        new Alternativa{Correta = false, Descricao= "FRANCO" },
                        new Alternativa{Correta = false, Descricao= " LIBRA" }
                     }
              },
               new Pergunta
              {
                     Id= 16,
                     Enunciado= "Que planta era usada para fabricação de papel no antigo Egito",
                     Alternativas= new()
                     {
                        new Alternativa{Correta = true, Descricao= "PAPIRO" },
                        new Alternativa{Correta = false, Descricao= " EUCALIPTO" },
                        new Alternativa{Correta = false, Descricao= "OLIVEIRA" },
                        new Alternativa{Correta = false, Descricao= "MILHO" }
                     }
              },
                new Pergunta
              {
                     Id= 17,
                     Enunciado= "Quando começou e terminou a Primeira Guerra Mundial",
                     Alternativas= new()
                     {
                        new Alternativa{Correta = true, Descricao= "PAPIRO" },
                        new Alternativa{Correta = false, Descricao= " EUCALIPTO" },
                        new Alternativa{Correta = false, Descricao= "OLIVEIRA" },
                        new Alternativa{Correta = false, Descricao= "MILHO" }
                     }
              },
                new Pergunta
              {
                     Id= 18,
                     Enunciado= "Que rio corta a cidade de Londres, na Inglaterra",
                     Alternativas= new()
                     {
                        new Alternativa{Correta = true, Descricao= "TÂMISA" },
                        new Alternativa{Correta = false, Descricao= " SENA" },
                        new Alternativa{Correta = false, Descricao= "RENO" },
                        new Alternativa{Correta = false, Descricao= "AUBE" }
                     }
              },
                new Pergunta
              {
                     Id= 19,
                     Enunciado= "Qual é a letra do alfabeto que simboliza o número dez em algarismo romano?",
                     Alternativas= new()
                     {
                        new Alternativa{Correta = false, Descricao= "V" },
                        new Alternativa{Correta = false, Descricao= " D" },
                        new Alternativa{Correta = false, Descricao= "L" },
                        new Alternativa{Correta = true, Descricao= "X" }
                     }
              },
                new Pergunta
              {
                     Id= 20,
                     Enunciado= "Quem introduziu o futebol no Brasil?",
                     Alternativas= new()
                     {
                        new Alternativa{Correta = false, Descricao= "PELÉ" },
                        new Alternativa{Correta = false, Descricao= " JOÃO HAVELANGE" },
                        new Alternativa{Correta = false, Descricao= "CHARLES MILLER" },
                        new Alternativa{Correta = true, Descricao= "PAULO MACHADO" }
                     }
              },

        List<Pergunta> perguntas_dificeis = new()

                new Pergunta
              {
                     Id= 1,
                     Enunciado= "Em qual espécie o macho choca os ovos e a fêmea procura alimento?",
                     Alternativas= new()
                     {
                        new Alternativa{Correta = false, Descricao= "ANDORINHA" },
                        new Alternativa{Correta = false, Descricao= " PATO SELVAGEM" },
                        new Alternativa{Correta = true, Descricao= "PINGUIM" },
                        new Alternativa{Correta = false, Descricao= "MARRECO" }
                     }
              },
                new Pergunta
              {
                     Id= 2,
                     Enunciado= "Onde nasceu Van Gogh, o grande pintor impressionista?",
                     Alternativas= new()
                     {
                        new Alternativa{Correta = false, Descricao= "POLONIA" },
                        new Alternativa{Correta = false, Descricao= " FRANÇA" },
                        new Alternativa{Correta = false, Descricao= "ITALIA" },
                        new Alternativa{Correta = true, Descricao= "HOLANDA" }
                     }
              },
                new Pergunta
              {
                     Id= 3,
                     Enunciado= "Qual desses quatro pesos é o mais leve?",
                     Alternativas= new()
                     {
                        new Alternativa{Correta = false, Descricao= "10 ONÇAS" },
                        new Alternativa{Correta = false, Descricao= "10 GRAMAS" },
                        new Alternativa{Correta = false, Descricao= "10 QUILOS" },
                        new Alternativa{Correta = true, Descricao= "10 LIBRAS" }
                     }
              },
                new Pergunta
              {
                     Id= 4,
                     Enunciado= "Que ramo da pecuária ocupa se de bodes e cabras",
                     Alternativas= new()
                     {
                        new Alternativa{Correta = false, Descricao= "ASININO" },
                        new Alternativa{Correta = true, Descricao= "CAPRINO" },
                        new Alternativa{Correta = false, Descricao= "BUFALINO" },
                        new Alternativa{Correta = false, Descricao= "MUAR" }
                     }
              },

                new Pergunta
              {
                     Id= 5,
                     Enunciado= "Qual oceano tem o maior volume de água?",
                     Alternativas= new()
                     {
                        new Alternativa{Correta = false, Descricao= "ATLÂNTICO" },
                        new Alternativa{Correta = true, Descricao= "PACÍFICO" },
                        new Alternativa{Correta = false, Descricao= "ÍNDICO" },
                        new Alternativa{Correta = false, Descricao= "ÁRTICO" }
                     }
              },
                new Pergunta
              {
                     Id= 6,
                     Enunciado= "Qual foi o último presidente militar do Brasil?",
                     Alternativas= new()
                     {
                        new Alternativa{Correta = false, Descricao= "FERNANDO COLLOR" },
                        new Alternativa{Correta = true, Descricao= "JOÃO FIGUEIREDO" },
                        new Alternativa{Correta = false, Descricao= "TANCREDO NEVES" },
                        new Alternativa{Correta = false, Descricao= "JOÃO GOULART" }
                     }
              },
                new Pergunta
              {
                     Id= 7,
                     Enunciado= "Que conflito ideológico envolveu os EUA e a União Soviética?",
                     Alternativas= new()
                     {
                        new Alternativa{Correta = true, Descricao= "GUERRA FRIA" },
                        new Alternativa{Correta = false, Descricao= "GUERRA DO VIETNÃ" },
                        new Alternativa{Correta = false, Descricao= "GUERRA NAS ESTRELAS" },
                        new Alternativa{Correta = false, Descricao= "GUERRA DA CORÉIA" }
                     }
              },
                new Pergunta
              {
                     Id= 8,
                     Enunciado= "O trapézio é um músculo que está situado:",
                     Alternativas= new()
                     {
                        new Alternativa{Correta = true, Descricao= "NO PESCOÇO" },
                        new Alternativa{Correta = false, Descricao= "NO OMBRO" },
                        new Alternativa{Correta = false, Descricao= "NA CABEÇA" },
                        new Alternativa{Correta = false, Descricao= "NO BRAÇO" }
                     }
              },
                 new Pergunta
              {
                     Id= 9,
                     Enunciado= "Que parte do corpo humano é infectada pela cólera?",
                     Alternativas= new()
                     {
                        new Alternativa{Correta = false, Descricao= " GARGANTA" },
                        new Alternativa{Correta = true, Descricao= "INTESTINO" },
                        new Alternativa{Correta = false, Descricao= "PULMÕES" },
                        new Alternativa{Correta = false, Descricao= " RINS" }
                     }
              },
                 new Pergunta
              {
                     Id= 10,
                     Enunciado= "A união do espermatozóide com o óvulo origina uma célula chamada:",
                     Alternativas= new()
                     {
                        new Alternativa{Correta = true, Descricao= " ZIGOTO" },
                        new Alternativa{Correta = false, Descricao= "BIGOTO" },
                        new Alternativa{Correta = false, Descricao= " FETO" },
                        new Alternativa{Correta = false, Descricao= "  GAROTO" }
                     }
              },
                 new Pergunta
              {
                     Id= 11,
                     Enunciado= "Que nome recebe a foz de um rio que se abre para o mar?",
                     Alternativas= new()
                     {
                        new Alternativa{Correta = true, Descricao= " ALAGADO" },
                        new Alternativa{Correta = false, Descricao= "MANGUEZAL" },
                        new Alternativa{Correta = false, Descricao= " PÂNTANO" },
                        new Alternativa{Correta = false, Descricao= "  ESTUÁRIO" }
                     }
              },
                 new Pergunta
              {
                     Id= 12,
                     Enunciado= "Em que ano Ayrton Senna venceu o primeiro campeonato de Fórmula 1?",
                     Alternativas= new()
                     {
                        new Alternativa{Correta = true, Descricao= " 1987" },
                        new Alternativa{Correta = false, Descricao= "1990" },
                        new Alternativa{Correta = false, Descricao= " 1985" },
                        new Alternativa{Correta = false, Descricao= "  1988" }
                     }
              },
                 new Pergunta
              {
                     Id= 13,
                     Enunciado= "Qual é a menor República do mundo?",
                     Alternativas= new()
                     {
                        new Alternativa{Correta = true, Descricao= " MÔNACO" },
                        new Alternativa{Correta = false, Descricao= "SAN MARINO" },
                        new Alternativa{Correta = false, Descricao= " NOVA ZELÂNDIA" },
                        new Alternativa{Correta = false, Descricao= " CHINA" }
                     }
              },
                 new Pergunta
              {
                     Id= 14,
                     Enunciado= "De quem é a frase ”Penso, logo existo”",
                     Alternativas= new()
                     {
                        new Alternativa{Correta = true, Descricao= "  PLATÃO" },
                        new Alternativa{Correta = false, Descricao= " JÚLIO VERNE" },
                        new Alternativa{Correta = false, Descricao= "  ARISTÓTELES" },
                        new Alternativa{Correta = false, Descricao= "  RENÉ DESCARTES" }
                     }
              },
                  new Pergunta
              {
                     Id= 15,
                     Enunciado= "Quem construiu o primeiro telescópio astronômico completo",
                     Alternativas= new()
                     {
                        new Alternativa{Correta = true, Descricao= "  CYRUS MCCORMICK" },
                        new Alternativa{Correta = false, Descricao= " THOMAS EDISON" },
                        new Alternativa{Correta = false, Descricao= "  MICHELANGELO" },
                        new Alternativa{Correta = false, Descricao= "  GALILEU GALILEI\r\n" }
                     }
              },
























