using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace DAL
{
    public class Dal_Tamanos
    {
        // Read
        public static List<Tamanos_VO> GetTamanos(params object[] parametros)
        {
            List<Tamanos_VO> list = new List<Tamanos_VO>();
            try
            {
                DataSet ds_tamanos = metodos_datos.execute_DataSet("sp_select_Tamanos", parametros);
                foreach (DataRow dr in ds_tamanos.Tables[0].Rows)
                {
                    list.Add(new Tamanos_VO(dr));
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