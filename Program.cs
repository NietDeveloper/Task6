// 1. Palindrome Tekshiruvi:
System.Console.Write("Sozni kiriting:");
string? input = Console.ReadLine();
if(PalindromeTekshirish(input))
{
    System.Console.WriteLine("Palindrom so\'z!");
}
else
{
    System.Console.WriteLine("Palindrom so\'z emas!");
}
static bool PalindromeTekshirish(string str)
{
    string newInput = str.Replace(" ","").ToLower();
    int uzunligi = newInput.Length;
    for(int i = 0; i < uzunligi/2; i++)
    {
        if(newInput[i] != newInput[uzunligi - i - 1])
        {
            return false;
        }
    }
    return true;
}

// 2. Temperatura o'girish: 
System.Console.Write("Haroratni kiriting (selsiyus)da:");
double c = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Haroratni qaysi turda ko'rishni xohlaysiz?\n1 - Selsiyus (°C)\n2 - Fahrenheit (°F)\n3 - Kelvin (K) ");
string? tanlov = Console.ReadLine();
double f = c*9/5+32;
double k = c + 273.15;
switch(tanlov)
{
    case "1":
        System.Console.WriteLine($"Selsiyus:{c}");
        break;
    case "2":
        System.Console.WriteLine($"Fahrenheit:{f}");
        break;
    case "3":
        System.Console.WriteLine($"Kelvin:{k}");
        break;
    default: 
        System.Console.WriteLine("Notog\'ri raqam kiritdingiz!");
        break;
}
//3. Sonlarni tartiblash:
System.Console.Write("Sonni kiriting:");
string? a = Console.ReadLine();
int[] number = a.Split(",").Select(s => int.Parse(s.Trim())).ToArray();
System.Console.WriteLine("Sonlardan birini tanlang!");
System.Console.WriteLine("1 - O'sish tartibi (ascending)");
System.Console.WriteLine("2 - Kamayish tartibi (descending)");
string? tanlash = Console.ReadLine();

switch(tanlash)
{
    case "1":
    var ascending = number.OrderBy(n => n);
    System.Console.WriteLine("Tartiblangan qator:" + string.Join(", ", ascending));
    break;
    case "2":
    var descending = number.OrderByDescending(n => n);
    System.Console.WriteLine("Teskari tartib:" + string.Join("," , descending));
    break;
    default:
    System.Console.WriteLine("Notog'ri raqam kiritingiz!");
    break;
}

// 4. Berilgan matnning simvol sanasini hisoblash:
Console.Write("Matn kiriting: ");
string text = Console.ReadLine();
char[] uniqueChars = new char[text.Length];
int[] counts = new int[text.Length];
int uniqueIndex = 0;
for (int i = 0; i < text.Length; i++)
{
    char currentChar = text[i];
    bool found = false;
    for (int j = 0; j < uniqueIndex; j++)
    {
        if (uniqueChars[j] == currentChar)
        {
            counts[j]++;
            found = true;
            break;
        }
    }
    if (!found)
    {
        uniqueChars[uniqueIndex] = currentChar;
        counts[uniqueIndex] = 1;
        uniqueIndex++;
    }
}
Console.WriteLine("\nSimvol sanog'i:");
for (int i = 0; i < uniqueIndex; i++)
{
    Console.WriteLine($"'{uniqueChars[i]}': {counts[i]} martta");
}


