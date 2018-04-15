using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	class BaoCaoTonDTO
	{
		private string maBaoCaoTon;
		public string MaBaoCaoTon
		{
			get { return maBaoCaoTon; }
			set { maBaoCaoTon = value; }
		}

		private int thangBaoCaoTon;
		public int ThangBaoCaoTon
		{
			get { return thangBaoCaoTon; }
			set { thangBaoCaoTon = value; }
		}

		private int namBaoCaoTon;
		public int NamBaoCaoTon
		{
			get { return NamBaoCaoTon; }
			set { NamBaoCaoTon = value; }
		}



		public BaoCaoTonDTO(string maBaoCaoTon, int thangBaoCaoTon, int namBaoCaoTon)
		{
			this.maBaoCaoTon = maBaoCaoTon;
			this.thangBaoCaoTon = thangBaoCaoTon;
			this.namBaoCaoTon = namBaoCaoTon;
		}

		~BaoCaoTonDTO() { }
	}
}
