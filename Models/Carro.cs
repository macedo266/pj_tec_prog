namespace Projeto_do_semestre.Models
{
    public class Carro
    {
        public int Id { get; set; }
        public string Nome { get; set; } = String.Empty;
        public string Descricao { get; set; } = String.Empty;
        public int Ano { get; set; }
        public int Quilometragem { get; set; }
        public string Cambio { get; set; } = String.Empty;
        public double Preco { get; set; }


    }
}
