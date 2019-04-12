using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //订单表
    public class Orders
    {
        public int Order_Id { get; set; }
        public DateTime Order_Time { get; set; }//下单时间
        public int User_Id { get; set; }//用户编号
        public decimal Money_Received { get; set; }//实收金额
        public decimal Money_Favorable { get; set; }//优惠金额
        public decimal Money_Should { get; set; }//应付金额
        public string Type_Of_Payment { get; set; }//支付类型
        public DateTime CheckIn_Time { get; set; }//入住时间
        public DateTime Leave_Time { get; set; }//退房时间
        public int Room_State { get; set; }//房间编号

    }
}
