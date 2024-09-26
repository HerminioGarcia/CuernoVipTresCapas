using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace DAL
{
    public class Dal_Productos
    {
        // Create
        public static string Insertar_Producto(Productos_VO producto)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("sp_insert_Producto",
                    "@Nombre_Producto", producto.Nombre_Producto,
                    "@Descripcion_Producto", producto.Descripcion_Producto,
                    "@Categoria_Id", producto.Categoria_Id,
                    "@Tamano_Id", (object)producto.Tamano_Id ?? DBNull.Value,
                    "@Urlfoto_Producto", producto.Urlfoto_Producto,
                    "@Precio_Producto", producto.Precio_Producto
                );
                if (respuesta != 0)
                {
                    salida = "Producto registrado con éxito";
                }
                else
                {
                    salida = "Ha ocurrido un error";
                }
            }
            catch (Exception)
            {
                salida = "Error en la inserción del producto";
            }
            return salida;
        }

        // Read
        public static List<Productos_VO> GetProductos(params object[] parametros)
        {
            List<Productos_VO> list = new List<Productos_VO>();
            try
            {
                DataSet ds_productos = metodos_datos.execute_DataSet("sp_select_Productos", parametros);
                foreach (DataRow dr in ds_productos.Tables[0].Rows)
                {
                    list.Add(new Productos_VO(dr));
                }
                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Update
        public static string Update_Producto(Productos_VO producto)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("sp_update_Producto",
                    "@ID_Producto", producto.ID_Producto,
                    "@Nombre_Producto", producto.Nombre_Producto,
                    "@Descripcion_Producto", producto.Descripcion_Producto,
                    "@Categoria_Id", producto.Categoria_Id,
                    "@Tamano_Id", (object)producto.Tamano_Id ?? DBNull.Value,
                    "@Urlfoto_Producto", producto.Urlfoto_Producto,
                    "@Precio_Producto", producto.Precio_Producto
                );
                if (respuesta != 0)
                {
                    salida = "Producto actualizado con éxito";
                }
                else
                {
                    salida = "Ha ocurrido un error";
                }
            }
            catch (Exception)
            {
                salida = "Error en la actualización del producto";
            }
            return salida;
        }

        // Delete
        public static string Delete_Producto(int id)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("sp_delete_Producto",
                    "@ID_Producto", id
                );
                if (respuesta != 0)
                {
                    salida = "Producto eliminado con éxito";
                }
                else
                {
                    salida = "Ha ocurrido un error";
                }
            }
            catch (Exception)
            {
                salida = "Error en la eliminación del producto";
            }
            return salida;
        }
    }
}