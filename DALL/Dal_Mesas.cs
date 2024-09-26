using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace DAL
{
    public class Dal_Mesas
    {
        // Insertar
        public static string Insertar_Mesa(Mesas_VO mesa)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("sp_Insert_Mesa",
                    "@Codigo_Mesa", mesa.Codigo_Mesa,
                    "@Capacidad", mesa.Capacidad
                );
                if (respuesta != 0)
                {
                    salida = "Mesa registrada con éxito";
                }
                else
                {
                    salida = "Ha ocurrido un error";
                }
            }
            catch (Exception)
            {
                salida = "Error en la inserción de la mesa";
            }
            return salida;
        }

        // Leer
        public static List<Mesas_VO> GetMesas(params object[] parametros)
        {
            List<Mesas_VO> list = new List<Mesas_VO>();
            try
            {
                DataSet ds_mesas = metodos_datos.execute_DataSet("sp_Select_Mesa", parametros);
                foreach (DataRow dr in ds_mesas.Tables[0].Rows)
                {
                    list.Add(new Mesas_VO(dr));
                }
                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Actualizar
        public static string Update_Mesa(Mesas_VO mesa)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("sp_Update_Mesa",
                    "@ID_Mesa", mesa.ID_Mesa,
                    "@Codigo_Mesa", mesa.Codigo_Mesa,
                    "@Capacidad", mesa.Capacidad
                );
                if (respuesta != 0)
                {
                    salida = "Mesa actualizada con éxito";
                }
                else
                {
                    salida = "Ha ocurrido un error";
                }
            }
            catch (Exception)
            {
                salida = "Error en la actualización de la mesa";
            }
            return salida;
        }

        // Eliminar
        public static string Delete_Mesa(int id)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("sp_Delete_Mesa",
                    "@ID_Mesa", id
                );
                if (respuesta != 0)
                {
                    salida = "Mesa eliminada con éxito";
                }
                else
                {
                    salida = "Ha ocurrido un error";
                }
            }
            catch (Exception)
            {
                salida = "Error en la eliminación de la mesa";
            }
            return salida;
        }
    }

}