
for (var i = 1; i <= 9; i++)
{
	if (i <= 5)
	{

		for (var j = 1; j <= i; j++)
		{
			Console.Write("*");
		}
		Console.WriteLine(" ");
	}
	else
	{
		for (var j = 5; j >= i; j--)
		{
			Console.Write("*");
		}
		Console.WriteLine(" ");


	}
}




for (var i = 1; i <= 5; i++)
{
		for (var j = 5; j >= i; j--)
		{
			Console.Write("*");
		}
		Console.WriteLine(" ");


}