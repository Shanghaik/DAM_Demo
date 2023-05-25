using _1_DataAccessLayer.IRepositories;
using _1_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DataAccessLayer.Repositories
{
    public class ChucvuRepo : IChucvuRepo
    {
        // Để có thể trỏ đến DB thì ta cần thông qua lớp DBContext
        // Sau khi có DbContext thì lại cần trỏ tiếp đến DBSet
        FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context context;
        public ChucvuRepo() {  }

        public ChucvuRepo(FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context context)
        {
            this.context = context;
        }

        public bool CreateChucVu(ChucVu cv)
        {
            try
            {
                context.ChucVus.Add(cv); // Thêm vào DBSet
                context.SaveChanges(); // Lưu thay đổi
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteChucVu(ChucVu cv)
        {
            try
            {
                context.ChucVus.Remove(cv); // Thêm vào DBSet
                context.SaveChanges(); // Lưu thay đổi
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<ChucVu> GetAll()
        {
            return context.ChucVus.ToList();
        }

        public bool UpdateChucVu(ChucVu cv)
        {
            try
            {
                context.ChucVus.Update(cv); // Thêm vào DBSet
                context.SaveChanges(); // Lưu thay đổi
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
