using System.Security.Cryptography.X509Certificates;

class program
{
    public static void Main(string[] args)
    {
        List<int> my_list = new List<int> {1,2,2,3,3,5,3,4,3,4,4,5};
        List<int> result = new List<int>();
        foreach (var n in my_list)
        {
            if(!result.Contains(n))
            {
                result.Add(n);
            }
            continue;
        }
        result.Sort();
        foreach (var r in result)
        {
            Console.WriteLine(r);
        }
    }
}