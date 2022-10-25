using System;

namespace Classes.Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        { Banca banca = new Banca("Intesa San Paolo ", "Milano", "via Frentani 200", "12345678901");
            Console.WriteLine(banca._nome+" a: "+banca._sede+" in:"+banca._indirizzo+" P.iva: "+banca._P_iva);
            Console.WriteLine("\nLista Clienti:\n");
            Cliente cliente1 = new Cliente("Mario ", "Rossi ", "Via Milano 12", "18\\07\\1996", "sposato", "mrirss96p18d960p",3453433);
            Console.WriteLine(cliente1._nome+cliente1._cognome+"\nresidente in: "+cliente1._indirizzo+"\nNato il: "+cliente1._dataDiNascita+"\nstato sociale: "+cliente1._statoSociale+"\ncodice fiscale: "+cliente1._cf+"\nCodice cliente: "+cliente1._codiceCliente);
            Cliente cliente2 = new Cliente("\nLuigi ", "Verdi ", "Via Roma 12", "12\\02\\1993", "celibe", "lglvrd92p12d960p", 7685748);
            Console.WriteLine(cliente2._nome + cliente2._cognome + "\nresidente in: " + cliente2._indirizzo + "\nNato il: " + cliente2._dataDiNascita + "\nstato sociale: " + cliente2._statoSociale + "\ncodice fiscale: " + cliente2._cf + "\nCodice cliente: " + cliente2._codiceCliente);
            Console.WriteLine("\nLista Conti:\n");
            ContoCorrente conto1 = new ContoCorrente(238912, 3453433, 1500, "19/12/2021", "IT101209890238291");
            Console.WriteLine("Numero Conto: " + conto1._numeroConto + "\n" + "Codice Cliente: " + conto1._codiceCliente + "\n" + "Saldo Disponibile: " + conto1._saldo + "\n" + "Data di apertura del conto: " + conto1._dataAperturaConto + "\nCodice IBAN:" + conto1._IBAN);
            ContoCorrente conto2 = new ContoCorrente(423342, 7685748, 6343, "11/09/2017", "IT135456456238291");
            Console.WriteLine("\nNumero Conto: " + conto2._numeroConto + "\n" + "Codice Cliente: " + conto2._codiceCliente + "\n" + "Saldo Disponibile: " + conto2._saldo + "\n" + "Data di apertura del conto: " + conto2._dataAperturaConto + "\nCodice IBAN:" + conto2._IBAN);
        }

    }
}
