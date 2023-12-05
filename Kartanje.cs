using System;
					
public class Program
{
	public static void Main()
	{
		int karte, bodovi = 0;
		while(bodovi < 31){
			Console.Write("Upisite vrijednost karte: ");
		try
		{
			karte = Convert.ToInt32(Console.ReadLine());
			if (karte > 13 || karte < 1){
				Console.WriteLine("Pogresan unos");
				continue;
			}
			else
			{
				bodovi += karte;
			}
		}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
		if (bodovi == 31){
			Console.WriteLine("Bodovi: " + bodovi);
			Console.WriteLine("Pobijedili ste!");
		}
		else
		{
			Console.WriteLine("Bodovi: " + bodovi);
			Console.WriteLine("Izgubili ste");
		}
	}
		}
}