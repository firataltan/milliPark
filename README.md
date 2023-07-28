Türkiye’de bulunan 48 adet Milli Parkın isimleri, bulunduğu iller, milli park ilan edildiği tarihler ve yüzölçümleri (hektar)  https://tr.wikipedia.org/wiki/T%C3%BCrkiye%27deki_mill%C3%AE_parklar_listesi https://www.tarimorman.gov.tr/DKMP/Belgeler/Korunan%20Alanlar%20Listesi/MP-WEB-Son.pdf bağlantılarında verilmektedir. Bu verilerden Milli Park nesnelerini oluşturarak ilgili bileşik veri yapısına yerleştiren etkin C# veya Java programını yazınız:

a)	Aşağıdaki sahaları içeren (uygun veri tiplerini / veri yapılarını siz belirleyiniz) bir Milli park sınıfı oluşturunuz: (5)

MilliPark sınıfı (MilliPark_Adı, İl_Adları, İlan_Yılı, Yüzölçümü) 
	
Bir Milli Parkın bulunduğu illerin adlarını tutmak için Generic List kullanabilirsiniz. Milli Park ilan edildiği tarihin sadece yılını tutmanız yeterli olmakla birlikte dileyen tarih (gün.ay.yıl formatında) olarak tutabilir. 

b)	2 elemanlı bir Generic List dizisi oluşturunuz (Şekil 1). Dizinin her bir elemanı Milli Park sınıfı tipinde elemanlardan oluşan birer Generic liste içersin. Verileri sıra ile yukarıdaki bağlantılardan birinden alarak, önce 1. Milli Parka ilişkin nesneyi oluşturunuz; Ardından yüzölçümü 15.000 hektardan küçük ise, dizinin 0. elemanındaki listenin, büyük ise 1. elemanındaki listenin sonuna ekleyiniz. Sonra, kalan Milli Park nesnelerini de belirtilen kritere göre uygun listeye ekleyiniz

c)	Dizideki her bir listedeki bilgilerin tümünü ekrana yazdıran metodu yazınız. 
