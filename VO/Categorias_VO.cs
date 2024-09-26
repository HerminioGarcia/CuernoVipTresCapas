using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class Categorias_VO
    {
        private int _Id_Categoria;
        private string _Categoria;

        public int Id_Categoria { get => _Id_Categoria; set => _Id_Categoria = value; }
        public string Categoria { get => _Categoria; set => _Categoria = value; }

        public Categorias_VO()
        {
            _Id_Categoria = 0;
            _Categoria = string.Empty;
        }

        public Categorias_VO(DataRow dr)
        {
            _Id_Categoria = int.Parse(dr["Id_Categoria"].ToString());
            _Categoria = dr["Categoria"].ToString();
        }
    }
}
