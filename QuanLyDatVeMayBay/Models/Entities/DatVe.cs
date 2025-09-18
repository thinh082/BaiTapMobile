using System;
using System.Collections.Generic;

namespace QuanLyDatVeMayBay.Models.Entities;

public partial class DatVe
{
    public long Id { get; set; }

    public long IdTaiKhoan { get; set; }

    public DateOnly NgayDat { get; set; }

    public virtual ICollection<ChiTietDatVe> ChiTietDatVes { get; set; } = new List<ChiTietDatVe>();

    public virtual TaiKhoan IdTaiKhoanNavigation { get; set; } = null!;
}
