
//2) CustomMath adinda class yaradin, hemin clasin icinde ashagidaki methodlar olacaq.
//Hemin methodlari proqram classda cagirib ishledin.
//
// 1)Method array qebul edir, arrayin icerisindeki tek ededlerin cemini tapin.
// 2)Methoda gelen ededin tek ve ya cut olub olmamasini gosterin.
// 3) Methoda gelen arrayin elementlerininden cut olanlarinin ceminin kvadratini tapmaq.
// 4) Methoda n ededi gelir, 1-den n ededine qeder olan ededlerin hasilini tapin.






using home_work1_c__metod_constructor_inheritance;


//CustomMath math = new CustomMath();

//int[] numbers = { 1, 2, 3, 4, 5 };
//int SumOfOdds = math.SumOfOdds(numbers);
//Console.WriteLine($"arrayin icindeki tek ededlerin cemi:" + SumOfOdds);


//int eded = 7;
//string SingleAndDouble = math.SingleAndDouble(eded);
//Console.WriteLine($"secilen eded " + SingleAndDouble);


//int[] array = { 1, 2, 3, 4, 5 };
//int SquareOfOdds = math.SquareOfOdds(array);
//Console.WriteLine($"arrayin cut ededlerin kvadrati: "+SquareOfOdds);


//int n = 5;
//int SumOfNumb = math.SumOfNumb(n);
//Console.WriteLine($"1den {n}-e qeder onaln ededlerin cemi: "+SumOfNumb);

CustomMath math = new CustomMath();

int[] nums = { 1, 2, 3, 4, 5, 6 };
int SumOfOdds = math.SumOfOdds(nums);
Console.WriteLine($"arrayin icindeki tek ededlerin cemi:" + SumOfOdds);

int n = 9;
string SingleAndDouble = math.SingleAndDouble(n);
Console.WriteLine($"secilen eded " + SingleAndDouble);

int[] array = { 1, 2, 3, 4, 5, 6 };
int SquareOfOdds = math.SquareOfOdds(array);
Console.WriteLine($"arrayin cut ededlerin kvadrati: " + SquareOfOdds);

int x = 6;
int SumOfNumbs = math.SumOfnumb(x);
Console.WriteLine($"1den {n}-e qeder onaln ededlerin cemi: " + SumOfNumbs);