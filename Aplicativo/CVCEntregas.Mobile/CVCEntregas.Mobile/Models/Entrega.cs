namespace CVCEntregas.Mobile.Models;

public class Entrega
{
    public int Id { get; set; }
    public string ClienteNome { get; set; }
    public string Endereco { get; set; }
    public string DescricaoItens { get; set; } // Ex: "200 Tijolos cerâmicos (9x19)"
    public string Status { get; set; } // "Pendente" ou "Entregue"
    public string CorStatus => Status == "Entregue" ? "#2E7D32" : "#D32F2F";
}