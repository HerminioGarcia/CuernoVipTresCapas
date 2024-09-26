using System;
using System.Collections.Generic;
using System.Data;
using VO;

namespace DAL
{
    public class DAL_Usuarios
    {
        //Create
        public static string InsertarUsuario(Usuario_VO user)
        {
            string salida = "";
            int respuesta = 0;

            try
            {
                respuesta = metodos_datos.execute_nonQuery("SP_InsertarUsuario",
                    "@Username", user.Username,
                    "@Password", user.Password,
                    "@Empleado_Id", user.EmpleadoId.HasValue ? (object)user.EmpleadoId.Value : DBNull.Value,
                    "@Cliente_Id", user.ClienteId.HasValue ? (object)user.ClienteId.Value : DBNull.Value
                );

                if (respuesta != 0)
                {
                    salida = "Usuario registrado con éxito";
                }
                else
                {
                    salida = "Ha ocurrido un error";
                }
            }
            catch (Exception e)
            {
                salida = "Error: " + e.Message;
            }
            return salida;
        }

        //Read - Obtener todos los usuarios
        public static List<Usuario_VO> ObtenerUsuarios(params object[] parametros)
        {
            List<Usuario_VO> listaUsuarios = new List<Usuario_VO>();
            try
            {
                DataSet ds_Usuarios = metodos_datos.execute_DataSet("SP_ObtenerUsuarios", parametros);
                foreach (DataRow dr in ds_Usuarios.Tables[0].Rows)
                {
                    listaUsuarios.Add(new Usuario_VO(dr));
                }
                return listaUsuarios;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //Login
        public static Usuario_VO Login(string username, string password)
        {
            Usuario_VO usuario = null;
            try
            {
                DataSet ds_Usuario = metodos_datos.execute_DataSet("SP_Login",
                    "@Username", username,
                    "@Password", password
                );

                foreach (DataRow dr in ds_Usuario.Tables[0].Rows)
                {
                    usuario = new Usuario_VO(dr);
                }
                return usuario;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //Update
        public static string EditarUsuario(Usuario_VO user)
        {
            string salida = "";
            int respuesta = 0;

            try
            {
                respuesta = metodos_datos.execute_nonQuery("SP_EditarUsuario",
                    "@Id_Usuario", user.IdUsuario,
                    "@Username", user.Username,
                    "@Password", user.Password,
                    "@Empleado_Id", user.EmpleadoId.HasValue ? (object)user.EmpleadoId.Value : DBNull.Value,
                    "@Cliente_Id", user.ClienteId.HasValue ? (object)user.ClienteId.Value : DBNull.Value
                );

                if (respuesta != 0)
                {
                    salida = "Usuario actualizado con éxito";
                }
                else
                {
                    salida = "Ha ocurrido un error";
                }
            }
            catch (Exception e)
            {
                salida = "Error: " + e.Message;
            }
            return salida;
        }

        //Delete
        public static string EliminarUsuario(int idUsuario)
        {
            string salida = "";
            int respuesta = 0;

            try
            {
                respuesta = metodos_datos.execute_nonQuery("SP_EliminarUsuario",
                    "@Id_Usuario", idUsuario
                );

                if (respuesta != 0)
                {
                    salida = "Usuario eliminado con éxito";
                }
                else
                {
                    salida = "Ha ocurrido un error";
                }
            }
            catch (Exception e)
            {
                salida = "Error: " + e.Message;
            }
            return salida;
        }
    }
}
