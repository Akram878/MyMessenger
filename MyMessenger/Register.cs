using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMessenger
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();

            this.FormClosed += AnyForm_FormClosed;


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.log.Show();
            this.Hide();
        }

        private void AnyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // يغلق البرنامج بالكامل عند غلق هذا الفورم
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // قراءة البيانات من الفورم
            string username = Username.Text.Trim();
            string password = Password.Text.Trim();
            int number;

            // التحقق من صحة الرقم
            if (!int.TryParse(Number.Text.Trim(), out number))
            {
                MessageBox.Show(" pleas enter a number only!");
                return;
            }

            // التحقق من أن الرقم غير مستخدم مسبقًا
            if (Program.users.Any(u => u.Number == number))
            {
                MessageBox.Show("this number already registered!");
                return;
            }

            // إنشاء مستخدم جديد باستخدام كلاس User
            User newUser = new User(username, number, password);

            // إضافة المستخدم إلى قاعدة البيانات
            Program.users.Add(newUser);

            MessageBox.Show("Account created sucssfully!");

            // إعادة عرض LoginForm بعد التسجيل
            Program.log.Show();
            this.Hide();
            
        }
    }
}
