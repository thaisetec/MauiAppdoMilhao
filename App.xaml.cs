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
                        new Alternativa { Correta = false, Descricao = "VAPOROSO" },
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
                        new Alternativa {Correta = false, Descricao = "OLÍVIA PALITO"},
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
                        new Alternativa {Correta = false, Descricao = "ANDORINHA"},
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
                        new Alternativa {Correta = true, Descricao = "MARECHAL DEODORO"},
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
                        new Alternativa{Correta = true, Descricao= "SACI-PERERÊ" },
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
                        new Alternativa{Correta = false, Descricao= "SAPO" },
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
                        new Alternativa{Correta = false, Descricao= "25 DE DEZEMBRO" },
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
                        new Alternativa{Correta = true, Descricao= "DOZE" },
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
                        new Alternativa{Correta = false, Descricao= "CHAVE DE RODA" },
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
                        new Alternativa{Correta = false, Descricao= "QUATRO" },
                    },
                    new Pergunta
            {
                    Id= 11,
                    Enunciado= "Quem é o inimigo do Piu-Piu nos\r\ndesenhos animados?",
                    Alternativas= new()
                    {
                        new Alternativa{Correta = false, Descricao= "FÉLIX" },
                        new Alternativa{Correta = false, Descricao= "TOM" },
                        new Alternativa{Correta = false, Descricao= "FRAJOLA" },
                        new Alternativa{Correta = false, Descricao= "MINGAU" },
                    },









