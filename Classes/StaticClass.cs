using AdminSystem.Classes;
using AdminSystem.DataAccess;
using AdminSystem.Forms;

namespace AdminSystem.Classes
{
    public static class StaticClass
    {
        public static EmployeeBase employeeBase = EmployeeBase.Instance;
        public static Data data = new Data();
        public static DBconnect sql = new DBconnect();
    }
}
