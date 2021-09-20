using GaleriaDeArte.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GaleriaDeArte.Services
{
    public class ObraStaticService : IObraService
    {
        List<Obra> getObras()
        {
            List<Obra> listaObras = new List<Obra>();
            listaObras.Add(new Obra
            {
                Id = 1,
                Imagem = "https://cdn.culturagenial.com/imagens/leonardo-da-vinci-mona-lisa-0-cke.jpg",
                Nome = "Mona Lisa",
                Autor = "Leonardo Da Vinci",
                Descricao = "A pintura considerada a obra-prima de Leonardo da Vinci foi iniciada em 1503/1506 e acabou sendo concluída somente em 1517. Apesar de ser uma tela pequena, com apenas 77 cm por 53 cm, Monalisa fascina os espectadores com o seu sorriso enigmático. Atualmente o quadro se encontra no museu do Louvre, em Paris. Pintada a óleo sobre madeira, a imagem é um símbolo do renascimento francês. Também conhecida como Gioconda. Chama a atenção a naturalidade com que a protagonista é representada. A mulher, cuja identidade é até hoje desconhecida, ficou imortalizada naquele que talvez seja o retrato mais celebrado da pintura ocidental.",
                Preco = 5500,
                Data = new DateTime(1503, 05, 12),
                Lances = new()
            });
            listaObras.Add(new Obra
            {
                Id = 2,
                Imagem = "https://cdn.culturagenial.com/imagens/1200px-van-gogh-starry-night-google-art-project-cke.jpg",
                Nome = "A Noite Estrelada",
                Autor = "Van Gogh",
                Descricao = "A noite estrelada, pintada em 1889, é uma pintura a óleo em tela que mede 73,7 cm × 92,1 cm e se encontra atualmente no MoMA, em Nova Iorque.",
                Preco = 50,
                Data = new DateTime(1889, 12, 23),
                Lances = new()
            });
            listaObras.Add(new Obra
            {
                Id = 3,
                Imagem = "https://cdn.culturagenial.com/imagens/maxresdefault-12-cke.jpg",
                Nome = "Composição número 5 (1948)",
                Autor = "Jackson Pollock",
                Descricao = "O pintor norte americano Jackson Pollock é uma referência no mundo da pintura abstrata. Sua Composição número 5 foi pintada em 1948 e adquirida em 2006 por um comprador particular que ofereceu 140 milhões de dólares pela obra. A tela é enorme, possui 2,44 m x 1,22 m e foi executada com tinta líquida sobre um painel de fibra. Uma curiosidade bastante peculiar: enquanto pintava, Pollock tinha o hábito de fumar, por isso foi possível encontrar rastros da cinza do cigarro espalhados por toda a tela.",
                Preco = 300,
                Data = new DateTime(1948, 3, 1),
                Lances = new()
            });
            listaObras.Add(new Obra
            {
                Id = 4,
                Imagem = "https://cdn.culturagenial.com/imagens/rene690-cke.jpg",
                Nome = "A Traição das Imagens",
                Autor = "René Magritte",
                Descricao = "Representante do surrealismo, o pintor belga René Magritte criou obras polêmicas como A traição das imagens. O quadro de 63,5cm × 93,98cm foi pintado entre 1928 e 1929 e atualmente pertence a coleção do Museu de Arte do Condado de Los Angeles. A obra fazia parte de uma série revolucionária intitulada A traição das imagens, que procurava questionar os limites da representação.O trabalho do pintor fomentou uma série de discussões filosóficas como o ensaio composto por Michel Foucault.",
                Preco = 19,
                Data = new DateTime(1929, 11, 29),
                Lances = new()
            });
            listaObras.Add(new Obra
            {
                Id = 5,
                Imagem = "https://cdn.culturagenial.com/imagens/899px-grant-devolson-wood-american-gothic-cke.jpg",
                Nome = "Gótico Americano",
                Autor = "Grant Wood",
                Descricao = "A tela representante do regionalismo americano foi pintada por Grant Wood em 1930. Trata-se de um pequeno quadro a óleo com dimensões não muito grandes (78cm × 65.3 cm) que está disponível para apreciação do público no Instituto de Arte de Chicago. Na contramão da cultura europeizante, Wood quis retratar uma realidade tipicamente rural norte americana (o Midwest americano), valorizando o que havia no seu país de singular. A casa de campo em estilo neogótico ilustrada na tela de fato existiu, foi descoberta pelo pintor em Iowa do Sul.",
                Preco = 4.8,
                Data = new DateTime(1930, 7, 18),
                Lances = new()
            });
            listaObras.Add(new Obra
            {
                Id = 6,
                Imagem = "https://cdn.culturagenial.com/imagens/restricted-0-0.jpg",
                Nome = "Ponte Sobre Uma Lagoa de Lírios de Água",
                Autor = "Claude Monet",
                Descricao = "Ponte Sobre Uma Lagoa de Lírios de Água talvez seja a tela mais representativa do período impressionista. Pintada em 1899 pelo francês Claude Monet, a tela tem 93 cm x 74 cm e pertence ao acervo do Metropolitan Museum of Art. A tela faz parte de um conjunto de imagens produzidas por Monet durante os últimos anos de sua vida.A coletânea de pinturas a óleo Monet deu o nome de Nenúfares.A paisagem retratada trata - se do jardim do próprio pintor, na comunidade rural de Giverny, na França. Monet mudou-se para lá com a família em 1883 e adquiriu a propriedade sete anos mais tarde.",
                Preco = 34.8,
                Data = new DateTime(1899, 10, 10),
                Lances = new()
            });
            listaObras.Add(new Obra
            {
                Id = 7,
                Imagem = "https://cdn.culturagenial.com/imagens/718px-the-kiss-gustav-klimt-google-cultural-institute-cke.jpg",
                Nome = "O Beijo",
                Autor = "Gustav Klimt",
                Descricao = "A imagem O beijo, do austríaco Gustav Klimt, tem uma particularidade especial: conhecida como parte da fase dourada do artista, a tela foi pintada a óleo com folhas de ouro. O abraço envolvente remete a ideia do aconchego e da proteção. O beijo não é a sua única tela com tema amoroso, antes pelo contrário, o artista tem uma série de trabalhos dedicados ao afeto romântico. Há quem diga que a pintura retrata o próprio casal Klimt e Emilie Flöge. O primeiro nome dado pelo pintor a tela foi Casal de Namorados, mais tarde o título foi alterado para o singelo O beijo.Com 180 cm x 180 cm, o quadro foi pintado entre 1907 e 1908 e atualmente está sendo exibido na Galeria Belvedere da Áustria, na cidade de Viena.",
                Preco = 15,
                Data = new DateTime(1908, 8, 4),
                Lances = new()
            });
            listaObras.Add(new Obra
            {
                Id = 8,
                Imagem = "https://cdn.culturagenial.com/imagens/755px-johannes-vermeer-1632-1675-the-girl-with-the-pearl-earring-1665-cke.jpg",
                Nome = "Moça Com Brinco de Pérola",
                Autor = "Johannes Vermeer",
                Descricao = "A peça mais famosa do acervo do holandês Johannes Vermeer é, sem dúvida, Moça com brinco de pérola. Pintada a óleo por volta de 1665, a tela mede 44,5 cm × 39 cm e atualmente está no museu Mauritshuis, na cidade holandesa de Haia. Não se sabe até hoje quem é a moça retratada por Vermeer em sua tela, mas há quem diga que se trata da filha do pintor, uma menina com cerca de 13 anos.É curioso que a protagonista tenha sido pintada com um turbante, acessório pouco comum naquela época.Outra curiosidade é que a tela foi pintada sem qualquer rascunho, os ajustes de cor e luz foram feitos sem nenhum estudo prévio.",
                Preco = 1.2,
                Data = new DateTime(1665, 9, 2),
                Lances = new()
            });
            listaObras.Add(new Obra
            {
                Id = 9,
                Imagem = "https://cdn.culturagenial.com/imagens/2012-01-20-15-37-020-cke.jpg",
                Nome = "A Persistência da Memória",
                Autor = "Salvador Dalí",
                Descricao = "A pintura a óleo é o símbolo do surrealismo e mede cerca de 24 cm × 33 cm. Atualmente se encontra no MoMA, em Nova Iorque. O quadro foi pintado em apenas algumas horas, enquanto a mulher de Dalí e alguns amigos se divertiam no cinema. A tela consagrou os relógios derretidos e as formigas, ícones do pintor.",
                Preco = 40,
                Data = new DateTime(1931, 1, 31),
                Lances = new()
            });
            listaObras.Add(new Obra
            {
                Id = 10,
                Imagem = "https://cdn.culturagenial.com/imagens/image-content-635182-20170403104358-cke.jpg",
                Nome = "Guernica",
                Autor = "Pablo Picasso",
                Descricao = "O painel pintado a óleo pelo espanhol Pablo Picasso, em 1937, é enorme (349 cm × 776 cm) e tem como tema o bombardeamento ocorrido no dia 26 de abril de 1937, na cidade Guernica, país Basco. Complexidade, o trabalho demorou apenas um mês para ser executado.Guernica se encontra no museu Reina Sofia, em Madrid, Espanha.",
                Preco = 250,
                Data = new DateTime(1937, 11, 22),
                Lances = new()
            });
            return listaObras;
        }

        public bool Create(Obra obra)
        {
            try
            {
                List<Obra> obras = getObras();
                obra.Id = obras.Count() + 1;
                obras.Add(obra);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int? id)
        {
            return false;            
        }

        public Obra Get(int? id)
        {
            return getObras().FirstOrDefault(o => o.Id == id);
        }

        public List<Obra> GetAll(string busca = null, bool ordenar = false)
        {
            if (busca != null)
            {
                return getObras().FindAll(a =>
                    a.Nome.ToLower().Contains(busca.ToLower())
                );
            }

            if (ordenar)
            {
                var lista = getObras();
                //lista.Sort((pa,pb) => pa.Nome.CompareTo(pb.Nome));
                lista = lista.OrderBy(p => p.Nome).ToList();
                return lista;
            }
            return getObras();
        }         
        
        public bool Update(Obra o)
        {
            return false;
        }
    }
}
