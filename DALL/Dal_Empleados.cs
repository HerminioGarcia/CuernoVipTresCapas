using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace DAL
{
    public class Dal_Empleados
    {
        // Create
        public static string Insertar_Empleado(Empleados_VO empleado)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("sp_Insert_Empleado",
                    "@Nombre_Empleado", empleado.Nombre_Empleado,
                    "@Apeido_P_Empleado", empleado.Apeido_P_Empleado,
                    "@Apeido_M_Empleado", empleado.Apeido_M_Empleado,
                    "@Email_Empleado", empleado.Email_Empleado,
                    "@Telefono_Empleado", empleado.Telefono_Empleado,
                    "@Rol_Id", empleado.Rol_Id
                );
                if (respuesta != 0)
                {
                    salida = "Empleado registrado con éxito";
                }
                else
                {
                    salida = "Ha ocurrido un error";
                }
            }
            catch (Exception)
            {
                salida = "Error en la inserción del empleado";
            }
            return salida;
        }

        // Read
        public static List<Empleados_VO> GetEmpleados(params object[] parametros)
        {
            List<Empleados_VO> list = new List<Empleados_VO>();
            try
            {
                DataSet ds_empleados = metodos_datos.execute_DataSet("sp_Select_Empleado", parametros);
                foreach (DataRow dr in ds_empleados.Tables[0].Rows)
                {
                    list.Add(new Empleados_VO(dr));
                }
                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Update
        public static string Update_Empleado(Empleados_VO empleado)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("sp_Update_Empleado",
                    "@Id_Empleado", empleado.Id_Empleado,
                    "@Nombre_Empleado", empleado.Nombre_Empleado,
                    "@Apeido_P_Empleado", empleado.Apeido_P_Empleado,
                    "@Apeido_M_Empleado", empleado.Apeido_M_Empleado,
                    "@Email_Empleado", empleado.Email_Empleado,
                    "@Telefono_Empleado", empleado.Telefono_Empleado,
                    "@Rol_Id", empleado.Rol_Id
                );
                if (respuesta != 0)
                {
                    salida = "Empleado actualizado con éxito";
                }
                else
                {
                    salida = "Ha ocurrido un error";
                }
            }
            catch (Exception)
            {
                salida = "Error en la actualización del empleado";
            }
            return salida;
        }

        // Delete
        public static string Delete_Empleado(int id)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("sp_Delete_Empleado",
                    "@Id_Empleado", id
                );
                if (respuesta != 0)
                {
                    salida = "Empleado eliminado con éxito";
                }
                else
                {
                    salida = "Ha ocurrido un error";
                }
            }
            catch (Exception)
            {
                salida = "Error en la eliminación del empleado";
            }
            return salida;
        }
    }
}