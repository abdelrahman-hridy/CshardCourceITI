
namespace CshardCourceITI
{
    public class calc
    {
        public static int Sum(int x, int y)
        {
            return (x + y);
        }
        public static float Sum(float x,float y)
        {
            return (float)(x + y);
        }
        public static int Sub(int x, int y)
        {
            return (x - y);
        }
        public static float Sub(float x, float y)
        {
            return (float)(x - y);
        }
        public static int mul(int x, int y)
        {
            return (x * y);
        }
        public static float mul(float x, float y)
        {
            return (float)(x * y);
        }
        public static int div(int x, int y)
        {
            return (x / y);
        }
        public static float div(float x, float y)
        {
            return (float)(x / y);
        }
    }

    public class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }

        public Question()
        {
            Header = "Default Header";
            Body = "Default Body";
            Mark = 1;
        }

        public Question(string header, string body, int mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
        }

        public virtual void Show()
        {
            Console.WriteLine($"[{Header}] ({Mark} mark)");
            Console.WriteLine(Body);
        }
    }

    public class MCQquestion : Question
    {
        public string[] choices { get; set; }
        public MCQquestion(string header, string body, int mark, string[] choices)
            : base(header, body, mark)
        {
            this.choices = choices;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("choices:");
            for(int i = 0; i < choices.Length; i++)
            {
                Console.WriteLine((i + 1) + "- " + choices[i]);
            }
        }
    }
}
