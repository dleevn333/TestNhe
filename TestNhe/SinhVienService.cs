using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNhe
{
    public class SinhVienService
    {
        private List<SinhVien> _sinhViens = new List<SinhVien>()
        {
        new SinhVien() { MaSV = "SV001", Ten = "Nguyen Van A", Tuoi = 20, diemTB = 7.5f, kyHoc = 4, chuyenNganh = "CNTT" },
        new SinhVien() { MaSV = "SV002", Ten = "Tran Thi B", Tuoi = 21, diemTB = 8.0f, kyHoc = 5, chuyenNganh = "Kinh Te" },
        };
        public bool KiemTraSinhVienTonTai(string maSV)
        {
            return _sinhViens.Any(sv => sv.MaSV == maSV);
        }
        public bool SuaSinhVien(SinhVien sinhVienSua)
        {
            if (sinhVienSua == null)
            { return false; }

            //validate ko để null
            if (string.IsNullOrEmpty(sinhVienSua.MaSV) || string.IsNullOrEmpty(sinhVienSua.Ten) || sinhVienSua.Tuoi <= 0 || sinhVienSua.diemTB < 0 || sinhVienSua.kyHoc <= 0 || string.IsNullOrEmpty(sinhVienSua.chuyenNganh))
            {
                return false;
            }
            var sv = _sinhViens.FirstOrDefault(s => s.MaSV == sinhVienSua.MaSV);
            if (sv == null)
            {
                return false;
            }
            sv.Ten = sinhVienSua.Ten;
            sv.Tuoi = sinhVienSua.Tuoi;
            sv.diemTB = sinhVienSua.diemTB;
            sv.kyHoc = sinhVienSua.kyHoc;
            sv.chuyenNganh = sinhVienSua.chuyenNganh;
            return true;

        }
        public SinhVien GetByMaSV(string maSV)
        {
            return _sinhViens.FirstOrDefault(sv => sv.MaSV == maSV);
        }
    } 
}
