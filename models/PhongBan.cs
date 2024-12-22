using System;
using System.Collections.Generic;

namespace QLPB.models;

public partial class PhongBan
{
    public string MaPhong { get; set; } = null!;

    public string? TenPhong { get; set; }

    public virtual ICollection<CongTacVien> CongTacViens { get; set; } = new List<CongTacVien>();
}
