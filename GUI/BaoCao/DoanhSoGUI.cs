﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAO;
using DTO;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;

namespace GUI
{
	public partial class fDoanhSo : Form
	{
		public fDoanhSo()
		{
			InitializeComponent();
			dtmThangLapBaoCao.Format = DateTimePickerFormat.Custom;
			dtmThangLapBaoCao.CustomFormat = "MM / yyyy";
			dtmThangLapBaoCao.ShowUpDown = true;
		}

		

        private void btnLapBaoCao_Click(object sender, EventArgs e)
        {
            if (!fMainForm.cNullTB(txtMaBaoCao.Text))
            {
                DateTime thang0 = dtmThangLapBaoCao.Value;
                string maBC = txtMaBaoCao.Text;

                dgvBaoCaoDoanhSo.DataSource = DoanhSoBUS.createBaoCaoDoanhSo(thang0.Month, thang0.Year);
                DoanhSoBUS.insertBaoCaoDoanhSo(maBC, thang0, thang0.Month, thang0.Year);

                txtTongDoanhThu.Text = DoanhSoBUS.selectTongDoanhThu(thang0).ToString();
            }
            else
                MessageBox.Show("Hãy nhập mã báo cáo.");
        }

        private void btnXuatFileExcel_Click(object sender, EventArgs e)
        {
            export2Excel(dgvBaoCaoDoanhSo, @"E:\", "ExportBaoCaoDoanhSo");
        }

        private void export2Excel(DataGridView g, string path, string filename)
        {

            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(path + filename + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }
    }
}
