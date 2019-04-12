using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //管理员表
    public class Admin
    {
        public int Admin_Id { get; set; }
        public string Admin_Name { get; set; }//管理员名称
        public string Admin_Pwd { get; set; }//管理员密码
        public int Role_Id { get; set; }//角色编号
    }
}
