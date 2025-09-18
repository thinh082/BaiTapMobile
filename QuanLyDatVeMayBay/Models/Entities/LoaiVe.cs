using System;
using System.Collections.Generic;

namespace QuanLyDatVeMayBay.Models.Entities;

public partial class LoaiVe
{
    public int Id { get; set; }

    public string TenLoaiVe { get; set; } = null!;

    public virtual ICollection<GheNgoi> GheNgois { get; set; } = new List<GheNgoi>();

    public virtual ICollection<VeMayBay> VeMayBays { get; set; } = new List<VeMayBay>();
}
