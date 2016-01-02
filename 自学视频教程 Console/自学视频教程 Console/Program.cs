using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 自学视频教程_Console
{
    class Program
    {
        enum MyColor {赤,橙,黄};
        enum People {小明=22,小张=21};
        static void Main(string[] args)
        {
            //第五章 数组和集合
            //填充字符串
            //string str = "_";
            //char[] ch = { '$','=','?'};
            //string[] express = new string[3];
            //for (int i = 0; i < ch.Length ; i++)
            //{
            //    string str1 = str.PadLeft(2,ch[i]);
            //    express[i] = str1.PadRight(3,ch[i]);
            //    Console.WriteLine("表情{0}的含义为：好多钱啊！",express[i]);
            //}
            //Console.ReadKey();

            //删除字符串
            //string str = "河畔的风放肆拼命地吹";
            //Console.WriteLine(str.TrimStart('的'));

            //string s = " from dual union all ";
            //s = s.Trim().TrimEnd("a".ToCharArray());
            //Console.WriteLine(s);

            //数组的遍历
            //string[] color = Enum.GetNames(typeof(MyColor));
            //Console.WriteLine("七色光：");
            //foreach (var c in color)
            //{
            //    Console.Write("{0}",c);
            //}
            ////声明一个枚举类型的数组
            //Console.WriteLine("\n个人信息：");
            //People[] people = { People.小明,People.小张};
            //foreach (People p in people)
            //{
            //    Console.WriteLine("{0} 年龄：{1}",p,p.GetHashCode());
            //}

            //ArrayList
            //ArrayList list = new ArrayList();
            //list.Add("1");
            //list.Add("1");
            //foreach (var a in list)
            //{
            //    Console.WriteLine(a);
            //}

            //int[] arr = new int[] {1,2,3,4,5,6};
            //ArrayList list = new ArrayList(arr);
            //string str = null;
            //list.Add(str);
            //foreach (var c in list)
            //{
            //    Console.WriteLine(c);
            //}
            ////Console.WriteLine();
            //Console.WriteLine(list.Capacity);
            //ArrayList移除元素
            int[] arr ={1,2,3};
            ArrayList list = new ArrayList(arr);
            Console.ReadKey();
        }
    }
}
