using TestNhe;

namespace Testnhe.Test;

public class TinhTongTest
{
    private TinhTong _tinhTong;
    [SetUp]
    public void Setup()
    {
        _tinhTong = new TinhTong();
    }

    [Test]
    public void TinhTong_MangDuong()
    {
        int[] arr = { 1, 2, 3 };
        int result = _tinhTong.TinhTongCacSo(arr);
        Assert.That(result, Is.EqualTo(6));
    }
    [Test]
    public void TinhTong_MangAm()
    {
        int[] arr = { -1, -2, -3 };
        int result = _tinhTong.TinhTongCacSo(arr);
        Assert.That(result, Is.EqualTo(-6));
    }
    [Test]
    public void TinhTong_MangRong()
    {
        int[] arr = { };
        int result = _tinhTong.TinhTongCacSo(arr);
        Assert.That(result, Is.EqualTo(0));
    }
    [Test]
    public void TinhTong_MotPhanTu()
    {
        int[] arr = { 36};
        int result = _tinhTong.TinhTongCacSo(arr);
        Assert.That(result, Is.EqualTo(36));
    }
}
