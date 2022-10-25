public class ContoCorrente
{

    public int _numeroConto;
    public int _codiceCliente;
    public int _saldo;
    public string _dataAperturaConto;
    public string _IBAN;

    public ContoCorrente(int NumConto, int CodCli,int saldo,string Data,string IBAN)
    {
        _numeroConto = NumConto;
        _codiceCliente = CodCli;    
        _saldo = saldo; 
        _dataAperturaConto = Data;
        _IBAN = IBAN;
    }
}
