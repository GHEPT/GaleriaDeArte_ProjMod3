using GaleriaDeArte.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Linq;

namespace GaleriaDeArte.Data
{
    public static class SeedDatabase
    {
        public static void initialize(IHost app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;
                var context = serviceProvider.GetRequiredService<GaleriaContext>();
                Random rnd = new();
                context.Database.Migrate(); // Mesma coisa que digitar "update-database" no terminal. Cria com base nos migrations.

                if (!context.Obra.Any())
                {
                    context.Obra.Add(new Obra
                    {
                        Imagem = "https://cdn.culturagenial.com/imagens/leonardo-da-vinci-mona-lisa-0-cke.jpg",
                        Nome = "Mona Lisa",
                        Autor = "Leonardo Da Vinci",
                        Descricao = "A pintura considerada a obra-prima de Leonardo da Vinci foi iniciada em 1503/1506 e acabou sendo concluída somente em 1517. Apesar de ser uma tela pequena, com apenas 77 cm por 53 cm, Monalisa fascina os espectadores com o seu sorriso enigmático. Atualmente o quadro se encontra no museu do Louvre, em Paris. Pintada a óleo sobre madeira, a imagem é um símbolo do renascimento francês. Também conhecida como Gioconda. Chama a atenção a naturalidade com que a protagonista é representada. A mulher, cuja identidade é até hoje desconhecida, ficou imortalizada naquele que talvez seja o retrato mais celebrado da pintura ocidental.",
                        Preco = 5500,
                        Data = new DateTime(1503, 05, 12)
                    });

                    context.Obra.Add(new Obra
                    {
                        Imagem = "https://cdn.culturagenial.com/imagens/1200px-van-gogh-starry-night-google-art-project-cke.jpg",
                        Nome = "A Noite Estrelada",
                        Autor = "Van Gogh",
                        Descricao = "A noite estrelada, pintada em 1889, é uma pintura a óleo em tela que mede 73,7 cm × 92,1 cm e se encontra atualmente no MoMA, em Nova Iorque.",
                        Preco = 50,
                        Data = new DateTime(1889, 12, 23)
                    });

                    context.Obra.Add(new Obra
                    {
                        Imagem = "https://cdn.culturagenial.com/imagens/maxresdefault-12-cke.jpg",
                        Nome = "Composição número 5 (1948)",
                        Autor = "Jackson Pollock",
                        Descricao = "O pintor norte americano Jackson Pollock é uma referência no mundo da pintura abstrata. Sua Composição número 5 foi pintada em 1948 e adquirida em 2006 por um comprador particular que ofereceu 140 milhões de dólares pela obra. A tela é enorme, possui 2,44 m x 1,22 m e foi executada com tinta líquida sobre um painel de fibra. Uma curiosidade bastante peculiar: enquanto pintava, Pollock tinha o hábito de fumar, por isso foi possível encontrar rastros da cinza do cigarro espalhados por toda a tela.",
                        Preco = 300,
                        Data = new DateTime(1948, 3, 1)
                    });

                    context.Obra.Add(new Obra
                    {
                        Imagem = "https://cdn.culturagenial.com/imagens/rene690-cke.jpg",
                        Nome = "A Traição das Imagens",
                        Autor = "René Magritte",
                        Descricao = "Representante do surrealismo, o pintor belga René Magritte criou obras polêmicas como A traição das imagens. O quadro de 63,5cm × 93,98cm foi pintado entre 1928 e 1929 e atualmente pertence a coleção do Museu de Arte do Condado de Los Angeles. A obra fazia parte de uma série revolucionária intitulada A traição das imagens, que procurava questionar os limites da representação.O trabalho do pintor fomentou uma série de discussões filosóficas como o ensaio composto por Michel Foucault.",
                        Preco = 19,
                        Data = new DateTime(1929, 11, 29)
                    });
                    context.Obra.Add(new Obra
                    {
                        Imagem = "https://cdn.culturagenial.com/imagens/899px-grant-devolson-wood-american-gothic-cke.jpg",
                        Nome = "Gótico Americano",
                        Autor = "Grant Wood",
                        Descricao = "A tela representante do regionalismo americano foi pintada por Grant Wood em 1930. Trata-se de um pequeno quadro a óleo com dimensões não muito grandes (78cm × 65.3 cm) que está disponível para apreciação do público no Instituto de Arte de Chicago. Na contramão da cultura europeizante, Wood quis retratar uma realidade tipicamente rural norte americana (o Midwest americano), valorizando o que havia no seu país de singular. A casa de campo em estilo neogótico ilustrada na tela de fato existiu, foi descoberta pelo pintor em Iowa do Sul.",
                        Preco = 4.8,
                        Data = new DateTime(1930, 7, 18)
                    });
                    context.Obra.Add(new Obra
                    {
                        Imagem = "https://cdn.culturagenial.com/imagens/restricted-0-0.jpg",
                        Nome = "Ponte Sobre Uma Lagoa de Lírios de Água",
                        Autor = "Claude Monet",
                        Descricao = "Ponte Sobre Uma Lagoa de Lírios de Água talvez seja a tela mais representativa do período impressionista. Pintada em 1899 pelo francês Claude Monet, a tela tem 93 cm x 74 cm e pertence ao acervo do Metropolitan Museum of Art. A tela faz parte de um conjunto de imagens produzidas por Monet durante os últimos anos de sua vida.A coletânea de pinturas a óleo Monet deu o nome de Nenúfares.A paisagem retratada trata - se do jardim do próprio pintor, na comunidade rural de Giverny, na França. Monet mudou-se para lá com a família em 1883 e adquiriu a propriedade sete anos mais tarde.",
                        Preco = 34.8,
                        Data = new DateTime(1899, 10, 10)
                    });
                    context.Obra.Add(new Obra
                    {
                        Imagem = "https://cdn.culturagenial.com/imagens/718px-the-kiss-gustav-klimt-google-cultural-institute-cke.jpg",
                        Nome = "O Beijo",
                        Autor = "Gustav Klimt",
                        Descricao = "A imagem O beijo, do austríaco Gustav Klimt, tem uma particularidade especial: conhecida como parte da fase dourada do artista, a tela foi pintada a óleo com folhas de ouro. O abraço envolvente remete a ideia do aconchego e da proteção. O beijo não é a sua única tela com tema amoroso, antes pelo contrário, o artista tem uma série de trabalhos dedicados ao afeto romântico. Há quem diga que a pintura retrata o próprio casal Klimt e Emilie Flöge. O primeiro nome dado pelo pintor a tela foi Casal de Namorados, mais tarde o título foi alterado para o singelo O beijo.Com 180 cm x 180 cm, o quadro foi pintado entre 1907 e 1908 e atualmente está sendo exibido na Galeria Belvedere da Áustria, na cidade de Viena.",
                        Preco = 15,
                        Data = new DateTime(1908, 8, 4)
                    });
                    context.Obra.Add(new Obra
                    {
                        Imagem = "https://cdn.culturagenial.com/imagens/755px-johannes-vermeer-1632-1675-the-girl-with-the-pearl-earring-1665-cke.jpg",
                        Nome = "Moça Com Brinco de Pérola",
                        Autor = "Johannes Vermeer",
                        Descricao = "A peça mais famosa do acervo do holandês Johannes Vermeer é, sem dúvida, Moça com brinco de pérola. Pintada a óleo por volta de 1665, a tela mede 44,5 cm × 39 cm e atualmente está no museu Mauritshuis, na cidade holandesa de Haia. Não se sabe até hoje quem é a moça retratada por Vermeer em sua tela, mas há quem diga que se trata da filha do pintor, uma menina com cerca de 13 anos.É curioso que a protagonista tenha sido pintada com um turbante, acessório pouco comum naquela época.Outra curiosidade é que a tela foi pintada sem qualquer rascunho, os ajustes de cor e luz foram feitos sem nenhum estudo prévio.",
                        Preco = 1.2,
                        Data = new DateTime(1665, 9, 2)
                    });
                    context.Obra.Add(new Obra
                    {
                        Imagem = "https://cdn.culturagenial.com/imagens/2012-01-20-15-37-020-cke.jpg",
                        Nome = "A Persistência da Memória",
                        Autor = "Salvador Dalí",
                        Descricao = "A pintura a óleo é o símbolo do surrealismo e mede cerca de 24 cm × 33 cm. Atualmente se encontra no MoMA, em Nova Iorque. O quadro foi pintado em apenas algumas horas, enquanto a mulher de Dalí e alguns amigos se divertiam no cinema. A tela consagrou os relógios derretidos e as formigas, ícones do pintor.",
                        Preco = 40,
                        Data = new DateTime(1931, 1, 31)
                    });
                    context.Obra.Add(new Obra
                    {
                        Imagem = "https://cdn.culturagenial.com/imagens/image-content-635182-20170403104358-cke.jpg",
                        Nome = "Guernica",
                        Autor = "Pablo Picasso",
                        Descricao = "O painel pintado a óleo pelo espanhol Pablo Picasso, em 1937, é enorme (349 cm × 776 cm) e tem como tema o bombardeamento ocorrido no dia 26 de abril de 1937, na cidade Guernica, país Basco. Complexidade, o trabalho demorou apenas um mês para ser executado.Guernica se encontra no museu Reina Sofia, em Madrid, Espanha.",
                        Preco = 250,
                        Data = new DateTime(1937, 11, 22)
                    });
                    context.Obra.Add(new Obra
                    {
                        Imagem = "https://i1.wp.com/arteref.com/wp-content/uploads/2019/04/the-creation-of-adam-michelangelo.jpg?w=900&ssl=1",
                        Nome = "A Criação de Adão",
                        Autor = "Michelangelo Buonarotti",
                        Descricao = "A Criação de Adão é um fresco de 280cm x 570cm,[ pintado por Michelangelo Buonarotti por volta de 1511, que fica no teto da Capela Sistina no Vaticano. A cena representa um episódio do Livro do Gênesis no qual Deus cria o primeiro homem: Adão.",
                        Preco = 185,
                        Data = new DateTime(1511, 05, 12)
                    });
                    context.Obra.Add(new Obra
                    {
                        Imagem = "https://i1.wp.com/arteref.com/wp-content/uploads/2019/04/medusa-de-caravaggio.jpg?w=859&ssl=1",
                        Nome = "Medusa",
                        Autor = "Caravaggio",
                        Descricao = "Medusa é uma pintura a óleo sobre tela montada sobre madeira (não é talha dourada), de Michel Angelo Merisi da Caravaggio, também conhecido apenas como Caravaggio.",
                        Preco = 7.5,
                        Data = new DateTime(1596, 11, 22)
                    });
                    context.Obra.Add(new Obra
                    {
                        Imagem = "https://i0.wp.com/arteref.com/wp-content/uploads/2019/04/night-watch-rembrandt.jpg?w=1000&ssl=1",
                        Nome = "A Ronda Noturna",
                        Autor = "Rembrandt",
                        Descricao = "Geralmente considerada como a magnum opus de Rembrandt, A Ronda Noturna é uma das pinturas mais conhecidas do Barroco. A peça é de propriedade do município de Amsterdã e faz parte da exposição permanente do Rijksmuseum, principal museu especializado em pintura neerlandesa.",
                        Preco = 11,
                        Data = new DateTime(1642, 3, 8)
                    });
                    context.Obra.Add(new Obra
                    {
                        Imagem = "https://i2.wp.com/arteref.com/wp-content/uploads/2019/04/Beheading-of-Saint-John-the-Baptist-caravaggio.jpg?w=1000&ssl=1",
                        Nome = "Decaptação de João Batista",
                        Autor = "Caravaggio",
                        Descricao = "A obra, criada quando Caravaggio estava sob a proteção dos Cavaleiros de Malta, é considerada uma das obras-primas do pintor e uma das obras mais importantes da pintura ocidental.",
                        Preco = 44.6,
                        Data = new DateTime(1608, 4, 5)
                    });
                    context.Obra.Add(new Obra
                    {
                        Imagem = "https://i1.wp.com/arteref.com/wp-content/uploads/2019/04/Olmpia-by-Edouard-Manet-painting.jpg?w=950&ssl=1",
                        Nome = "Olympia",
                        Autor = "Édouard Manet",
                        Descricao = "O quadro mostra uma mulher nua (“Olympia”) deitada em uma cama, enquanto uma serva lhe traz flores. Foram modelos Victorine Meurent e Laure. O olhar direto de Olympia causou choque e espanto quando a pintura foi exibida pela primeira vez, porque um certo número de detalhes na pintura a identificavam como uma prostituta. O governo francês adquiriu a pintura em 1890 após uma subscrição pública organizada por Claude Monet.",
                        Preco = 87.2,
                        Data = new DateTime(1863, 7, 30)
                    });
                    context.Obra.Add(new Obra
                    {
                        Imagem = "https://i0.wp.com/arteref.com/wp-content/uploads/2019/04/the-last-supper-mary-magdalene-painting.jpg?w=1000&ssl=1",
                        Nome = "A Última Ceia",
                        Autor = "Leonardo Da Vinci",
                        Descricao = "A Última Ceia (em italiano: L’Ultima Cena e também Il Cenacolo) é um afresco de Leonardo da Vinci para a igreja de Santa Maria delle Grazie em Milão, Itália, O trabalho presume-se que tenha sido iniciado por volta de 1495-96 e foi encomendado como parte de um plano de reformas na igreja e em seus edifícios conventuais pelo patrono de Leonardo, Ludovico Sforza, duque de Milão. Representa o episódio bíblico da Última Ceiade Jesus com os Apóstolos antes de ser preso e crucificado. É um dos bens culturais mais conhecidos e estimados do mundo.",
                        Preco = 135,
                        Data = new DateTime(1495, 2, 3)
                    });
                    context.Obra.Add(new Obra
                    {
                        Imagem = "https://i0.wp.com/arteref.com/wp-content/uploads/2019/04/The-Birth-of-Venus-Painting.jpg?w=1000&ssl=1",
                        Nome = "O Nascimento de Vênus",
                        Autor = "Sandro Botticelli",
                        Descricao = "O Nascimento de Vênus é uma pintura de Sandro Botticelli, encomendada por Lorenzo di Pierfrancesco de Médici para a Villa Medicea di Castello. A obra está exposta na Galleria degli Uffizi, em Florença, na Itália.Consiste de têmpera sobre tela e mede 175 cm de altura por 278,5 cm de largura. A pintura representa a deusa Vênus emergindo do mar, já mulher adulta, conforme descrito na mitologia romana.",
                        Preco = 42,
                        Data = new DateTime(1485, 8, 15)
                    });
                    context.Obra.Add(new Obra
                    {
                        Imagem = "https://i0.wp.com/arteref.com/wp-content/uploads/2019/04/the-scream-edvard-munch-poster.jpg?w=785&ssl=1",
                        Nome = "O Grito",
                        Autor = "Edvard Munch",
                        Descricao = "O Grito (em norueguês: Skrik) é uma série de quatro pinturas do norueguês Edvard Munch, 1893. A obra representa uma figura andrógina num momento de profunda angústia e desespero existencial. O plano de fundo é a doca de Oslofjord (em Oslo) ao pôr-do-Sol. O Grito é considerado uma das obras mais importantes do movimento expressionista e adquiriu um estatuto de ícone cultural, a par da Mona Lisa de Leonardo da Vinci.",
                        Preco = 188,
                        Data = new DateTime(1893, 9, 14)
                    });
                    context.Obra.Add(new Obra
                    {
                        Imagem = "https://i0.wp.com/arteref.com/wp-content/uploads/2019/04/Water-lilies-by-Claude-Monet.jpg?w=887&ssl=1",
                        Nome = "Nenúfares",
                        Autor = "Claude Monet",
                        Descricao = "Nenúfares (ou, em francês: Nymphéas) é uma série de aproximadamente 250 pinturas a óleo do pintor impressionista francês Claude Monet (1840-1926). Estas pinturas representam o jardim de floresde Monet em Giverny e foram o foco principal da produção artística de Monet nos últimos trinta anos da sua vida. Muitas das obras foram pintadas quando Monet já sofria de cataratas. Esta obra está no Musée d’Orsay.",
                        Preco = 24,
                        Data = new DateTime(1840, 3, 1)
                    });
                    context.Obra.Add(new Obra
                    {
                        Imagem = "https://i1.wp.com/arteref.com/wp-content/uploads/2019/04/abapuru.jpg?w=660&ssl=1",
                        Nome = "Abaporu",
                        Autor = "Tarsila do Amaral",
                        Descricao = "Hoje é a tela brasileira mais valorizada no mercado mundial das artes, com valor estimado de US$ 40 milhões. Foi comprada pelo colecionador argentino Eduardo Costantini por US$ 2,5 milhões, em 1995 em um leilão realizado na Christies. Anteriormente pertencia ao empresário brasileiro Raul Forbes desde 1985. Atualmente, a obra encontra-se exposta no Museu de arte latino-americana de Buenos Aires (MALBA).",
                        Preco = 40,
                        Data = new DateTime(1902, 9, 10)
                    });
                    context.Obra.Add(new Obra
                    {
                        Imagem = "https://i1.wp.com/arteref.com/wp-content/uploads/2019/04/abapuru.jpg?w=660&ssl=1",
                        Nome = "As Meninas",
                        Autor = "Diego Velázquez",
                        Descricao = "A composição enigmática e complexa da obra levanta questões sobre realidade e ilusão, criando uma relação incerta entre o observador e as figuras representadas. Por essas complexidades, As Meninas é uma das obras mais analisadas da pintura ocidental.",
                        Preco = 8,
                        Data = new DateTime(1656, 1, 20)
                    });
                }

                context.SaveChanges();

                var obras = context.Obra.ToList();
                if (!context.Lance.Any())
                {
                    context.Lance.Add(new Lance
                    {
                        Nome = "Eduardo Teodoro",
                        CPF = "333.666.999-10",
                        Proposta = 2.6,
                        ObraId = obras[rnd.Next(obras.Count)].Id
                    });
                    context.Lance.Add(new Lance
                    {
                        Nome = "Wellington Perazzoli",
                        CPF = "224.316.967-56",
                        Proposta = 14,
                        ObraId = obras[rnd.Next(obras.Count)].Id
                    });
                    context.Lance.Add(new Lance
                    {
                        Nome = "Eurico Nicario",
                        CPF = "278.886.541-87",
                        Proposta = 32,
                        ObraId = obras[rnd.Next(obras.Count)].Id
                    });
                }

                context.SaveChanges();
            }
        }
    }
}
