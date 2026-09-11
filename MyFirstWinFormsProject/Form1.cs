using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormsProject
{
    public partial class Form1 : Form
    {
        bool isChangingName = false;      
        bool isChangingLabel1 = false;
        bool isDarkMode = false;

        public Form1()
        {
            InitializeComponent();
        }

        // زر: "Copy On Mouse Click" (button1)
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                Clipboard.SetText(textBox1.Text); // النسخ للحافظة = Ctrl + C
            }
        }
       
        // زر: "Copy On Mouse Enter" (button2)
        private void Mouse_Enter(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                Clipboard.SetText(textBox1.Text); // النسخ للحافظة = Ctrl + C
            }
        }

        // زر: "Delete Text" (button3)
        private void button3_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();

            textBox1.Focus();// ينقل المؤشر إلى textBox1 ليبدأ المستخدم الكتابة مباشرة

        }

        // حدث: تغيير النص (TextChanged) الخاص بـ textBox1
        // الوظيفة: ينسخ النص لـ textBox2 فوراً أثناء الكتابة، ويحدّث العنوان أو الـ Label1 في نفس اللحظة إذا تم تفعيل وضع التعديل الخاص بأي منهما
        private void textBox1_TextChanged(object sender, EventArgs e)//ده المكان ال بكتب فيه النص 
        {
            textBox2.Text = textBox1.Text;
            label4.Text = $"Characters : {textBox1.Text.Length}";

            if (isChangingName)
            {
                this.Text = textBox1.Text;
            }
            if (isChangingLabel1)
            {
                label1.Text = textBox1.Text;
            }
        }

        // زر: "Disable Text 1" (button4)
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        // زر: "Enable Text 1" (button5)
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }

        // زر: "Hidee Text 1" (button6)
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;

        }

        // زر: "Show Text 1" (button7)
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
        }

        // زر: "Text 1 To Red" (button8)
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Red;

        }

        // زر: "Text 1 To White" (button9)
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        // زر: "Rename The Title Main Page" (button10)
        private void button10_Click(object sender, EventArgs e)
        {
            isChangingName = true; 
            textBox1.Clear();      
            textBox1.Focus();     
        }

        // حدث: الضغط على أزرار لوحة المفاتيح (KeyDown) الخاص بـ textBox1
        // الوظيفة: عند الضغط على Enter، يقوم بحفظ الاسم الجديد (للعنوان أو للـ Label1) وإغلاق وضع التعديل ومنع صوت التنبيه
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { 
                // مفيش داعي نكرر this.Text = textBox1.Text; هنا
                // لأن TextChanged أصلاً حدثها أول بأول
                isChangingName = false;
                isChangingLabel1 = false;
            }
            //{ 
            //    // مفيش داعي نكرر this.Text = textBox1.Text; هنا
            //  // لأن TextChanged أصلاً حدثها أول بأول
            //    if (isChangingName)
            //    {
            //        this.Text = textBox1.Text;
            //        isChangingName = false;
            //    }
            //    else if (isChangingLabel1)
            //    {
            //        label1.Text = textBox1.Text;
            //        isChangingLabel1 = false;
            //    }
           // }
        }

        // زر: "Change The Main Title" (button11)
        // الوظيفة: يفعل وضع تعديل النص الترحيبي label1، ويمسح النص القديم ويركز المؤشر في textBox1
        private void button11_Click(object sender, EventArgs e)
        {
            isChangingLabel1 = true;
            isChangingName = false; // إيقاف تغيير عنوان النافذة لتفادي التداخل
            textBox1.Clear();
            textBox1.Focus();
        }

        

        private void button13_Click(object sender, EventArgs e)//ToLower
        {
            textBox1.Text = textBox1.Text.ToLower();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToUpper();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            // 1. تحويل النص لمصفوفة حروف
            char[] charArray = textBox1.Text.ToCharArray();

            // 2. عكس المصفوفة
            Array.Reverse(charArray);

            // 3. تحويل المصفوفة المعكوسة لنص جديد ووضعه في الـ TextBox
            textBox1.Text = new string(charArray);
        }

        private void picDarkMode_Click(object sender, EventArgs e)
        {
            if (isDarkMode == false)
            {
                // 1. تغيير خلفية النافذة للون الرمادي الداكن
                this.BackColor = Color.FromArgb(30, 30, 30);

                // 2. جعل القمر "يضيء" بخلفية صفراء ذهبية
                picDarkMode.BackColor = Color.FromArgb(255, 230, 150);

                // 3. تغيير ألوان النصوص للون الأبيض
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;

                // 4. تحويل العلم للوضع الداكن
                isDarkMode = true;
            }
            else
            {
                // 1. إرجاع لون الخلفية للون الفاتح الافتراضي للويندوز
                this.BackColor = SystemColors.Control;

                // 2. إطفاء القمر بجعل خلفيته شفافة تماماً مجدداً
                picDarkMode.BackColor = Color.Transparent;

                // 3. إرجاع ألوان النصوص للون الأسود
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;

                // 4. تحويل العلم للوضع الفاتح
                isDarkMode = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); ;



        }

        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show(chkReceveeMAIL.Checked.ToString());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           button15.Enabled = chkReceveeMAIL.Checked;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Small.Checked.ToString());

        }

        
    }
}
