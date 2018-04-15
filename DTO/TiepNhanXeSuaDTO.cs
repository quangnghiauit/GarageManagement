using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class TiepNhanXeSuaDTO
	{
		private string maTiepNhanXeSua;

		public string MaTiepNhanXeSua
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
            this.maTiepNhanXeSua = "";
            this.bienSo = "";
            this.ngayTiepNhan = new DateTime();
        }

		public TiepNhanXeSuaDTO(string maTiepNhanXeSua, string bienSo, DateTime ngayTiepNhan)
		{
			this.maTiepNhanXeSua = maTiepNhanXeSua;
			this.bienSo = bienSo;
			this.ngayTiepNhan = ngayTiepNhan;
		}

		~TiepNhanXeSuaDTO() { }
	}
}
