using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanVien.Libary
{
    public class NhanVien
    {
        [DisplayName("Mã nhân viên")]
        public string NhanvienId { get; set; }

        [DisplayName("Họ lót")]
        public string Holot { get; set; }

        [DisplayName("Tên nhân viên")]
        public string Ten { get; set; }

        [DisplayName("Ngày sinh")]
        public DateTime Ngaysinh { get; set; }

        [DisplayName("Ngày vào làm")]
        public DateTime NgayVaolam { get; set; }
    }
}
