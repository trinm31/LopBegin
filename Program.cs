﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ConsoleAppBeginner
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Buoi 1 - bien if else
            // 1. Bien(variable)
            // int a = 1; // số nguyên - integer
            // double b = 1.23; // số thực
            // string c = "Hello world"; // chuỗi 
            // bool d = true; // false - biến logic boolean

            //char e = 'S'; // kí tự - character

            // <kiểu dữ liệu> <tên biến> = gán dữ liệu cho biến ;
            // int f;
            // f = 1;
            // f = 2;
            
            // hằng số (constant)
            //const string Mon = "Thứ hai";
            // in ra màn hình
            //Console.WriteLine("Hello lop begin");
            // hàm đọc dữ liệu
            // bool userLogin;
            // Console.WriteLine("Let's input something");
            //
            // userLogin = Convert.ToBoolean(Console.ReadLine());// "1,25" --> 1.25
            
            // bool - convert.toBoolean
            // double - convert.toDouble
            // int - convert.toInt32
            
            //Console.WriteLine("User Input " + userLogin);
            
            // thuộc tính để gán màu chữ xuất ra
            // Console.ForegroundColor = ConsoleColor.Cyan; // đặt màu chữ
            // Console.WriteLine("Chào mọi người"); 
            // Console.ResetColor();
            // Console.WriteLine("after reset");

            // var bien1 = 3.14; // biến 1 sẽ là kiểu dữ liệu double
            // var bien2 = "Hello world"; // biến 2 sẽ là kiểu dữ liệu string
            // var bien3 = true; // biến 3 sẽ là kiểu dữ liệu bool
            // var bien4 = 1; // biến 4 sẽ là kiểu dữ liệu int
            // lưu ý: khi dùng biến var các bạn cần gán dữ liệu trực tiếp cho nó;

            // string bien6;
            // bien6 = "fdsafds";
            //
            // 2. Toán tử số học và gán
            // + -> phép cộng
            // - -> phép trừ
            // * -> phép nhân
            // / -> chia (tùy theo kiểu dữ liệu thì nó sẽ hoạt động khác nhau) (int)5/2 = 2(lấy phần nguyên của kết quả) (double)5/2 = 2.5
            // % -> chia lấy phần dư 5%2 = 1 (lấy phần dư)
            
            // Console.WriteLine(5+3*2);
            // Console.WriteLine((5+3)*2);
            // Console.WriteLine((double)6/(2+3)*2);
            // Console.WriteLine(6/(3%2)*2);

            // int x = 1;
            // x = x + 10; // x+=10
            // x = x - 10; // x-=10
            // x = x * 10; // x*=10
            // x = x / 10; // x/=10
            // x = x % 10; // x%=10
            
            // Console.WriteLine(x);
            //
            // x = x + 1; // x+=1 hoặc x++
            // x = x - 1; // x+=1 hoặc x--
            //
            // int g = 10;
            // g++; // 11
            // ++g; // 12
            //
            // int h = 10;
            // --h; // 9
            // h--; // 8


            // int i = 5;
            // int j = 2 * --i; // i = 4; j= 8
            
            // lưu ý dấu ++ đằng trước thì tiến hành tăng lên 1 đơn vị trc gòi thực hiện các phép tính còn lại
            // dấu ++ đằng sau thì tiến hành thực phép tính trc gòi mới tăng lên 1 đơn vị sau
            
            // 3. so sánh
            // < bé hơn
            // <= bé hơn hoặc bằng
            // > lớn hơn
            // >= lớn hơn hoặc bằng
            // == bằng
            // != khác

            // bool k = (5 != 6); // true
            
            // toán rời rạc &&(và and) || (hoặc or) ! (đối)

            // var l = true && true; // true
            
            
            // 4. điều liện logic
            // if(<điều kiện>) {}

            // bool isEnabledToRun = true;
            //
            // while (isEnabledToRun)
            // {
            //     int a;
            //     int b;
            //     Console.WriteLine("Let's input a");
            //     a = Convert.ToInt32(Console.ReadLine());
            //
            //     Console.WriteLine("Let's input b");
            //     b = Convert.ToInt32(Console.ReadLine());
            //
            //     if (a<b)
            //     {
            //         Console.WriteLine("a less than b");
            //     }
            //     else if (a>b)
            //     {
            //         Console.WriteLine("a more than b");
            //     }
            //     else
            //     {
            //         Console.WriteLine("a equal b");
            //     }
            //     
            //     Console.WriteLine("Do u wanna continue? y/n");
            //     var input = Console.ReadLine();
            //     isEnabledToRun = input == "y" || input == "Y";
            // }
            #endregion

            #region Buoi 2 - switch case/ loop
            // 1 switch case
            // var a = 0;
            // switch(a)
            // {
            //     case 1:
            //         Console.WriteLine("a equal 1");
            //         break;
            //     case 2:
            //         Console.WriteLine("a equal 2");
            //         break;
            //     case 3:
            //         Console.WriteLine("a equal 3");
            //         break;
            //     case 4:
            //         Console.WriteLine("a equal 4");
            //         break;
            //     default:
            //         Console.WriteLine("a not in the define list");
            //         break;
            // }
            
            // 2 câu lệnh 3 thanh phần
            // int age;
            // age = Convert.ToInt32(Console.ReadLine());
            // var msg = (age >= 18) ? "Đủ điều kiện" : "Không đủ điều kiện";
            // Console.WriteLine(msg);

            // var a = 2;
            // var b = 3.5;
            // var c = 2;
            //
            // var max = a >= b ? (a >= c ? a : c) : (b >= c ? b : c);
            //
            // Console.WriteLine(max);
            // 
            
            
            // loop
            // 1. nó là gì
            // 2. nó làm gì
            // 3. có bao nhiêu biến thể
            
            // 3. vòng lặp for
            // for(khởi tạo; điều kiện; cập nhật){}
            // khởi tạo - giá trị bắt đầu của vòng lặp
            // điều kiện - điều kiện hợp lệ của vòng lặp
            // cập nhật - sau mỗi lần chạy thì tiến hành cập nhật 1 giá trị gì đó

            // for (int i = 0; i < 2; i++)
            // {
            //     Console.WriteLine(i);
            // }

            
            // vòng lặp vô tận
            // var i = 0;
            // for (;;)
            // {
            //     Console.WriteLine(i);
            //     i++;
            // }

            // char love;
            // Console.WriteLine("Do u love me?");
            // love = Convert.ToChar(Console.ReadLine());
            //
            // for (;;)
            // {
            //     if (love == 'Y' || love == 'y')
            //     {
            //         break;
            //     }
            //     Console.WriteLine("Do u love me?");
            //     love = Convert.ToChar(Console.ReadLine());
            // }
            
            // 4. vòng lặp while
            // while(điều kiên) {}
            // điều kiện - điều kiện hợp lệ của vòng lặp

            // int i = 0;
            // while (i < 10)
            // {
            //     Console.WriteLine(i);
            //     i++;
            // }
            
            // 5. vong lap do while

            // int i = 10;
            // do
            // {
            //     Console.WriteLine(i);
            //     i++;
            // } while (i < 10);
            
            // char love;
            // do
            // {
            //     Console.WriteLine("Do u love me?");
            //     love = Convert.ToChar(Console.ReadLine());
            // } while (love == 'N' || love == 'n');
            
            // 6. break; continue;
            
            // in ra các số chia hết cho 3 
            // for (int i = 10; i <=20; i++)
            // {
            //     if (i % 3 != 0)
            //     {
            //         continue;
            //     }
            //     Console.WriteLine(i);
            // }

            // int i = 0;
            // while (true)
            // {
            //     Console.WriteLine(++i);
            //     if (i == 10)
            //     {
            //         break;
            //     }
            // }
            
            

            #endregion

            #region Buoi 3 - Mảng/list
            
            // 1. mảng là chuỗi các hộp chứa dữ liệu - xác định số lượng phần tử trong mảng;
            // cách 1: để khai báo và gán dữ liệu cho mảng
            string[] LopBegin = new string[4];
            LopBegin[0] = "Son";
            LopBegin[1] = "Phong";
            LopBegin[2] = "Linh";
            LopBegin[3] = "Hieu";
            // cách 2: 
            string[] productNames = new string[5] { "Iphone", "Samsung", "Asus", "Acer", "Dell" };

            // cách để lấy dữ liệu trong mảng
            Console.WriteLine(productNames[2]);
            productNames[2] = "Asus fake";
            Console.WriteLine(productNames[2]);
            
            var productName2 = new string[5] { "Iphone", "Samsung", "Asus", "Acer", "Dell" };
            string[] productName3 = { "Iphone", "Samsung", "Asus", "Acer", "Dell" };
            
            // đếm số lượng phần tử trong mảng
            Console.WriteLine("Number element in array " + productName3.Length);
            
            // min - lấy phần tử nhỏ nhất trong mảng
            int[] number = { 3, 45, 6, 6453, 143, 8, 76452654 };

            Console.WriteLine("Smallest number in array is: " + number.Min());
            // max - lấy phần tử lớn nhất trong mảng
            Console.WriteLine("Smallest number in array is: " + number.Max());
            
            // indexOf - lấy vị trí index của phần tử trong mảng
            Console.WriteLine("Index of 6453 is " + Array.IndexOf(number, 6453));
            
            // dùng for để in ra các phần tử trong mảng
            // for (int i = 0; i < number.Length; i++)
            // {
            //     Console.WriteLine(number[i]);
            // }
            //
            // foreach (var element in number)
            // {
            //     Console.WriteLine(element);
            // }
            
            // sắp xếp các phần tử trong mảng
            Array.Sort(number);
            Array.Reverse(number);
            foreach (var element in number)
            {
                Console.WriteLine(element);
            }
            
            // Mảng 2 chiều

            int[,] mang2chieu = new int[3,4];

            mang2chieu[0, 0] = 1;
            mang2chieu[2, 3] = 5;
            
            // Mảng trong mảng

            int[][] mangtrongmang = new int[4][]
            {
                new []{1,2,3},
                new []{1,2,3},
                new []{1,2,3},
                new []{1,2,3}
            };
            
            // list -
            // nó là mảng những mà kiểu dynamic nên cho
            // phép ko cần khai báo số lượng phần tử khi khởi tạo

            List<string> className = new List<string>();
            className.Add("tri");
            className.Add("tri1");
            className.Add("tri2");
            className.Add("tri3");
            className.Add("tri4");
            
            // đếm số lượng phần tử trong list 
            Console.WriteLine("Number of element in list " + className.Count);
            
            // in ra các phần tử trong list
            foreach (var element in className)
            {
                Console.WriteLine(element);
            }
            #endregion
        }
    }
}