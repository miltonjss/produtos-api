using System.ComponentModel.DataAnnotations.Schema;

namespace ProdutosAPI.Models;

[Table("produtos")]
public class Produto
{
    public int id { get; set; }
    public string nome { get; set; }
    public decimal preco { get; set; }
    public int quantidade { get; set; }
}
