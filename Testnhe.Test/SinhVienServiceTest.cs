using TestNhe;

namespace Testnhe.Test;

public class SinhVienServiceTest
{
    private SinhVienService _sinhVienService;
    [SetUp]
    public void Setup()
    {
        _sinhVienService = new SinhVienService();
    }

    [Test]
    public void KiemTraMaTonTai_False()
    {
        Assert.That(_sinhVienService.KiemTraSinhVienTonTai("SV003"), Is.False);
    }
    [Test]
    public void SuaSinhVien_ThanhCong()
    {
        var sinhVienSua = new SinhVien() { MaSV = "SV001", Ten = "Nguyen Van A", Tuoi = 20, diemTB = 7.5f, kyHoc = 4, chuyenNganh = "CNTT" };
        var result = _sinhVienService.SuaSinhVien(sinhVienSua);
        Assert.That(result, Is.True);
    }
    [Test]
    public void SuaSinhVien_KhongTonTai()
    {
        var sinhVienSua = new SinhVien() { MaSV = "SV036", Ten = "Nguyen Van A", Tuoi = 20, diemTB = 7.5f, kyHoc = 4, chuyenNganh = "CNTT" };
        var result = _sinhVienService.SuaSinhVien(sinhVienSua);
        Assert.That(result, Is.False);
    }
    [Test]
    public void SuaSinhVien_KhongCoTen()
    {
        var sinhVienSua = new SinhVien() { MaSV = "SV001", Ten = "", Tuoi = 20, diemTB = 7.5f, kyHoc = 4, chuyenNganh = "CNTT" };
        var result = _sinhVienService.SuaSinhVien(sinhVienSua);
        Assert.That(result, Is.False);
    }
}
