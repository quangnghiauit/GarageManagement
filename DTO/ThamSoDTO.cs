using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	class ThamSoDTO
	{
		

		

		private bool suDungQuyDinh4;
		public bool SuDungQuyDinh4
		{
			get { return suDungQuyDinh4; }
			set { suDungQuyDinh4 = value; }
		}

		private int soTienNoToiDa;
		public int SoTienNoToiDa
		{
			get { return soTienNoToiDa; }
			set { soTienNoToiDa = value; }
		}

		private int soXeSuaChuaToiDa;
		public int SoXeSuaChuaToiDa
		{
			get { return soXeSuaChuaToiDa; }
			set { soXeSuaChuaToiDa = value; }
		}

		public ThamSoDTO()
		{
			soXeSuaChuaToiDa = 100;
			soTienNoToiDa = 0;
			suDungQuyDinh4 = false;
		}



		public ThamSoDTO(bool suDungQuyDinh4, int soTienNoToiDa, int soXeSuaChuaToiDa)
		{

			this.suDungQuyDinh4 = suDungQuyDinh4;
			this.soTienNoToiDa = soTienNoToiDa;
			this.soXeSuaChuaToiDa = soXeSuaChuaToiDa;

		}
		~ThamSoDTO() { }
	}
}
