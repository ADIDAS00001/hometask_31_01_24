
List<int> number1 =new List<int>(){1,2,3,4,5};
List<int> number2 =new List<int>(){1,2,3,4,5};
foreach (var item1 in number1)
{
    foreach (var item2 in number2)
    {
        if(item1==item2)
        {
            System.Console.WriteLine("True");
            return ;
        }
        else
        {
            System.Console.WriteLine("False");
            return ;
        }
    }
}