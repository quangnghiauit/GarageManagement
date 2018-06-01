using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class TiepNhanXeSuaDTO
	{
		private Int64 maTiepNhanXeSua;

		public Int64 MaTiepNhanXeSua
		{
			get { return maTiepNhanXeSua; }
			set { maTiepNhanXeSua = value; }
		}

		private string bienSo;
		public string BienSo
		{
			get { return bienSo; }

			set { bienSo = value; }
		}

		private DateTime ngayTiepNhan;
		public DateTime NgayTiepNhan
		{
			get { return ngayTiepNhan; }
			set { ngayTiepNhan = value; }
		}

        public TiepNhanXeSuaDTO()
        {
            this.BienSo = "";
            this.ngayTiepNhan = new DateTime();
        }

		public TiepNhanXeSuaDTO( string _bienSo,  DateTime _ngayTiepNhan)
		{
            this.bienSo = _bienSo;
			this.ngayTiepNhan = _ngayTiepNhan;
		}

		~TiepNhanXeSuaDTO() { }
	}
}
