using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class ThamSoDTO
	{
		static bool suDungQuyDinh4 = false;
		static decimal soTienNoToiDa = 0;
		static decimal soXeSuaChuaToiDa = 100;


		public static bool SuDungQuyDinh4
		{
			get { return suDungQuyDinh4; }
			set { suDungQuyDinh4 = value; }
		}

		
		public static decimal SoTienNoToiDa
		{
			get { return soTienNoToiDa; }
			set { soTienNoToiDa = value; }
		}

		
		public static decimal SoXeSuaChuaToiDa
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



		
		~ThamSoDTO() { }
	}
}
