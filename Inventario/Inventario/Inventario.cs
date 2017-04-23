using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    class Inventario
    {

        private Producto[] inv = new Producto[15];
        private int actual = 0;

        public void agregar(string codigo, string nombre, int cantidad, double precio)
        {
            inv[actual] = new Producto(codigo, nombre, cantidad, precio);
            actual++;
        }

        public void borrar(string cod)
        {
            for(int i = 0; i < actual; i++)
            {
                if (inv[i].getCodigo().Equals(cod))
                {
                    inv[i] = inv[actual - 1];
                    inv[actual - 1] = null;
                    actual--;
                }
            }
        }

        public void insertar(int posicion, string codigo, string nombre, int cantidad, double precio)
        {
            Producto temp = inv[posicion];
            inv[posicion] = new Producto(codigo, nombre, cantidad, precio);
            inv[actual] = temp;
            actual++;
        }

        public Producto buscar(string codigo)
        {
            for(int i = 0; i < actual; i++)
            {
                if (inv[i].getCodigo().Equals(codigo))
                {
                    return inv[i];
                }
            }
            return null;
        }

        public String reporte()
        {
            String s = "";
            for(int i = 0; i < actual; i++)
            {
                s += inv[i].ToString() + Environment.NewLine;
            }
            return s;
        }

    }
}
