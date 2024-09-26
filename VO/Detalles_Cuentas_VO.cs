using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class Detalles_Cuentas_VO
    {
        private int _Id_Detalle_Cuenta;
        private int? _Venta_Id; // Nullable para permitir valores nulos
        private int? _Producto_Id; // Nullable para permitir valores nulos
        private int _Cantidad;
        private decimal _Subtotal;

        public int Id_Detalle_Cuenta { get => _Id_Detalle_Cuenta; set => _Id_Detalle_Cuenta = value; }
        public int? Venta_Id { get => _Venta_Id; set => _Venta_Id = value; }
        public int? Producto_Id { get => _Producto_Id; set => _Producto_Id = value; }
        public int Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public decimal Subtotal { get => _Subtotal; set => _Subtotal = value; }

        public Detalles_Cuentas_VO()
        {
            _Id_Detalle_Cuenta = 0;
            _Venta_Id = null; // Inicializa como nulo
            _Producto_Id = null; // Inicializa como nulo
            _Cantidad = 0; // Inicializa como 0
            _Subtotal = 0.0m; // Inicializa como 0
        }

        public Detalles_Cuentas_VO(DataRow dr)
        {
            _Id_Detalle_Cuenta = int.Parse(dr["Id_Detalle_Cuenta"].ToString());
            _Venta_Id = dr["Venta_Id"] != DBNull.Value ? (int?)int.Parse(dr["Venta_Id"].ToString()) : null;
            _Producto_Id = dr["Producto_Id"] != DBNull.Value ? (int?)int.Parse(dr["Producto_Id"].ToString()) : null;
            _Cantidad = int.Parse(dr["Cantidad"].ToString());
            _Subtotal = decimal.Parse(dr["Subtotal"].ToString());
        }
    }
}