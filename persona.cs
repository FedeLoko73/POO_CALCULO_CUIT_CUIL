using System;
using System.Collections.Generic;
using System.Text;

namespace prog_orientada_objetos
{
    class persona
    {
        private int p_legajo;
        public int legajo
        {
            get
            {
                return p_legajo;
            }
            set
            {
                p_legajo = value;
            }
        }
        public persona()
        {
            this.legajo = 0;
            this.apellido = " ";
            this.nombre = " ";
            this.dni = 0;
            this.sexo = 'M';
            this.cat = "peon";
            this.salario = 0;
        }
        public persona(int n_legajo, int p_dni)
        {
            this.legajo = n_legajo;
            this.dni = p_dni;
            this.apellido = " ";
            this.nombre = " ";
            this.sexo = 'M';
            this.cat = "peon";
            this.salario = 0;
        }

         public persona(int n_legajo)
         {
        this.legajo=(n_legajo);
         }
        private string p_apellido;
        public string apellido
        {
            get
            {
                return p_apellido;
            }
            set
            {
                p_apellido = value;
            }
        }
        private string p_nombre;
        public string nombre
        {
            get
            {
                return p_nombre;
            }
            set
            {
                p_nombre = value;
            }
        }
        private int p_dni;
        public int dni
        {
            get
            {
                return p_dni;
            }
            set
            {
                p_dni = value;
            }
        }
        private char p_sexo;
        public char sexo
        {
            get
            {
                return p_sexo;
            }
            set
            {
                p_sexo = value;
            }
        }
        private string p_cat;
        public string cat
        {
            get
            {
                return p_cat;
            }
            set
            {
                p_cat = value;
            }
        }
        private float p_salario;
        public float salario
        {
            get
            {
                return p_salario;
            }
            set
            {
                p_salario = value;
            }
        }
        private string p_cuil, cadena;
        private int suma, aux, div, resto, dv, xy;
        public string cuil
        {
            get
            {
                if (p_sexo == 'M')
                {
                    suma = 2 * 5;
                    suma = suma + (0 * 4);
                    cadena = p_dni.ToString();
                    cadena = cadena.Substring(0,1);
                    int.TryParse(cadena, out aux);
                    suma = suma + (aux * 3);
                    cadena = p_dni.ToString();
                    cadena = cadena.Substring(1,1);
                    int.TryParse(cadena, out aux);
                    suma = suma + (aux * 2);
                    cadena = p_dni.ToString();
                    cadena = cadena.Substring(2,1);
                    int.TryParse(cadena, out aux);
                    suma = suma + (aux * 7);
                    cadena = p_dni.ToString();
                    cadena = cadena.Substring(3,1);
                    int.TryParse(cadena, out aux);
                    suma = suma + (aux * 6);
                    cadena = p_dni.ToString();
                    cadena = cadena.Substring(4,1);
                    int.TryParse(cadena, out aux);
                    suma = suma + (aux * 5);
                    cadena = p_dni.ToString();
                    cadena = cadena.Substring(5,1);
                    int.TryParse(cadena, out aux);
                    suma = suma + (aux * 4);
                    cadena = p_dni.ToString();
                    cadena = cadena.Substring(6,1);
                    int.TryParse(cadena, out aux);
                    suma = suma + (aux * 3);
                    cadena = p_dni.ToString();
                    cadena = cadena.Substring(7,1);
                    int.TryParse(cadena, out aux);
                    suma = suma + (aux * 2);
                    div = suma / 11;
                    resto = suma - (div * 11);
                    Console.WriteLine(suma);
                    xy = 20;
                    if (resto == 0)
                    {
                        dv = 0;
                    }
                    else if (resto == 1)
                    {
                        dv = 9;
                        xy = 23;
                    }
                    else
                    {
                        dv = 11 - resto;
                    }
                }
                else
                {
                    suma = 2 * 5;
                    suma = suma + (7 * 4);
                    cadena = p_dni.ToString();
                    cadena = cadena.Substring(0,1);
                    int.TryParse(cadena, out aux);
                    suma = suma + (aux * 3);
                    cadena = p_dni.ToString();
                    cadena = cadena.Substring(1,1);
                    int.TryParse(cadena, out aux);
                    suma = suma + (aux * 2);
                    cadena = p_dni.ToString();
                    cadena = cadena.Substring(2,1);
                    int.TryParse(cadena, out aux);
                    suma = suma + (aux * 7);
                    cadena = p_dni.ToString();
                    cadena = cadena.Substring(3,1);
                    int.TryParse(cadena, out aux);
                    suma = suma + (aux * 6);
                    cadena = p_dni.ToString();
                    cadena = cadena.Substring(4,1);
                    int.TryParse(cadena, out aux);
                    suma = suma + (aux * 5);
                    cadena = p_dni.ToString();
                    cadena = cadena.Substring(5,1);
                    int.TryParse(cadena, out aux);
                    suma = suma + (aux * 4);
                    cadena = p_dni.ToString();
                    cadena = cadena.Substring(6,1);
                    int.TryParse(cadena, out aux);
                    suma = suma + (aux * 3);
                    cadena = p_dni.ToString();
                    cadena = cadena.Substring(7,1);
                    int.TryParse(cadena, out aux);
                    suma = suma + (aux * 2);
                    div = suma / 11;
                    resto = suma - (div * 11);
                    Console.WriteLine(suma);
                    xy = 27;
                    if (resto == 0)
                    {
                        dv = 0;
                    }
                    else if (resto == 1)
                    {
                        dv = 4;
                        xy = 23;
                    }
                    else
                    {
                        dv = 11 - resto;
                    }
                }
                p_cuil = xy.ToString() + "-" + p_dni.ToString() + "-" + dv.ToString();
                return p_cuil;
            }
        }


                






                
            

    }
}
