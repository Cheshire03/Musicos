abstract class Musico
{
    public string Nombre{get;set;}

    public Musico(string n)
    {
        Nombre=n;
    }
    public virtual void GetSaludo()
    {
        Console.WriteLine($"hola soy {Nombre}");
    }

    public virtual void Saludo()
    {
        GetSaludo();
    }
    public /*virtual*/ abstract void Toca(); //los metodos abstractos, se delegan obligatoriamente a las clases heredadas

}
class Vocalista:Musico
{
    public string Voz{get;set;}

    public Vocalista(string n,string v):base(n)
    {
        Voz=v;
    }
    public override void Toca()
    {
        Console.WriteLine($"{Nombre} canta en {Voz}");
    }
    public override void GetSaludo()
    {
        base.GetSaludo() +" y soy vocalista";
    }
    public override void Saludo()
    {
        Console.WriteLine($"hola soy {Nombre} y soy cantante");
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
    public override void Saludo()
    {
        Console.WriteLine($"hola soy {Nombre} y soy bajista");
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
public override void Saludo()
    {
        Console.WriteLine($"hola soy {Nombre} y soy baterista");
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        List<Musico> Queen=new List<Musico>();
        Queen.Add(new Vocalista("Freddie Mercury","Baritono"));
        Queen.Add(new Bajista("Bryan May", "Stratocaster"));
        Queen.Add(new Baterista("Roger Taylor","Tama"));
        foreach(Musico m in Queen) m.Saludo();
        foreach(Musico m in Queen) m.Toca();
    }
}

// clases abstractas solo pueden generar referencias, no objetos
// virtual da la opcion de redifinir métodos en subclases
// override para redifinir un método de una clase heredada