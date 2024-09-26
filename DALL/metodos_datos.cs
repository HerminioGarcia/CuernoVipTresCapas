using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class metodos_datos
    {
        public static DataSet execute_DataSet(string sp, params object[] parametros)
        {
            DataSet ds = new DataSet();
            //cadena conexion que esta en configuracion.sc
            string cadenaConexion = configuracion.CadenaConexion;
            //crear una conexion => 
            SqlConnection con = new SqlConnection(cadenaConexion);

            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                else
                {
                    //Comando para  sql 
                    SqlCommand cmd = new SqlCommand(sp, con);
                    //definimos que el comando sera ejecutado como un SP 
                    cmd.CommandType = CommandType.StoredProcedure;
                    //pasamos el SP
                    cmd.CommandText = sp;

                    //validamos si existen y estan completos los parametros
                    if (parametros != null && parametros.Length % 2 != 0)
                    {
                        throw new Exception("los parametros deben estar en pares" +
                            "clave:valor");

                    }
                    else
                    {
                        for (int i = 0; i < parametros.Length; i = i + 2)
                        {
                            cmd.Parameters.AddWithValue(parametros[i].ToString(), parametros[i + 1].ToString());
                        }
                        //abrimos la conexion
                        con.Open();
                        //ejecutamos ek comando 
                        //SqlDataAdaoter = Objeto de ADO
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        //llenamos el ds
                        adapter.Fill(ds);
                        //cerramos la conexion
                        con.Close();
                    }
                }
                return ds;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                //verificamos si la conexion esta abierta
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            //método para ejecutar un dataset
            //Utilizado para ejecutar una consulta SQL que devuelve un conjunto de datos
            //que puede contener una o varias tablas con filas y columnas de datos.

            //Métodod que ejecuta un escalar
            //ejecuta una consulta SQL que devuelve un solo valor o una sola columna de dats.
            //retorna el valor de la primera columna y la primera fila del conjutno de resutltado

            //Método que ejecuta un NonQuery
            //Utilizado para ejecutar consultas SQL que no devuelven un conjunto de resultados.
            //como sentencias INSERT, UPDATE o DELETE.
            //Retorna un valor entero  que representa el número de filas afectadas por la operación.
            //(por ejemplo, el número de filas insertadas, actualizdas o eliminadas).
        }

        public static int execute_Scalar(string sp, params object[] parametros)
        {


            //variable para eñ controñ desde la clase
            int id = 0;
            DataSet ds = new DataSet();
            //cadena conexion que esta en configuracion.sc
            string cadenaConexion = configuracion.CadenaConexion;
            //crear una conexion => 
            SqlConnection con = new SqlConnection(cadenaConexion);

            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                else
                {
                    //Comando para  sql 
                    SqlCommand cmd = new SqlCommand(sp, con);
                    //definimos que el comando sera ejecutado como un SP 
                    cmd.CommandType = CommandType.StoredProcedure;
                    //pasamos el SP
                    cmd.CommandText = sp;

                    //validamos si existen y estan completos los parametros
                    if (parametros != null && parametros.Length % 2 != 0)
                    {
                        throw new Exception("los parametros deben estar en pares" +
                            "clave:valor");

                    }
                    else
                    {
                        for (int i = 0; i < parametros.Length; i = i + 2)
                        {
                            cmd.Parameters.AddWithValue(parametros[i].ToString(), parametros[i + 1].ToString());
                        }
                        //abrimos la conexion
                        con.Open();
                        //ejecutamos ek comando 
                        id = int.Parse(cmd.ExecuteScalar().ToString());
                        //cerramos la conexion
                        con.Close();
                    }
                }
                return id;
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                //verificamos si la conexion esta abierta
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            //método para ejecutar un dataset
            //Utilizado para ejecutar una consulta SQL que devuelve un conjunto de datos
            //que puede contener una o varias tablas con filas y columnas de datos.

            //Métodod que ejecuta un escalar
            //ejecuta una consulta SQL que devuelve un solo valor o una sola columna de dats.
            //retorna el valor de la primera columna y la primera fila del conjutno de resutltado

            //Método que ejecuta un NonQuery
            //Utilizado para ejecutar consultas SQL que no devuelven un conjunto de resultados.
            //como sentencias INSERT, UPDATE o DELETE.
            //Retorna un valor entero  que representa el número de filas afectadas por la operación.
            //(por ejemplo, el número de filas insertadas, actualizdas o eliminadas).
        }

        public static int execute_nonQuery(string sp, params object[] parametros)
        {
            int id = 0;
            DataSet ds = new DataSet();
            //cadena conexion que esta en configuracion.sc
            string cadenaConexion = configuracion.CadenaConexion;
            //crear una conexion => 
            SqlConnection con = new SqlConnection(cadenaConexion);

            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                else
                {
                    //Comando para  sql 
                    SqlCommand cmd = new SqlCommand(sp, con);
                    //definimos que el comando sera ejecutado como un SP 
                    cmd.CommandType = CommandType.StoredProcedure;
                    //pasamos el SP
                    cmd.CommandText = sp;

                    //validamos si existen y estan completos los parametros
                    if (parametros != null && parametros.Length % 2 != 0)
                    {
                        throw new Exception("los parametros deben estar en pares" +
                            "clave:valor");

                    }
                    else
                    {
                        for (int i = 0; i < parametros.Length; i = i + 2)
                        {
                            cmd.Parameters.AddWithValue(parametros[i].ToString(), parametros[i + 1].ToString());
                        }
                        //abrimos la conexion
                        con.Open();
                        //ejecutamos ek comando 

                        cmd.ExecuteNonQuery();

                        id = 1;

                        //cerramos la conexion
                        con.Close();
                    }
                }
                return id;
            }
            catch (Exception ex)
            {
                //aaaa
                return 0;
            }
            finally
            {
                //verificamos si la conexion esta abierta
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }




        }

    }
}