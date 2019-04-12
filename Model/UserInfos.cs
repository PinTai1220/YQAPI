using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 用户表
    /// </summary>
    public class UserInfos
    {
        public int UserInfo_Id { get; set; }
        public string UserInfo_Name { get; set; }//姓名
        public int UserInfo_Sex { get; set; }//性别
        public string ID_Num { get; set; }//身份证号
        public string Phone_Num { get; set; }//手机号
        public string Address { get; set; }//当前位置
        public string HeadImg { get; set; }//用户头像

    }
}
