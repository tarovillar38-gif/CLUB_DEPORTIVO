using System;
using System.Collections.Generic;
using System.Text;

namespace CLUB_DEPORTIVO
{
    public class Persona
    {
        //vamos a definir los atributos de la clase persona
        private string nombre;
        private string apellido;
        private string tipoDocumento;
        private string numeroDocumento;

        //vamos a definir el constructor de la clase persona

        public Persona(string nombre, string apellido, string tipoDocumento, string numeroDocumento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.tipoDocumento = tipoDocumento;
            this.numeroDocumento = numeroDocumento;
        }
    }
}
