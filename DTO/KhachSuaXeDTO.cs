using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{

	
	public class KhachSuaXeDTO
	{
		private string maKhachSuaXe;
		private string tenChuXe;
		private string diaChi;
		private string dienThoai;
		private string email;
		private int tienNo;
		
		#region Properties
		public string MaKhachSuaXe
		{
			get { return maKhachSuaXe; }
			set { maKhachSuaXe = value; }
		}


		public string TenChuXe
		{
			get { return tenChuXe; }
			set { tenChuXe = value; }
		}

		

		public string DiaChi
		{
			get { return diaChi; }
			set { diaChi = value; }
		}


		public string DienThoai
		{
			get { return dienThoai; }
			set { dienThoai = value; }
		}


		public string Email
		{
			get { return email; }
			set { email = value; }
		}


		public int TienNo
		{
			get { return tienNo; }
			set { tienNo = value; }
		}
		#endregion

		#region Constructor and Destructor
		public KhachSuaXeDTO()
		{
			MaKhachSuaXe = "";
			TenChuXe = "";
			DienThoai = "";
			DiaChi = "";
			Email = "";
			TienNo = 0;

		}



		public KhachSuaXeDTO(string maKhachSuaXe, string tenChuXe, string dienThoai, string diaChi, string email, int tienNo)
		{
			this.maKhachSuaXe = maKhachSuaXe;
			this.tenChuXe = tenChuXe;
			//this.tuoi = tuoi;
			this.diaChi = diaChi;
			this.dienThoai = dienThoai;
			this.email = email;
			this.tienNo = tienNo;
		}

		 ~KhachSuaXeDTO()
		{
			
		}
		#endregion
	}
}
