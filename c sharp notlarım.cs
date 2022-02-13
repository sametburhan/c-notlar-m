int baban, deden, ninen;
int anan = 1;
int Anan = 2;
//int içerisine deðiþken tanýmlanýr. Büyük küçük uyumu önemlidir. Virgül kullanýlarak birden fazla deðiþken tanýmlanabilir.
int sayi;
//int  içerisine deðiþken tanýmlanýrken türkçe karakter kullanýlmamasýna dikkat edilmelidir.
int anan_baban;
//deðiþken tanýmlanýrken boþluk yerine _ iþareti kullanýlmalýdýr. Ayrýca deðiþken tanýmlanýrken _ dýþýnda özel karakter desteklenmez.
int code;
//kodlamada kullanýlan özel ifadeler null, for, if gibi deðiþken olarak tanýmlanamaz.

//sabitler içerisinde sabit deðer bulundurmaktadýr ve kodlama aktif olduðu sürece deðiþim göstermez.
const double a = 5;
double anan1, baban1, anan_baban1;
//const sabit ifadelerde kullanýlan koddur.

//deðiþkenler local (bölgesel) ve global (küresel) olmak üzere ikiye ayrýlýr.
//local deðiþken deðiþken tipi ve deðiþken adý þeklinde tanýmlanýr. ÖRN.
int sayi1;
//yukarýdaki deðiþkeni global olarak tanýmlayabilmek için iki farklý yöntem izlenebilir.
int sayi2 = 8;//deðiþken form1 sýnýfýnýn altýnda tanýmlandý.
private void button2_click(object sender Eventargs e);//kullanýlan deðiþkenin tüm proje içerisinde geçerli olmasý için Public static deðiþkentipi deðiþkenadý.
//ÖRN.
public static int sayi3 = 3;//bir formdan, baþka bir formdaki global deðiþkende eriþmek için;
//FormÝsmi. DeðiþkenÝsmi metodu kullanýlýr.
//public ile tanýmlanan deðiþkenler baþka formlar içinde kullanýlabilir.

//farklý tiplerden deðiþkenlerin gruplandýrýldýðý bir veri türü yapýsý vardýr ki structure (struct) veri türü yapýsý denir.
//structure tanýmlanan yapýlarýn boyutlarý elemanlarýn deðer türlerinin toplam boyutu kadardýr.
//programýn performans açýsýndan daha iyi sonuç verebilmesi için ayný yapý içinde yer alacak elemanlarý belirlemek ve onlarý bir çatý altýnda toplamak gerekir.
//ÖRN.
struct ev
{
	public double metrekare;
	public string cephe;
	public int binayasi;
}
//yukarýda struct yapýmýzý oluþturduk. Þimdi bu yapýyý kullanarak yeni bir deðiþken oluþturalým.

buyuk_ev ev = new ev();
//ya da
ev buyuk_ev;

//struct yapýsýný oluþturduktan sonra herhangi bir deðiþkene deðer atamak için aþaðýdaki kodu inceleyebilirsiniz.
buyuk_ev.metrekare = 120;
buyuk_ev.cephe = "güney";
buyuk_ev.binayasi = 5;

//if kullanýmý dallanma anlamýna gelmektedir ve csharp programlama dilinde þart ifadesi olarak kullanýlýr. Dallanma programcýlarýn en çok tercih ettiði yapýdýr.
//programlarda if komutu kullanýlýrken þart, else komutu kullanýlýrken þartýn olmadýðý durumlar ifade edilir.
if (sart)
{
	//þartýn gerçekleþtiði durum.
}
else (sart)
{
	//þartýn gerçekleþmediði durum.
}
//ÖRN.
Console.Write("sayi gir");
int sayi4 = Convert.ToInt16(Console.ReadLine());
if (sayi4 % 2 == 0)
{
	Console.WriteLine("Girilen sayý cift");
}
else
Console.WriteLine("Girilen sayý tek");
Console.ReadKey();

switch (kosul)
{
case 1 :
	//birinci öge
break;

case 2 :
	//ikinci öge
break;

default:
	//son öge
break;
}
//switch komutu uygulama akýþýný kontrol etmek için kullanýlýr. Karmaþýk if-else komutlarýndan programý kurtarmak için kullanýlýr.

//while döngüsünün temel amacý belirlenen komut bloðunu koþul saðlandýðý sürece çalýþtýrmaktýr.
while (kosul)
{
	//komutlar yazýlýr.
}
//ÖRN.
int SAYÝ = 1;
while (SAYÝ<=10)
{
	Console.WriteLine("Hosgeldin");
	SAYÝ++;
}
//do while döngüsü temelde en az bir kere çalýþan þartý ifade eder. While döngüsünde þarta baðlý olarak komutlar çalýþýrken, do-while döngüsünde þart en az bir kez çalýþýr.
int k = 21;
do
{
Console.WriteLine(k);
k++;
}
while (k<=30);
//sonuç true olursa döngü çalýþmaya devam eder, ama false olursa bir kez çalýþýr ve durur.

//for döngüsü kullanýlýrken öncelikle bir deðiþken oluþturulur. Oluþturulan bu deðiþken döngü içerisinde kullanýlýr.
for (int i:0; i>10; i++)
{
	int i=0;  //deðiþkenin baþlangýç deðeri.
	int i>10;  //deðiþkenin sýnýrlarýný belirleyen koþul.
	i++;  //deðiþken üzerinde gerçekleþecek matematiksel ifade.
}
//baþlangýç deðerinin bir diðer ismi de kontrol deðeridir. Kontrol deðeri döngü içinde sayaç görevi görür ve kontrol edilecek deðeri belirtir.
//koþul, yapýlmak isteneni denetleyen mekanizmadýr. Baþlangýç deðerinin durumu operatörler ile denetlenir.
//matematiksel iþlem yapýlmazsa döngü içerisinde sonsuz döngü oluþur.
int topla=30;
for (int i=0; i<10; i++)
topla +=i
{
	Console.WriteLine(topla);
}

//foreach döngüsü dizi ve koleksiyon tabanlý nesnelerin elemanlarý üzerinden ilerler.
//koleksiyon ;dizi, arraylist, dictionary gibi ayný tipleri içinde barýndýran yapýlara denir.
int() ab=(1,2,3,4);
int Carp=1;
foreach (int x in ab)
{
	Carp = carpim*x;
}
//x deðiþkeninin içine sayý dizisindeki her sayý alýnarak tek tek çarpýlýr. Sonuç 24.

//c# dilinde dizi tanýmlamanýn birden fazla yöntemi vardýr. Tümünün çalýþma mantýðý aynýdýr.
