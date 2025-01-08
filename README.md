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

## **Öne Çıkan Özellikler**

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

![image](https://github.com/user-attachments/assets/762c338b-ad10-41ab-b633-58a1cd42ebd3)
![image](https://github.com/user-attachments/assets/eb017cbd-1476-47a2-8a70-c294a6155dee)
![image](https://github.com/user-attachments/assets/787684a4-6ebf-401f-835a-4fa8d3a19b80)
![image](https://github.com/user-attachments/assets/b35f0c43-5aa9-4344-abd5-c6b052c9e25e)
![image](https://github.com/user-attachments/assets/09721239-c7e7-4b9b-bc16-d5aa37dd6832)
![image](https://github.com/user-attachments/assets/d8f469f8-c088-4031-91a8-1b11650e55d8)
![image](https://github.com/user-attachments/assets/d2cfce39-ede2-4288-9dad-48427ed469f9)
![image](https://github.com/user-attachments/assets/b8efe8be-2767-4e7b-918f-b097cb127849)
![image](https://github.com/user-attachments/assets/b29f1f4f-5e0f-45ad-af3a-9a41bdbb1fc2)
![image](https://github.com/user-attachments/assets/c0cf3e2d-ad92-4401-bc88-fe0d24c4c6f6)
![image](https://github.com/user-attachments/assets/e503c2c9-4f58-42b6-a6c5-2b4a3c403423)
![image](https://github.com/user-attachments/assets/90078f4d-d86c-4097-a551-0be6408ab0ab)
![image](https://github.com/user-attachments/assets/5090c2c8-3ea4-4442-a8fe-f83ee70861e2)
![image](https://github.com/user-attachments/assets/9ee28fa7-2318-479d-8607-43a5e2934ad4)
![image](https://github.com/user-attachments/assets/2372d242-7e21-4d00-be79-7b55d5763a7d)
![image](https://github.com/user-attachments/assets/350ef93e-b689-4bec-b0d5-ce10c50005a9)
![image](https://github.com/user-attachments/assets/aabd6bd0-60fa-447f-8e76-74e06a66bbc2)
![image](https://github.com/user-attachments/assets/b9036520-cd36-46c4-bf9a-bff8b2a08027)
![image](https://github.com/user-attachments/assets/9abf23a0-5933-4704-9688-12c742075cec)
![image](https://github.com/user-attachments/assets/83b88113-56f4-4f44-80d6-3d4a76c8290a)
![image](https://github.com/user-attachments/assets/c3099a64-8270-4bb4-8a10-0f38a73abad5)
![image](https://github.com/user-attachments/assets/e2e7e8db-3b58-461b-905c-964e41ad4d34)
![image](https://github.com/user-attachments/assets/b18dba64-7099-4d8d-ae19-3e1d075b7bef)
![image](https://github.com/user-attachments/assets/91c28ddd-c6d2-44d6-ae9c-8f6207ad927b)
![image](https://github.com/user-attachments/assets/c83c2602-1494-4de2-b246-a747bf366ab3)
![image](https://github.com/user-attachments/assets/2cd53024-6525-4b99-83c7-bcecb63516c8)







</div>
