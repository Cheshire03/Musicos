class Musico
{
    public string Nombre{get;set;}

    public Musico(string n)
    {
        Nombre=n;
    }
    
    public void Saludo()
    {
        Console.WriteLine($"hola soy {Nombre}");
    }
    public virtual void Toca()
    {
        Console.WriteLine($"{Nombre} tocando su instrumento");
    }
}
class Bajista:Musico
{
    public string Bajo{get;set;}

    public Bajista(string n,string b):base(n)
    {
        Bajo=b;
    }
    public override void Toca()
    {
        Console.WriteLine($"{Nombre} tocando su {Bajo}");
    }
}
class Baterista:Musico
{
    public string Bateria{get;set;}
public Baterista(string n,string bt):base(n)
{
    Bateria=bt;
}
public override void Toca()
    {
        Console.WriteLine($"{Nombre} tocando su {Bateria}");
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        List<Musico> Queen=new List<Musico>();
        Queen.Add(new Musico("Freddie Mercury"));
        Queen.Add(new Bajista("Bryan May", "Stratocaster"));
        Queen.Add(new Baterista("Roger Taylor","Tama"));
        foreach(Musico m in Queen) m.Saludo();
        foreach(Musico m in Queen) m.Toca();
    }
}