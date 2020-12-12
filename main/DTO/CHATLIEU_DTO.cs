using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CHATLIEU_DTO
    {
        private string maCL;
        private string tenCL;
        public string MaCL
        {
            get
            {
                return maCL;
            }
            set
            {
                maCL = value;
            }

        }
        public string TenCL
        {
            get
            {
                return tenCL;
            }
            set
            {
                tenCL = value;
            }

        }
    }
}
