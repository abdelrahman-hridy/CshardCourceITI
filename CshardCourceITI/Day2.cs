namespace D1CSharp
{
    public class Day2
    {
        public static void StuList(int num)
        {
            string[] stuarr = new string[num];
            Console.WriteLine("Enter all student names:\n");
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Student " + (i + 1) + ": ");
                stuarr[i] = (Console.ReadLine());
            }
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Student " + (i + 1) + ": " + stuarr[i]);
            }
        }

        public static void Traks(int track_num, int stu_num)
        {
            int[,] trackList = new int[track_num, stu_num];
            float[] avg = new float[track_num];
            float total = 0;
            for (int i = 0; i < track_num; i++)
            {
                Console.WriteLine("Track " + (i + 1) + ": ");

                for (int j = 0; j < stu_num; j++)
                {
                    trackList[i, j] = Convert.ToInt32(Console.ReadLine());
                    total += trackList[i, j];
                }
                avg[i] = total / stu_num;
                Console.WriteLine();
            }
            for (int i = 0; i < track_num; i++)
            {
                Console.WriteLine("Track " + (i + 1) + ": ");

                for (int j = 0; j < stu_num; j++)
                {
                    Console.Write("\t");
                    Console.Write(trackList[i, j]);
                }
                Console.WriteLine();
            }

            for (int j = 0; j < track_num; j++)
            {
                Console.WriteLine("AVG of Track " + (j + 1) + ": ");
                Console.WriteLine(avg[j] + "\n");
            }
        }

        public static void DateList()
        {
            int[][] time = new int[1][];
            time[0] = new int[3];

            time[0][0] = 22;
            time[0][1] = 33;
            time[0][2] = 11;

            int hours = time[0][0];
            int minutes = time[0][1];
            int seconds = time[0][2];

            Console.WriteLine($"{hours}H:{minutes}M:{seconds}S");
        }
    }
}