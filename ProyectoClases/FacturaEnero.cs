using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoClases
{
    public class FacturaEnero : IFactura
    {
        public int PrecioBase { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int PrecioTotal { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void CalcularIva()
        {
            throw new NotImplementedException();
        }

        public void OdioHacienda(int mucho)
        {
            throw new NotImplementedException();
        }
    }
}
