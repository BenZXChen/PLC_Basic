using System;
using System.Windows.Forms;

namespace PLC_Basic
{
    public partial class fMain : Form
    {
        private AxActUtlTypeLib.AxActUtlType axActUtlType1;
        private int iReturnCode = 0;
        public fMain()
        {
            InitializeComponent();
            Load += new EventHandler(fMain_Load);

        }
        private void fMain_Load(object sender, EventArgs e)
        {
            axActUtlType1 = new AxActUtlTypeLib.AxActUtlType();
            btnConnect.Click += new EventHandler(btnConnect_Click);
            btnRead.Click += new EventHandler(btnRead_Click);
            btnWrite.Click += new EventHandler(btnWrite_Click);
            btnClose.Click += new EventHandler(btnClose_Click);
            txtPLCArea.Text = "D3200";
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //Set the value of 'LogicalStationNumber' to the property.
            //與Communication Setup Utility設定值相同
            axActUtlType1.ActLogicalStationNumber = 1;
            //Set the value of 'Password'.
            //沒有密碼就給它空值
            axActUtlType1.ActPassword = "";
            //The Open method is executed.
            //回傳值0等於成功
            iReturnCode = axActUtlType1.Open();
            labInfo.Text = (iReturnCode == 0) ? "連線PLC成功" : "連線PLC失敗";
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            short[] arrShort = new short[3];
            //位址名稱 , 數量 , 出輸資料啟始位址
            //位址名稱: 例如 D3200
            //數量: 例如要讀取 D3200 D3201 D3202 數量就是3
            //出輸資料啟始位址: 假設有一個陣列 short[] sdata = new short[3];
            //從0開始放就 sdata[0] 從1開始就 sdata[1] ... 
            iReturnCode = axActUtlType1.ReadDeviceBlock2(txtPLCArea.Text, 3, out arrShort[0]);
            labInfo.Text = iReturnCode.ToString();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            short arrDevice = 0;
            iReturnCode = axActUtlType1.WriteDeviceRandom2(txtPLCArea.Text, 3, ref arrDevice);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            axActUtlType1.Close();
        }
    }
}
