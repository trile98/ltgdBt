using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class Phong_DAO
    {
        public static SqlConnection connection;
        public static List<Phong_DTO> LoadData(string name = "")
        {
            string query;
            if (name == "")
                query = "select * from Phong";
            else
                query = "select * from NhanVien where Phong LIKE '%" + name + "$'";

            connection = DataProvider.Conn();
            DataTable tbl = new DataTable();
            tbl = DataProvider.Getingdata(query, connection);

            if (tbl.Rows.Count == 0)
                return null;

            List<Phong_DTO> listPhong = new List<Phong_DTO>();
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                Phong_DTO phong = new Phong_DTO();
                phong.Phong = int.Parse(tbl.Rows[i]["Phong"].ToString());
                phong.TenPhong = tbl.Rows[i]["TenPhong"].ToString();
               
                listPhong.Add(phong);
            }
            DataProvider.Closeconn(connection);
            return listPhong;
        }
    }
}
