int baban, deden, ninen;
int anan = 1;
int Anan = 2;
//int i�erisine de�i�ken tan�mlan�r. B�y�k k���k uyumu �nemlidir. Virg�l kullan�larak birden fazla de�i�ken tan�mlanabilir.
int sayi;
//int  i�erisine de�i�ken tan�mlan�rken t�rk�e karakter kullan�lmamas�na dikkat edilmelidir.
int anan_baban;
//de�i�ken tan�mlan�rken bo�luk yerine _ i�areti kullan�lmal�d�r. Ayr�ca de�i�ken tan�mlan�rken _ d���nda �zel karakter desteklenmez.
int code;
//kodlamada kullan�lan �zel ifadeler null, for, if gibi de�i�ken olarak tan�mlanamaz.

//sabitler i�erisinde sabit de�er bulundurmaktad�r ve kodlama aktif oldu�u s�rece de�i�im g�stermez.
const double a = 5;
double anan1, baban1, anan_baban1;
//const sabit ifadelerde kullan�lan koddur.

//de�i�kenler local (b�lgesel) ve global (k�resel) olmak �zere ikiye ayr�l�r.
//local de�i�ken de�i�ken tipi ve de�i�ken ad� �eklinde tan�mlan�r. �RN.
int sayi1;
//yukar�daki de�i�keni global olarak tan�mlayabilmek i�in iki farkl� y�ntem izlenebilir.
int sayi2 = 8;//de�i�ken form1 s�n�f�n�n alt�nda tan�mland�.
private void button2_click(object sender Eventargs e);//kullan�lan de�i�kenin t�m proje i�erisinde ge�erli olmas� i�in Public static de�i�kentipi de�i�kenad�.
//�RN.
public static int sayi3 = 3;//bir formdan, ba�ka bir formdaki global de�i�kende eri�mek i�in;
//Form�smi. De�i�ken�smi metodu kullan�l�r.
//public ile tan�mlanan de�i�kenler ba�ka formlar i�inde kullan�labilir.

//farkl� tiplerden de�i�kenlerin grupland�r�ld��� bir veri t�r� yap�s� vard�r ki structure (struct) veri t�r� yap�s� denir.
//structure tan�mlanan yap�lar�n boyutlar� elemanlar�n de�er t�rlerinin toplam boyutu kadard�r.
//program�n performans a��s�ndan daha iyi sonu� verebilmesi i�in ayn� yap� i�inde yer alacak elemanlar� belirlemek ve onlar� bir �at� alt�nda toplamak gerekir.
//�RN.
struct ev
{
	public double metrekare;
	public string cephe;
	public int binayasi;
}
//yukar�da struct yap�m�z� olu�turduk. �imdi bu yap�y� kullanarak yeni bir de�i�ken olu�tural�m.

buyuk_ev ev = new ev();
//ya da
ev buyuk_ev;

//struct yap�s�n� olu�turduktan sonra herhangi bir de�i�kene de�er atamak i�in a�a��daki kodu inceleyebilirsiniz.
buyuk_ev.metrekare = 120;
buyuk_ev.cephe = "g�ney";
buyuk_ev.binayasi = 5;

//if kullan�m� dallanma anlam�na gelmektedir ve csharp programlama dilinde �art ifadesi olarak kullan�l�r. Dallanma programc�lar�n en �ok tercih etti�i yap�d�r.
//programlarda if komutu kullan�l�rken �art, else komutu kullan�l�rken �art�n olmad��� durumlar ifade edilir.
if (sart)
{
	//�art�n ger�ekle�ti�i durum.
}
else (sart)
{
	//�art�n ger�ekle�medi�i durum.
}
//�RN.
Console.Write("sayi gir");
int sayi4 = Convert.ToInt16(Console.ReadLine());
if (sayi4 % 2 == 0)
{
	Console.WriteLine("Girilen say� cift");
}
else
Console.WriteLine("Girilen say� tek");
Console.ReadKey();

switch (kosul)
{
case 1 :
	//birinci �ge
break;

case 2 :
	//ikinci �ge
break;

default:
	//son �ge
break;
}
//switch komutu uygulama ak���n� kontrol etmek i�in kullan�l�r. Karma��k if-else komutlar�ndan program� kurtarmak i�in kullan�l�r.

//while d�ng�s�n�n temel amac� belirlenen komut blo�unu ko�ul sa�land��� s�rece �al��t�rmakt�r.
while (kosul)
{
	//komutlar yaz�l�r.
}
//�RN.
int SAY� = 1;
while (SAY�<=10)
{
	Console.WriteLine("Hosgeldin");
	SAY�++;
}
//do while d�ng�s� temelde en az bir kere �al��an �art� ifade eder. While d�ng�s�nde �arta ba�l� olarak komutlar �al���rken, do-while d�ng�s�nde �art en az bir kez �al���r.
int k = 21;
do
{
Console.WriteLine(k);
k++;
}
while (k<=30);
//sonu� true olursa d�ng� �al��maya devam eder, ama false olursa bir kez �al���r ve durur.

//for d�ng�s� kullan�l�rken �ncelikle bir de�i�ken olu�turulur. Olu�turulan bu de�i�ken d�ng� i�erisinde kullan�l�r.
for (int i:0; i>10; i++)
{
	int i=0;  //de�i�kenin ba�lang�� de�eri.
	int i>10;  //de�i�kenin s�n�rlar�n� belirleyen ko�ul.
	i++;  //de�i�ken �zerinde ger�ekle�ecek matematiksel ifade.
}
//ba�lang�� de�erinin bir di�er ismi de kontrol de�eridir. Kontrol de�eri d�ng� i�inde saya� g�revi g�r�r ve kontrol edilecek de�eri belirtir.
//ko�ul, yap�lmak isteneni denetleyen mekanizmad�r. Ba�lang�� de�erinin durumu operat�rler ile denetlenir.
//matematiksel i�lem yap�lmazsa d�ng� i�erisinde sonsuz d�ng� olu�ur.
int topla=30;
for (int i=0; i<10; i++)
topla +=i
{
	Console.WriteLine(topla);
}

//foreach d�ng�s� dizi ve koleksiyon tabanl� nesnelerin elemanlar� �zerinden ilerler.
//koleksiyon ;dizi, arraylist, dictionary gibi ayn� tipleri i�inde bar�nd�ran yap�lara denir.
int() ab=(1,2,3,4);
int Carp=1;
foreach (int x in ab)
{
	Carp = carpim*x;
}
//x de�i�keninin i�ine say� dizisindeki her say� al�narak tek tek �arp�l�r. Sonu� 24.

//c# dilinde dizi tan�mlaman�n birden fazla y�ntemi vard�r. T�m�n�n �al��ma mant��� ayn�d�r.
