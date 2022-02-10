using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTecnica2022.Client.Helpers
{
    /// <summary>
    /// Interfaz para mostrar los mensajes de error
    /// </summary>
    public interface IMostrarMensajes
    {
        Task MostrarMensajeError(string mensaje);
    }
}
