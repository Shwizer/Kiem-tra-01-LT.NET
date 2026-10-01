
Câu 1: Sự khác nhau giữa Value Types (Kiểu giá trị) và Reference Types
(Kiểu tham chiếu) trong C# về cơ chế lưu trữ vùng nhớ (Stack vs Heap).

1. Cơ chế lưu trữ vùng nhớ

Value Types (Kiểu giá trị):
* Lưu trữ trực tiếp giá trị thực tế của biến.
* Khi được khai báo là biến cục bộ (local variable) hoặc tham số trong phương thức, dữ liệu được cấp phát trực tiếp trên Stack.
* Ngoại lệ: Khi là trường dữ liệu (field) bên trong một `class`, phần tử của mảng, hoặc khi xảy ra hiện tượng Boxing, dữ liệu của Value Type sẽ nằm trong khối bộ nhớ của đối tượng tương ứng trên Managed Heap.


Reference Types (Kiểu tham chiếu):
* Bộ nhớ được tách biệt làm hai thành phần:
* Biến tham chiếu (Reference Pointer): Lưu địa chỉ con trỏ trỏ tới vùng nhớ đối tượng, có kích thước 4 bytes (hệ 32-bit) hoặc 8 bytes (hệ 64-bit), thường nằm trên Stack (nếu là biến cục bộ).
* Thực thể đối tượng (Object Instance): Bao gồm dữ liệu thực tế cùng các trường quản lý ngầm (`Object Header` và `Method Table Pointer`), luôn được cấp phát động trên Managed Heap qua toán tử `new`.

#Câu 2: Thuộc tính Init-only (`init`) trong C# 9/10 và Ứng dụng Thực tế

1. Phân biệt `init` và `set` thông thường
* Thuộc tính có `set` (Mutable):
* Cho phép gán hoặc sửa đổi giá trị của thuộc tính tại bất kỳ thời điểm nào trong suốt vòng đời của đối tượng.
* Trạng thái đối tượng có thể bị biến đổi sau khi đã được tạo ra.


* Thuộc tính có `init` (Init-only / Semi-immutable):
* Chỉ cho phép gán giá trị tại thời điểm khởi tạo đối tượng: thông qua Constructor hoặc Object Initializer (`new ClassName { Property = value }`).
* Ngay khi quá trình khởi tạo hoàn tất, thuộc tính chuyển sang trạng thái "chỉ đọc" . Mọi thao tác gán lại giá trị sau đó sẽ gặp lỗi biên dịch .

2. Trường hợp sử dụng thực tế

Làm API / Web Service (Đối tượng DTO):
Khi viết API cho App hay Web, dữ liệu từ Client gửi lên (như đăng ký tài khoản, gửi đơn hàng) sau khi được hứng vào DTO thì chỉ mang đi xử lý chứ không được phép sửa lung tung. Dùng init giúp dữ liệu không bao giờ bị các hàm phía sau ghi đè.

Câu 3: Phân biệt `virtual` ở Lớp cha và `override` ở Lớp con

1. Bản chất và vai trò

Phương thức `virtual` (ở lớp cha):
* Đóng vai trò là phương thức cơ sở, thông báo cho trình biên dịch rằng phương thức này được phép định nghĩa lại hành vi ở các lớp dẫn xuất.
* Bắt buộc phải có phần thân hoàn chỉnh (cung cấp triển khai mặc định). Lớp con kế thừa không bắt buộc phải ghi đè nếu triển khai mặc định đã đáp ứng yêu cầu.


Phương thức `override` (ở lớp con):
* Định nghĩa lại nội dung thực thi cụ thể của phương thức `virtual` (hoặc `abstract`) được kế thừa.
* Bắt buộc chữ ký phương thức (tên, danh sách tham số, kiểu dữ liệu trả về) phải trùng khớp hoàn toàn với phương thức ở lớp cha.


Câu 4: Nguyên nhân Thành phần `static` không thể truy xuất qua Thể hiện (Instance)

1. Phân bổ kiến trúc bộ nhớ và Vòng đời tồn tại

* Thành phần thể hiện (Instance): Thuộc quyền sở hữu riêng của từng đối tượng. Chúng được cấp phát độc lập trên Managed Heap mỗi khi toán tử `new` được thực thi.
* Thành phần tĩnh (Static): Thuộc về cấp độ Kiểu dữ liệu, không thuộc về bất kỳ đối tượng cụ thể nào. Dữ liệu tĩnh chỉ được cấp phát một lần duy nhất khi lớp được nạp lần đầu, tồn tại độc lập ngay cả khi không có bất kỳ thể hiện nào được khởi tạo.

2. Loại bỏ sự nhầm lẫn ngữ nghĩa

* Tránh ngộ nhận trạng thái: Cú pháp nhằm ngầm định thao tác trên trạng thái riêng của đối tượng đó. Nếu cho phép truy xuất, dễ lầm tưởng việc sửa đổi giá trị chỉ ảnh hưởng tới một thể hiện cục bộ, trong khi thực tế thao tác này làm thay đổi trạng thái chung của toàn bộ hệ thống.
