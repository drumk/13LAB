using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace _13LAB
{
    public partial class Form1 : Form
    {
        int n;
        string[] a = new string[100];
        string[] b = new string[100];
        string[] c = new string[100];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i;
            for (i = 1; i <= 9; i++)
            {//������� ������� ComboBoxl
                comboBox1.Items.Add(Convert.ToString(i + 1));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            n = Convert.ToInt32(comboBox1.Text);//���� ����� ������ �������
            listBox1.Text = ""; //������� ������
            for (i = 1; i <= n; i++)
            {
                a[i] = Microsoft.VisualBasic.Interaction.InputBox("������� �������� ������", "��������: ", "������");
                listBox1.Items.Add(a[i]); //���������� � listbox1
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            for (int i = 1; i <= n; i++)
            {
                if (a[i].EndsWith("�"))
                {
                    x = i;
                    break;
                }
            }
            for (int i = 1; i < n; i++)
            {
                if (a[i + 1].EndsWith("�"))
                {
                    y = i + 1;
                    break;
                }
            }
            string temp = a[x];
            a[x] = a[y];
            a[y] = temp;
            string message = string.Join("\n", a, 1, n);
            MessageBox.Show(message, "���������:", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
        }
    }
}