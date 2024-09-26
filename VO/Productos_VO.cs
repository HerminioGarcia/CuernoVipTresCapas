using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class Productos_VO
    {
        private int _ID_Producto;
        private string _Nombre_Producto;
        private string _Descripcion_Producto;
        private int _Categoria_Id;
        private int? _Tamano_Id; // Nullable para permitir valores nulos
        private string _Urlfoto_Producto;
        private decimal _Precio_Producto;

        public int ID_Producto { get => _ID_Producto; set => _ID_Producto = value; }
        public string Nombre_Producto { get => _Nombre_Producto; set => _Nombre_Producto = value; }
        public string Descripcion_Producto { get => _Descripcion_Producto; set => _Descripcion_Producto = value; }
        public int Categoria_Id { get => _Categoria_Id; set => _Categoria_Id = value; }
        public int? Tamano_Id { get => _Tamano_Id; set => _Tamano_Id = value; }
        public string Urlfoto_Producto { get => _Urlfoto_Producto; set => _Urlfoto_Producto = value; }
        public decimal Precio_Producto { get => _Precio_Producto; set => _Precio_Producto = value; }

        public Productos_VO()
        {
            _ID_Producto = 0;
            _Nombre_Producto = string.Empty;
            _Descripcion_Producto = string.Empty;
            _Categoria_Id = 0;
            _Tamano_Id = null; // Inicializa como nulo
            _Urlfoto_Producto = string.Empty;
            _Precio_Producto = 0.0m; // Inicializa como 0
        }

        public Productos_VO(DataRow dr)
        {
            _ID_Producto = int.Parse(dr["ID_Producto"].ToString());
            _Nombre_Producto = dr["Nombre_Producto"].ToString();
            _Descripcion_Producto = dr["Descripcion_Producto"].ToString();
            _Categoria_Id = int.Parse(dr["Categoria_Id"].ToString());
            _Tamano_Id = dr["Tamano_Id"] != DBNull.Value ? (int?)int.Parse(dr["Tamano_Id"].ToString()) : null;
            _Urlfoto_Producto = dr["Urlfoto_Producto"].ToString();
            _Precio_Producto = decimal.Parse(dr["Precio_Producto"].ToString());
        }
    }
}
