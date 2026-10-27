using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercitacion2
{
    internal class EjercicioC
    {
        public interface IAlarmaObserver
        {
            void Actualizar(Alarma alarma);
        }
        public class Alarma
        {
            private readonly List<IAlarmaObserver> _observadores = new List<IAlarmaObserver>();
            public void Suscribir(IAlarmaObserver o) => _observadores.Add(o);
            public void Desuscribir(IAlarmaObserver o) => _observadores.Remove(o);
            public void Sonar()
            {
                Console.WriteLine("¡Riiiing!");
                foreach (var o in _observadores.ToList()) // ← algo está mal acá
                    o.Actualizar(this);
            }
        }
        public class AvisoUnico : IAlarmaObserver
        {
            public void Actualizar(Alarma alarma)
            {
                Console.WriteLine("Me avisaron una vez y me doy de baja");
                alarma.Desuscribir(this);
            }
        }
        public class Luz : IAlarmaObserver
        {
            public void Actualizar(Alarma alarma) => Console.WriteLine("Luz encendida");
        }

        // ============================================
        // SECCIÓN C — Pregunta 1
        // Respuesta: [tu respuesta acá]
        // ¿Por qué?: [tu explicación con tus palabras]
        // ============================================
    }
}
