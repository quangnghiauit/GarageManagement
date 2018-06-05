using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class TienCongDTO
	{
		public string maTienCong;
		public string tenTienCong;
		public decimal soTienCong;

		public string MaTienCong
		{
			get { return maTienCong; }
			set { maTienCong = value; }
		}

		public string TenTienCong
		{
			get { return tenTienCong; }
			set { tenTienCong = value; }
		}

		public decimal SoTienCong
		{
			get { return soTienCong; }
			set { soTienCong = value; }
		}
		public TienCongDTO ()
		{
			maTienCong = "";
			tenTienCong = "";
			soTienCong = 0;
			}
		public TienCongDTO(string maTienCong,string tenTienCong,decimal soTienCong)
		{
			this.maTienCong = maTienCong;
			this.tenTienCong = tenTienCong;
			this.soTienCong = soTienCong;
		}
		~TienCongDTO() { }
	}
}
