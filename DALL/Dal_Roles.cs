using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;
using VO.VO;

namespace DAL
{
    public class Dal_Roles
    {
        // Create
        public static string Insertar_Rol(Roles_VO rol)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("sp_Insert_Rol",
                    "@Rol", rol.Rol,
                    "@Pago", rol.Pago
                );
                if (respuesta != 0)
                {
                    salida = "Rol registrado con éxito";
                }
                else
                {
                    salida = "Ha ocurrido un error";
                }
            }
            catch (Exception)
            {
                salida = "Error en la inserción del rol";
            }
            return salida;
        }

        // Read
        public static List<Roles_VO> GetRoles(params object[] parametros)
        {
            List<Roles_VO> list = new List<Roles_VO>();
            try
            {
                DataSet ds_roles = metodos_datos.execute_DataSet("sp_Select_Rol", parametros);
                foreach (DataRow dr in ds_roles.Tables[0].Rows)
                {
                    list.Add(new Roles_VO(dr));
                }
                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Update
        public static string Update_Rol(Roles_VO rol)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("sp_Update_Rol",
                    "@Id_Rol", rol.Id_Rol,
                    "@Rol", rol.Rol,
                    "@Pago", rol.Pago
                );
                if (respuesta != 0)
                {
                    salida = "Rol actualizado con éxito";
                }
                else
                {
                    salida = "Ha ocurrido un error";
                }
            }
            catch (Exception)
            {
                salida = "Error en la actualización del rol";
            }
            return salida;
        }

        // Delete
        public static string Delete_Rol(int id)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("sp_Delete_Rol",
                    "@Id_Rol", id
                );
                if (respuesta != 0)
                {
                    salida = "Rol eliminado con éxito";
                }
                else
                {
                    salida = "Ha ocurrido un error";
                }
            }
            catch (Exception)
            {
                salida = "Error en la eliminación del rol";
            }
            return salida;
        }
    }
}
