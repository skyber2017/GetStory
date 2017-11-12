using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHoangDuy
{
    class hocsinh
    {
        long _maso;
        [DisplayName("Mã số")]
        public long Maso
        {
            get { return _maso; }
            set { _maso = value; }
        }


        string _holot;
        [DisplayName("Họ lót")]
        public string Holot
        {
            get { return _holot; }
            set { _holot = value; }
        }


        string _ten;
        [DisplayName("Tên")]
        public string Ten
        {
            get { return _ten; }
            set { _ten = value; }
        }


        DateTime _ngaysinh;
        [DisplayName("Ngày sinh")]
        public DateTime Ngaysinh
        {
            get { return _ngaysinh; }
            set { _ngaysinh = value; }
        }


        bool _gioitinh;
        [DisplayName("Giới tính")]
        public bool Gioitinh
        {
            get { return _gioitinh; }
            set { _gioitinh = value; }
        }

        [DisplayName("Giới tính")]
        public string GioitinhString
        {
            get
            {
                if (_gioitinh == true)
                    return "Nam";
                return "Nữ";
            }
        }


        Image _hinhanh;
        [DisplayName("Hình ảnh")]
        public Image Hinhanh
        {
            get { return _hinhanh; }
            set { _hinhanh = value; }
        }
    }
}
