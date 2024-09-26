using System;
using System.Collections.Generic;
using System.Data;
using VO;

namespace DAL
{
    public class Dal_DetallesCuentas
    {
        // Insertar
        public static string Insertar_DetalleCuenta(Detalles_Cuentas_VO detalle)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("sp_insert_DetalleCuenta",
                    "@Venta_Id", detalle.Venta_Id,
                    "@Producto_Id", detalle.Producto_Id,
                    "@Cantidad", detalle.Cantidad,
                    "@Subtotal", detalle.Subtotal
                );
                if (respuesta != 0)
                {
                    salida = "Detalle de cuenta registrado con éxito";
                }
                else
                {
                    salida = "Ha ocurrido un error";
                }
            }
            catch (Exception)
            {
                salida = "Error en la inserción del detalle de cuenta";
            }
            return salida;
        }

        // Leer
        public static List<Detalles_Cuentas_VO> GetDetallesCuentas(params object[] parametros)
        {
            List<Detalles_Cuentas_VO> list = new List<Detalles_Cuentas_VO>();
            try
            {
                DataSet ds_detalles = metodos_datos.execute_DataSet("sp_select_DetallesCuentas", parametros);
                foreach (DataRow dr in ds_detalles.Tables[0].Rows)
                {
                    list.Add(new Detalles_Cuentas_VO(dr));
                }
                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Actualizar
        public static string Update_DetalleCuenta(Detalles_Cuentas_VO detalle)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("sp_update_DetalleCuenta",
                    "@Id_Detalle_Cuenta", detalle.Id_Detalle_Cuenta,
                    "@Venta_Id", detalle.Venta_Id,
                    "@Producto_Id", detalle.Producto_Id,
                    "@Cantidad", detalle.Cantidad,
                    "@Subtotal", detalle.Subtotal
                );
                if (respuesta != 0)
                {
                    salida = "Detalle de cuenta actualizado con éxito";
                }
                else
                {
                    salida = "Ha ocurrido un error";
                }
            }
            catch (Exception)
            {
                salida = "Error en la actualización del detalle de cuenta";
            }
            return salida;
        }

        // Eliminar
        public static string Delete_DetalleCuenta(int id)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("sp_delete_DetalleCuenta",
                    "@Id_Detalle_Cuenta", id
                );
                if (respuesta != 0)
                {
                    salida = "Detalle de cuenta eliminado con éxito";
                }
                else
                {
                    salida = "Ha ocurrido un error";
                }
            }
            catch (Exception)
            {
                salida = "Error en la eliminación del detalle de cuenta";
            }
            return salida;
        }
    }
}