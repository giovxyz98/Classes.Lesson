namespace Classes.Lesson
{
    public class Cliente
    {
        public string _nome;
        public string _cognome;
        public string _indirizzo;
        public string _dataDiNascita;
        public string _statoSociale;
        public string _cf;
        public int _codiceCliente;

        public Cliente(string nome, string cognome, string indirizzo, string datadinascita, string statosociale, string cf, int codiceCliente)
        {
            _nome = nome;
            _cognome = cognome;
            _indirizzo = indirizzo;
            _dataDiNascita = datadinascita;
            _statoSociale = statosociale;
            _cf = cf;
            _codiceCliente = codiceCliente;
        }
    }
}