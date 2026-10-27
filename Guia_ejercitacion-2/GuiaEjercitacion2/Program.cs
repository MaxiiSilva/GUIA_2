using System;
using static GuiaEjercitacion2.EjercicioB;
using static GuiaEjercitacion2.EjercicioC;
namespace GuiaEjercitacion2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //EjercicioB1 a
            var a = EjercicioB.Instancia;
            var b = EjercicioB.Instancia;
            Console.WriteLine(a.Siguiente());
            Console.WriteLine(b.Siguiente());
            Console.WriteLine(EjercicioB.Instancia.Siguiente());
            Console.WriteLine(ReferenceEquals(a, b));

            //EjercicioB2 b
            var Cuenta = new Cuenta(new SinPropina());
            Cuenta.Mostrar(20000);
            Cuenta.CambiarPropina(new Propina10());
            Cuenta.Mostrar(20000);
            Cuenta.CambiarPropina(new PropinaFija(1500));
            Cuenta.Mostrar(20000);

            //EjercicioB3 c
            var canal = new Canal();
            var lu = new Fan("Lu");
            canal.Suscribir(lu);
            canal.Suscribir(new Fan("Tomi"));
            canal.Suscribir(new Estadisticas());
            canal.Publicar("Patrones en C#");
            canal.Desuscribir(lu);
            canal.Publicar("Observer en WinForms");

            // EjercicioC:
            var alarma = new Alarma();
            alarma.Suscribir(new AvisoUnico());
            alarma.Suscribir(new Luz());
            alarma.Sonar();
        }
    }
}
