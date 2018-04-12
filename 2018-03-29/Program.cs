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
            // 放入學生姓名、星座、性別、血型、身高資料
            string[] Name = { "葉俊廷", "張澤瑜", "王程捷 的咩？", "江儀婷", "張秉華", "陳柏霖", "黃紀瑜", "黃昱維", "蔡逸群", "登琳", "世新魏鈞孝吧", "劉定南", "陳信如", "童信傑", "李岳倫", "鄒和恆", "簡毓玟", "劉子瑄", "蕭紹洋", "李亞宸la", "張以潔", "邱仕紳", "呂家瑩", "世新林鑫佑", "徐均得", "陳佳欣", "張恩瑋", "周詮", "王湘婷", "蕭宇成", "Max Cheung(BANG)", "馬嘉誠Σヽ(ﾟД ﾟ; )ﾉ魔貫光殺砲(ﾟДﾟ)σ━0000", "陳昱嘉", "康珈熏", "盧奕宏", "陳郁佳的大哥黃博涵", "遲正雯", "世新林星彤", "許晏誠ｘ勒是奇多＿８＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝Ｄ　", "許子安", "高子晴", "陳思婷", "矝鵘鮿", "余彥廷", "吳耀輝", "鄭丞智", "林冠廷", "世新何曜宇", "邵喬雨", "張豐愷", "林子晴", "邱雁回", "陳家欣是韓妞", "鄧雅馨", "謝汶珊", "李曼寧", "我是陳柏霖2號", "张钰慈", "鍾宜珊", "raer_tsai", "世新李姳諼", "鄭曼君", "陳柏霖", "世新許子安", "世新方若帆", "李曼寧", "世新遲正雯", "世新周詮" };
            string [] Star = { "金牛", "", "巨蟹", "白羊", "雙魚", "雙子", "天蠍", "巨蟹", "獅子", "雙魚", "雙子", "雙子", "獅子", "雙魚", "天蠍", "天蠍", "處女", "處女", "金牛", "雙魚", "處女", "摩羯", "雙魚", "白羊", "天蠍", "處女", "雙子", "金牛", "雙子", "白羊", "白羊", "摩羯", "射手", "巨蟹", "雙魚", "獅子", "射手", "摩羯", "天蠍", "", "雙魚", "雙子", "", "雙魚", "處女", "金牛", "天秤", "水瓶", "巨蟹", "處女", "白羊", "摩羯", "水瓶", "天秤", "金牛", "天蠍", "天蠍", "處女", "雙子", "", "摩羯", "天蠍", "雙子", "", "獅子", "天蠍", "射手", "金牛" };
            string [] BG = { "男", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "男", "女", "男", "男", "男", "女", "女", "男", "男", "女", "男", "女", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "女", "男", "男", "女", "女", "男", "男", "女", "女", "男", "男", "男", "男", "男", "男", "女", "男", "女", "女", "女", "女", "女", "女", "男", "女", "女", "女", "女", "女", "男", "男", "女", "女", "女", "男" };
            string [] Blood = { "O", "其他", "O", "O", "A", "O", "A", "A", "O", "O", "A", "O", "A", "B", "O", "O", "A", "其他", "O", "O", "A", "", "B", "O", "", "O", "B", "O", "B", "B", "B", "O", "O", "AB", "O", "B", "A", "O", "O", "", "O", "A", "", "O", "O", "A", "O", "O", "其他", "B", "O", "O", "O", "A", "AB", "A", "O", "B", "AB", "", "O", "O", "O", "", "O", "A", "A", "O" };
            int[] heights = { 173, 0, 179, 155, 183, 170, 163, 174, 165, 189, 177, 180, 154, 167, 170, 173, 165, 158, 180, 165, 153, 175, 162, 165, 0, 160, 165, 173, 164, 177, 177, 180, 170, 151, 176, 180, 168, 152, 666, 2147483647, 165, 155, 777, 173, 169, 170, 169, 171, 0, 170, 150, 160, 155, 164, 163, 165, 184, 165, 155, 0, 168, 160, 169, 0, 150, 163, 168, 173 };


            // 宣告計算用的變數(男女、血型)
            int boys = 0, girls = 0, A = 0, B = 0, O = 0, AB = 0, others = 0;

            // BTall、GTall 分別用來計算輸入數值正確的男女生個數
            // Bsum、Gsum 分別放男女生身高總和
            int BTall=0,GTall = 0;
            int Bsum=0,Gsum = 0;

            Console.WriteLine("天蠍座O型的人有:");
            // 計算男女、各血型數量，及找出天蠍座O型的人
            for (int i = 0; i < Blood.Length; i++)
            {                    
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
                    if (heights[i] > 100 && heights[i] < 200)
                    {
                        BTall++;
                        Bsum = Bsum + heights[i];
                    }
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
                    if (Star[i] == "天蠍")
                    {
                        Console.WriteLine(Name[i]);
                    }
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
            int Max = 0, min = 200;
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

            // 計算男女生、全班身高平均
            double BTAverage = Math.Round((double)Bsum / BTall,1);
            double GTAverage = Math.Round((double)Gsum / GTall,1);
            double TallAvg = Math.Round((double)(Bsum + Gsum) / (BTall + GTall),1);
                       
            // 將顏色改為藍色，印出男生人數&百分比、身高
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n"+"男生人數: " + boys + "人，百分比: " + BPercent + " %");
            Console.WriteLine("男生身高總和: " + Bsum + " 公分" + "\n" + "男生身高平均: " + BTAverage + " 公分" +"\n" );
            
            // 將顏色改為紫色，印出女生人數&百分比、身高
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("女生人數: " + girls + "人，百分比: " + GPercent + " %");
            Console.WriteLine("女生身高總和: " + Gsum + " 公分" + "\n" + "女生身高平均: " + GTAverage + " 公分" +"\n" );

            // 將顏色改為綠色，印出全班身高最大最小值
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("身高最高: " + Max + " 公分" + "\n" + "身高最矮: " + min + " 公分");
            Console.WriteLine("全班身高平均: " + TallAvg + " 公分" + "\n");

            // 將文字顏色改為黃色
            Console.ForegroundColor = ConsoleColor.Yellow;

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
