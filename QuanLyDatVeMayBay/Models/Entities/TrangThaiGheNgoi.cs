﻿using System;
using System.Collections.Generic;

namespace QuanLyDatVeMayBay.Models.Entities;

public partial class TrangThaiGheNgoi
{
    public int Id { get; set; }

    public string? TenTrangThai { get; set; }

    public virtual ICollection<GheNgoi> GheNgois { get; set; } = new List<GheNgoi>();
}
