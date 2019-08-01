
using EricCupueran_ExamenVueling.Clases;
using EricCupueran_ExamenVueling.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EricCupueran_ExamenVueling.Factory
{
    public class Factory
    {

        public IUniverse getUniverse(string name) {
            switch (name) {
                case "Planeta":
                    return new Planeta();
                case "Rebelde":
                    return new Rebelde();
                case "Soldado":
                    return new Soldado();

            }
            return null;
        }
    }
}