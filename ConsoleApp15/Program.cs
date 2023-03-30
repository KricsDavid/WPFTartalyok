class Tartaly
{
    private string nev;
    private int a,b,c;
    private double aktLiter;

    public Tartaly(string nev, int a, int b, int c)
    {
        this.nev = nev;
        this.a = a;
        this.b = b;
        this.c = c;
        this.aktLiter = 0;
    }
    public Tartaly(String nev)
    {
        this.nev =nev;
        a = b = c = 10;
    }

    public double Terfogat
    {
        get { return this.a * this.b * this.c; }
    }
    public string Info()
    {
        return $"{this.nev}: {this.Terfogat * 1000:n1} cm3 = ({this.Terfogat:n2} liter)," +
            $" töltöttsége: {this.Toltottseg:n2}%, ({this.aktLiter:n2} liter)," +
            $" méretei: {this.a}x{this.b}x{this.c} cm";
    }
    public void DuplazMeretet()
    {
        this.a *= 2;
    }

    public void TeljesLeengedes()
    {
        this.aktLiter = 0;
    }

    public double Toltottseg
    {
        get => (this.aktLiter * 1000 / Terfogat) * 100;
    }
    public string Nev { get => nev; }
    public int aEl { get => a; }
    public int bEl { get => b; }
    public int cEl { get => c; }
    public double AktLiter { get => aktLiter; }

    public void Tolt(double mennyit)
    {

        if (Terfogat / 1000 < this.aktLiter + mennyit)
        {
            //todo Ez nem szép! Helyette kivételt kellene dobni!
            Console.WriteLine("Hiba! Nem lehet ennyit beletölteni!");
            return;
        }
        this.aktLiter += mennyit;
    }
}

class Program {
    static void Main(string[] args)
    {
        Tartaly nagytartaly, literes;

        Console.WriteLine(nagytartaly.Info());
        nagytartaly.Tolt(12500);
        nagytartaly.Tolt(5680);
        Console.WriteLine(nagytartaly.Info());
        Console.WriteLine();
        Console.WriteLine(literes.Info());
        literes.DuplazMeretet();
        literes.Tolt(0.56);
        Console.WriteLine(literes.Info());
        literes.TeljesLeengedes();
        literes.Tolt(1.6);
        Console.WriteLine(literes.Info());


        Console.ReadKey();
    }
}