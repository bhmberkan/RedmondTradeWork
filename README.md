<div align="center">
  
## **Redmond Trade**

Bu proje, RedmondTrade şirketinin süreçlerini dijitalleştirmek ve kullanıcılar için kolaylaştırılmış bir web  platformu sunmak amacıyla geliştirilmiştir.
Kullanıcı dostu bir arayüz ve güçlü bir backend ile desteklenen platform, hem sayfa yöneticileri hem de kullanıcılar için kapsamlı bir çözüm sağlamaktadır.

---
## **Projenin Amacı**
Bu sistem, Redmondtrade şirketi ile iglilenen kullanıcıların hızlı ve etkili bir şekilde erişim yapmasını sağlarken yöneticilerin tüm süreçlerini tek bir platformdan kontrol etmesine olanak tanır.
Projede kullanılan modern yazılım teknolojileri, performanslı ve güvenli bir çözüm sunmayı hedefler.

---

## **Teknolojik Altyapı**

Proje, ASP.NET Teknolojisi kullanılarak geliştirilmiştir. Backend kısmında entity framework ile veritabanı işlemleri gerçekleştirilmiştir. Mvc controller yapısıyla kullanıcı arayüzü oluşturulmuştur.

---

##**Öne Çıkan Özellikler**

### **1. Kullanıcı Rolleri ve Yetkilendirme**
- **admin**: sayfa yönetimi ve kullanıcı mesajları. container işlemleri gibi işlemlere erişip kontrollerini sağlama. Türkçe,ingilizce,Fransızca sayfaları için içerikleri ayrı ayrı düzenleyebilme.
yeni kullanıcı kaydı oluşturma. çözüm ortağı ekleme silme güncelleme gibi işlemleri gerçekleştirme vb.

- **Member**: member rolüne sahip kullanıcılar sayfanın home,content vb kısımları dışında container için arama işlemleri yapabilme, detaylarını görebilme gibi işlemleri yapar.

- **Normal**:  Normal kullanıcılar yani hiç yetkilendirme almamış olan kullanıcılar. Sadece home sayfası gibi alanları görebilir admin kısmındaki hiçbir yere erişemezler.

- **Güvenlik**: Base controller kullanırak session ile oturum yapılandırılması yapılmıştır.

### **2. Container Yönetimi**
- **Container Oluşturma**: Admin kolayca container oluşturabilir ve detaylarını görebilir.
- **Container silme**: Admin container silebilir. Container silindiğinde içerik kısmı gitmez. Container silinen containerler listesine gönderilir.
- **Container Güncelleme**: Admin Girmiş olduğu containerin bilgilerini güncelleyebilir.
- **Container Arama**: İlgili containerin bilgilerini girerek arama yapabilirsiniz. Ayrıca containerin içerisinde bulunan, örn tuğla yazıldığı zaman hangi containerde tuğla bulunuyorsa veya hangilerinde onlar listelenir.
- **Container Contents**: Örn 1 numaralı containerin detayına tıkladığınızda. İlgili containere içerik ekleyebilirsiniz.

### **3. Gtip Ve Taxlist**

- **Gtip**: gitpler eklenip listelenir. silinebilir güncellene bilir ve arama işlemi gerçekleştirilebilir.
- **TaxList**:Tüm taskler için yukarıdaki özellikler geçerlidir.

### **4. Welcome, About, Solution Partners, Work, Service.**

- **Bilgi**: Başlıkta geçen sayfalar için. Güncelleme ekleme silme işlemlerini türkçe,ingilizce ve fransızca sayfaları için değiştirme olanağı sunar.

### **5. Message** 

- **Message**: Kullanıcıların göndermiş olduğu mesajları görüp detaylarına bakabilir. Ayrıca silme işlemi gerçekleştirebilirsiniz. Ayrıca kullanıcıların göndermiş oldukları mesajlar ilgili mail adresinize gönderilir.
Bu özellik şu anda aktif durumda değildir kodlardaki yorum satırını gözlemleyerek düzenleme yapabilirsiniz.

### **6. Kullanıcı**

- Admin tarafından kullanıcı ekleuyebilirsiniz. Bu kullanıcılara şifre ataması yapabilir ve şifrelerini görüntüleyip güncelleme işlemi sağlayabilirsiniz. Bu kullanıcıların rolleri member olarak atanır. Ve containerler için
login paneli üzerinden giriş yaptıklarında sadece arama ve detayları yanı ilgili containerin neler içerdiklerini görüp arama işlemi yapabilirler.



---
## **Kullanılan Teknolojiler**

### **Web Geliştirme**
- ASP.NET Core 5.0 MVC

### **Veritabanı**
- MSSQL
- Entity Framework

### **Güvenlik**
- Session Oturum yönetimi
- Rol Tabanlı Yetkilendirme

### **Kullanıcı Arayüzü**
- Bootstrap
- html/Css
- Java script
  
---

## **Kurulum ve Çalıştırma**

### **Gereksinimler**
- .NET ? SDK
- MSSQL Server
- Visual Studio / Visual Studio Code

### **Kurulum**
1. **Projeyi Klonlayın**  
   ```bash
   git clone https://github.com/bhmberkan/RedmondTradeWork.git
   cd RedmondTradeWork

---


## **Proje Görselleri**







</div>
