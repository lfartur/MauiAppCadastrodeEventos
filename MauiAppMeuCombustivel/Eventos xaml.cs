namespace CadastroDeEventos.Models
{
    public class Evento
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; }
        public decimal CustoPorParticipante { get; set; }

        public int DuracaoDias => (int)(DataTermino - DataInicio).TotalDays + 1;

        public decimal CustoTotal => NumeroParticipantes * CustoPorParticipante;
    }
}