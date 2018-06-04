using System.Data;
using DTO;
using DAO;

namespace BUS
{
	public class ThamSoBUS
	{
		public static bool UpdateParameters( string exception ="")
		{

			if(ThamSoDTO.SoTienNoToiDa<0||ThamSoDTO.SoXeSuaChuaToiDa<0)
			{
				exception = "Gía trị tham số không được phép nhỏ hơn 0";
				return false;

			}
			return ThamSoDAO.UpdateParameters(exception);

		}
		public static bool GetParameters(string exception ="")
		{
			return ThamSoDAO.GetParameters(exception);
		}


	}
}
