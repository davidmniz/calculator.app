class Calculator{
	static void Main(string[] args){
		Console.WriteLine("Progam Kalkulator\n\n");
		
		Console.WriteLine("1. Penambahan");
		Console.WriteLine("2. Pengurangan");
		Console.WriteLine("3. Perkalian");
		Console.WriteLine("4. Pembagian");
		int choice;
		int a ;
		int b ;
		
		Console.WriteLine("\nSilahkan pilih menu : ");
		choice =  Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("\nInput nilai a : ");
		a =  Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("\nInput nilai b: ");
		b =  Convert.ToInt32(Console.ReadLine());
		
		switch(choice){
			case 1:
				Console.WriteLine("Hasil Penambahan: {0} + {1} = {2}", a,b, Penambahan(a, b));
				break;
			case 2:
				Console.WriteLine("Hasil Pengurangan: {0} + {1} = {2}", a,b, Pengurangan(a, b));
				break;
			case 3:
				Console.WriteLine("Hasil Perkalian: {0} * {1} = {2}", a,b, Perkalian(a, b));
				break;
			case 4:
				Console.WriteLine("Hasil Pembagian: {0} / {1} = {2}", a,b, Pembagian(a, b));
				break;
			default:
				Console.WriteLine("Error");
				break;
		}
		

		Console.WriteLine("\nPress any key to continue");
		Console.ReadKey();
	}
	static int Penambahan(int a, int b){
		return a + b;
	}
	static int Pengurangan(int a, int b){
		return a - b;
	}
	static int Perkalian(int a, int b){
		return a * b;
	}
	static int Pembagian(int a, int b){
		return a / b;
	}
}
