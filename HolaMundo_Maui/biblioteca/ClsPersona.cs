using System;
using System.Collections.Generic;
using System.Text;

namespace biblioteca
{
    internal class ClsPersona
    {
        #region atributos
        private String _nombre;
        private String _apellidos;
        #endregion

        #region constructores
        public ClsPersona()
        {
            _nombre = "";
            _apellidos = "";
        }
        public ClsPersona(string nombre, string apellidos)
        {
            _nombre = nombre;
            _apellidos = apellidos;
        }

        #endregion

        #region propiedades
        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public String Apellidos
        {
            get { return _apellidos; }
            set { _apellidos = value; }
        }
        public String Direccion { get; set; }
        public String NombreCompleto
        {
            get { return $"Su nombre completo es {Nombre} {Apellidos}"; }
        }
        #endregion

        #region funciones y metodos

        #endregion

    }
}
