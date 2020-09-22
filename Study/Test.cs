using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Study
{
    class Test
    {
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        /// <summary>
        /// 构造函数，跟类名相同
        /// </summary>
        public Person() : this("张三", 20, "男")
        {
            //this 调用别的构造函数，用于生成默认值，简化实例化的代码
        }
        /// <summary>
        /// 不同的构造函数
        /// </summary>
        /// <param name="strName"></param>
        /// <param name="age"></param>
        /// <param name="strSex"></param>
        public Person(string strName, int age, string strSex)
        {
            this.Name = strName;
            this.Age = age;
            this.Sex = strSex;
        }
        public virtual string Say()
        {
            return "说话";
        }
        public string Eat()
        {
            return "吃东西";
        }
    }
    /// <summary>
    /// Student 类继承Person，会继承Person的属性、变量以及方法
    /// </summary>
    class Student : Person
    {
        //添加新的属性,直接写
        public string School { get; set; }
        public Student()
        {
            School = "育才";
        }
        public Student(string strSchool) : base("学生", 10, "男")
        {
            School = strSchool;
        }
    }
    class Teacher : Person
    {
        public override string Say()
        {
            return "老师在说话";  //父类中virtual的方法在子类中隐藏是OVERRIDE
        }
        new public string Eat()
        {
            return "老师在吃东西";//父类中没有virtual的方法在子类中隐藏是new
        }
    }
}
