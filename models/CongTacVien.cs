using System;
using System.Collections.Generic;

namespace QLPB.models;

public partial class CongTacVien
{
    public string MaCtv { get; set; } = null!;

    public string? HoTen { get; set; }

    public int? SoBv { get; set; }

    public string? MaPhong { get; set; }

    public virtual PhongBan? MaPhongNavigation { get; set; }
}
