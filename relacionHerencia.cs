using System;

abstract class F{

    private string X;
    private double Y;
    private long Z;
    protected byte W;


     public F()
    {
        X  = "Ferreiras, Castro";
        Y  = 12.34E+12;
        Z = 987364354;
        W = 34;

    }
    
    public F(string x, double y, long z, byte w)
    {
        X = x;
        Y = y;
        Z = z;
        W = w;
    }

    public string getX()
    {
        return X;
    }

    public double getY()
    {
        return Y;
    }

    public long getZ()
    {
        return Z;
    }


    public void verObjeto()
    {
        Console.WriteLine("\n\tEstado del objeto...");
        Console.WriteLine("\n=> X {0}", getX());
        Console.WriteLine("\n=> Y {0}", getY());
        Console.WriteLine("\n=> Z {0}", getZ());
        Console.WriteLine("\n=> W " + W);
    }
}

class G : F{
    private int s;

    public G()
    {
        s = 9998833;
    }

   
}


//Tester-class

class TersterClass{

    public static void Main()
    {
        // F letra = new F();
        G letra0 = new G();

        letra0.verObjeto();
    }
}