using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercitacion2
{
    public class EjercicioB
    {
        private static EjercicioB _Instancia;
        private int _Valor = 0;

        private EjercicioB() { Console.WriteLine("Creando Contador..."); }

        public static EjercicioB Instancia
        {
            get {
                if (_Instancia == null)
                 
                    _Instancia = new EjercicioB();
                    return _Instancia;
                }
        }
        public int Siguiente(){
            _Valor ++;
            return _Valor;  
        }
        // ============================================
        // SECCIÓN B — Pregunta 1
        /* Respuesta: [¿Qué imprime?: Crando contador 1,2,3 y TRUE]
        //[¿Cuántas veces aparece "Creando contador" y por qué?:
            Creando Contador se muestra una sola vez, porque cuando 
            se instacio la primera vez aparece, y cuando se llama a 
            la instrancia las otras veces ya existe entocnes no aparece otro mebsaje]
        //[¿Por qué b.Siguiente() no devuelve 1?:Porque cuadno creamos el metodo Siguiente. _Valor es 
            autoincrementable por eso Bno vale 1, porque A lo llama primero entonces es 1,
            y cuando lo llama B es 2.]
        */
        // ============================================

        public interface IPropina{
             string Nombre { get; }
             decimal Calcular(decimal Total);
        }
        public class SinPropina : IPropina 
        {
            public string Nombre => "Sin propina";
            public decimal Calcular(decimal Total) => 0;
        }
        public class Propina10 : IPropina 
        {
            public string Nombre => "10%";
            public decimal Calcular(decimal Total) => Total * 0.10m;
        }
        public class PropinaFija : IPropina 
        {
            private readonly decimal _Monto;
            public  PropinaFija(decimal Monto) => _Monto = Monto;
            public string Nombre => "Propina Fija";
            public decimal Calcular(decimal Total) => _Monto;
        }
        public class Cuenta 
        {
            private IPropina _Propina;
            public Cuenta(IPropina propina) => _Propina = propina; 
            public void CambiarPropina(IPropina propina) => _Propina =propina;
            public void Mostrar(decimal Total){ 
                decimal Final = Total +_Propina.Calcular(Total);
                Console.WriteLine($"{_Propina.Nombre}: {Final:0}");
            }
        }
        // ============================================
        // SECCIÓN B — Pregunta 2
        // /*Respuesta: [¿Qué imprime?: Sin Propina:20000, 10%: 22000 y Propina fija: 21500]
        //   [¿quién es el contexto y quiénes son las estrategias?: El contexto es la Class Cuenta.
        //   Y las estrategias son SinPropina,Propina10 yPropinaFija]
        //    [¿Qué hubo que modificar de Cuenta para poder usar PropinaFija? ¿Qué principio se cumple?:
        //    No hubo que modifcarn nada, ya que Propina fija y Cuenta usan la misma interfaz.
        //    El principio que se cumple esOpen/Closed]
        //    */
        // ============================================
        public interface IObservador 
        {
            void Actualizar(string video);
        }
        public class Canal
        {
            private readonly List<IObservador> _suscriptores = new List<IObservador>();
            public void Suscribir(IObservador o) => _suscriptores.Add(o);
            public void Desuscribir(IObservador o) => _suscriptores.Remove(o);
            public void Publicar(string video)
            {
                Console.WriteLine($"Nuevo video: {video}");
                foreach (var s in _suscriptores.ToList())
                    s.Actualizar(video);
            }

        }
        public class Fan : IObservador
        {
            private readonly string _nombre;
            public Fan(string nombre) => _nombre = nombre;
            public void Actualizar(string video) => Console.WriteLine($" {_nombre} mira {video}");
        }
        public class Estadisticas : IObservador
        {
            private int _avisos = 0;
            public void Actualizar(string video)
            {
                _avisos++;
                Console.WriteLine($" Avisos registrados: {_avisos}");
            }
        }

        // ============================================
        // SECCIÓN B — Pregunta 3
        // Respuesta: [¿Qué imprime?:Nuevo video: Patrones en C#,Lu mira Patrones en C#,
        // Tomi mira Patrones en C#, Avisos registrados: 1 ,Nuevo video: Observer en WinForms,
        // Tomi mira Observer en WinForms, Avisos registrados: 2]
        // [¿Por qué Lu no aparece en la segunda publicación?:Lu no aparece porque se desuscribiodel canal]
        // [¿Canal conoce la clase Fan? ¿Cómo te das cuenta mirando el código?: Esta no la entendi bien, yo creo que no porque Canal NO hereda de la interfaz. I]
        // ============================================
    }
}
