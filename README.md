# **Takım İsmi**

Sodhisur

# Genel Oyun Fikri ve Roller

## Takım Elemanları

- Hamide Sümeyye Gökalp : Scrum Master / Product Owner / Developer
- Gülnur Doğancıoğlu : Developer / Artist
- Muhammet Uysal : Developer
- Dilara Nur Değirmen : Aktif Olmayan Üye

## Oyun İsmi

--MetoCod--

## Product Backlog URL

[Sodhisur Trello Backlog Board](https://trello.com/invite/b/FSVS9saS/ATTI4f9f2d67348095b6892d2cb86a4773e3DCED8AD4/metocode)

## GAME DESIGN DOCUMENT

[MetoCod Game Design Document](https://github.com/wilkagul/MetoCod/blob/main/Assets/Doc/Game-Design-Document.pdf)

## Oyunun Açıklaması

MetoCod, eğlenerek öğrenebileceğiniz, gezegen savunması konseptini benimsemiş, C# Algoritma pratiklerini bolca uygulayacağınız, 2D platform oyunudur. Temel olarak Ipad Pro’da çizdiğimiz Meto adlı karaterimizin gezegeni korumak için
kötücül düşmanlarla savaşmasını, ayrıca "Yazılım dünyayayı güzelleştirir.” mottosuyla çıktığımız bu yolda, C# algoritma sorularının sonuçlarını gezegenimize ulaştırılmasını sağlayarak, C# öğrenme yolculuğuna katkı sağlamasını amaçladığımız bir oyun türüdür. Tematik bir gezegende özel olarak hazırladığımız karakterin, "Kod yaz dünyayı geliştir!" sloganıyla çıktığımız bu yolda, disiplinler arası presipleri birleştirip, oyunlaştırıp, basitçe hikayeleştirip, bir amaca göre hem eğlendirip hem de öğrettiğimiz bir mobil oyun projesidir.

- **Oyunun birincil fonksiyonu**: C# programlama dilinde pratikler yaptırarak, Playerın algoritmik soruların sonuçlarını
  hızlıca çözüp bu oyunlaştırma projesinde hedefe ulaşması oyunun birincil fonksiyonunu oluşturmaktadır.

- **Oyunun İkincil fonksiyonu**: Bu oyun, Gezegen Savunması konseptini benimseyerek düşmanların gezegene zarar vermesini önlemeyi, yaşanabilir bir gezegeni korumayı ve kollamayı, gerektiğinde ise geliştirmeyi hedefleyen ikincil fonksiyonlara sahiptir.

## Oyunun Türü

- **Oyunumuzun** türü 2D gezegen savunması disiplinindedir. Dikey yani portait ekranlarda oynanacaktır. Genel kapsayıcı hedefler bakımından tek bir mekanik olması sebebiyle hypercasual türünü kapsamaktadır. Aynı zamanda konsepti gereği bir eğitsel oyun türü olduğu oyun amacımızda eğlenerek C# öğretmesi en büyük beklentimizdir. Aynı zamanda Challenge ve Code Learning alanlarınıda kapsamaktadır.

### Kapsadığı Türler

- Hyper Casual
- Educational Game
- Code Challenge
- Code Learning
- Gamification

## Oyunun Amacı

- Meto adlı karakterimizin gezegenini savunmasına yardım etmek.
- Meto adlı karakterimizi yöneterek, ölümcül düşmanların gezegenimize zarar vermesini önlemek.
- Konsol ekranında çıkan, C# algoritma sorularının çıktılarını çözmek.
- Meto adlı karakterimizin dost olan Codo yaratıklarına izin vererek, gezegenimizin gelişmesine yardım edilmesi sağlamak.
- Codo yaratıklarımızın içinde ise, C# algoritma sorularının çıktı sonuçları yer aldığını için her doğru cevap bizlerin gezegenin gelişmesine katkı sağlamaya ve amacımıza ulaşmaya gayret ettirecektir.

Bu oyunu oynayan kişilerce oyuna baktığımızda oyunun temelde 2 amacı vardır;

- Meto ile düşmanları engelle,
- Meto ile dostların(Codo) güvenle gezegene inmelerine izin ver.

Codo'lar , içlerinde sorulmuş olan algoritmaların çıktılarını tutan kasalardır.

Bu amaçlarla birlikte öğretim vurgusu yaparak, amacımız eğlenceli bir şekilde algoritma sorularını oyunculara çözdürmektir. Diğer oyunlarda olduğu gibi, elementler bir oyunu oyun yapan ve oyunlaştırma unsurlarıdır. Bizim buradaki oyun amacımız ise eğlenerek öğretmektir.

## Oyunun Açıklaması

"MetoCod" oyununda yönettiğimiz tek karakter, Meto adlı bir karakterdir. Genellikle yatay yönde hareket etmektedir. Amacı kötü düşmanları engellemek ve dost varlıkların gezegene iniş yapmasını sağlamaktır. Dost varlıklar, algoritma sorularının sonuçları olacaktır. Bu oyun, 2D retro uzay savaşları oyunlarından ilham alınarak oluşturulmuştur. Gezegen savunması temasını seçmemizin nedeni, yaşayabileceğimiz tek dünya olması ve bu dünyayı yazılım aracılığıyla güzelleştirmek isteğimizdir. Bu nedenle, stilize gezegenimizi Meto karakteriyle düşmanlardan korumak görevlerimiz arasındadır. Meto'nun kimin dost kimin düşman olduğunu anlamak için oyuncuya yardımcı olmamız gerekmektedir. Bu nedenle, oyunda kullanıcı deneyimi içinde basit algoritma sorularını gösteren bir konsol ekranı bulunmaktadır. Oyuncu, oyun ekranında sürekli olarak iki yeri kontrol etmelidir. Birincisi soruların bulunduğu bölümler, ikincisi ise kötücül düşmanları gezegenden uzak tutmaya çalışmak. Oyunun çizimleri, sanatsal yaklaşımı, müzikleri ve ses efektleri özel olarak seçilecek ve oyuncunun duygusal deneyimini güçlendirmek için kullanılacaktır. Böylece oyunun oynanışı, sanatı, teması ve sesleri bir araya gelerek oyuncuların kendilerini oyun dünyasında tamamen kaybetmelerine ve öğrenme konseptlerine farklı bir yaklaşım sunmalarına yardımcı olacaktır.

## Oyunun Mekaniği

- **Core Game Mechanic #1 & Character Move - Temel Oyun Mekaniği**

  Kullanıcıdan alınan inputlar ile, mouse input - touch input girişi kullanılarak karakterin sağa veya sola
  hareket etmesi kararlaştırılmıştır.

- **Core Game Mechanic #2 & Consol Mechanic - Temel Oyun Mekaniği**

  Biz buna konsol mekanik ismi adını verdik. Burada her level, tur yada roundda C# algoritma sorusunu oyuncucuya soracağımız bir ekran olacaktır.

- **Core Game Mechanic #3 & Stack Mechanic - Temel Oyun Mekaniği**

  Burada oyuncudan toplamasını istediğimiz 2 adet oyun objesi vardır. Bunlar Kod Pulları ve Enemylerdir.

  - **Kod Pulları** → Bunlar gezegene iniş yapmasını istediğimiz sonuçlarımızdir. Gezegenin gelişmesine yardımcı olacaklardır.
  - **Enemyler** → Bunlar ise gezegene zarar verecek olan Enemyler. Bunların gezegene iniş yapmasını Meto ile engellemeliyiz.

## Oyunun Platform

- **Mobile platformlarında**, Android ve Ios marketler’de listelenmesi hedeflenmiştir.

## Hedef Kitle

Hedef kitle, oyunun türüne ve amacına bağlı olarak belirlenir. Platform oyunları genellikle geniş bir kitleye hitap eder. Ancak temanın eğitsel yazılım ve kodlama ile ilgili olması, oyuncuların daha çok yazılıma merakı olan kişiler arasından seçilebileceğini gösteriyor. Ayrıca, konseptte basit algoritma mantığını öğrenmek isteyen herkese hitap etmesi sebebiyle erken dönem eğitim gören kişileride kapsadığını
düşünüyoruz. Bu nedenle, hedef kitle olarak teknolojiye ve yazılıma meraklı olan herkes olarak kategorilendirmek istiyoruz.
Ayrıca aşağıdaki gibi bir liste oluşturup sizlere sunuyoruz.

1. Üniversite Öğrencileri: Bilgisayar bilimi, yazılım mühendisliği veya ilgili alanlarda
   okuyan üniversite öğrencileri.
2. Kendi Kendine Öğrenenler: Programlama dili öğrenmek veya becerilerini
   geliştirmek isteyen kendi kendine öğrenen bireyler.
3. Yeni Başlayanlar: Herhangi bir programlama diline hakim olmayan ve temel
   becerilerini geliştirmek isteyen bireyler.
4. Programlama İlgisi Olanlar: Programlamayı merak eden ve programlama
   dünyasına girmek isteyen herkes.
5. Programlama Öğrencileri: İlk adımlarını atan veya programlama öğrenmeye yeni
   başlayan öğrenciler.

## Juriye Not

Bu projede en büyük eksikliğimiz projede 3 kişi olmamızdır. ilk sprint boyunca oyunun fikri ve ekip içerisindeki iletişimi güçlendirmeye çalıştık. Ayrıca oyunumuz orjinal bir fikir olmasından dolayı assetlerin tamamını referans alarak kendimiz çizdik. Tematik bir oyun yapmayı ve bu oyunun gerçekleştirmek için birçok bizi zorlayıcı etmeni düşünüp planlama ve karar aşamasında iletişimde kaldık.

# Sprint 1

## Sprint Notları

Bu sprint ekip üyelerinin alışık olmadığı düzenin kurgulanması ve oyunumuzun sanat tarafıyla ilgilenilmesi; Github, Trello, Readme dosyası ve Assetleri hazırlanması ile geçmiştir.

## Sprint Puanlama

- **Sprint içinde tamamlanması tahmin edilen puan**: Projeyi 3 parçalı bir halkaya benzetirsek, her bir Sprintin tamamlanması sonucunda 360 puan almayı hedeflemekteyiz.
- 1.  Sprint halkasında hedeflenen toplam puan= 110 puan.
- 2.  Sprint halkasında hedeflenen toplam puan= 120 puan.
- 3.  Sprint halkasında hedeflenen toplam puan= 130 puan.
      Böylece halkanın tüm parçaları birleşir; proje görünür ve işlevsel hale gelir.

- **Puan tamamlama mantığı**: Readme dosyası temelde 2 adımdan oluşmaktadır.
  - 1. Ürün fikrini listelemek ve belgelemek içeriğini oluşturan maddeler için - 30 puan,
  - 2. 1 . Sprint içeriğini oluşturan maddeler için - 30 puan,
  Buna ek olarak;
  - 3. Game Art için - 25 puan,
  - 4. Geriye kalan rastgele işler için - 25 puan verilecektir.

## Daily Scrum

Daily Scrum toplantılarının zamansal sebeplerden ötürü Whatsapp üzerinden yapılmasına karar verilmiştir. Daily Scrum toplantısı örneği jpeg veya word olarak Readme'de tarafımızdan paylaşılmaktadır: [Sprint 1 Daily Scrum Chats](https://github.com/wilkagul/MetoCod/blob/main/Assets/Sprint/Sprint-1/DailyScrum/_chat.txt)


## Sprint Board Updated

- **Sprint board screenshotları:**
  ![Backlog 1](https://github.com/wilkagul/MetoCod/blob/main/Assets/Sprint/Sprint-1/SprintBoardUpdated/SprintBoard-1.jpeg)

## Ürün Durumu 
Ekran Görüntüleri
- **Oyundan Bir Görsel:** 
  ![Backlog 1](https://github.com/wilkagul/MetoCod/blob/main/Assets/Sprint/Sprint-1/Game/Sprint-1.jpeg)

## Sprint Review

- **Alınan Kararlar**:
  - Oyunun genel konsept tasarımları çizildi ve Readme dosyasına eklendi.
  - Oyunun tüm assetleri tarafımızca çizildi ve Unity içerisinde kullanımları hazır hale getirildi.
  - Bizlere rehber olabilecek bir game design document geliştirilmesi yapıldı.
  - Unity içerisine hiçbir iterasyonu olmayan basit düzeyde oyunun son görünümü ile ilgili çalışmalar yapıldı.

## Sprint Retrospective

- **Alınan Kararlar**
  - Roller için net vurgulamalar ve rollere göre geliştirme planları yapılmıştır.
  - Görev beyanları net bir zemin üzerine oturtulmuştur.
  - Ekip üyelerinin az olması sebebi ile herkese daha fazla sorumluluk düştüğünden görevler üzerinde basit iyileştirmelere gidilmiştir.
  - Takım üyelerinin gelecek sprintlerde aktif olması gerektiğine vurgu yapılmıştır.

# Sprint 2

## Sprint Notları

Bu sprint, bir oyun geliştirme sürecini nasıl yönetmemiz gerektiğini ve ilk defa teknik problemlerle karşılaşarak kod yazmaya başladığımızı öğrenmemizi sağladı. Şu aşamada touch sisteminin entegre edildiği ve karakterimizin buna göre hareket ettirilebildiği bir noktaya geldik. Ayrıca araya bayram tatili girmesi süreci ve planlamamızı biraz aksattı diyebiliriz. Ancak ekip olarak bunu uygun gördük ve sprint backlog düzenlemesini buna göre yaptık. Sprint-2'de tüm atanan görevleri tamamladık ve Sprint-3'te daha zorlu teknik konularla karşılaşmayı bekliyoruz.

## Sprint Puanlama

- **Sprint içinde tamamlanması tahmin edilen puan**: Projenin 2. halkasını bu sprint oluşturmaktadır. Hedeflenen toplam puan 120 dir.

- **Puan tamamlama mantığı**: Bu sprint puanlama mantığı temelde 2 adımdan oluşmaktadır.
  - 1. Her Sprint Sonu Beklentiler - 20 puan,
  - 2. Proje geliştirme süreçleri - 100 puan şeklindedir.

## Daily Scrum

Daily Scrum toplantılarının zamansal sebeplerden ötürü Whatsapp üzerinden yapılmasına karar verilmiştir. Daily Scrum toplantısı örneği jpeg veya word olarak Readme'de tarafımızdan paylaşılmaktadır: [Sprint 2 Daily Scrum Chats](https://github.com/wilkagul/MetoCod/blob/main/Assets/Sprint/Sprint-2/DailyScrum/_chat.txt)

## Sprint Board Updated

- **Sprint board screenshotları:**
  ![Backlog 1](https://github.com/wilkagul/MetoCod/blob/main/Assets/Sprint/Sprint-2/SprintBoardUpdated/SprintBoard-2.jpeg)


## Ürün Durumu
Ekran Görüntüleri
- **Oyundan Bir Görsel:**
  ![Backlog 1](https://github.com/wilkagul/MetoCod/blob/main/Assets/Sprint/Sprint-2/Game/Sprint-2.gif)

## Sprint Review

- **Alınan Kararlar**:
  - Unity de C# kodlamaya başladık. Bu süreçte online kaynakları aktif bir şekilde kullandık.
  - Ekip üyelerimizin sayısının azlığı ve bazı teknik bilgilerin eksikliği nedeniyle, çağımızın en büyük velinimetlerinden biri olan Chat GPT'yi yoğun bir şekilde kullanmaya başladık. Eksik kaldığımız konularda ondan destek almaya çalıştık.
  - Bu süreçte eksik kaldığımız noktaları belirledik. Eğer bunları tanım olarak bilirsek, ona göre araştırmalarımızı yaparız diye düşünüyoruz.
    - Touch Input System.
    - Object Pooling
    - Scriptable Object ile Level Sistemi
    - Puanlama Sistemi
  - Yukarıdaki maddelerden ilk 2 tanesini başarı ile youtube dersleri ile tamamladık. Diğer konularıda hızlıca öğrenip uygulamak istiyoruz.

## Sprint Retrospective

- **Alınan Kararlar**
  - Artık kaybedecek zaman ve enerji kalmadığı için eskisinden daha çok ekip ruhuna ve azmine ihtiyacımız olduğuna karar kıldık.
  - Bayram, tatil, deniz ekstra tüm işleri erteleyip, hem öğrenme hemde proje geliştirme süreçlerinde son sprint daha çok aktif olma kararı aldık.
  - Bu süreçte görev beyanları net olarak Trello üzerinden ifade edildi.

## Product Backlog URL

[Sodhisur Trello Backlog Board](https://trello.com/invite/b/FSVS9saS/ATTI4f9f2d67348095b6892d2cb86a4773e3DCED8AD4/metocode)


# Sprint 3

## Sprint Notları

Oyun tamamlandı, sesler entegre edildi, oyunun videosu hazırlandı.

## Sprint Puanlama

- **Sprint içinde tamamlanması tahmin edilen puan**: Projenin 3. halkasını bu sprint oluşturmaktadır. Hedeflenen toplam puan 130 dur.

## Daily Scrum

Daily Scrum toplantılarının zamansal sebeplerden ötürü Whatsapp üzerinden yapılmasına karar verilmiştir. Daily Scrum toplantısı örneği jpeg veya word olarak Readme'de tarafımızdan paylaşılmaktadır: [Sprint 3 Daily Scrum Chats] 


## Sprint Board Updated

- **Sprint board screenshotları:**
 yükleniyor...

 ## Ürün Durumu
Ekran Görüntüleri
- **Oyundan Bir Görsel:**
  yükleniyor...

## Sprint Review

- **Alınan Kararlar**:
Scriptable obje ile level sistemi yazılmış, level içerikleri belirlenip algoritmaları kodlanmış, level içerikleri Code karakterimize entegre edilmiş, Sound manager hazırlanmış ve sesler entegre edilmiştir. Ekip üyelerinin yetersizliği sebebiyle bazı işlerin askıya alınmasına karar verilmiştir. Sprint Review katılımcıları: Hamide Sümeyye Gökalp, Gülnur Doğancıoğlu, Muhammet Uysal.

## Sprint Retrospective

- **Alınan Kararlar**
  
Takım üyelerinin gelecek projelerde daha fazla aktif olması gerektiğine vurgu yapılmıştır.

## Product Backlog URL
yükleniyor...

