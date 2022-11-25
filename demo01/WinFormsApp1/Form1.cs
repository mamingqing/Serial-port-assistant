namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region  全部串口和可用串口切换
                switch (button1.Text)
                {
                    case "可用串口":
                        try
                        {
                            button1.Text = "全部串口";
                            cb_port.Items.Clear();
                            string[] str = SerialPort.GetPortNames();
                            for (int i = 0; i < str.Length; i++)
                            {
                                cb_port.Items.Add(str[i]);
                            }
                            cb_port.SelectedIndex = 0;
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("没有可用端口", "提示");
                        }
                        break;
                    case "全部串口":
                        button1.Text = "可用串口";
                        cb_port.Items.Clear();
                        for (int i = 1; i <= 16; i++)
                        {
                            cb_port.Items.Add("COM" + i);
                        }
                        cb_port.SelectedIndex = 0;
                        break;
                    default:
                        MessageBox.Show("请选择可用串口");
                        break;
                }
            #endregion
        }
    }
}