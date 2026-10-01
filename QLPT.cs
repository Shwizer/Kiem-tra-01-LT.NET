using System;
using System.Collections.Generic;
using System.Linq;

public abstract class PhuongTien
{
    private string _maPT;
    private string _tenHang;
    private int _namSanXuat;
    private decimal _giaGoc;

    public string MaPT
    {
        get => _maPT;
        set => _maPT = string.IsNullOrWhiteSpace(value) ? "PT000" : value.Trim();
    }

    public string TenHang
    {
        get => _tenHang;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Tên hãng không được để trống.");
            _tenHang = value;
        }
    }

    public int NamSanXuat
    {
        get => _namSanXuat;
        set
        {
            if (value < 1900 || value > DateTime.Now.Year)
                throw new ArgumentException("Năm sản xuất không hợp lệ!");
            _namSanXuat = value;
        }
    }

    public decimal GiaGoc
    {
        get => _giaGoc;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Giá gốc phải lớn hơn 0.");
            _giaGoc = value;
        }
    }

    public PhuongTien(string maPT, string tenHang, int namSanXuat, decimal giaGoc)
    {
        MaPT = maPT;
        TenHang = tenHang;
        NamSanXuat = namSanXuat;
        GiaGoc = giaGoc;
    }

    public abstract decimal TinhGiaLanBanh();

    public virtual string GetInfo()
    {
        return $"Mã PT: {MaPT}, Hãng: {TenHang}, Năm SX: {NamSanXuat}, Giá gốc: {GiaGoc:N0} VNĐ";
    }
}

public class OTo : PhuongTien
{
    private int _soChoNgoi;
    private double _dungTichDongCo;

    public int SoChoNgoi
    {
        get => _soChoNgoi;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Số chỗ ngồi phải lớn hơn 0.");
            _soChoNgoi = value;
        }
    }

    public double DungTichDongCo
    {
        get => _dungTichDongCo;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Dung tích động cơ phải lớn hơn 0.");
            _dungTichDongCo = value;
        }
    }

    public OTo(string maPT, string tenHang, int namSanXuat, decimal giaGoc, int soChoNgoi, double dungTichDongCo)
        : base(maPT, tenHang, namSanXuat, giaGoc)
    {
        SoChoNgoi = soChoNgoi;
        DungTichDongCo = dungTichDongCo;
    }

    public override decimal TinhGiaLanBanh()
    {
        if (SoChoNgoi <= 9)
        {
            return GiaGoc + (GiaGoc * 0.12m) + (GiaGoc * 0.30m);
        }
        else
        {
            return GiaGoc + (GiaGoc * 0.10m);
        }
    }

    public override string GetInfo()
    {
        return $"{base.GetInfo()}, Số chỗ ngồi: {SoChoNgoi}, Dung tích động cơ: {DungTichDongCo}L";
    }
}

public class XeMay : PhuongTien
{
    public int DungTichXylanh { get; set; }

    public XeMay(string maPT, string tenHang, int namSanXuat, decimal giaGoc, int dungTichXylanh)
        : base(maPT, tenHang, namSanXuat, giaGoc)
    {
        DungTichXylanh = dungTichXylanh;
    }

    public override decimal TinhGiaLanBanh()
    {
        if (DungTichXylanh < 175)
        {
            return GiaGoc + (GiaGoc * 0.02m);
        }
        else
        {
            return GiaGoc + (GiaGoc * 0.05m);
        }
    }

    public override string GetInfo()
    {
        return $"{base.GetInfo()}, Dung tích xy lanh: {DungTichXylanh} cc";
    }
}

public class QuanLyPhuongTien
{
    private List<PhuongTien> _danhSach = new List<PhuongTien>();

    public void AddPhuongTien(PhuongTien pt)
    {
        _danhSach.Add(pt);
    }

    public void DisplayAll()
    {
        foreach (var pt in _danhSach)
        {
            Console.WriteLine($"{pt.GetInfo()} - Giá lăn bánh: {pt.TinhGiaLanBanh():N0} VNĐ");
        }
    }

    public PhuongTien FindMaxGiaLanBanh()
    {
        if (_danhSach.Count == 0) return null;

        PhuongTien maxPt = _danhSach[0];
        foreach (var pt in _danhSach)
        {
            if (pt.TinhGiaLanBanh() > maxPt.TinhGiaLanBanh())
            {
                maxPt = pt;
            }
        }
        return maxPt;
    }

    public List<PhuongTien> SearchByName(string keyword)
    {
        return _danhSach.Where(pt => pt.TenHang.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
    }
}

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("TestCase01: Kiểm tra Validation Năm sản xuất:");
        try
        {
            OTo otoLoi = new OTo("OT00", "Toyota", 1850, 1000000000m, 5, 2.0);
            Console.WriteLine("Thất bại: Không ném ngoại lệ.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Kết quả: Bắt ngoại lệ thành công -> {ex.Message}");
        }

        Console.WriteLine("\nTestCase02: Kiểm tra Tính Giá Lăn Bánh Ô tô ");
        OTo oto5Cho = new OTo("OT01", "Toyota", 2022, 1000000000m, 5, 2.0);
        decimal giaOTo = oto5Cho.TinhGiaLanBanh();
        Console.WriteLine($"Giá lăn bánh: {giaOTo:N0} VNĐ (Kỳ vọng: 1,420,000,000 VNĐ)");

        Console.WriteLine("\nTestCase03: Kiểm tra Tính Giá Lăn Bánh Xe máy:");
        XeMay xeMay150 = new XeMay("XM01", "Honda", 2023, 50000000m, 150);
        decimal giaXeMay = xeMay150.TinhGiaLanBanh();
        Console.WriteLine($"Giá lăn bánh: {giaXeMay:N0} VNĐ (Kỳ vọng: 51,000,000 VNĐ)");

        Console.WriteLine("\nTestCase04: Kiểm tra Đa hình List:");
        QuanLyPhuongTien ql = new QuanLyPhuongTien();
        ql.AddPhuongTien(oto5Cho);
        ql.AddPhuongTien(xeMay150);
        ql.DisplayAll();

        Console.WriteLine("\n TestCase05: Kiểm tra Tìm Giá Lăn Bánh Max: ");
        PhuongTien maxPt = ql.FindMaxGiaLanBanh();
        if (maxPt != null)
        {
            Console.WriteLine($"Đối tượng có giá lăn bánh cao nhất: {maxPt.MaPT} - {maxPt.TenHang}");
            Console.WriteLine($"Giá lăn bánh: {maxPt.TinhGiaLanBanh():N0} VNĐ (Kỳ vọng: 1,420,000,000 VNĐ)");
        }
     Console.ReadKey();
   }
}