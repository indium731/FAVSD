namespace FaVSD;

public class Dokument
{
    public List<Artikel> artiklar;
    public DateTime skapad;
    public string skapadAv;
    public int totalPris
    {
        get
        {
            int temp = 0;
            foreach (Artikel a in artiklar)
            {
                temp += a.pris;
            }
            return temp;
        } private set;
    }
}
