using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class NV_BUS
    {
        public static List<NV_DTO> LoadData(string name="")
        {
            return NV_DAO.LoadData(name);
        }

        
        public static bool AddNV(NV_DTO nv)
        {
            if (!NV_DAO.CheckByMs(nv.MS))
            {
                return NV_DAO.AddNV(nv);
            }
            else
                return false;
        }

        public static bool UpdateNV(NV_DTO nv)
        {
            return NV_DAO.UpdateNV(nv);
        }

        public static bool DeleteNV(string MS)
        {
            return NV_DAO.DeleteNV(MS);
        }
    }
}
