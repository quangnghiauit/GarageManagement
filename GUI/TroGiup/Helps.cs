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
            tbHelp.ScrollBars = ScrollBars.Vertical;
		}

		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{
			string selectedNodeText = e.Node.Text;
			if(selectedNodeText== "Quản lý khách hàng")
			{
				tbHelp.Text = "\tKhung Thao Tác bên phải dùng để nhập từng công việc của Quản lý khách hàng, trong đó:\r\n"
					+ "\t- Mã khách sửa xe: CHÚ Ý Mã khách hàng là số nên chú ý trong việc nhập dữ liệu vào.\r\n"
					+ "\t- Tên chủ xe: Tên của khách sửa xe.\r\n"
					+ "\t- Điện thoại: Số điện thoại của khách sửa xe.Dữ liệu nhập vào là số.\r\n"
					+ "\t- Địa chỉ: Địa chỉ của khách sửa xe.\r\n"
					+ "\t- Email: Email của khách sửa xe.\r\n"
					+ "\t- Số tiền nợ: Số tiền nợ của khách hàng đó khi nhập xe vào.Mặc định khi thêm mới là số tiền nợ bằng 0.\r\n"
					+ "\t- Nút thêm sẽ nhập dữ liệu của khách hàng vào database.\r\n"
					+ "\t- Nút cập nhật sẽ cập nhật lại dữ liệu của khách hàng vào database.\r\n"
					+ "\t- Nút xóa sẽ xóa hết các dữ liệu đã nhập của khách hàng đó.LƯU Ý: Muốn xóa khách hàng phải xóa hết các xe của khách hàng đó rồi mới được xóa khách hàng.\r\n\r\n"
					+ "\t- Nút Lịch sử thao tác cho phép hiển thị tất cả thông tin của khách hàng nhập vào.\r\n"
					+ "\tPhía bên trái là khu vực tìm kiếm và xử lí các thông tin tổng quan của chức năng quản lý khách hàng:\r\n"
					+ "\t- Mã khách hàng: CHÚ Ý Mã khách hàng là số nên chú ý trong việc nhập dữ liệu vào.Khi sử dụng chức năng tìm kiếm thì mã khách hàng nhập vào chỉ cần nhớ một phần của mã khách hàng vẫn có thể tìm được thông tin khách hàng đó.\r\n"
					+ "\t- Tên khách hàng: Tên của khách sửa xe.\r\n"
					+ "\t- Điện thoại: Số điện thoại của khách sửa xe.Dữ liệu nhập vào là số.\r\n"
					+ "\t- Địa chỉ: Địa chỉ của khách sửa xe.\r\n"
					+ "\t- Email: Email của khách sửa xe.\r\n"
					+ "\t- Combobox số tiền nợ: Được sử dụng cho chức năng tìm kiếm.Có thể tìm khách hàng theo từng loại tiền nợ khác nhau.\r\n"
					+ "\t- Số tiền nợ: Số tiền nợ của khách hàng đó khi nhập xe vào.Mặc định khi thêm mới là số tiền nợ bằng 0.\r\n"
					+ "\t- Nút Tìm kiếm: Dùng để tìm kiếm những khách hàng có thông tin như người dùng muốn tìm kiếm.Lưu ý: Mã khách hàng có thể chỉ cần nhập một phần mã cần tìm và có thể chọn theo từng khung số tiền nợ.\r\n"
					+ "\t- Nút Xuất File: Xuất nội dung của phiếu đang nhập ra tập tin Excel.";
			}
			if (selectedNodeText == "Tra cứu xe")
			{
				tbHelp.Text = "\tKhung Thao Tác bên phải dùng để nhập từng công việc của Quản lý xe, trong đó:\r\n"
					+ "\t- Biển số: Dữ liệu nhập vào là chuỗi.\r\n"
					+ "\t- Tên chủ xe: Tên của khách sửa xe.Dữ liệu được lấy từ việc nhập khách hàng ở chức năng quản lý khách hàng.\r\n"
					+ "\t- Hiệu xe: Nếu chưa có hiệu xe thì phải thêm hiệu xe vào. Nhấn vào nút '+' để thêm hiệu xe.Nhập Mã hiệu xe là chuỗi.\n +Nhấn Nút Thêm để thêm hiệu xe.\n +Nhấn nút Xóa để xóa Hiệu xe.\n +Nhấn nút Lịch sử để hiển thị tất cả các hiệu xe đã nhập.\n Nếu đã có Hiệu xe thì chọn trong list Hiệu xe để nhập hiệu xe.\r\n"
					+ "\t- Tiền nợ: Số tiền nợ của khách hàng đó khi nhập xe vào.Mặc định khi thêm mới là số tiền nợ bằng 0.\r\n"
					+ "\t- Nút thêm sẽ nhập dữ liệu của xe vào database.\r\n"
					+ "\t- Nút cập nhật sẽ cập nhật lại dữ liệu của xe vào database.\r\n"
					+ "\t- Nút xóa sẽ xóa hết các dữ liệu đã nhập của xe đó.\r\n\r\n"
					+ "\t- Nút Lịch sử thao tác cho phép hiển thị tất cả thông tin của xe nhập vào.\r\n"
					+ "\tPhía bên trái là khu vực tìm kiếm và xử lí các thông tin tổng quan của chức năng quản lý xe:\r\n"
					+ "\t- Biển số: Chọn biển số trong list các xe cần tìm kiếm.\r\n"
					+ "\t- Tên chủ xe: Tên của khách sửa xe.\r\n"
					+ "\t- Hiệu xe: Tên hiệu xe đó.\r\n"
					+ "\t- Tiền nợ: Số tiền nợ của khách hàng đó khi nhập xe vào.Mặc định khi thêm mới là số tiền nợ bằng 0.\r\n"
					+ "\t- Nút Tìm kiếm: Dùng để tìm kiếm những xe có thông tin như người dùng muốn tìm kiếm.Có thể tìm xe bằng cách nhập mỗi biển số.\r\n"
					+ "\t- Nút Xuất File: Xuất nội dung của phiếu đang nhập ra tập tin Excel.";
			}
			if (selectedNodeText == "Quản lý vật tư")
			{
				tbHelp.Text = "\tKhung Thao Tác bên phải dùng để nhập từng công việc của Quản lý vật tư, trong đó:\r\n"
					+ "\t- Mã vật tư: Mã vật tư là chuỗi.\r\n"
					+ "\t- Tên vật tư: Tên của vật tư phụ tùng.\r\n"
					+ "\t- Đơn giá: Đơn giá của vật tư phụ tùng.Dữ liệu nhập vào là số.\r\n"
					+ "\t- Số lượng: Số lượng của vật tư nhập vào.\r\n"
					+ "\t- Ngày nhập: Ngày nhập vật tư.\r\n"
					+ "\t- Nút thêm sẽ nhập dữ liệu của vật tư vào database.\r\n"
					+ "\t- Nút cập nhật sẽ cập nhật lại dữ liệu của vật tư vào database.\r\n"
					+ "\t- Nút xóa sẽ xóa hết các dữ liệu đã nhập của vật tư đó.\r\n\r\n"
					+ "\t- Nút Lịch sử thao tác cho phép hiển thị tất cả thông tin của vật tư nhập vào.\r\n"
					+ "\tPhía bên trái là khu vực tìm kiếm và xử lí các thông tin tổng quan của chức năng quản lý vật tư:\r\n"
					+ "\t- Mã vật tư: Mã vật tư được chọn trong list vật tư đã được nhập ở phần Thao tác.\r\n"
					+ "\t- Tên vật tư: Tên của vật tư phụ tùng.\r\n"
					+ "\t- Đơn giá: Đơn giá của vật tư phụ tùng.Dữ liệu nhập vào là số.\r\n"
					+ "\t- Số lượng: Số lượng của vật tư nhập vào.\r\n"
					+ "\t- Nút Tìm kiếm: Dùng để tìm kiếm những vật tư có thông tin như người dùng muốn tìm kiếm.\r\n"
					+ "\t- Nút Xuất File: Xuất nội dung của phiếu đang nhập ra tập tin Excel.";
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
			if (selectedNodeText == "Thông tin")
			{
				tbHelp.Text = "\tChức năng thông tin bao gồm 3 chức năng nhỏ:\r\n."
					+ "\t- Thay đổi Database: Kết nối và lưu thông tin kết nối với database.\r\n"
					+ "\t- Thay đổi quy định: Thay đổi các quy định của phần mềm.\r\n"
					+ "\t- Thay đổi số loại tiền công: Thêm hoặc xóa các loại tiền công của các nhân viên trong gara.";
			}
			if (selectedNodeText == "Thay đổi Database")
			{
				tbHelp.Text = "\tKiểm tra lại cơ sở dữ liệu của máy bạn sau đó nhập đúng Server, User, Password, Database Name.\r\n"
					+ "\tKiểm tra kết nối để xem phần mềm đã kết nối với database thành công hay chưa.Nếu không kết nối thành công thì bạn kiểm tra lại thông tin đã nhập vào đúng hay chưa.\r\n"
					+ "\tSau khi đã kết nối thành công thì nhấn nút lưu kết nối để lưu lại thông tin kết nối.\r\n"
					+ "\tCHÚ Ý: PHẢI KẾT NỐI VỚI DATABASE THÀNH CÔNG MỚI SỬ DỤNG ĐƯỢC PHẦN MỀM.";
			}
			if (selectedNodeText == "Thay đổi quy định")
			{
				tbHelp.Text = "\tSố xe sửa tối đa trong ngày và số tiền nợ tối đa nhập vào là số.\r\n"
					+ "\tKhi sử dụng quy định 4 thì click vào checkbox Sử dụng quy định 4.\r\n"
					+ "\tNút Áp dụng để sử dụng tất cả các quy định mà bạn vừa thay đổi.";
					
			}

			if (selectedNodeText == "Thay đổi số loại tiền công")
			{
				tbHelp.Text = "\tMã tiền công nhập vào là chuỗi kí tự.\r\n"
					+ "\tNút Thêm để thêm Mã tiền công, Tên tiền công và số tiền công khi được thêm mới.\r\n"
					+ "\tNút Xóa để xóa một loại tiền công có sẵn trong cơ sở dữ liệu.Chỉ cần nhập Mã tiền công để xóa loại Tiền công đó.\r\n"
					+ "\tNút Xem lịch sử để xem các loại Tiền công được thêm vào.";
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
