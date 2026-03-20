using System;
using System.Collections.Generic;


{
    
    public abstract class Empleado
    {
        public string Nombre { get; set; }

        public Empleado(string nombre)
        {
            Nombre = nombre;
        }

        
        public virtual double CalcularSalario()
        {
            return 0.0;
        }
    }

 
    public class EmpleadoFijo : Empleado
    {
        private double salarioFijo;

        public EmpleadoFijo(string nombre, double salarioFijo) : base(nombre)
        {
            this.salarioFijo = salarioFijo;
        }

        public override double CalcularSalario()
        {
            return salarioFijo;
        }
    }

  
    public class EmpleadoPorHoras : Empleado
    {
        private int horas;
        private double valorHora;

        public EmpleadoPorHoras(string nombre, int horas, double valorHora) : base(nombre)
        {
            this.horas = horas;
            this.valorHora = valorHora;
        }

        public override double CalcularSalario()
        {
            return horas * valorHora;
        }
    }

   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Reto 4: Sistema de Empleados (Polimorfismo) ---\n");

            List<Empleado> nomina = new List<Empleado>();

            nomina.Add(new EmpleadoFijo("Juan Pérez", 1500.0));
            nomina.Add(new EmpleadoPorHoras("María García", 160, 10.5));
            nomina.Add(new EmpleadoFijo("Pedro López", 1800.0));
            nomina.Add(new EmpleadoPorHoras("Ana Torres", 80, 15.0));

            foreach (Empleado emp in nomina)
            {
                Console.WriteLine($"Empleado: {emp.Nombre}, Salario: ${emp.CalcularSalario():N2}");
            }

            Console.ReadKey();
        }
    }
}
