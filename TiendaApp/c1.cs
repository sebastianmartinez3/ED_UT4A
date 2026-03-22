namespace TiendaApp;

public class c1 
{
    public int t; 
    public int a; 
        
    // Calcula el total
    // Devuelve True si va bien
    public decimal Calc(decimal p, int q) 
    {
        // Declaro r y le asigno p por q
        decimal r = p * q; 
            
        if (p > 0 && q > 0)
        {
            if (t == 1)
            {
                r = r * 0.90m;
            }
            else if (t == 2)
            {
                r = r * 0.80m;
                    
                if (a > 5)
                {
                    r = r - 5; 
                }
            }
        }
        else
        {
            throw new Exception("Error");
        }
            
        return r;
    }

    public void ImprimirFactura(decimal p, int q)
    {
        Console.WriteLine("***************************");
        Console.WriteLine("**** FACTURA DE COMPRA ****");
        Console.WriteLine("***************************");
        decimal total = Calc(p, q);
        Console.WriteLine("Total a pagar: " + total + " EUR");
        Console.WriteLine("Gracias por su visita.");
    }
}