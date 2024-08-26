using AdminSystem.Classes;
using AdminSystem.DataAccess;
using AdminSystem.Forms;
using AdminSystem.Query;

namespace AdminSystem.Classes
{
    public static class StaticClass
    {
        public static EmployeeBase employeeBase = EmployeeBase.Instance;
        public static Data data = new Data();
        public static DBconnect sql = new DBconnect();
        public static EmpQuery empQuery = new EmpQuery();
    }
}
