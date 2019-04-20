using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPelota.Clase
{
    public interface  IOperaciones
    {
        void AgregarCaracteristicas(Pelota pelotas);
        void AgregarCaracteristicas(int Serie);
        void EliminarCaracteristicas(Pelota pelotas);
        void EliminarCaracteristicas(int Serie, string modelo);
    }
}
