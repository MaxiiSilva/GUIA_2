using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GuiaEjercitacion2
{
    internal class EjercicioA
    {
        // ============================================
        // SECCIÓN A — Pregunta 1
        // Respuesta: [c) El constructor private AppLogger() { }.]
        // ¿Por qué?: [Porque el constructor solo puede ser llamado dentro de la propia clase Apploger]
        // ============================================
        // ============================================
        // SECCIÓN A — Pregunta 2
        // Respuesta: [a) La instancia se crea la primera vez que alguien la pide, no antes.]
        // ¿Por qué?: [POrque cuando intean acceder a la propiedad,se crea la instancia por primera vez  y despues seimpre va adevoler la misma.]
        // ============================================
        // SECCIÓN A — Pregunta 3
        // Respuesta: [d) Reemplazar un condicional que elige entre variantes de un algoritmo por clases intercambiablesdetrás de una interfaz.]
        // ¿Por qué?: [Las otras respuestas hacian referncia a otros patrones, mencionando sigleton y factory y tambien a observe]
        // ============================================
        // SECCIÓN A — Pregunta 4
        // Respuesta: [b) Usa una estrategia a través de la interfaz y le delega el cálculo, sin saber cuál es.]
        // ¿Por qué?: [porque se definiod una IEstrategia, con el obejetivo de separar las distintas estrategias.]
        // ============================================
        // SECCIÓN A — Pregunta 5
        // Respuesta: [c) El medio de pago llega como texto ("QR", "EFECTIVO") desde un ComboBox y desde un JSON, yhay que crear el objeto correcto en varios lugares.]
        // ¿Por qué?: [porque recibe el texto y devuelve el objeto correspondiente, evitando repetir un if o un switch en distintas partes del programa.]
        // ============================================
        // SECCIÓN A — Pregunta 6
        // Respuesta: [a) En Factory Method, una superclase con lógica de negocio declara el método de creación y cads subclase decide qué producto concreto crear.]
        // ¿Por qué?: [simple facotory tiene como resposanbilidad crear objetos segun parametros, en cambio facory method delega a las subclases para que las creen]
        // ============================================
        // SECCIÓN A — Pregunta 7
        // Respuesta: [b) Una lista de referencias a objetos que implementan la interfaz suscriptora.]
        // ¿Por qué?: []
        // ============================================
        // SECCIÓN A — Pregunta 8
        // Respuesta: [d) El controller le sigue avisando a un formulario destruido: puede saltar una excepción y el objetonunca se libera de memoria.]
        // ¿Por qué?: [Porque por mas que cierres el form , va a seguir recibviendo avisos porque quedo guardado como suscripto]
        // ============================================
        // SECCIÓN A — Pregunta 9
        // Respuesta: [b) Suscriptor.]
        // ¿Por qué?: [porque al hacer click(es el evento) en el boton(Guardar) estas agregando un suscriptor.]
        // ============================================
        // SECCIÓN A — Pregunta 10
        // Respuesta: [c) Creás una clase que implementa la interfaz suscriptora y la suscribís en Program.cs.]
        // ¿Por qué?: [No necesito modificar nda en el controller, creo una nueva clase e implemto la interdaz, para no romper nada del codigo orignal.]
        // ============================================
    }
}
