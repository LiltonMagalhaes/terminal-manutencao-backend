namespace TerminalBackend.Models;

public class OrdemServico
{
    public int Id { get; set; }
    public string Cliente { get; set; } = string.Empty;
    public int ClienteId { get; set; } // Para linkar com o cliente no futuro
    public string Data { get; set; } = string.Empty;
    public string Equipamento { get; set; } = string.Empty;
    public string Defeito { get; set; } = string.Empty;
    public string Solucao { get; set; } = string.Empty;
    public string Materiais { get; set; } = string.Empty;
    public string Status { get; set; } = "ABERTA";
}