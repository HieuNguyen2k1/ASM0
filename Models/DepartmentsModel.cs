namespace ASM0.Models
{
    public class DepartmentsModel
    {
        public String MaPB;
        public String TenPB;
        public int SoLNV;

        public DepartmentsModel (string maPB, string tenPB, int soLNV)
        {
            MaPB = maPB;
            TenPB = tenPB;
            SoLNV = soLNV;
        }
    }
}
