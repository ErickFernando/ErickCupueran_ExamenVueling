
using EricCupueran_ExamenVueling.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EricCupueran_ExamenVueling.Clases
{
    public class Planeta : IUniverse,IPlaneta
    {
        private string namePlaneta;
        private string tipo;

        public Planeta() { }
        public Planeta(string nameRebelde)
        {
            namePlaneta = nameRebelde;
        }

        public string NamePlaneta { get => namePlaneta; set =>namePlaneta= value; }
        public string Tipo { get => tipo; set => tipo = value; }

        public string GetName()
        {
            return namePlaneta;
        }

        public void SetName(string name)
        {
            NamePlaneta = name;
        }

        public void SetTipo(string tipo)
        {
            Tipo = tipo;
        }

        public string tipoPersona()
        {
            return tipo;
        }
    }
}