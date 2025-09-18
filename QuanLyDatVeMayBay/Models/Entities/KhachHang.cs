﻿using System;
using System.Collections.Generic;

namespace QuanLyDatVeMayBay.Models.Entities;

public partial class KhachHang
{
    public long Id { get; set; }

    public long IdTaiKhoan { get; set; }

    public string TenKh { get; set; } = null!;

    public string? DiaChi { get; set; }

    public int? IdPhuong { get; set; }

    public int? IdQuan { get; set; }

    public int? IdTinh { get; set; }

    public virtual Phuong? IdPhuongNavigation { get; set; }

    public virtual Quan? IdQuanNavigation { get; set; }

    public virtual TaiKhoan IdTaiKhoanNavigation { get; set; } = null!;

    public virtual Tinh? IdTinhNavigation { get; set; }

    public virtual ICollection<KhachHangGiayTo> KhachHangGiayTos { get; set; } = new List<KhachHangGiayTo>();
}
