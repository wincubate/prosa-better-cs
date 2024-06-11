enum Input
{
    First = 0,
    Second = 1,
    Third = 2,
    Fourth = 3,
}

class Program
{
    public static void Main()
    {
        int x = 22;
        if (x > 87)
        {
            int y = 33;
            if( y > 11 )
            {
                Console.WriteLine("Hello, World!");
            }
        }
        else
        {
            Console.WriteLine("Less!");
            
            Input input = Input.Second;
            switch (input)
            {
                case Input.First:
                    break;
                case Input.Second:
                    break;
                case Input.Third:
                    break;
                case Input.Fourth:
                    break;
                default:
                    break;
            }
        }
    }
}
