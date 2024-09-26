using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace DAL
{
    public class Dal_Reservaciones
    {
        // Insertar
        public static string Insertar_Reservacion(Reservaciones_VO reservacion)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("sp_insert_Reservacion",
                    "@Mesa_Id", reservacion.Mesa_Id,
                    "@Cliente_Id", reservacion.Cliente_Id,
                    "@Fecha_Reservacion", reservacion.Fecha_Reservacion,
                    "@Horario", reservacion.Horario,
                    "@Num_Personas", reservacion.Num_Personas,
                    "@Estatus", reservacion.Estatus
                );
                if (respuesta != 0)
                {
                    salida = "Reservación registrada con éxito";
                }
                else
                {
                    salida = "Ha ocurrido un error";
                }
            }
            catch (Exception)
            {
                salida = "Error en la inserción de la reservación";
            }
            return salida;
        }

        // Leer
        public static List<Reservaciones_VO> GetReservaciones(params object[] parametros)
        {
            List<Reservaciones_VO> list = new List<Reservaciones_VO>();
            try
            {
                DataSet ds_reservaciones = metodos_datos.execute_DataSet("sp_select_Reservaciones", parametros);
                foreach (DataRow dr in ds_reservaciones.Tables[0].Rows)
                {
                    list.Add(new Reservaciones_VO(dr));
                }
                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Actualizar
        public static string Update_Reservacion(Reservaciones_VO reservacion)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("sp_update_Reservacion",
                    "@Id_Reservacion", reservacion.Id_Reservacion,
                    "@Mesa_Id", reservacion.Mesa_Id,
                    "@Cliente_Id", reservacion.Cliente_Id,
                    "@Fecha_Reservacion", reservacion.Fecha_Reservacion,
                    "@Horario", reservacion.Horario,
                    "@Num_Personas", reservacion.Num_Personas,
                    "@Estatus", reservacion.Estatus
                );
                if (respuesta != 0)
                {
                    salida = "Reservación actualizada con éxito";
                }
                else
                {
                    salida = "Ha ocurrido un error";
                }
            }
            catch (Exception)
            {
                salida = "Error en la actualización de la reservación";
            }
            return salida;
        }

        // Eliminar
        public static string Delete_Reservacion(int id)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("sp_delete_Reservacion",
                    "@Id_Reservacion", id
                );
                if (respuesta != 0)
                {
                    salida = "Reservación eliminada con éxito";
                }
                else
                {
                    salida = "Ha ocurrido un error";
                }
            }
            catch (Exception)
            {
                salida = "Error en la eliminación de la reservación";
            }
            return salida;
        }
    }
}