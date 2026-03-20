using System;
abstract class Figura
{
    public abstract double calcularArea();
}


class Circulo extends Figura
{
    private double radio;

public Circulo(double radio)
{
    this.radio = radio;
}

@Override
    public double calcularArea()
{
    double area = Math.PI * radio * radio;
    return Math.round(area * 100.0) / 100.0;
}
} 
class Rectangulo extends Figura
{
    private double base;
private double altura;

public Rectangulo(double base, double altura)
{
    this.base = base;
    this.altura = altura;
}

@Override
    public double calcularArea()
{
    return base * altura;
}
}


public class Main
{
    public static void main(String[] args)
    {
        Figura f1 = new Circulo(5);
        Figura f2 = new Rectangulo(4, 6);

        System.out.println("Área círculo: " + f1.calcularArea());
        System.out.println("Área rectángulo: " + f2.calcularArea());
    }
}