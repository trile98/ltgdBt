using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class NV_DAO
    {
        public static SqlConnection connection;
        public static List<NV_DTO> LoadData(string name="")
        {
            string query;
            if (name == "")
                query = "select * from NhanVien";
            else
                query = "select * from NhanVien where Ten LIKE '%" + name + "%'";

            connection = DataProvider.Conn();
            DataTable tbl = new DataTable();
            tbl = DataProvider.Getingdata(query,connection);

            if (tbl.Rows.Count == 0)
                return null;

            List<NV_DTO> listNV = new List<NV_DTO>();
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                NV_DTO nv = new NV_DTO();
                nv.Ten = tbl.Rows[i]["Ten"].ToString();
                nv.NS = tbl.Rows[i]["Ngaysinh"].ToString();
                nv.SDT = tbl.Rows[i]["Sdt"].ToString();
                nv.DC = tbl.Rows[i]["DiaChi"].ToString();
                nv.MS = tbl.Rows[i]["Ms"].ToString();
                nv.Phong = int.Parse(tbl.Rows[i]["Phong"].ToString());
                listNV.Add(nv);
            }
            DataProvider.Closeconn(connection);
            return listNV;
        }

        public static bool AddNV(NV_DTO nv)
        {
            string query = string.Format("Insert into NhanVien values('{0}','{1}','{2}','{3}','{4}',{5})", nv.MS, nv, nv.NS, nv.SDT, nv.DC,nv.Phong.ToString());
            try
            {
                connection = DataProvider.Conn();
                DataProvider.ExcuteNQuery(query, connection);
                DataProvider.Closeconn(connection);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool UpdateNV(NV_DTO nv)
        {
            string query = string.Format("Update  NhanVien set Ten=N'{0}',Ngaysinh='{1}',Sdt='{2}',DiaChi=N'{3}',Phong={4} where Ms='{5}')", nv.Ten, nv.NS, nv.SDT, nv.DC,nv.Phong.ToString(), nv.MS);
            try
            {
                connection = DataProvider.Conn();
                DataProvider.ExcuteNQuery(query, connection);
                DataProvider.Closeconn(connection);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool DeleteNV(string MS)
        {
            string query = string.Format("Delete from NhanVien where Ms={0}", MS);
            try
            {
                connection = DataProvider.Conn();
                DataProvider.ExcuteNQuery(query, connection);
                DataProvider.Closeconn(connection);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool CheckByMs(string MS)
        {
            string query = string.Format("Select * from NhanVien where Ms={0})", MS);
            try
            {
                connection = DataProvider.Conn();
                DataTable tbl = new DataTable();
                tbl = DataProvider.Getingdata(query, connection);
                if (tbl.Rows.Count>0)
                {
                    DataProvider.Closeconn(connection);
                    return true;
                }
                DataProvider.Closeconn(connection);
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        
    }
}
