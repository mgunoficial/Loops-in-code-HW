
//Ededin musbet ve ya menfi olmagi

using System.Xml.Schema;
Console.WriteLine("Reqem daxil edin");
var num = Console.ReadLine();
var ConvNum = Convert.ToInt32(num);


if (ConvNum > 0)
    Console.WriteLine("Musbetdir");
else
    Console.WriteLine("Menfidir");


//Ixtiyari daxil edilmis 5 ededin cemini tapan alqoritma

double sums = 0;
double nummer;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"{i} ededi daxil edin");
    nummer = Convert.ToDouble(Console.ReadLine());
    sums += nummer;
}

Console.WriteLine(sums);

//Ixtiyari daxil edilmis ededin kvadratini tapan alqoritma

var degree = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(degree * degree);

//Ixtiyari daxil edilmis 3 ededden boyuyunu tapan alqoritma


var a = Convert.ToDouble(Console.ReadLine());
var b = Convert.ToDouble(Console.ReadLine());
var c = Convert.ToDouble(Console.ReadLine());

if (a > b && a > c)
    Console.WriteLine("En boyuy eded a-dir");
else if (a < b && c < b)
    Console.WriteLine("En boyuy eded b-dir");
else
    Console.WriteLine("En boyuy eded c-dir");


//Iki Ixtiyari eded daxil edilir, birinci daxil edilen ededin kubunun ikinci daxil ededden boyuk olub olmadigini tapan alqoritma 

var x = Convert.ToDouble(Console.ReadLine());
var y = Convert.ToDouble(Console.ReadLine());

if (x * x * x > y)
    Console.WriteLine("Birinci ededin kubunnan boyuk deyil");
else
    Console.WriteLine("Birinci ededin kubunnn boyukdur");

//Ededin hem 3e, hem 5e bolunub bolunmemesini tapan alqoritma


var n = Convert.ToInt32(Console.ReadLine());

if (n % 5 == 0 && n % 3 == 0)
    Console.WriteLine("Deyer hem 3e hemde 5se bolunur");
else
    Console.WriteLine("Eded ya iksine yadaki 3e yada 5e bolunmur");


//Input olaraq kartdaki mebleg ve mehsulun meblegi goturulur, kartdaki meblegin mehsulu almaga yeterli olub olmadigini tapan alqoritma


var card = Convert.ToDouble(Console.ReadLine());
var product = Convert.ToDouble(Console.ReadLine());

if (card > product)
    Console.WriteLine("Kartin meblegi mehsulu almaga yeterlidir");
else
    Console.WriteLine("Kartdaki meblegi hemsulu almaga yeterli deyil");

//Telebenin semestri kecib kecmediyini tapan alqoritma
double sum = 0;
double sub;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"{i} Fennen aldiginiz bali daxil edin:");
    sub = Convert.ToDouble(Console.ReadLine());
    sum += sub;
}

if ((sum) * 5 > 65)
    Console.WriteLine("Telebe semestri ugurla kecib");
else
    Console.WriteLine("Telebe semestri teesufki kecmeyib");


//Input olaraq daxil edilmis iki natural ededden hansinin boyuk oldugunu tapan alqoritma

var n1 = Convert.ToInt32(Console.ReadLine());
var n2 = Convert.ToInt32(Console.ReadLine());

if (n1 > 0 && n2 > 0)
{
    if (n1 > n2)
        Console.WriteLine("Birinci natural eded boyukdur");
    else
        Console.WriteLine("Ikinci natural eded boyukdur");
}
else
    Console.WriteLine("Yanlis daxil edilib regemler");


//Input olarag temperaturu yoxlayan alqoritma


var temp = Convert.ToDouble(Console.ReadLine());

if (temp > 0)
    Console.WriteLine("Temperature suyun donma temperaturunnan yuxaridir");
else
    Console.WriteLine("Temperature suyun donma temperaturunnan asagidir ve yaxut eynidir");




//50e qeder olan ededleri artan sira ile gostermek

for (int i = 0; i < 50; i++)
{
    Console.WriteLine(i);
}

//40a qeder 3e bolunen ededlerin sayini tapmaq

var count = 0;

for (int i = 0; i < 40; i++)
{
    if (i % 3 == 0)
        count++;
}

Console.WriteLine($"40a qeder 3e bulunene ededlerin sayi {count} denedir");


//100e qeder hem 3e hem 7e bolunen ededleri tapmaq ve gostermek
for (int i = 0; i < 100; i++)
{
    if (i % 3 == 0 && i % 7 == 0)
        Console.WriteLine(i); ;
}



//Ededin reqemlerinin sayini tapmaq;

var num2 = Convert.ToInt32(Console.ReadLine());
var counter = 0;
int resulter5;
while (num2 > 0)
{
    counter++;
    resulter5 = num2 % 10;
    num2 = (num2 - resulter5) / 10;
}

Console.WriteLine(counter);


//Ededi tersine yazmaq

var k = Convert.ToInt32(Console.ReadLine());
int resulter2;
var Str = "";
while (k > 0)
{
    resulter2 = k % 10;

    Str += resulter2.ToString();
    k = (k - resulter2) / 10;
}
Console.WriteLine(Str);


//Ededin Faktorialini tapmaq

var summer = 0;
var z = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < z; i++)
{
    summer *= i;
}

Console.WriteLine(summer);

//Ededin sade ve ya murekkeb olmasi


var l = Convert.ToInt32(Console.ReadLine());

if(l%2==0)
    Console.WriteLine("Sade");
else
    Console.WriteLine("Murekkeb");

//Ededin reqemlerinin cemini tapmaq

var e = Convert.ToInt32(Console.ReadLine());
int resulter3;
int summers = 0;
while (e > 0)
{
    resulter3 = e % 10;

    summers += resulter3;
    e = (e - resulter3) / 10;
}
Console.WriteLine(summers);

//Ededin reqemleri icerisinde en boyuyu tapmaq

var m = Convert.ToInt32(Console.ReadLine());
int resulter4;
int max = 0;
while (m > 0)
{
    resulter4 = m % 10;

    if (max < resulter4)
        max = resulter4;

    m = (m - resulter4) / 10;
}

Console.WriteLine(max);


//70den kicik olan ededlerden cut olanlari azalan sira ile gostermek

var count1 = 0;

for (int i = 0; i < 70; i++)
{
    if (i % 2 == 0)
        count1++;
}

var newArr = new int [count1];
var j = 0;

for (int i = 0; i < 70; i++)
{
    if (i % 2 == 0)
    {
        newArr[j] = i;
        j++;
    }
}

newArr.Reverse();


for (int i = newArr.Length - 1; i <= newArr.Length; i--)
{
    if (i >= 0)
    {
        Console.WriteLine(newArr[i]);

    }


}


//Ilin fesli daxil edilir.Meselen 11. Cavab olaraq:Noyabr,Payiz feslidir


var fesil = Convert.ToInt32(Console.ReadLine());

switch (fesil)
{

    case 1:
        Console.WriteLine("Yanvar");
        break;
    case 2:
        Console.WriteLine("Fevral");
        break;
    case 3:
        Console.WriteLine("Mart");
        break;
    case 4:
        Console.WriteLine("Aprel");
        break;
    case 5:
        Console.WriteLine("May");
        break;
    case 6:
        Console.WriteLine("Iyun");
        break;
    case 7:
        Console.WriteLine("Iyul");
        break;
    case 8:
        Console.WriteLine("Avqust");
        break;
    case 9:
        Console.WriteLine("Sentyabr");
        break;
    case 10:
        Console.WriteLine("Oktyabr");
        break;
    case 11:
        Console.WriteLine("Noyabr");
        break;
    case 12:
        Console.WriteLine("Dekabr");
        break;
    default:
        break;
}


if (fesil > 10&& fesil < 3)
    Console.WriteLine("Qis aylari");
else if(fesil>2&&fesil<6)
    Console.WriteLine("Yaz aylari");
else if(fesil>5&&fesil<9)
    Console.WriteLine("Yay aylari");
else
    Console.WriteLine("Payiz aylari");