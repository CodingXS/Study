using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Study
{
    public partial class frmTestClass : Form
    {
        public frmTestClass()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            Person p1 = new Person(); //实例化Person,直接调用不带参数的构造方法,会将对象的属性设置成默认值
            foreach (var item in p1.GetType().GetProperties())
            {
                textBox1.Text += item.Name + ":" + item.GetValue(p1, null) + "\r\n";
            }
            Person p2 = new Person("王梅", 30, "女");//实例化Person,调用带参数的构造方法,会根据传入的值进行设定
            foreach (var item in p2.GetType().GetProperties())
            {
                textBox1.Text += item.Name + ":" + item.GetValue(p2, null) + "\r\n";
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            /*
             * 运行结果
             * School:
             * Name:张三
             * Age:20
             * Sex:男
             */
            //子类实例化时，先去实例化父类的部分灾区实例化子类的部分，即先去调用父类中的构造方法（无参的），再去调用子类的构造方法
            Student s1 = new Student();
            foreach (var item in s1.GetType().GetProperties())
            {
                textBox1.Text += item.Name + ":" + item.GetValue(s1, null) + "\r\n";
            }
            //如果想去调用父类中有参数的构造方法，用base
            Student s2=new Student("外国语");
            foreach (var item in s2.GetType().GetProperties())
            {
                textBox1.Text += item.Name + ":" + item.GetValue(s2, null) + "\r\n";
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //被子类隐藏的方法被调用时，只会执行子类中的方法
            //如果没有被隐藏则会执行父类中的方法
            Teacher t1 = new Teacher();
            textBox1.Text=t1.Say()+"\r\n";
            Student s1 = new Student();
            textBox1.Text += s1.Say(); s1.Say();

        }
    }
}
