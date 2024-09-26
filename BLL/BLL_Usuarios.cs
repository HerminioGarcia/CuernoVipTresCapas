using DAL;
using System;
using System.Collections.Generic;
using VO;

namespace BLL
{
    public class BLL_Usuarios

    {
        // Create
        public static string InsertarUsuario(Usuario_VO user)
        {
            // Llamar al método DAL para insertar un usuario
            return DAL_Usuarios.InsertarUsuario(user);
        }

        // Read
        public static List<Usuario_VO> ObtenerUsuarios(params object[] parametros)
        {
            // Llamar al método DAL para obtener todos los usuarios
            return DAL_Usuarios.ObtenerUsuarios(parametros);
        }

        // Login
        public static Usuario_VO Login(string username, string password)
        {
            // Llamar al método DAL para el login
            return DAL_Usuarios.Login(username, password);
        }

        // Update
        public static string EditarUsuario(Usuario_VO user)
        {
            // Llamar al método DAL para editar un usuario
            return DAL_Usuarios.EditarUsuario(user);
        }

        // Delete
        public static string EliminarUsuario(int idUsuario)
        {
            // Llamar al método DAL para eliminar un usuario
            return DAL_Usuarios.EliminarUsuario(idUsuario);
        }
    }
}
