using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Users
    {
        public int UserId { get; set; }
        public string User_Name { get; set; }//用户名
        public string User_PassWord { get; set; }//密码
        public string Name { get; set; }//真实姓名
        public int Sex { get; set; }//性别
        public DateTime Birthday { get; set; }//生日
        public string Email { get; set; }//邮箱
        public string HeadImg { get; set; }//头像
        public string Phone { get; set; }//手机号
        public DateTime Reg_Time { get; set; }//注册时间
    }
}
