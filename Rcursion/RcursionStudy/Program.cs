// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");




void PrintNum(int x, int n, int sum)
{
    if (x == n)
    {
        sum += x;
        Console.WriteLine(sum);
        return;
    }
    sum += x;
    PrintNum(x + 1, n, sum);

}
//PrintNum(1, 5, 0);




void PrintNum1(int x)
{
    if (x == 0)
    {
        return;
    }
    Console.WriteLine(x);
    PrintNum1(x - 1);

}
//PrintNum1(5);


void PrintNum2(int x)
{
    if (x == 6)
    {
        return;
    }
    Console.WriteLine(x);
    PrintNum2(x + 1);

}
//PrintNum2(1);




int CaclulateFact(int x)
{
    if (x == 1 || x == 0)
    {
        return 1;
    }
   int fact_nm1 = CaclulateFact(x - 1);
    int fact_n = x * (fact_nm1);
    return fact_n;


}
//var fact = CaclulateFact(5);
//Console.WriteLine(fact);


void PrintFibnnoci(int a,int b ,int n)
{
    if (n == 0) {
        return;
    }
    int c = a + b;
    Console.WriteLine(c);
    PrintFibnnoci(b,c,n - 1);
   
}
int a = 0;
int b = 1;
//Console.WriteLine(a);
//Console.WriteLine(b);
int n = 7;
//PrintFibnnoci(a, b, n-2);

int CalPower(int x,int y)
{
    if (y == 0) //base 1
    {
        return 1;
    }
    if(x == 0) { // base 2
        return 0;
    }
    int xPownm1 = CalPower(x,y-1); //work
    //Console.WriteLine(xPownm1);
    int xPown = x * xPownm1;
    return xPown;
}
int x = 2;
int y = 8;
//var ans = CalPower(x,y);
//Console.WriteLine(ans);



int CalPower1(int t, int p)
{
    if (p == 0) //base 1
    {
        return 1;
    }
    if (t == 0)
    { // base 2
        return 0;
    }
    if(t %2 == 0)
    {
        return CalPower(t,p/2)*CalPower(t,p/2);
    }
    else
    {
        return CalPower(t, p / 2) * CalPower(t, p / 2)*t;
    }

}
int t = 2;
int p = 8;
//var ansl = CalPower1(t, p);
//Console.WriteLine(ansl);


string str;
string revstr = "";
Console.WriteLine("Please enter your word");
str = Console.ReadLine();

for(int i = str.Length -1; i >= 0; i--)
{
    revstr = revstr + str[i];
}
    Console.WriteLine(revstr);