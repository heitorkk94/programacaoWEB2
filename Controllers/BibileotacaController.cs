using Microsoft.AspNetCore.Mvc;
using Biblioteca.Models;
using System.Collections.Generic;
using System.Linq;

namespace Biblioteca.Controllers
{
    public class BibliotecaController : Controller
    {
        private static List<Livro> livros = new List<Livro>
        {
            new Livro { Id = 1, Titulo = "O Inferno", Autor = "Dante Alighieri", Ano = "1320", Genero = "Poesia Épica", Resumo = "A primeira parte da Divina Comédia, onde Dante desce aos nove círculos do Inferno guiado por Virgílio, encontrando castigos proporcionais aos pecados cometidos." },
            new Livro { Id = 2, Titulo = "Dom Casmurro", Autor = "Machado de Assis", Ano = "1899", Genero = "Romance Realista", Resumo = "O narrador, Bento Santiago, já velho e solitário (apelidado de Dom Casmurro), decide escrever suas memórias para unir as duas pontas da vida. Ele relembra a infância na Rua de Matacavalos, onde se apaixonou pela vizinha Capitu." },
            new Livro { Id = 3, Titulo = "As 48 Leis do Poder", Autor = "Robert Greene", Ano = "1998", Genero = "Não Ficção", Resumo = "Um guia clássico sobre poder, estratégia e influência humana. Baseado em histórias de grandes figuras históricas, revela as leis que governam a conquista e manutenção do poder." },
            new Livro { Id = 4, Titulo = "A Empregada", Autor = "Freida McFadden", Ano = "2023", Genero = "Suspense", Resumo = "Uma jovem empregada doméstica aceita trabalhar em uma mansão luxuosa. O que começa como um emprego comum rapidamente se transforma em um pesadelo cheio de segredos, mentiras e perigo." }
        };

        public IActionResult Index()
        {
            return View(livros);
        }
    }
}