using test_5;
Random rand = new Random();
double x = rand.NextDouble(-100,100) ;
double y = rand.NextDouble() ;
//double x1, y1, x2, y2, x3, y3;
//Console.WriteLine("Enter the coordinates of the triangle vertices:");
//Console.Write("x1 = ");
//x1 = double.Parse(Console.ReadLine());
//Console.Write("y1 = ");
//y1 = double.Parse(Console.ReadLine());
//Console.Write("x2 = ");
//x2 = double.Parse(Console.ReadLine());
//Console.Write("y2 = ");
//y2 = double.Parse(Console.ReadLine());
//Console.Write("x3 = ");
//x3 = double.Parse(Console.ReadLine());
//Console.Write("y3 = ");
//y3 = double.Parse(Console.ReadLine());

//Triangle triangle = new Triangle(x1, y1, x2, y2, x3, y3);

//int choice;
//do
//{
//	Console.Clear();
//	Console.WriteLine("1. Перевірити, чи рівні два трикутники");
//	Console.WriteLine("2. Обчислити площу трикутника");
//	Console.WriteLine("3. Обчислити периметр трикутника");
//	Console.WriteLine("4. Обчислити висоти трикутника");
//	Console.WriteLine("5. Обчислити медіани трикутника");
//	Console.WriteLine("6. Обчислити бісектриси трикутника");
//	Console.WriteLine("7. Обчислити радіус вписаного кола трикутника");
//	Console.WriteLine("8. Обчислити радіус описаного кола трикутника");
//	Console.WriteLine("9. Визначити тип трикутника");
//	Console.WriteLine("10. Повернути трикутник на заданий кут");
//	Console.WriteLine("0. Вихід");
//	Console.Write("Виберіть опцію: ");
//	choice = int.Parse(Console.ReadLine());

//	switch (choice)
//	{
//		case 1:
//			Console.WriteLine("Обраний пункт 1");
//			// код для порівняння двох трикутників
//			break;
//		case 2:
//			Console.WriteLine("Обраний пункт 2");
//			// код для обчислення площі трикутника
//			break;
//		case 3:
//			Console.WriteLine("Обраний пункт 3");
//			// код для обчислення периметра трикутника
//			break;
//		case 4:
//			Console.WriteLine("Обраний пункт 4");
//			// код для обчислення висот трикутника
//			break;
//		case 5:
//			Console.WriteLine("Обраний пункт 5");
//			// код для обчислення медіан трикутника
//			break;
//		case 6:
//			Console.WriteLine("Обраний пункт 6");
//			// код для обчислення бісектрис трикутника
//			break;
//		case 7:
//			Console.WriteLine("Обраний пункт 7");
//			// код для обчислення радіуса вписаного кола трикутника
//			break;
//		case 8:
//			Console.WriteLine("Обраний пункт 8");
//			// код для обчислення радіуса описаного кола трикутника
//			break;
//		case 9:
//			Console.WriteLine("Обраний пункт 9");
//			// код для визначення типу трикутника
//			break;
//		case 10:
//			Console.WriteLine("Обраний пункт 10");
//			// код для повороту трикутника
//			break;
//		case 0:
//			Console.WriteLine("Goodbye!");
//			break;
//		default:
//			Console.WriteLine("Виберіть правильну опцію");
//			break;
//	}
//	Console.WriteLine();
//} while (choice != 2);