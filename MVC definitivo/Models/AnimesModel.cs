using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_definitivo.Models
{
    public class AnimesModel
    {
        public string Nome { get; set; }
        public string Protagonista { get; set; }
        public int Episodios { get; set; }
        public string Lançamento { get; set; }

        public static List<AnimesModel> CriarList()
        {
            var list = new List<AnimesModel>();
            list.Add(new AnimesModel() { Nome = "Samurai-X", Protagonista = "Kenshin Rorouini", Episodios = 94, Lançamento = "10 de Janeiro de 1996" });
            list.Add(new AnimesModel() { Nome = "Chainsaw Man", Protagonista = "Denji", Episodios = 12, Lançamento = "12 de Outubro de 2022" });
            list.Add(new AnimesModel() { Nome = "Naruto Shippuden", Protagonista = "Naruto Uzumaki", Episodios = 500, Lançamento = "15 de Fevereiro de 2007" });
            list.Add(new AnimesModel() { Nome = "Jujutsu Kaisen", Protagonista = "Yujji Itadori", Episodios = 34, Lançamento = "2 de Outubro de 2020" });
            return list;
        }
    }
}
