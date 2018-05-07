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

		public TienCongDTO ()
		{
			maTienCong = "";
			tenTienCong = "";
			}
		public TienCongDTO(string maTienCong,string tenTienCong)
		{
			this.maTienCong = maTienCong;
			this.tenTienCong = tenTienCong;
		}
		~TienCongDTO() { }
	}
}
