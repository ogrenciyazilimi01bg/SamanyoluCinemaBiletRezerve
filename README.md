# SamanyoluCinemaBiletRezervasyon
Bu projede, Sinema Bileti Rezervasyonu için geliştirilen kodların kaynağı yer almaktadır. Bu proje, C# dilinde yazılmış bir sinema bileti rezervasyonu uygulamasını içermektedir. Proje, konsol uygulaması olarak tasarlanmıştır ve kullanıcının istekleri doğrultusunda sinema bileti rezervasyonu yapmayı amaçlamaktadır.
Bu yönergeleri, projeyi kendi makinenizde çalıştırmak ve geliştirmek için kullanabilirsiniz.

## Classlar
Bu proje sinema bileti rezervasyon projesi.Burda Film ,Salon,Seans,Rezervasyon  ,Bilgi, classlarından oluşmaktadır.
Bu projede, 6 Class yer almaktadır. Film, salon, seans, rezervasyon ve bilgi.
Film Class’ı içerisinde: Filmin adı, film türü, film süresi ve filmin yönetmeni özellikleri yer almaktadır.
Salon Class’ı içerisinde: Salon adı ve salon kapasitesi özellikleri yer almaktadır.
Seans Class’ı içerisinde: Film class’ından film, salon class’ından salon özellikleri türetilir. Bu class’ın içerisinde seans zamanı ve tarihi özellikleri yer almaktadır.
Rezervasyon Class’ı içerisinde: Seans class’ından seans türetilir. Müşteri adı, soyadı, bilet adedi, koltuk no ve müşteri cep telefonu özellikleri yer almaktadır.
Bilgi Class’ı içerisinde: Rezervasyon class’ı içerisinde rezervasyon özellik türetilir ve bilet fiyatı özellik yer almaktadır.
GirisEkranı Class'ı içerisinde :Buradan program ilerleyecek ve kullanıcıdan bilgiler isteyerek uygulama çalışmaya devam edecektir.

### Consol uygulaması bu şekilde çalışır:
1)Aşağıdaki filmlerden birini seçiniz yazar. Filmleri ve film hakkında bilgiler yazar. Kulllanıcıdan bir film sayısı girmesi istenir.Yazılı olan film numaralarından girin.
2)Film numarasına göre filmin salonu hakkında bilgiler ekrana yazıcak. Ardından tarih seçmeniz istenir.Bugün seçerseniz işleme devam eder başka bir tarihi seçerseniz kullanıcıdan ekrana tarih girmesi istenir.Örnek:14.05.2023 gibi.
3) Seans saatleri çıkıcak. Kullanıcı seans saati seçecek. 
4) Müsteri adı soyadı girilir. Ekrana müşteri adı soyadı yazılır.
5) Müsteri telefon No konsola girilir. .Örnek :(###)-###-##-##
6)Konsola boş koltuk sayısı ,koltuk yerleri ve dolu koltuklar çıkar.
7) Kullanıcıdan bilet adeti girmesi istenir. Bilet adeti kadar koltuk numarası boş mu kontrol edilir. Değilse tekrar koltuk numarası girmesi istenir. Yeterl i koltuk adeti varsa .İşleme devam edilir. Bilet adeti ekrana çıkar ve toplam  fiyatı yazar.
8)Bilet adeti kadar koltuk numarası girilmesi istenir. Kullanıcı bilet adeti kadar koltuk numaralarını tek tek girer.
9)Oluşturulan bilet konsolda çıkar. Ve işlem başarılı yazısı çıkar.
