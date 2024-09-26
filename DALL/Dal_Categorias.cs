using System;
using System.Collections.Generic;
using System.Data;
using VO;

namespace DAL
{
    public class Dal_Categorias
    {
        // Read
        public static List<Categorias_VO> GetCategorias(params object[] parametros)
        {
            List<Categorias_VO> list = new List<Categorias_VO>();
            try
            {
                DataSet ds_categorias = metodos_datos.execute_DataSet("sp_select_Categorias", parametros);
                foreach (DataRow dr in ds_categorias.Tables[0].Rows)
                {
                    list.Add(new Categorias_VO(dr));
                }
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }
    }
}
