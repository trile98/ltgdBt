using DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Phong_BUS
    {
        public static List<Phong_DTO> LoadData(string name = "")
        {
            return Phong_DAO.LoadData(name);
        }
    }
}
