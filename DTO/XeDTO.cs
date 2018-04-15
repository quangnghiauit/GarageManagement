using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	class XeDTO
	{
		private string bienSo;
		public string BienSo
		{
			get { return bienSo; }
			set { bienSo = value; }
		}

		private string maKhachSuaXe;
		public string MaKhachSuaXe
		{
			get { return maKhachSuaXe; }
			set { maKhachSuaXe = value; }
		}

		private string dienThoai;
		public string DienThoai
		{
			get { return dienThoai; }
			set { dienThoai = value; }
		}

		private string diaChi;
		public string DiaChi
		{
			get { return diaChi; }
			set { diaChi = value; }
		}

		private string maHieuXe;
		public string MaHieuXe
		{
			get { return maKhachSuaXe; }
			set { maKhachSuaXe = value; }
		}

		public XeDTO(string bienSo, string maKhachSuaXe, string dienThoai, string diaChi, string maHieuXe)
		{
			this.bienSo = bienSo;
			this.maKhachSuaXe = maKhachSuaXe;
			this.dienThoai = dienThoai;
			this.diaChi = diaChi;
			this.maHieuXe = maHieuXe;
		}
		~XeDTO() { }
	}
}
