
M    MINISTRY OF EDUCATION AND TRAINING
UNI      UNIVERSITY OF ECONOMICS AND FINANCE





PROJECT REPORT

Desktop Application Development

TOPIC
Quản Lý Quán Bida


Major: 	Information Technology
Minor: 	Software engineering
 
 



Ho Chi Minh City, 2023
MINISTRY OF EDUCATION AND TRAINING
UNIVERSITY OF ECONOMICS AND FINANCE



PROJECT REPORT
Desktop Application Development

TOPIC
Quản Lý Quán Bida

Major: 	Information Technology
Minor: 	Software engineering

Supervisor: Hoàng Văn Hiếu
Student ID 1: 195050974	Student’s name 1: Lê Tấn Đạt
Student ID 2: 215052247	Student’s name 2: Nguyễn Viết Hoá
Student ID 3:215101362	Student’s name 3: Nguyễn Ngọc Thịnh
	
Class: A04E



Ho Chi Minh City, 2023

TABLE OF CONTENTS

Chương 1 Tổng quan về việc nghiên cứu	2
1.1 Lý do chọn đề tài	2
1.2 Giới thiệu bài toán và một số nghiên cứu liên quan	2
1.2.1 Giới thiệu bài toán	2
1.2.2 Các nghiên cứu liên quan	3
1.2.3 Những thách thức trong bài toán	3
1.2.4 Hướng tiếp cận giải quyết bài toán	4
1.3 Mục tiêu, đối tượng, phạm vi nghiên cứu	5
1.3.1 Mục tiêu nghiên cứu	5
1.3.2 Đối tượng nghiên cứu	5
1.3.3 Phạm vi nghiên cứu	6
1.4 Nội dung và phương pháp nghiên cứu	6
1.4.1 Nội dung nghiên cứu	6
1.4.2 Phương pháp nghiên cứu	6
1.5 Đóng góp của đề tài	6
Chương 2 Phân tích thiết kế hệ thống	7
2.1 Phân tích thiết kế hệ thống thông tin	7
2.2 Các cách tiếp cận và phát triển một hệ thống thông tin	8
2.3 Các bước phát triển của một hệ thống thông tin	9
2.4 Một số mô hình phát triển của một hệ thống thông tin	9
2.5 Các phương pháp phân tích thiết kế hướng cấu trúc	10
2.6 Mô tả quy trình nghiệp cụ quản lý Phòng Khoa học Công Nghệ	11
2.6.1 Quy trình đăng ký, xét duyệt, nghiệm thu, thanh lý đề tài nghiên cứu khoa học sinh viên	11
2.7 Phân tích thiết kế hệ thống	14
2.7.1 Phân tích hiện trạng	14
2.7.2 Xác định yêu cầu	14
2.1 Yêu cầu chức năng	14
2.2 Yêu cầu phi chức năng	14
3.1 Lược đồ các bảng dữ liệu	15
3.2 Danh sách và chức năng các bảng dữ liệu chính	15
Chương 3 Xây dựng và thực nghiệm hệ thống	16
3.1 Các chức năng của hệ thống	16
3.1.1 Đăng nhập	16
3.1.2 Quản lý thời gian chơi của khách	17
3.1.3 Quản lý thức ăn	18
3.1.4 Quản lý doanh thu	19
3.1.5 Thêm xóa sửa thông tin tài khoản	20
3.1.6 Thanh toán	21
3.2 Giao diện chương trình	23
3.2.1 Giao diện đăng nhập	23
3.2.2 Giao diện quản lý thời gian chơi của khách	24
3.2.3 Giao diện quản lý thức ăn	24
3.2.4 Giao diện quản lý doanh thu	24
3.1.5 Giao diện thêm xóa sửa thông tin tài khoản	24
3.1.6 Giao diện thanh toán	26
Chương 4 Kết luận và hướng phát triển	27
4.1 Kết luận	27
4.2 Hướng phát triển	1
Tài liệu tham khảo	1
LIST OF ABBREVIATIONS
ST
Abbreviations
Description



Chương 1 Tổng quan về việc nghiên cứu 
1.1 Lý do chọn đề tài
Bida là một môn thể thao mang hơi hướng của nghệ thuật, được nhiều người yêu thích và chơi trong thời gian rảnh rỗi. Ngày nay, khi mà đời sống con người nâng cao hơn, con người cần nhiều hơn là vật chất và cũng có nhiều người tìm đến bida, như một hình thức giải trí, thư giãn sau những giờ làm việc căng thẳng. Do đó, các quán, câu lạc bộ bida ngày càng phát triển và thu hút nhiều khách hàng.
Tuy nhiên, việc quản lý quán bida không phải là đơn giản, bởi nó liên quan đến nhiều hoạt động như tính tiền, bảo trì, thống kê, tìm kiếm, in hóa đơn, v.v. Nếu chỉ sử dụng các phương pháp truyền thống như sổ sách, bảng biểu, máy tính, v.v. thì sẽ gặp nhiều khó khăn và bất tiện, như mất thời gian, sai sót, khó kiểm soát, khó cập nhật, v.v.
Để giải quyết những khó khăn trên, chúng tôi đã chọn đề tài đồ án quản lý quán bida để áp dụng các kiến thức về công nghệ thông tin vào giải quyết các vấn đề thực tế của các quán, câu lạc bộ bida. Đồ án này có tính thực tiễn cao, sáng tạo, hấp dẫn và thách thức.
1.2 Giới thiệu bài toán và một số nghiên cứu liên quan
1.2.1 Giới thiệu bài toán
Bài toán quản lý quán bida là bài toán áp dụng công nghệ thông tin vào việc giải quyết các vấn đề thực tế của các quán, câu lạc bộ bida, như tính tiền, bảo trì, thống kê, tìm kiếm, in hóa đơn, v.v. Bài toán này có thể được định nghĩa như sau:
Đầu vào: là thông tin của các quán bida và khách hàng sử dụng dịch vụ bida, như tên, địa chỉ, số điện thoại, số bàn bida, giá thuê bàn theo giờ, số giờ thuê bàn, số tiền thanh toán, v.v.
Đầu ra: là các chức năng quản lý quán bida trên nền web, như đăng nhập và đăng xuất, quản lý quán bida, quản lý khách hàng, tính tiền, in hóa đơn, thống kê, tìm kiếm, v.v.
Mục đích: là giúp cho người dùng có thể quản lý quán bida một cách hiệu quả và tiện lợi hơn so với các phương pháp truyền thống. Bài toán này có ý nghĩa cho thực tiễn và lý thuyết như sau:
Cho thực tiễn: là giúp cho người dùng tiết kiệm thời gian, công sức và chi phí trong việc quản lý quán bida. Bài toán này cũng góp phần nâng cao chất lượng dịch vụ và sự hài lòng của khách hàng khi sử dụng dịch vụ bida.
Cho lý thuyết: là góp phần phát triển và ứng dụng các kiến thức về công nghệ thông tin vào giải quyết các vấn đề thực tế. Bài toán này cũng mở ra những hướng nghiên cứu mới và thú vị cho các nhà khoa học và sinh viên trong lĩnh vực này.

1.2.2 Các nghiên cứu liên quan
Các nghiên cứu liên quan đến quản lý quán bida là các nghiên cứu về cách mở, vận hành và phát triển các quán, câu lạc bộ bida, cũng như cách ứng dụng công nghệ thông tin vào việc quản lý quán bida. 
1.2.3 Những thách thức trong bài toán
Phát triển AI cờ vua đối diện với nhiều thách thức phức tạp, bao gồm:
1. Khả năng tính toán lớn: Trò chơi cờ vua có mức độ phức tạp cao với số lượng lớn các nước đi có thể, và để đánh bại kỳ thủ hàng đầu, AI cần phải xử lý hàng triệu hoặc thậm chí hàng tỷ nước đi mỗi giây.
2. Học máy và Tự học: AI cờ vua hiệu quả cần có khả năng học máy và tự học. Các chương trình như AlphaZero đã chứng minh rằng tự học thông qua chơi hàng triệu trận cờ vua có thể giúp cải thiện nhiều. Tuy nhiên, việc tự học đôi khi đòi hỏi nhiều tài nguyên tính toán và có thể trở nên không hiệu quả.
3. Trò chơi công bằng và phát hiện gian lận: Trong các cuộc thi và trò chơi cờ vua trực tuyến, đảm bảo trò chơi công bằng và phát hiện gian lận là một thách thức quan trọng. Phát triển các công cụ và thuật toán để kiểm tra trò chơi công bằng và phát hiện sự gian lận đòi hỏi nghiên cứu về an toàn và bảo mật thông tin.
4.Xử lý kiến thức cuối trò chơi: Trong các tình huống cuối trò chơi, như khi chỉ còn vài quân cờ trên bàn, cần có kiến thức cuối trò chơi chính xác để đánh bại đối thủ. Phát triển và sử dụng bảng cuối trò chơi (endgame tablebases) đòi hỏi không gian lưu trữ lớn và kiến thức chi tiết về các tình huống cuối cùng.
5. Học từ lối chơi con người: Một khía cạnh thú vị của AI cờ vua là khả năng học từ lối chơi của con người. Điều này đòi hỏi phát triển các thuật toán học máy có khả năng nắm bắt chiến thuật và chiến thuật cờ vua của con người và sử dụng chúng để cải thiện hiệu suất của AI.
Phát triển AI cờ vua là một thách thức phức tạp, yêu cầu sự kết hợp của tính toán, lý thuyết trò chơi, học máy và nhiều khía cạnh khác của trí tuệ nhân tạo.
1.2.4 Hướng tiếp cận giải quyết bài toán
Có nhiều hướng tiếp cận để giải quyết bài toán cờ vua AI, và các hướng tiếp cận này thường kết hợp để tạo ra các chương trình cờ vua AI mạnh mẽ. Dưới đây là một số hướng tiếp cận quan trọng:
1. Tối ưu hóa thuật toán tìm kiếm: Đây là hướng tiếp cận cơ bản trong phát triển AI cờ vua. Thuật toán tìm kiếm như Minimax và Alpha-Beta Pruning được sử dụng để tìm kiếm các nước đi tốt nhất trong không gian trò chơi. Các kỹ thuật tối ưu hóa như Negamax cải thiện tốc độ tính toán và tạo ra các phiên bản nâng cao như Principal Variation Search (PVS) và MTD(f).
2. Biểu diễn trạng thái cờ và đánh giá: Cách bạn biểu diễn trạng thái cờ trên bàn và cách bạn đánh giá các trạng thái này rất quan trọng. Sử dụng bảng trạng thái, kết hợp với các hệ thống đánh giá thông qua hàm ước tính giá trị, là một phần quan trọng của hướng tiếp cận này. Các công cụ như bitboards cũng được sử dụng để tăng tốc độ tính toán.
3. Học máy và mạng nơ-ron: Sử dụng học máy, đặc biệt là mạng nơ-ron, là một hướng tiếp cận hiện đại. Các mô hình học sâu như CNN (Convolutional Neural Networks) và RNN (Recurrent Neural Networks) được sử dụng để xử lý dữ liệu cờ và dự đoán giá trị tình huống. AlphaZero của DeepMind là một ví dụ tiêu biểu của hướng tiếp cận này.
4. Sử dụng bảng cuối trò chơi (Endgame Tablebases): Bảng cuối trò chơi là một phần quan trọng của AI cờ vua. Chúng lưu trữ thông tin hoàn hảo về cách chơi trong các tình huống cuối cùng của trò chơi. Sử dụng bảng cuối trò chơi có thể giúp AI đánh cờ vua đạt được hiệu suất tối ưu trong những tình huống cuối cùng.

5. Học từ dữ liệu và con người: Cách chơi của con người, đặc biệt là các kỳ thủ hàng đầu, có thể cung cấp kiến thức quý báu cho AI. Thu thập và học từ dữ liệu trận đấu cờ vua của con người có thể cải thiện chiến thuật và chiến thuật của AI.

6. Phát triển chương trình thế mạnh qua việc cải thiện tính chính xác đánh giá: Một phần quan trọng của hướng tiếp cận này là phát triển các hệ thống đánh giá mạnh mẽ và khả năng đánh giá tình huống chính xác. Điều này bao gồm cải thiện hàm ước tính giá trị và cách xử lý các yếu tố phức tạp như trạng thái của bàn cờ và các quân cờ trên bàn.
7. Kiểm tra và phát hiện gian lận: Đảm bảo tính trung thực và công bằng trong trò chơi cờ vua trực tuyến là một phần quan trọng. Phát triển các công cụ và thuật toán để kiểm tra gian lận và đảm bảo rằng trò chơi diễn ra một cách công bằng là quan trọng.

Hướng tiếp cận cụ thể sẽ phụ thuộc vào mục tiêu và ngữ cảnh cụ thể của mỗi dự án AI cờ vua. Thường thì sự kết hợp của nhiều hướng tiếp cận này mới tạo ra các chương trình cờ vua AI mạnh mẽ và cạnh tranh.
1.3 Mục tiêu, đối tượng, phạm vi nghiên cứu
1.3.1 Mục tiêu nghiên cứu
Mục tiêu nghiên cứu của chúng tôi là xây dựng một ứng dụng quản lý quán bida window form c#, có các chức năng cơ bản như đăng nhập và đăng xuất, quản lý quán bida, quản lý khách hàng, tính tiền, in hóa đơn, thống kê, tìm kiếm, v.v. Chúng tôi muốn đạt được những kết quả sau:
Hoàn thành ứng dụng quản lý quán bida theo yêu cầu chức năng và phi chức năng đã phân tích.
Đánh giá hiệu năng và độ chính xác của ứng dụng qua các tiêu chí như thời gian xử lý, dung lượng bộ nhớ, số lượng lỗi, v.v.
So sánh và đánh giá ưu điểm và khác biệt của ứng dụng so với các phần mềm quản lý quán bida khác trên thị trường.
Đề xuất và triển khai ứng dụng cho một số quán bida thực tế để kiểm tra hiệu quả và khả năng ứng dụng của ứng dụng.

1.3.2 Đối tượng nghiên cứu
Đối tượng nghiên cứu của chúng tôi là các quán bida và các khách hàng sử dụng dịch vụ bida. Chúng tôi muốn xây dựng một ứng dụng phù hợp với nhu cầu và thị hiếu của cả hai đối tượng này. Chúng tôi sẽ thu thập thông tin và ý kiến của các quán bida và khách hàng để phân tích yêu cầu và thiết kế ứng dụng. Chúng tôi cũng sẽ tiến hành kiểm tra và đánh giá ứng dụng trên cơ sở phản hồi của các đối tượng này.
1.3.3 Phạm vi nghiên cứu
Phạm vi nghiên cứu của chúng tôi là giới hạn trong một số quán bida trong khu vực Chúng tôi sẽ chọn một số quán bida có đặc điểm đại diện cho các loại quán bida khác nhau, như quy mô, mô hình kinh doanh, đối tượng khách hàng, v.v. Chúng tôi sẽ tiến hành nghiên cứu trên cơ sở thông tin và dữ liệu của các quán bida này. Chúng tôi không áp dụng ứng dụng cho các quán bida
1.4 Nội dung và phương pháp nghiên cứu
1.4.1 Nội dung nghiên cứu
Phân tích yêu cầu: là việc nghiên cứu về bài toán quản lý quán bida, xác định mục tiêu, đối tượng, phạm vi nghiên cứu và các yêu cầu chức năng và phi chức năng của ứng dụng.
Thu thập và xử lý dữ liệu,
Thiết kế và xây dựng ứng dụng,
Kiểm thử và triển khai ứng dụng

1.4.2 Phương pháp nghiên cứu
Phương pháp nghiên cứu của chúng tôi gồm có các phương pháp sau:
Phương pháp nghiên cứu tài liệu
Phương pháp khảo sát
Phương pháp lập trình
Phương pháp kiểm thử
Phương pháp triển khai
1.5 Đóng góp của đề tài 
Đóng góp của đề tài là những lợi ích và khác biệt mà đề tài mang lại cho lĩnh vực công nghệ thông tin và quản lý quán bida. Tôi xin tổng kết lại những đóng góp của đề tài như sau:
Cho lĩnh vực công nghệ thông tin: là góp phần phát triển và ứng dụng các kiến thức và kỹ năng về lập trình window form c#, cơ sở dữ liệu, thiết kế giao diện, kiểm thử ứng dụng, v.v. vào giải quyết các vấn đề thực tế. Đề tài cũng mở ra những hướng nghiên cứu mới và thú vị cho các nhà khoa học và sinh viên trong lĩnh vực này.
Cho lĩnh vực quản lý quán bida: là giúp cho người dùng có thể quản lý quán bida một cách hiệu quả và tiện lợi hơn so với các phương pháp truyền thống. Ứng dụng cũng góp phần nâng cao chất lượng dịch vụ và sự hài lòng của khách hàng khi sử dụng dịch vụ bida.
So với các nghiên cứu liên quan: đề tài có những ưu điểm và khác biệt như sau:
Đề tài có hướng tiếp cận mới là sử dụng công nghệ thông tin để xây dựng một ứng dụng quản lý quán bida trên nền window form c#, trong khi các nghiên cứu liên quan chỉ tập trung vào khía cạnh kinh doanh quán bida.
Đề tài có tính toàn diện và chi tiết hơn, bao gồm các công việc từ phân tích yêu cầu, thu thập và xử lý dữ liệu, thiết kế và xây dựng ứng dụng, kiểm thử và triển khai ứng dụng, trong khi các nghiên cứu liên quan chỉ cung cấp những thông tin cơ bản và hữu ích.
Đề tài có tính khoa học và thực nghiệm cao, sử dụng các phương pháp nghiên cứu tài liệu, khảo sát, lập trình, kiểm thử, triển khai, trong khi các nghiên cứu liên quan chỉ dựa trên kinh nghiệm và quan điểm cá nhân của tác giả.

Chương 2 Phân tích thiết kế hệ thống 
2.1 Phân tích thiết kế hệ thống thông tin
- Các định nghĩa
- Hệ thống là tập hợp các phần tử có quan hệ hữu cơ với nhau, tác động chi phối lẫn nhau theo các quy luật nhất định để trở thành một chỉnh thể. Từ đó xuất hiện thuộc tính mới gọi là tính trồi của hệ thống mà từng phần tử riêng lẻ không có hoặc có không đáng kể. 
- Hệ thống thông tin là một hệ thống bao gồm các yếu tố có quan hệ với nhau cùng làm nhiệm vụ thu thập, xử lý, lưu trữ và phân phối thông tin và dữ liệu và cung cấp một cơ chế phản hồi để đạt được một mục tiêu định trước. Các tổ chức có thể sử dụng các hệ thống thông tin với nhiều mục đích khác nhau.
- Hệ thống thông tin quản lý (Management Information System) là hệ thống cung cấp thông tin cho công tác quản lý của tổ chức. Hệ thống bao gồm con người, thiết bị và quy trình thu thập, phân tích, đánh giá và phân phối những thông tin cần thiết, kịp thời, chính xác cho những người soạn thảo các quyết định trong tổ chức.
2.2 Các cách tiếp cận và phát triển một hệ thống thông tin 
PDA (Process-Driven Approach): Đây là một tiếp cận tập trung vào việc thiết kế và phát triển hệ thống dựa trên quy trình và quy trình kinh doanh của tổ chức. PDA đặt sự tập trung lớn vào việc tối ưu hóa và cải thiện các quy trình kinh doanh trước khi xây dựng hệ thống thông tin. Mục tiêu chính là tạo ra hệ thống để hỗ trợ và tối ưu hóa các hoạt động kinh doanh.
DDA (Data-Driven Approach): Trong tiếp cận này, tập trung vào quản lý và sử dụng dữ liệu một cách hiệu quả. Dữ liệu được coi là trái tim của hệ thống thông tin. DDA đặt sự tập trung vào việc xây dựng cơ sở dữ liệu mạnh mẽ và quản lý dữ liệu một cách cẩn thận để đảm bảo tính chính xác và sẵn sàng cho các quyết định kinh doanh.

SDA (Service-Driven Approach): Tiếp cận này tập trung vào việc xây dựng hệ thống thông tin bằng cách sử dụng các dịch vụ (services) độc lập. Mỗi dịch vụ có thể thực hiện một nhiệm vụ cụ thể và có khả năng tái sử dụng. SDA thúc đẩy tích hợp và mở rộng dễ dàng bằng cách sử dụng dịch vụ đã có sẵn.
OOA (Object-Oriented Approach): Đây là tiếp cận dựa trên hướng đối tượng, trong đó hệ thống thông tin được xây dựng bằng cách sử dụng các đối tượng và lớp đối tượng để biểu diễn các khái niệm và chức năng. OOA giúp tạo ra mối quan hệ logic giữa các đối tượng và dễ dàng quản lý mã nguồn.

2.3 Các bước phát triển của một hệ thống thông tin
Khảo sát: Thu thập thông tin về nhu cầu và yêu cầu của dự án. Cần hiểu rõ mục tiêu của hệ thống và thu thập thông tin từ người dùng cuối, quản lý, và các bên liên quan để xác định rõ những gì hệ thống cần thực hiện.
Phân tích hệ thống: Phân tích chi tiết yêu cầu của hệ thống. Điều này bao gồm việc xác định các chức năng và quy trình cần thiết, đánh giá kiến trúc tổng thể của hệ thống, và xác định các luồng dữ liệu cũng như quan hệ giữa các thành phần.
Thiết kế hệ thống: Xây dựng kiến trúc chi tiết của hệ thống. Thiết kế cơ sở dữ liệu, lược đồ dữ liệu, giao diện người dùng, và xác định các tiêu chuẩn và quy tắc phát triển giúp tạo ra một bản thiết kế chi tiết cho hệ thống.
Xây dựng hệ thống thông tin: Lập trình ứng dụng và các thành phần hệ thống dựa trên bản thiết kế đã tạo. Xây dựng cơ sở dữ liệu và triển khai quy trình xử lý dữ liệu, sau đó tích hợp các thành phần lại với nhau.
Cài đặt và bảo trì: Triển khai hệ thống vào môi trường sản xuất, đào tạo người dùng cuối về cách sử dụng hệ thống, và tiến hành bảo trì và quản lý hệ thống trong suốt vòng đời của nó. Bảo trì đảm bảo tính bảo mật và tuân thủ quy tắc và quy định.

2.4 Một số mô hình phát triển của một hệ thống thông tin
Mô hình Waterfall (Chảy xuôi)
Mô hình Agile
Mô hình Spiral (Mô hình xoắn ốc)
Mô hình V-Model (Mô hình hình chữ V)
Mô hình Incremental (Tích hợp từng phần)
Mô hình RAD (Rapid Application Development - Phát triển ứng dụng nhanh)
2.5 Các phương pháp phân tích thiết kế hướng cấu trúc
Cơ sở dữ liệu
Dữ liệu: Bao gồm những mệnh đề phản ánh thực tại. Một phân loại lớn của các mệnh đề quan trọng trong thực tiễn là các đo đạc hay quan sát về một đại lượng biến đổi
Cơ sở dữ liệu: Cơ sở dữ liệu là một tập hợp các dữ liệu có tổ chức liên quan đến nhau, thường được lưu trữ và truy cập điện tử từ hệ thống máy tính.
Cơ sở dữ liệu quan hệ: Cơ sở dữ liệu quan hệ là một loại cơ sở dữ liệu lưu trữ và cung cấp quyền truy cập vào các điểm dữ liệu có liên quan đến nhau.
Cách tạo lập quan hệ:
Ràng buộc dữ liệu: Nhằm đảm bảo lưu trữ dữ liệu phù hợp với đối tượng trong thực tế thì có thể nói đến ba loại ràng buộc cơ bản nhất
Ràng buộc về kiểu
Ràng buộc về giải tích 
Ràng buộc về logic 
Các phép toán trên cơ sở dữ liệu quan hệ: Cơ sở dữ liệu thường xuyên thay đổi nhờ các phép toán.
Phép chèn - Insert: Là phép thêm một bộ mới vào một quan hệ nhất định.
Phép loại bỏ - Delete: Là phép xóa khỏi quan hệ một bộ bất kỳ.
Phép thay đổi - Change: Sửa đổi nội dung của một bộ bất kì.
2.6 Mô tả quy trình nghiệp cụ quản lý Phòng Khoa học Công Nghệ
2.6.1 Quy trình đăng ký, xét duyệt, nghiệm thu, thanh lý đề tài nghiên cứu khoa học sinh viên
	Quy trình đăng ký và xét duyệt đề tài nghiên cứu khoa học sinh viên được Phòng khoa học công nghệ xây dựng rõ ràng và chi tiết. Tư những thông tin đó, nhóm đã mô hình hóa quy trình như sau:
	Quy trình đăng ký, xét duyệt, nghiệm thu và thanh lý đề tài nghiên cứu khoa học sinh viên: Giảng viên hoặc sinh viên hoặc thư ký khoa sẽ đại diện nhập thông tin đề tài và tiến hành nộp đề tài để xét duyệt. Sau khi nộp đề tài danh sách các đề tài sẽ chuyển qua cấp khoa xét duyệt. Nếu đề tài được xét duyệt sẽ được chuyển lên P.KHCN xét duyệt. Nếu đề tài được xét duyệt thì nhóm nghiên cứu sẽ tiến hành thực hiện đề tài. Ngược lại đề tài không xét duyệt ở cấp khoa hoặc P.KHCN thì sẽ được thông báo chỉnh sửa tương ứng.



2.7 Phân tích thiết kế hệ thống
2.7.1 Phân tích hiện trạng
Hiện tại nhu cầu chơi bida đang ngày càng tăng cao, các quán bida liên tục được mở ra nhờ đó mà nhu cầu quản lý quán một cách hiệu quả cũng ngày một tăng cao vì vậy chúng em đã viết ra chương trình quản lý quán bi da nhằm mục đích phục vụ cũng như quản lý quán bida một cách hiệu quả.
2.7.2 Xác định yêu cầu
2.1 Yêu cầu chức năng
Hệ thống được xây dựng cho các nhóm người sử dụng sau:
Người quản lý:
Xem doanh thu 
 Thêm xóa sửa thông tin thức ăn 
Thêm xóa sửa thông tin thông tin tài khoản
Tính thời gian chơi 
 Order món ăn 
 Thanh toán bill
Nhân viên:
Tính thời gian chơi 
 Order món ăn 
Thanh toán bill
2.2 Yêu cầu phi chức năng 
Yêu cầu hệ thống
Phân Quyền 
Hệ thống được phần quyền theo nhóm người dùng. Với người quản lý có quyền cao nhất, có quyền cập nhật chỉnh sửa thông tin giá cả,  xem doanh thu, order thức ăn và thanh toán hóa đơn cho khách. Nhân viên có quyền thêm order và thanh toán hóa đơn cho khách.
Cấu hình thực nghiệm
Nhóm đưa ra cấu hình máy tính có cấu hình tối thiểu như sau:
 Laptop có cấu hình tối thiểu Core i3
 RAM 4GB
 Kết nối Internet ổn định.
Cài được phần mềm Microsoft Visual Studio từ phiên bản 2010 trở lên.
Công cụ thực hiện phần mềm:
Dùng ngôn ngữ C#
Công cụ lập trình: Visual Studio 2017
Hệ quản trị cơ sở dữ liệu Microsoft SQL Server 2016
3.1 Lược đồ các bảng dữ liệu 


3.2 Danh sách và chức năng các bảng dữ liệu chính
Bảng 1: Danh sách và chức năng các bảng đã hiệu chỉnh
STT
TÊN BẢNG 
MÔ TẢ
1
Account
Lưu trữ thông tin tài khoản đăng nhập
2
TableFood
Lưu trữ thông tin của bàn hiện tại
3
FoodCategory
Lưu trữ thông tin các loại thức ăn 
4
Food
Lưu trữ thông tin các món ăn và giá
5
Bill
Lưu trữ thông tin hóa đơn
6
BillInfo
Lưu trữ thông tin hóa đơn từng bàn



Chương 3 Xây dựng và thực nghiệm hệ thống 
3.1 Các chức năng của hệ thống
3.1.1 Đăng nhập
	Chức năng đăng nhập là quá trình người dùng xác thực danh tính của họ bằng cách cung cấp thông tin xác thực như tên đăng nhập và mật khẩu để truy cập vào một hệ thống hoặc ứng dụng.
3.1.2 Quản lý thời gian chơi của khách 
	Tính năng quản lý thời gian chơi của khách trong phần mềm quản lý bida cho phép ghi nhận thời gian mỗi khách hàng sử dụng sân bida. Điều này giúp tính toán chi phí và đảm bảo rằng mọi người trả tiền dựa trên thời gian chơi thực tế, đồng thời giúp quản lý quán bida hiệu quả theo dõi sử dụng sân.
3.1.3 Quản lý thức ăn 
	Chức năng quản lý thức ăn trong phần mềm quản lý bida không phải là để ghi nhận và tính thời gian chơi bida, mà là để quản lý và theo dõi các đơn hàng thức ăn mà khách hàng đặt trong quán bida. Chức năng này giúp ghi nhận danh sách thực đơn, cập nhật, thêm, xóa sửa danh sách món ăn, tính toán tổng tiền, và đảm bảo rằng khách hàng được phục vụ thức ăn một cách hiệu quả và chính xác.
3.1.4 Quản lý doanh thu 
	Chức năng quản lý doanh thu trong phần mềm quản lý quán bida nhằm ghi nhận, tính toán và theo dõi tất cả thu nhập từ các giao dịch, bao gồm tiền thu từ việc chơi bida, đặt thức ăn, đồ uống và các dịch vụ khác, nhằm đảm bảo việc theo dõi và quản lý doanh thu một cách hiệu quả.
3.1.5 Thêm xóa sửa thông tin tài khoản	
 	Chức năng quản lý tài khoản trong một phần mềm quản lý quán bida bao gồm thêm (đăng ký) tài khoản mới, xóa tài khoản không cần thiết, và sửa thông tin cá nhân của người dùng.

3.1.6 Thanh toán
 	Chức năng thanh toán trong phần mềm quản lý quán bida cho phép khách hàng thanh toán các dịch vụ và sản phẩm mà họ đã sử dụng hoặc mua trong quán bida. 
3.2 Giao diện chương trình 
3.2.1 Giao diện đăng nhập

Đăng nhập: khi khởi chạy ứng dụng, form đăng nhập hiện ra, nhập tên đăng nhập và mật khẩu. có 2 loại tài khoản là admin và staff. Bấm nút đăng nhập sẽ đăng nhập vào form, nút thoát để thoát chương trình, nút hình con mắt là để xem nhập mật khẩu đúng chưa


3.2.2 Giao diện quản lý thời gian chơi của khách

 	Khi đăng nhập thành công sẽ hiện form. Chọn bàn sau đó chọn thức ăn và đồ uống sau đó bấm bắt đầu tính giờ thì thời gian sẽ được hiển thị ở ô txb thời gian bắt đầu và bắt đầu tính giờ chơi. Khi kết thúc bấm nút thanh toán thì ô txb thời gian kết thúc sẽ hiển thị thời gian nghỉ chơi đồng thời hiện ô thanh toán

3.2.3 Giao diện quản lý thức ăn
 	Sau khi bấm chọn bàn thì có thể lựa chọn loại thức ăn đồ uống cũng như tên món ở 2 ô bên dưới, ô số bên cạnh là số lượng, sau khi lựa món thì bấm thêm món. Nếu khách kh gọi món thì lúc tính chỉ cần bấm thêm giá trị mặc định none
Bảng dưới là bảng danh sách các món có sẵn. khi đăng nhập bằng tài khoản admin thì ta có thể theo dõi danh sách cũng như thực hiện các thao tác thêm, xóa, sửa món và tìm kiếm thức ăn

3.2.4 Giao diện quản lý doanh thu
 	Khi đăng nhập bằng tk admin thì ta có thể theo dõi doanh thu của theo ngày hoặc theo tháng khi nhấn vào ô ngày bắt đầu và ngày kết thúc, giá trị mặc định sẽ là ngày đầu tháng và ngày cuối tháng. Sau đó bấm thống kê thì thông tin bill trong tháng sẽ hiện ra




3.1.5 Giao diện thêm xóa sửa thông tin tài khoản
 	Khi đăng nhập bằng tk admin thì ta có thể vào phần tk để theo dõi tên hiển thị và tên đăng nhập của tk cũng như có thể thêm, xóa sửa tk đó nhưng không thể đổi mk


còn ở ngoài giao diện chính sẽ có mục thông tin cá nhân. ở mục này ta có thể theo dõi các thông tin dưới của tk ta đăng nhập và có thể sử được mk mong muốn.














	
3.1.6 Giao diện thanh toán
 	Sau khi lựa chọn bàn món ăn và giảm giá (nếu có) thì ta bấm nút thanh toán, nó sẽ hiện ra một ô thông báo số tiền và lưu tất cả dữ liệu vào database


Sau khi chọn bàn và bấm nút thanh toán




Chương 4 Kết luận và hướng phát triển
4.1 Kết luận 
	Đề tài đã nghiên cứu và xây dựng được hệ thống quản lý quán bida. Hệ thống đã hoàn thiện và đang chờ được xét duyệt. Hệ thống giúp nhân viên cũng như người quản lý thuận tiện trong việc quản lý, theo dõi hoạt động của quán. Ngoài ra chương trình còn có thể giúp nhân viên nhanh chóng hơn trong việc kiểm tra thanh toán và giúp đỡ khách hàng thuận tiện hơn cho việc phục vụ khách.
	Ngoài việc hỗ trợ quản lý, theo dõi bàn quản lý doanh thu chương trình còn có thể mở rộng thêm chức năng lưu trữ, thống kê, in xuất hóa đơn, quản lý tần suất khách hàng đến thăm, kiểm tra khách vip, tạo hội viên khách hàng, v.v	
4.2 Hướng phát triển 
	Bên cạnh những kết quả đạt được, đề tài còn tồn đọng một số vấn đề chưa giải quyết được 
Tối ưu hóa lịch đặt bàn: làm thế nào để tối ưu hóa quá trình đặt bàn và sắp xếp lịch chơi bida sao cho tận dụng tối đa sân bida mà không gây xung đột về thời gian.
Quản lý nguồn nhân lực: Quản lý nhân viên và ca làm việc, cũng như tích hợp lịch làm việc của nhân viên vào hệ thống để đảm bảo đủ số lượng nhân viên vào mỗi ca làm việc.


Phân tích dữ liệu và đánh giá hiệu suất: Làm thế nào để thu thập và phân tích dữ liệu từ hoạt động kinh doanh và sử dụng chúng để đánh giá hiệu suất, dự đoán nhu cầu của khách hàng, và cải thiện quản lý.
Tương tác với khách hàng: Tương tác với khách hàng thông qua ứng dụng di động, thông báo thời gian sẵn sàng chơi, đặt bàn từ xa và khả năng đánh giá dịch vụ.
Trong thời gian tới, nhóm sẽ tiếp tục nghiên cứu khắc phục, hạn chế và mở rộng thêm các chức năng mới.












Tài liệu tham khảo 

[1]  Lập trình phần mềm Quản lý quán cafe C# Winform
https://www.youtube.com/watch?v=tu2k9ZrDlWA&list=PL33lvabfss1xnPhBJHjM0A8TEBBcGCTsf















Giới thiệu chi tiết đề tài
Input-Method-Output
Mô tả chi tiết
Các chức năng ứng dụng
Demo ứng dụng

