﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyTaiLieu
{
    public class DanhMuc
    {
        public DanhMuc()
        {
        }

        public DanhMuc(int MaDM, string TenDM)
        {
            // TODO: Complete member initialization
            this.MaDM = MaDM;
            this.TenDanhMuc = TenDM;
        }
        public int MaDM
        {
            get;
            set;
        }

        public string TenDanhMuc
        {
            get;
            set;
        }

        public DanhMuc DMCha = null;
        public List<DanhMuc> DSDanhMucCon = new List<DanhMuc>();

        public void TaoDanhMuc()
        {
            throw new System.NotImplementedException();
        }

        public void CapNhatDanhMuc()
        {
            throw new System.NotImplementedException();
        }

        public void XoaDanhMuc()
        {
            throw new System.NotImplementedException();
        }

        public void ThongTin()
        {
            throw new System.NotImplementedException();
        }

        public void SoLuongTaiLieu()
        {
            throw new System.NotImplementedException();
        }
    }
}
