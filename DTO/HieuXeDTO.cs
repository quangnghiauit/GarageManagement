using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class HieuXeDTO
	{
		private string maHieuXe;
		public string MaHieuXe
		{
			get { return maHieuXe; }
			set { maHieuXe = value; }
		}

		private string tenHieuXe;
		public string TenHieuXe
		{
			get { return tenHieuXe; }
			set { tenHieuXe = value; }
		}


		public HieuXeDTO(string maHieuXe, string tenHieuXe)
		{
			this.maHieuXe = maHieuXe;
			this.tenHieuXe = tenHieuXe;
		}
		HieuXeDTO()
		{
			maHieuXe = "";
			tenHieuXe = "";
		}
		~HieuXeDTO() { }
	}
}
