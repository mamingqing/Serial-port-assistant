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
            #region  ȫ�����ںͿ��ô����л�
                switch (button1.Text)
                {
                    case "���ô���":
                        try
                        {
                            button1.Text = "ȫ������";
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
                            MessageBox.Show("û�п��ö˿�", "��ʾ");
                        }
                        break;
                    case "ȫ������":
                        button1.Text = "���ô���";
                        cb_port.Items.Clear();
                        for (int i = 1; i <= 16; i++)
                        {
                            cb_port.Items.Add("COM" + i);
                        }
                        cb_port.SelectedIndex = 0;
                        break;
                    default:
                        MessageBox.Show("��ѡ����ô���");
                        break;
                }
            #endregion
        }
    }
}