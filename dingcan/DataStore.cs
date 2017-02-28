using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
namespace dingcan
{
    static class DataStore
    {
        public class Table
        {
            //订单
            public int OriCount=0; //奶油甜甜圈
            public int SpeedCount = 0;//特殊甜甜圈
            //饮料
            public int Roast = 0;//0 1 2  None Dark Medium
            public int Sweetener = 0;//0 1 None Sugar
            public int Cream = 0;//0 1 2 Node   2% milk   Whole Milk
        }
        static public Table NowTable;//当前订单
        static async public void ShowMsgbox(string title,string cont)
        {
            var msgbox = new MessageDialog(cont, title);
            msgbox.Commands.Add(new UICommand("确定"));
            await msgbox.ShowAsync();
        }
    }
}
