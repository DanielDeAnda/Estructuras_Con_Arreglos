using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace catalogoVectores
{
    class Registro
    {
        private string[] _auto;
        private string _datos;
        private int _contador;

        public Registro()
        {
            _datos = "";
            _auto = new string[15];
            _contador = 0;
        }

        public void Agregar (string Placa, string Marca, string Modelo, string Año, string Telefono)
        {
            _datos = Placa + " " + Marca + " " + Modelo + " " + Año + " " + Telefono + " " + Environment.NewLine;
            _auto[_contador] = _datos;
            _contador++;
        }

        public void Buscar(string placa)
        {
            bool Encontrado = false;
            for(int x = 0; x < _contador; x++)
            {
                if (_auto[x]==placa)
                {
                    Encontrado = true;
                }
            }
        }

        public void eliminar(string placa)
        {
            for (int x = 0; x < _contador; x++)
            {
                if (_auto[x].Contains(placa))
                {

                    while (x < _contador)
                    {
                        _auto[x] = _auto[x + 1];
                        x++;
                    }

                }
            }
            _contador--;
        }

        public void insertar(string Placa, string Marca, string Modelo, string Año, string Telefono)
        {
            for (int x = 0; x < _contador; x++)
            {
                if (_auto[x].Contains(Telefono))
                {
                    _datos = " ";
                    _datos += Placa + " " + Marca + " " + Modelo + " " + Año + " " + Telefono + " " + Environment.NewLine;
                    _auto[x] = _datos;
                }
            }
        }

        public string listar()
        {
            string lista = "";
            for (int x = 0; x < _contador; x++)
            {
                lista += _auto[x] + Environment.NewLine;

            }
            return lista;
        }
    }
}
