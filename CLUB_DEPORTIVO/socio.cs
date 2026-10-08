using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CLUB_DEPORTIVO
{
    public class Socio : Persona
    {
        private DateTime fechaAlta;
        
        public Socio(string nombre, string apellido, string tipoDocumento, string numeroDocumento) : base(nombre, apellido, tipoDocumento, numeroDocumento)
        {
            //agrego la fecha de alta como atributo de la clase socio
            this.fechaAlta = DateTime.Now;  

        }
    }
}
