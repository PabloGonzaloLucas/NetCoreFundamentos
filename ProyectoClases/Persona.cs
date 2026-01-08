using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    public enum TipoGenero { Masculino = 0, Femenino = 1}
    public enum Paises { España, Francia, Alemania, Andorra, Colombia}

    public class Persona
    {
        #region Constructores
        public Persona()
        {
            //this.Domicilio = new Direccion();
            Debug.WriteLine("Constructor PERSONA vacío");
        }
        public Persona(string nombre, string apellidos)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            Debug.WriteLine("Constructor PERSONA con dos parametros");
        }
        #endregion

        #region propiedades
        private string _DescripcionThis;
        public string this[int indice]
        {
            get { return this._DescripcionThis; }
            set
            {
                Random random = new Random();
                int dato = random.Next(1, 20);
                this._DescripcionThis = "Descripcion " + dato;
            }
        }
        public Direccion Domicilio { get; set; }
        public Direccion DomicilioVacaciones { get; set; }
        private TipoGenero _Genero { get; set; }
        public TipoGenero Genero {
            get { return this._Genero; } 
            set
            {
                if(value != TipoGenero.Femenino && value != TipoGenero.Masculino)
                {
                    throw new Exception("Donde vas, listo...");
                }
                else
                {
                    this._Genero = value;
                }
            }
        }
        public Paises Nacionalidad { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        private int _Edad;
        public int Edad
        {
            get { return this._Edad; }
            set 
            {
                if(value < 0)
                {
                    //this._Edad = 0;
                    throw new Exception("La edad no puede ser negativa");
                }
                else
                {
                    this._Edad = value;    
                }
            }
        }

        #endregion

        #region METODOS
        public string GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellidos;
        }

        public string GetNombreCompleto(bool orden)
        {
            return this.Apellidos + " " + this.Nombre;
        }

        public string GetNombreCompleto(int num1)
        {
            return (this.Nombre + " " + this.Apellidos).ToUpper();
        }
        public string GetNombreCompleto(int num1, int num2)
        {
            return this.GetNombreCompleto().ToLower();
        }
        public void GetNombreCompleto(string dato)
        {

        }

        #endregion 
    }
}
