using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI;

namespace GUI
{
	public partial class fHelps : Form
	{
		public fHelps()
		{
			InitializeComponent();
			LoadTreeView();
		}

		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{
			string selectedNodeText = e.Node.Text;
			if(selectedNodeText== "Quản lý khách hàng")
			{
				tbHelp.Text = "Hướng dẫn quản lý khách hàng.";
			}
			if (selectedNodeText == "Tra cứu xe")
			{
				tbHelp.Text = "Hướng dẫn tra cứu xe.";
			}
			if (selectedNodeText == "Quản lý vật tư")
			{
				tbHelp.Text = "Hướng dẫn quản lý vật tư.";
			}
            if (selectedNodeText == "Giao dịch")
            {
                tbHelp.Text = "\tChức năng giao dịch gồm 3 chức năng nhỏ:\r\n"
                    + "\t- Tiếp nhận bảo trì xe: Ghi nhận khi xe được tiếp nhận bảo trì ở gara.\r\n"
                    + "\t- Lập phiếu sửa chữa: Ghi nhận chi tiết về các công việc và các vật tư sử dụng trong quá trình sửa chữa xe.\r\n"
                    + "\t- Lập phiếu thu tiền: Ghi nhận các thông tin khi khách trả tiền.";

            }
            if (selectedNodeText == "Tiếp nhận bảo trì xe")
			{
                tbHelp.Text = "\tTên Chủ Xe, Biển Số và Hiệu Xe sẽ được lấy từ dữ liệu đã nhập ở chức năng Quản Lý Khách Hàng và Tra Cứu Xe.\r\n"
                    + "\tĐịa Chỉ và Số Điện Thoại của khách hàng là chuỗi kí tự được nhập vào.\r\n"
                    + "\tSau khi nhập đầy đủ các thông tin, nhấn nút tiếp nhận sẽ tiến hành nhập dữ liệu vào.\r\n"
                    + "\tNút Lịch Sử Tiếp Nhập sẽ đưa ra danh sách các xe đã được tiếp nhận ở bảng bên dưới.\r\n\r\n";

            }
			if (selectedNodeText == "Lập phiếu sửa chữa")
			{
				tbHelp.Text = "\tKhung Thao Tác bên phải dùng để nhập từng công việc của Phiếu Sửa Chữa, trong đó:\r\n"
                    + "\t- Nội dung: Chuỗi kí tự ghi lại nội dung công việc.\r\n"
                    + "\t- Vật tư phụ tùng: Dữ liệu được lấy từ chức năng Quản Lý Vật Tư.\r\n"
                    + "\t- Số lượng: Số vật tư phụ tùng đã sử dụng.\r\n"
                    + "\t- Đơn giá: Giá tiền của một vật tư phụ tùng đã sử dụng.\r\n"
                    + "\t- Tiền công: Dữ liệu được lấy từ chức năng Thông Tin, Thay Đổi Số Loại Tiền Công.\r\n"
                    + "\t- Thành tiền: Dữ liệu được tính tự động theo công thức (số lượng x đơn giá + tiền công).\r\n"
                    + "\t- Nút thêm sẽ đưa dữ liệu đã nhập hợp lệ vào bản bên trái.\r\n"
                    + "\t- Nút hủy sẽ xóa hết các dữ liệu đã nhập ở khu vực thao tác.\r\n\r\n"
                    + "\tPhía bên trái là khu vực xử lí các thông tin tổng quan của phiếu sửa chữa:\r\n"
                    + "\t- Số phiếu: Chuỗi kí tự.\r\n"
                    + "\t- Biển số: Dữ liệu được lấy từ chức năng Tra Cứu Xe.\r\n"
                    + "\t- Bảng thể hiện các thông tin của phiếu đang nhập.\r\n"
                    + "\t- Nút Tạo Phiếu Mới: Xóa hết các dữ liệu của phiếu đang nhập.\r\n"
                    + "\t- Nút Lập Phiếu: Nhập thông tin của phiếu vào khi đủ các dữ liệu.\r\n"
                    + "\t- Nút Lịch Sử Lập Phiếu: Hiển thị thông tin của các phiếu đã nhập.\r\n"
                    + "\t- Nút Xuất File: Xuất nội dung của phiếu đang nhập ra tập tin Excel.";
			}
			if (selectedNodeText == "Lập phiếu thu tiền")
			{
				tbHelp.Text = "\tDữ liệu ô Biển Số được lấy từ chức năng Tra Cứu Xe.\r\n"
                    + "\tDữ liệu ô Tên Chủ Xe được lấy từ chức năng Quản Lý Khách Hàng.\r\n"
                    + "\tÔ Số Tiền Nợ và Số Tiền Khách Trả chỉ nhập vào được các dạng số.\r\n"
                    + "\tÔ Số Tiền Trả Khách và Số Tiền Thu được tính tự động.\r\n"
                    + "\tNút Lập Phiếu sẽ nhập dữ liệu vào khi điền đầy đủ và hợp lệ các thông tin.\r\n"
                    + "\tNút Lịch Sử Thu Tiền sẽ xuất kết quả các phiếu đã nhập ở bảng bên dưới.";
			}
            if (selectedNodeText == "Báo cáo")
            {
                tbHelp.Text = "\tChức năng báo cáo bao gồm 2 chức năng nhỏ:\r\n"
                    + "\t- Báo cáo tồn: Lập báo cáo về số lượng tồn cho vật tư phụ tùng trong gara theo tháng.\r\n"
                    + "\t- Doanh số: Lập báo cáo về doanh số của gara theo tháng.";
            }
            if (selectedNodeText == "Báo cáo tồn")
			{
				tbHelp.Text = "\tMã báo cáo tồn nhập vào là chuỗi kí tự.\r\n"
                    + "\tNút Lập Báo Cáo sẽ tự động lập báo cáo dựa vào các dữ liệu đã nhập về vật tư phụ tùng ở mục Quản Lý Vật Tưhay khi sử dụng trong sửa chữa.\r\n"
                    + "\tNút Xuất File Excel sẽ xuất kết quả của báo cáo đã hiện về trên bảng ra tập tin Excel.";
			}
			if (selectedNodeText == "Doanh số")
			{
				tbHelp.Text = "\tMã báo cáo doanh số nhập vào là chuỗi kí tự.\r\n"
                    + "\tTổng Doanh Thu được tính tự động từ đữ liệu các Phiếu Thu Tiền đã nhập.\r\n"
                    + "\tNút Lập Báo Cáo sẽ tự động lập báo cáo dựa vào các dữ liệu đã nhập ở mục Giao Dịch, chức năng Phiếu Thu Tiền.\r\n"
                    + "\tNút Xuất File Excel sẽ xuất kết quả của báo cáo đã hiện về trên bảng ra tập tin Excel.";
			}
			if (selectedNodeText == "Thay đổi Database")
			{
				tbHelp.Text = "Hướng dẫn thay đổi database.";
			}
			if (selectedNodeText == "Thay đổi quy định")
			{
				tbHelp.Text = "Hướng dẫn thay đổi quy định.";
			}

			if (selectedNodeText == "Thay đổi số loại tiền công")
			{
				tbHelp.Text = "Hướng dẫn thay đổi số loại tiền công.";
			}


		}

		void LoadTreeView()
		{
			
			tvHelp.NodeMouseClick += tvHelp_MouseDoubleClick;

			TreeNode root1 = new TreeNode();
			root1.Text = "Quản lý khách hàng";
			tvHelp.Nodes.Add(root1);
			

			TreeNode root2 = new TreeNode();
			root2.Text = "Tra cứu xe";
			tvHelp.Nodes.Add(root2);

			TreeNode root3 = new TreeNode();
			root3.Text = "Quản lý vật tư";
			tvHelp.Nodes.Add(root3);

			TreeNode root4 = new TreeNode();
			root4.Text = "Giao dịch";
			tvHelp.Nodes.Add(root4);

			TreeNode node41 = new TreeNode() { Text = "Tiếp nhận bảo trì xe" };
			root4.Nodes.Add(node41);
			TreeNode node42 = new TreeNode() { Text = "Lập phiếu sửa chữa" };
			root4.Nodes.Add(node42);
			TreeNode node43 = new TreeNode() { Text = "Lập phiếu thu tiền" };
			root4.Nodes.Add(node43);

			TreeNode root5 = new TreeNode();
			root5.Text = "Báo cáo";
			tvHelp.Nodes.Add(root5);

			TreeNode node51 = new TreeNode() { Text = "Báo cáo tồn" };
			root5.Nodes.Add(node51);
			TreeNode node52 = new TreeNode() { Text = "Doanh số" };
			root5.Nodes.Add(node52);

			TreeNode root6 = new TreeNode();
			root6.Text = "Thông tin";
			tvHelp.Nodes.Add(root6);

			TreeNode node61 = new TreeNode() { Text = "Thay đổi Database" };
			root6.Nodes.Add(node61);
			TreeNode node62 = new TreeNode() { Text = "Thay đổi quy định" };
			root6.Nodes.Add(node62);
			TreeNode node63 = new TreeNode() { Text = "Thay đổi số loại tiền công" };
			root6.Nodes.Add(node63);

			
			
			
			
			
			
		}

		private void tvHelp_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			
		}
	}
}
