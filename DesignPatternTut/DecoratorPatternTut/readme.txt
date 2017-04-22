
Hãy xem xem xét một ví dụ rất phổ biến trong những cuốn sách về GoF, đó là ví dụ về Pizza. 
Tưởng tượng về một kịch bản rằng bạn đang làm việc cho một cửa hàng bánh Pizza, và cửa hàng của bạn vừa làm pizza cà chua và pizza phô mai. 
Sau đó bạn cần đặt thêm một vài nguyên liệu nữa lên phần trên của bánh vì khách hàng có quyền lựa chọn thêm gà hoặc hồ tiêu và chiếc bánh của họ. 
Về cơ bản bạn có một số loại pizza như: pizza gà cà chua, pizza cà chua hạt tiêu, pizza gà phô mai, pizza phô mai hồ tiêu, pizza cà chua gà hồ tiêu và phô mai gà hồ tiêu. 
Trong trường hợp này, nếu chúng ta giải quyết vấn đề này với cách mở rộng tĩnh thì bạn sẽ cần tạo ra một số lượng lớn các lớp như TomatoChickenPizza, 
TomatoPepperPizza … nó có nghĩa đây sẽ là một số lượng lớn của các kết hợp được thêm vào vào để có được cái mà khách hàng mong muốn. Và sẽ có nhiều lớp mà bạn cần phải cài đặt. 
Mặt khác, mấu thiết kế Decorator sẽ giúp bạn giảm đi một lượng lớn các lớp được mở rộng. 
Để rõ hơn về điều này, hãy xem biểu đồ lớp và cách thức hoạt động của mẫu thiết kế Decorator dưới đây: