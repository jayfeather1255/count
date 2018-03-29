using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_03_29
{
    class Program
    {
        static void Main(string[] args)
        {
            // 放入學生姓名、性別、血型資料
            string [] names = { "葉俊廷", "張澤瑜", "王程捷 的咩？", "江儀婷", "張秉華", "陳柏霖", "黃紀瑜", "黃昱維", "蔡逸群", "登琳", "世新魏鈞孝吧", "劉定南", "陳信如", "童信傑", "李岳倫", "鄒和恆", "簡毓玟", "劉子瑄", "蕭紹洋", "李亞宸la", "張以潔", "邱仕紳", "呂家瑩", "世新林鑫佑", "徐均得", "陳佳欣", "張恩瑋", "周詮", "王湘婷", "蕭宇成", "Max Cheung(BANG)", "馬嘉誠Σヽ(ﾟД ﾟ; )ﾉ魔貫光殺砲(ﾟДﾟ)σ━0000", "陳昱嘉", "康珈熏", "盧奕宏", "陳郁佳的大哥黃博涵", "遲正雯", "世新林星彤", "許晏誠ｘ勒是奇多＿８＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝Ｄ　", "許子安", "高子晴", "陳思婷", "矝鵘鮿", "余彥廷", "吳耀輝", "鄭丞智", "林冠廷", "世新何曜宇", "邵喬雨", "張豐愷", "林子晴", "邱雁回", "陳家欣是韓妞", "鄧雅馨", "謝汶珊", "李曼寧", "世新徐偉哲", "张钰慈", "鍾宜珊", "raer_tsai", "世新李姳諼", "鄭曼君", "陳柏霖", "世新許子安", "世新方若帆", "李曼寧", "世新遲正雯", "世新周詮" };
            string [] BG = { "男", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "男", "女", "男", "男", "男", "女", "女", "男", "男", "女", "男", "女", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "女", "男", "男", "女", "女", "男", "男", "女", "女", "男", "男", "男", "男", "男", "男", "女", "男", "女", "女", "女", "女", "女", "女", "男", "女", "女", "女", "女", "女", "男", "男", "女", "女", "女", "男" };
            string [] Blood = { "O", "其他", "O", "O", "A", "O", "A", "A", "O", "O", "A", "O", "A", "B", "O", "O", "A", "其他", "O", "O", "A", "", "B", "O", "", "O", "B", "O", "B", "B", "B", "O", "O", "AB", "O", "B", "A", "O", "O", "", "O", "A", "", "O", "O", "A", "O", "O", "其他", "B", "O", "O", "O", "A", "AB", "A", "O", "B", "AB", "", "O", "O", "O", "", "O", "A", "A", "O" };
            int[] heights = { 173, 0, 179, 155, 183, 170, 163, 174, 165, 189, 177, 180, 154, 167, 170, 173, 165, 158, 180, 165, 153, 175, 162, 165, 0, 160, 165, 173, 164, 177, 177, 180, 170, 151, 176, 180, 168, 152, 666, 2147483647, 165, 155, 777, 173, 169, 170, 169, 171, 0, 170, 150, 160, 155, 164, 163, 165, 184, 165, 155, 0, 168, 160, 169, 0, 150, 163, 168, 173 };


            // 宣告計算用的變數(男女、血型)
            int boys = 0;
            int girls = 0;            
            int A = 0;
            int B = 0;
            int O = 0;
            int AB = 0;
            int others = 0;

            // GTall 用來計算輸入數值正確的女生個數
            // Gsum 放女生身高總和
            int GTall = 0;
            int Gsum = 0;

            // 計算男女、各血型數量
            for (int i = 0; i < Blood.Length; i++)
            {
                //印出全班同學名字
                //Console.WriteLine(names[i]);
                            
                if (BG[i] == "女")
                {
                    girls++;
                    if (heights[i] > 100 && heights[i] < 200)
                    {
                        GTall++;
                        Gsum = Gsum + heights[i];
                    }
                    
                }
                else if (BG[i] == "男")
                {
                    boys++;
                }

                if (Blood[i] == "A")
                {
                    A++;
                }
                else if (Blood[i] == "B")
                {
                    B++;
                }
                else if (Blood[i] == "O")
                {
                    O++;
                }
                else if (Blood[i] == "AB")
                {
                    AB++;
                }
                else 
                {
                    others++;
                }

            }

            // 計算全班身高最大值、最小值
            int Max = 0;
            int min = 200;
            for (int i = 0; i < heights.Length; i++)
            {
                if (heights[i] > 100 && heights[i] < 200)
                {
                    if (heights[i] > Max)
                    {
                        Max = heights[i];
                    }

                    if (heights[i] < min)
                    {
                        min = heights[i];
                    }
                }                

            }

            // 計算男女生百分比
            double GPercent = Math.Round((double)girls / BG.Length*100,0);
            double BPercent = Math.Round((double)boys / BG.Length*100,0);

            // 計算各血型百分比
            double AStudents = Math.Round((double)A / Blood.Length *100,0);
            double BStudents = Math.Round((double)B / Blood.Length * 100,0);
            double OStudents = Math.Round((double)O / Blood.Length *100,0);
            double ABStudents = Math.Round((double)AB / Blood.Length * 100,0);
            double Others = Math.Round((double)others / Blood.Length * 100, 0);

            // 計算女生身高平均
            double GTAverage = Math.Round((double)Gsum / GTall,1);

            // 文字顏色為黃色
            Console.ForegroundColor = ConsoleColor.Yellow;

            // 印出男女生人數，百分比            
            Console.WriteLine("女生人數: " + girls+"人，百分比: "+GPercent+" %"+"\n"+"男生人數: "+boys+ "人，百分比: " + BPercent+" %" + "\n");
           

            // 印出女生身高
            Console.WriteLine("女生身高總和: " + GTall+"\n"+"女生身高平均: "+ GTAverage +"\n");

            // 印出全班身高最大最小值
            Console.WriteLine("身高最高: " + Max + "公分" + "\n" + "身高最矮: " + min + "公分"+"\n");
                                  

            // A型人數、百分比(長條圖)
            Console.WriteLine("A型人數有" + A + "人，" + "百分比: " + AStudents + "%");
            for (int i = 0; i < Blood.Length; i++)
            {
                
                if (i < AStudents)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                }
                Console.Write(" ");
            }

            // 重設背景為黑色
            Console.BackgroundColor = ConsoleColor.Black;
            
            // B型百分比
            Console.WriteLine("\n" + "B型人數有" + B + "人，" +"百分比: " + BStudents + "%");
            for (int i = 0; i < Blood.Length; i++)
            {

                if (i < BStudents)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                }
                Console.Write(" ");
            }

            Console.BackgroundColor = ConsoleColor.Black;

            // O型百分比
            Console.WriteLine("\n" + "O型人數有" + O + "人，" + "百分比: " + OStudents + "%");
            for (int i = 0; i < Blood.Length; i++)
            {

                if (i < OStudents)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                }
                Console.Write(" ");
            }

            Console.BackgroundColor = ConsoleColor.Black;
            
            // AB型百分比
            Console.WriteLine("\n" + "AB型人數有" + AB + "人，" + "百分比: " + ABStudents + "%");
            for (int i = 0; i < Blood.Length; i++)
            {

                if (i < ABStudents)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                }
                Console.Write(" ");
            }

            Console.BackgroundColor = ConsoleColor.Black;

            // 其他百分比
            Console.WriteLine("\n"+"其他有" + others + "人，"+ "百分比: " + Others + "%");
            for (int i = 0; i < Blood.Length; i++)
            {

                if (i < Others)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                }
                Console.Write(" ");
            }

            // 暫停閱讀
            Console.ReadLine();
        }
    }
}
