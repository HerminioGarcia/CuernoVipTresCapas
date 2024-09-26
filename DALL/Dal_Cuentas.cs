using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace DAL
{
    public class Dal_Cuentas
    {
        // Insertar
        public static string Insertar_Cuenta(Cuentas_VO cuenta)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("sp_insert_Cuenta",
                    "@Mesa_Id", cuenta.Mesa_Id,
                    "@Cliente_Id", cuenta.Cliente_Id,
                    "@Reservacion_Id", cuenta.Reservacion_Id,
                    "@Empleado_Id", cuenta.Empleado_Id,
                    "@Fecha", cuenta.Fecha,
                    "@Total", cuenta.Total,
                    "@Es_Reservacion", cuenta.Es_Reservacion
                );
                if (respuesta != 0)
                {
                    salida = "Cuenta registrada con éxito";
                }
                else
                {
                    salida = "Ha ocurrido un error";
                }
            }
            catch (Exception)
            {
                salida = "Error en la inserción de la cuenta";
            }
            return salida;
        }

        // Leer
        public static List<Cuentas_VO> GetCuentas(params object[] parametros)
        {
            List<Cuentas_VO> list = new List<Cuentas_VO>();
            try
            {
                DataSet ds_cuentas = metodos_datos.execute_DataSet("sp_select_Cuentas", parametros);
                foreach (DataRow dr in ds_cuentas.Tables[0].Rows)
                {
                    list.Add(new Cuentas_VO(dr));
                }
                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Actualizar
        public static string Update_Cuenta(Cuentas_VO cuenta)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("sp_update_Cuenta",
                    "@Id_Cuenta", cuenta.Id_Cuenta,
                    "@Mesa_Id", cuenta.Mesa_Id,
                    "@Cliente_Id", cuenta.Cliente_Id,
                    "@Reservacion_Id", cuenta.Reservacion_Id,
                    "@Empleado_Id", cuenta.Empleado_Id,
                    "@Fecha", cuenta.Fecha,
                    "@Total", cuenta.Total,
                    "@Es_Reservacion", cuenta.Es_Reservacion
                );
                if (respuesta != 0)
                {
                    salida = "Cuenta actualizada con éxito";
                }
                else
                {
                    salida = "Ha ocurrido un error";
                }
            }
            catch (Exception)
            {
                salida = "Error en la actualización de la cuenta";
            }
            return salida;
        }

        // Eliminar
        public static string Delete_Cuenta(int id)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("sp_delete_Cuenta",
                    "@Id_Cuenta", id
                );
                if (respuesta != 0)
                {
                    salida = "Cuenta eliminada con éxito";
                }
                else
                {
                    salida = "Ha ocurrido un error";
                }
            }
            catch (Exception)
            {
                salida = "Error en la eliminación de la cuenta";
            }
            return salida;
        }
    }
}
