using System.Data;
using DTO;
using DAO;

namespace BUS
{
	public class ThamSoBUS
	{
		public bool UpdateParameters(bool _SuDungQuyDinh4, int _SoTienNoToiDa, int _SoXeSuaChuaToiDa, string exception ="")
		{

			if(_SoTienNoToiDa<0||_SoXeSuaChuaToiDa<0)
			{
				exception = "Gía trị tham số không được phép nhỏ hơn 0";
				return false;

			}
			return ThamSoDAO.UpdateParameters(_SuDungQuyDinh4, _SoTienNoToiDa, _SoXeSuaChuaToiDa, exception);

		}

	}
}
