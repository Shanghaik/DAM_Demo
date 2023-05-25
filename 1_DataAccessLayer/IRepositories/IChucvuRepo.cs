using _1_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DataAccessLayer.IRepositories
{
    public interface IChucvuRepo
    {
        public List<ChucVu> GetAll();
        public bool CreateChucVu(ChucVu cv);
        public bool UpdateChucVu(ChucVu cv);
        public bool DeleteChucVu(ChucVu cv);
        /*
         * Interface trong lập trình OOP được định nghĩa là
         * một giao diện chung mà các lớp có thể cùng triển khai
         * Triển khai ở đây mang ý nghĩa là làm rõ các phương thức
         * nằm trong Interface đó. Ví dụ với phương thức 
         * CreateChucVu(ChucVu cv) sẽ không có phần thân và chỉ có mô
         * tả là trả về 1 boolean và truyền vào 1 đối tượng ChucVu
         * chúng ta cần triển khai (làm rõ) xem phương thức này có 
         * phần thân như thế nào? ở các class kế thừa từ nó
         * Interface giải quyết được các vấn đề liên quan tới tính trừu
         * tượng trong lập trình OOP
         * Tính trừu tượng trong OOP được định nghĩa thông qua ví dụ như 
         * sau: Giả sử ta có 1 interface Ca (Cá) chứa các phương thức
         * như Ăn, Bơi, ...thì chúng ta không thể biết được liệu cá Ăn, Bơi
         * như thế nào vì mỗi loài cá sẽ có thể ăn, bơi khác nhau. Khi 
         * triển khai các class thì những hành động trừu tượng như Ăn/Bơi
         * sẽ được làm rõ. VD như trong Class CaMap thì CaMap sẽ ăn thịt,
         * Bơi bằng Vây...
         * Interface con giải quyết được vấn dề liên quan tới Đa kế thừa
         * (Khi 1 class kế thừa nhiều thành phần khác cùng lúc) thì nếu
         * class đó kế thừa nhiều class với các Phương thức giống nhau,
         * cùng có phần thân thì các phương thức đó sẽ không thể xác định 
         * được việc kế thừa phần thân của Class nào. Tuy nhiên với
         * Interface các phương thức không có thân nên đa kế thừa là
         * điều hoàn toàn có thể làm được.
         */
    }
}
