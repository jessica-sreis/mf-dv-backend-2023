using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dv_backend_2023.Models
{
    [Table("Consumos")]
    public class Consumo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Obrigatório informar a descrição")]

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a data")]

        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a valor")]
        public decimal valor { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a quilometragem!")]
        public int km { get; set; }

        [Display(Name = "Tipo de Combustível")]
        public TipoCombustivel tipo { get; set; }

        [Display(Name = "Veículo")]
        [Required(ErrorMessage = "Obrigatório informar o veículo!")]
        public int  VeiculoId { get; set; }

        [ForeignKey("VeiculoId")]
        public Veiculo Veiculo { get; set; }
    }

    public enum TipoCombustivel
    {
        Gasolina,
        Etanol
    }
}
