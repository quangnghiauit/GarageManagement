using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class XeDTO
	{
		private string bienSo;
		public string BienSo
		{
			get { return bienSo; }
			set { bienSo = value; }
		}

		private string tenChuXe;
		public string TenChuXe
		{
			get { return tenChuXe; }
			set { tenChuXe = value; }
		}

		private string tenHieuXe;
		public string TenHieuXe
		{
			get { return tenHieuXe; }
			set { tenHieuXe = value; }
		}

		private int tienNo;
		public int TienNo
		{
			get { return tienNo; }
			set { tienNo = value; }
		}

		public XeDTO(string bienSo, string tenChuXe, string hieuXe, int tienNo)
		{
			this.bienSo = bienSo;
			this.tenChuXe = tenChuXe;
			this.tenHieuXe = hieuXe;
			this.tienNo = tienNo;
			
		}
		public XeDTO()
		{
			bienSo = "";
			tenChuXe = "";
			tenHieuXe = "";
			tienNo = 0;
		}
		~XeDTO() { }
	}
}
