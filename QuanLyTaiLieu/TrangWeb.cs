﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyTaiLieu
{
    public class TrangWeb : TaiLieu
    {
        public TrangWeb(TaiLieu tl)
        {
            this.MaTL = tl.MaTL;
            this.LoaiTaiLieu = tl.LoaiTaiLieu;
            this.TacGia = tl.TacGia;
            this.TieuDe = tl.TieuDe;
            this.TomTat = tl.TomTat;
            this.Nam = tl.Nam;
            this.GhiChu = tl.GhiChu;
            this.File = tl.File;
            this.URL = tl.URL;
            this.DOI = tl.DOI;
        }
        public string ToChuc
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int Ngay
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int Thang
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public DateTime NgayTruyCap
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
