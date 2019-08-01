
using EricCupueran_ExamenVueling.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EricCupueran_ExamenVueling.Clases
{
   public  class Rebelde : IUniverse,IRebelde
    {
        private string nameRebelde;
        private string tipo;

        public Rebelde() { }
        public Rebelde(string nameRebelde)
        {
            NameRebelde = nameRebelde;
        }
        
        public string NameRebelde { get => nameRebelde; set => nameRebelde = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        public string GetName()
        {
            return NameRebelde;
        }

        public void SetName(string name)
        {
            NameRebelde = name;
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