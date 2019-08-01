using EricCupueran_ExamenVueling.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EricCupueran_ExamenVueling.Clases
{
    public class Soldado : IUniverse, ISoldado
    {
        private string nameSoldado;
        private string tipo;

        public Soldado() { }
        public Soldado(string nameRebelde)
        {
            nameSoldado = nameRebelde;
        }

        public string NameSoldado { get => nameSoldado; set => nameSoldado = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        public string GetName()
        {
            return NameSoldado;
        }

        public void SetName(string name)
        {
            NameSoldado = name;
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