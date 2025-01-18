İşte istediğiniz gibi bir `README.md` dosyası:

```markdown
# PostgreSQL Ödev Projeleri

## İçerik:

- [ODEV1](#odev1)
- [ODEV2](#odev2)
- [ODEV3](#odev3)
- [ODEV4](#odev4)

## Veritabanı
Bu projede kullanılan veritabanı, **dvdrental** örnek veritabanıdır. Veritabanı dosyasını aşağıdaki bağlantıdan indirip kullanabilirsiniz:

[**dvdrental.zip**](https://www.postgresqltutorial.com/wp-content/uploads/2019/05/dvdrental.zip)

---

## ODEV1

1. **Film Tablosunda Title ve Description Sütunlarındaki Verileri Sıralayın**
   ```sql
   SELECT title, description FROM film;
   ```

2. **Film Tablosunda Bulunan Tüm Sütunlardaki Verileri, Film Uzunluğu (length) 60'dan Büyük ve 75'ten Küçük Olan Koşullarla Sıralayın**
   ```sql
   SELECT * FROM film WHERE length > 60 AND length < 75;
   ```

3. **Film Tablosunda Bulunan Tüm Sütunlardaki Verileri, Rental Rate 0.99 ve Replacement Cost 12.99 veya 28.99 Olma Koşullarıyla Sıralayın**
   ```sql
   SELECT * FROM film WHERE rental_rate = 0.99 AND (replacement_cost = 12.99 OR replacement_cost = 28.99);
   ```

4. **Customer Tablosunda Bulunan First Name Sütunundaki Değeri 'Mary' Olan Müşterinin Last Name Sütunundaki Değeri Nedir?**
   ```sql
   SELECT last_name FROM customer WHERE first_name = 'Mary';
   ```

5. **Film Tablosundaki Uzunluğu (length) 50'den Büyük Olmayan ve Aynı Zamanında Rental Rate Değeri 2.99 veya 4.99 Olmayan Verileri Sıralayın**
   ```sql
   SELECT * FROM film WHERE length <= 50 AND rental_rate NOT IN (2.99, 4.99);
   ```

---

## ODEV2

1. **Film Tablosunda Bulunan Tüm Sütunlardaki Verileri, Replacement Cost Değeri 12.99'dan Büyük veya Eşit ve 16.99'dan Küçük Olma Koşuluyla Sıralayın (BETWEEN - AND Kullanınız)**
   ```sql
   SELECT * FROM film WHERE replacement_cost BETWEEN 12.99 AND 16.99;
   ```

2. **Actor Tablosunda Bulunan First Name ve Last Name Sütunlarındaki Verileri, First Name 'Penelope', 'Nick' veya 'Ed' Olanları Sıralayın (IN Operatörünü Kullanın)**
   ```sql
   SELECT first_name, last_name FROM actor WHERE first_name IN ('Penelope', 'Nick', 'Ed');
   ```

3. **Film Tablosunda Bulunan Tüm Sütunlardaki Verileri, Rental Rate 0.99, 2.99, 4.99 ve Replacement Cost 12.99, 15.99, 28.99 Olma Koşullarıyla Sıralayın (IN Operatörünü Kullanın)**
   ```sql
   SELECT * FROM film WHERE rental_rate IN (0.99, 2.99, 4.99) AND replacement_cost IN (12.99, 15.99, 28.99);
   ```

---

## ODEV3

1. **Country Tablosunda Bulunan Ülke İsimlerinden 'A' Karakteriyle Başlayıp 'a' Karakteriyle Sonlananları Sıralayın**
   ```sql
   SELECT country FROM country WHERE country LIKE 'A%a';
   ```

2. **Country Tablosunda Bulunan Ülke İsimlerinden En Az 6 Karakterden Oluşan ve Sonu 'n' Karakteriyle Sonlananları Sıralayın**
   ```sql
   SELECT country FROM country WHERE country LIKE '_____%n';
   ```

3. **Film Tablosunda Bulunan Title Sütunundaki Film İsimlerinden En Az 4 Adet Büyük ya da Küçük Harf Farketmeksizin 'T' Karakteri İçeren Film İsimlerini Sıralayın**
   ```sql
   SELECT title FROM film WHERE title ILIKE '%t%t%t%t%';
   ```

4. **Film Tablosunda Bulunan Tüm Sütunlardaki Verilerden Title 'C' Karakteriyle Başlayan ve Uzunluğu (length) 90'dan Büyük Olan ve Rental Rate 2.99 Olan Verileri Sıralayın**
   ```sql
   SELECT * FROM film WHERE title LIKE 'C%' AND length > 90 AND rental_rate = 2.99;
   ```

---

## ODEV4

1. **Film Tablosunda Bulunan Replacement Cost Sütununda Bulunan Birbirinden Farklı Değerleri Sıralayın**
   ```sql
   SELECT DISTINCT replacement_cost FROM film;
   ```

2. **Film Tablosunda Bulunan Replacement Cost Sütununda Birbirinden Farklı Kaç Tane Veri Vardır?**
   ```sql
   SELECT COUNT(DISTINCT replacement_cost) FROM film;
   ```

3. **Film Tablosunda Bulunan Film İsimlerinde (Title) Kaç Tanesi 'T' Karakteriyle Başlar ve Aynı Zamanda Rating 'G' Ye Eşittir?**
   ```sql
   SELECT COUNT(*) FROM film WHERE title LIKE 'T%' AND rating = 'G';
   ```

4. **Country Tablosunda Bulunan Ülke İsimlerinden (Country) Kaç Tanesi 5 Karakterden Oluşmaktadır?**
   ```sql
   SELECT COUNT(*) FROM country WHERE country LIKE '_____';
   ```

5. **City Tablosundaki Şehir İsimlerinin Kaç Tanesi 'R' veya 'r' Karakteriyle Biter?**
   ```sql
   SELECT COUNT(*) FROM city WHERE city LIKE '%r' OR city LIKE '%R';
   ```

---

## Kullanılan Veritabanı ve Dosya

Veritabanı, **dvdrental** örnek veritabanı kullanılarak yapılmıştır. Veritabanını aşağıdaki bağlantıdan indirebilirsiniz:

- [dvdrental.zip](https://www.postgresqltutorial.com/wp-content/uploads/2019/05/dvdrental.zip)

Bu proje için PostgreSQL veritabanı kullanılmakta olup, sorgular PostgreSQL sorgu dili ile yazılmıştır.

---

## Notlar

- **Sorgu**: SQL dilinde yazılmıştır ve PostgreSQL veritabanında çalıştırılmak üzere tasarlanmıştır.
- **Veritabanı**: `dvdrental` veritabanı PostgreSQL ortamında çalıştırılmaktadır.