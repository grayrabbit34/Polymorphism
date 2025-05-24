# Polymorphism - Geometrik Şekil Alan Hesaplama

Bu C# projesi, **polimorfizm (çok biçimlilik)** kavramını kullanarak farklı geometrik şekillerin alanını hesaplayan bir uygulamadır. Her şekil `BaseGeometrikSekil` adlı temel sınıftan türemiştir.

## 📁 Proje Yapısı

### 🔹 BaseGeometrikSekil.cs

- Ortak özellikleri (`Width`, `Height`) ve sanal (`virtual`) `AlanHesapla()` metodunu içerir.
- `Width` ve `Height` için pozitif sayı kontrolü içeren property'ler tanımlıdır.

### 🔹 RightTriangle.cs
- Dik üçgenin alanını hesaplar.
- `Alan = (Width * Height) / 2` formülünü kullanır.
- `AlanHesapla()` metodu override edilmiştir.

### 🔹 Rectangle.cs
- `BaseGeometrikSekil`'in varsayılan `AlanHesapla()` metodunu kullanır (`Alan = Width * Height`).

### 🔹 Square.cs
- Kare sınıfı olup genişlik ve yüksekliği eşit olarak atanmalıdır.
- Şu an `AlanHesapla()` override edilmemiştir ama dilersen genişletilebilir.

### 🔹 Program.cs
- `Main` metodu içinde üç farklı şekil oluşturulup alanları hesaplanır ve konsola yazdırılır.

## ▶️ Çalıştırma

1. Bu dosyaları bir C# projesine (`.NET Console App`) dahil edin.
2. `Program.cs` dosyasındaki `Main` metodu uygulamayı başlatır.
3. Konsolda her şeklin alanı görüntülenir.
