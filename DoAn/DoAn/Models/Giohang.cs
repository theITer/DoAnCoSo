﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoAn.Models;

namespace DoAn.Models
{
    public class Giohang
    {
        //Tao doi tuong data chua dữ liệu từ model dbBansach đã tạo. 
        dbQLMonanDataContext data = new dbQLMonanDataContext();
        public int iMamon{set; get;}
        public int iMaThucUong { set; get; }
        public string sTenmon{set; get;}
        public int sGiaban{set; get;}
        public int iSoluong { set; get; }
        public string sAnh { set; get; }
        public string sTenthucuong { set; get; }
        public Double dDongia{set; get;}
        public Double dThanhtien
        {
            get { return iSoluong * dDongia; }

        }
        //Khoi tao gio hàng theo Masach duoc truyen vao voi Soluong mac dinh la 1
        public Giohang(int Mamon, int MaThucUong)
        {
            iMamon = Mamon;
            CTMONAN monan = data.CTMONANs.Single(n => n.Mamon == iMamon);
            sTenmon = monan.Tenmon;
            sAnh = monan.Anh;
            iMaThucUong = MaThucUong;
            Tb_Drink thucuong = data.Tb_Drinks.Single(n => n.MaThucUong == iMaThucUong);
            sTenthucuong = thucuong.TenThucUong;
            dDongia =double.Parse(monan.Giaban.ToString());
            iSoluong = 1;
        }
    }
}