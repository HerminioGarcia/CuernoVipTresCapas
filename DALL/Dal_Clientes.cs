using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace DAL
{
    public class Dal_Clientes
    {
        // Insertar
        public static string Insertar_Cliente(Clientes_VO cliente)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("sp_Insert_Cliente",
                    "@Nombre_Cliente", cliente.Nombre_Cliente,
                    "@Apeido_P_Cliente", cliente.Apeido_P_Cliente,
                    "@Apeido_M_Cliente", cliente.Apeido_M_Cliente,
                    "@Email", cliente.Email,
                    "@Telefono", cliente.Telefono
                );
                if (respuesta != 0)
                {
                    salida = "Cliente registrado con éxito";
                }
                else
                {
                    salida = "Ha ocurrido un error";
                }
            }
            catch (Exception)
            {
                salida = "Error en la inserción del cliente";
            }
            return salida;
        }

        // Leer
        public static List<Clientes_VO> GetClientes(params object[] parametros)
        {
            List<Clientes_VO> list = new List<Clientes_VO>();
            try
            {
                DataSet ds_clientes = metodos_datos.execute_DataSet("sp_Select_Cliente", parametros);
                foreach (DataRow dr in ds_clientes.Tables[0].Rows)
                {
                    list.Add(new Clientes_VO(dr));
                }
                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Actualizar
        public static string Update_Cliente(Clientes_VO cliente)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("sp_Update_Cliente",
                    "@Id_Cliente", cliente.Id_Cliente,
                    "@Nombre_Cliente", cliente.Nombre_Cliente,
                    "@Apeido_P_Cliente", cliente.Apeido_P_Cliente,
                    "@Apeido_M_Cliente", cliente.Apeido_M_Cliente,
                    "@Email", cliente.Email,
                    "@Telefono", cliente.Telefono
                );
                if (respuesta != 0)
                {
                    salida = "Cliente actualizado con éxito";
                }
                else
                {
                    salida = "Ha ocurrido un error";
                }
            }
            catch (Exception)
            {
                salida = "Error en la actualización del cliente";
            }
            return salida;
        }

        // Eliminar
        public static string Delete_Cliente(int id)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("sp_Delete_Cliente",
                    "@Id_Cliente", id
                );
                if (respuesta != 0)
                {
                    salida = "Cliente eliminado con éxito";
                }
                else
                {
                    salida = "Ha ocurrido un error";
                }
            }
            catch (Exception)
            {
                salida = "Error en la eliminación del cliente";
            }
            return salida;
        }
    }
}