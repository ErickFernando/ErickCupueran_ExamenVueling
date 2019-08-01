
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EricCupueran_ExamenVueling.Interfaces
{
    public interface  IUniverse
    {
        string GetName();
        void SetName(String name);
        string tipoPersona();
        void SetTipo(String tipo);
    }
}