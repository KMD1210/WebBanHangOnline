using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBanHangOnline.Models
{
    public abstract class CommonAbstract
    {
        //public string NguoiTao { get; set; }
        //public DateTime NgayTao { get; set; }
        //public DateTime NgaySua { get; set; }
        //public string NguoiSua { get; set; }
        public string NguoiTao { get; set; }       // NguoiTao -> NguoiTao
        public DateTime NgayTao { get; set; }      // NgayTao -> NgayTao
        public DateTime NgaySua { get; set; }      // NgaySua -> NgaySua
        public string NguoiSua { get; set; }       // ModifiedBy -> NguoiSua

    }
}