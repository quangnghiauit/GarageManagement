using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class ThamSoDTO
	{
		public bool suDungQuyDinh4 = false;
		public int soTienNoToiDa = 0;
		public int soXeSuaChuaToiDa = 100;


		public bool SuDungQuyDinh4
		{
			get { return suDungQuyDinh4; }
			set { suDungQuyDinh4 = value; }
		}

		
		public int SoTienNoToiDa
		{
			get { return soTienNoToiDa; }
			set { soTienNoToiDa = value; }
		}

		
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
