using System;

class CuentaBancaria
{
    private double saldo;

   
    public CuentaBancaria(double saldoInicial)
    {
        saldo = saldoInicial;
    }

   
    public void Depositar(double monto)
    {
        if (monto > 0)
        {
            saldo += monto;
        }
    }

    
    public bool Retirar(double monto)
    {
        if (monto > 0 && saldo >= monto)
        {
            saldo -= monto;
            return true;
        }
        return false;
    }

   
    public double ObtenerSaldo()
    {
        return saldo;
    }
}

class Program
{
    static void Main(string[] args)
    {
        CuentaBancaria cuenta = new CuentaBancaria(1000);

        cuenta.Depositar(500);
        Console.WriteLine("Saldo: " + cuenta.ObtenerSaldo());

        if (cuenta.Retirar(300))
        {
            Console.WriteLine("Retiro exitoso");
        }
        else
        {
            Console.WriteLine("Fondos insuficientes");
        }

        Console.WriteLine("Saldo final: " + cuenta.ObtenerSaldo());
    }
}