using ASM0.Models;

namespace ASM0.DAO
{
    public class DepartmentsDAO
    {
        public DepartmentsDAO() { }
        public List<DepartmentsModel> GetDepartments()
        {
            List<DepartmentsModel> list= new List<DepartmentsModel>();
            list.Add(new DepartmentsModel("hi", "he", 20));
            list.Add(new DepartmentsModel("he", "hee", 10));
            list.Add(new DepartmentsModel("ha", "heee", 15));
            list.Add(new DepartmentsModel("hu", "heeee", 25));
            return list; 
        }
    }
}
