//1
//using System;

//Console.Write("Adınızı daxil edin: ");
//string ad = Console.ReadLine();

//Console.Write("Yaşınızı daxil edin: ");
//int yas = int.Parse(Console.ReadLine());

//Console.Write("Boyunuzu daxil edin: ");
//double boy = double.Parse(Console.ReadLine());

//Console.WriteLine("Salam, mənim adım " + ad + ". Mənim " + yas +
//                  " yaşım var, boyum " + boy + " m-dir.");


//2
//using System;

//const double Pi = 3.14159;

//Console.Write("Radiusu daxil edin: ");
//double radius = double.Parse(Console.ReadLine());

//double sahe = Pi * radius * radius;

//Console.WriteLine("Dairənin sahəsi: " + sahe);

//3
//using System;

//const double USD = 1.7;
//const double EUR = 1.82;

//Console.Write("Manat məbləğini daxil edin: ");
//string daxilEt = Console.ReadLine();

//double manat;

//if (double.TryParse(daxilEt, out manat))
//{
//    double dollar = manat / USD;
//    double avro = manat / EUR;

//    Console.WriteLine("Dollar: " + dollar);
//    Console.WriteLine("Avro: " + avro);
//}
//else
//{
//    Console.WriteLine("Səhv dəyər daxil etdiniz!");
//}


//4
//using System;

//Console.Write("1-ci qiyməti daxil edin: ");
//string qiymet1 = Console.ReadLine();

//Console.Write("2-ci qiyməti daxil edin: ");
//string qiymet2 = Console.ReadLine();

//Console.Write("3-cü qiyməti daxil edin: ");
//string qiymet3 = Console.ReadLine();

//Console.Write("4-cü qiyməti daxil edin: ");
//string qiymet4 = Console.ReadLine();

//Console.Write("5-ci qiyməti daxil edin: ");
//string qiymet5 = Console.ReadLine();

//int bal1 = Convert.ToInt32(qiymet1);
//int bal2 = Convert.ToInt32(qiymet2);
//int bal3 = Convert.ToInt32(qiymet3);
//int bal4 = Convert.ToInt32(qiymet4);
//int bal5 = Convert.ToInt32(qiymet5);

//double orta = (bal1 + bal2 + bal3 + bal4 + bal5) / 5.0;

//Console.WriteLine("Orta bal: " + orta);

//if (orta < 51)
//{
//    Console.WriteLine("Kəsildiniz");
//}
//else if (orta <= 90)
//{
//    Console.WriteLine("Orta nəticə");
//}
//else
//{
//    Console.WriteLine("Əla nəticə");
//}

//5
//using System;

//const double faiz = 0.12;

//Console.Write("İlkin məbləği daxil edin: ");
//double mebleg = Convert.ToDouble(Console.ReadLine());

//Console.Write("Neçə il saxlayacağınızı daxil edin: ");
//int il = Convert.ToInt32(Console.ReadLine());

//double gelecekMebleg = mebleg * (1 + faiz * il);

//Console.WriteLine("Gələcək məbləğ: " + gelecekMebleg);

//6
//using System;

//Console.Write("Məsafəni (km) daxil edin: ");
//double mesafe = Convert.ToDouble(Console.ReadLine());

//Console.Write("Sərf olunan yanacağı (litr) daxil edin: ");
//double yanacaq = Convert.ToDouble(Console.ReadLine());

//if (mesafe <= 0 || yanacaq < 0)
//{
//    Console.WriteLine("Daxil edilən məlumat yanlışdır!");
//}
//else
//{
//    double serfiyyat = (yanacaq / mesafe) * 100;

//    Console.WriteLine("100 km üçün sərfiyyat: " + serfiyyat + " litr");
//}