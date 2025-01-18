
# Proje: SQL Sorguları

Bu projede, PostgreSQL kullanarak çeşitli SQL sorguları yazılmıştır. Veri tabanı olarak `dvdrental` örnek veri tabanı kullanılmıştır. Veri tabanı bağlantısını [buradan](https://www.postgresqltutorial.com/wp-content/uploads/2019/05/dvdrental.zip) indirebilirsiniz.

## ODEV5

### Sorgular:

1. **Film Tablosunda İsim (Title) 'n' Karakteri ile Biten En Uzun (Length) 5 Filmi Sıralayın**  
   ```sql
   SELECT title
   FROM film
   WHERE title LIKE '%n'
   ORDER BY LENGTH(title) DESC
   LIMIT 5;
   ```

2. **Film Tablosunda İsim (Title) 'n' Karakteri ile Biten En Kısa (Length) İkinci (6,7,8,9,10) 5 Filmi Sıralayın**  
   ```sql
   SELECT *
   FROM film
   WHERE title LIKE '%n'
   ORDER BY length ASC
   OFFSET 5
   LIMIT 5;
   ```

3. **Customer Tablosunda Last Name Sütununa Göre Azalan Sıralamada Store ID 1 Olan İlk 4 Veriyi Sıralayın**  
   ```sql
   SELECT *
   FROM customer
   WHERE store_id = 1
   ORDER BY last_name DESC
   LIMIT 4;
   ```

---

## ODEV6

### Sorgular:

1. **Film Tablosunda Rental Rate Sütunundaki Değerlerin Ortalaması Nedir?**  
   ```sql
   SELECT ROUND(AVG(rental_rate), 2)
   FROM film;
   ```

2. **Film Tablosunda 'C' Karakteri ile Başlayan Kaç Film Vardır?**  
   ```sql
   SELECT COUNT(*)
   FROM film
   WHERE title LIKE 'C%';
   ```

3. **Film Tablosunda Rental Rate Değeri 0.99’a Eşit Olan En Uzun (Length) Film Kaç Dakikadır?**  
   ```sql
   SELECT MAX(length)
   FROM film
   WHERE rental_rate = 0.99;
   ```

4. **Film Tablosunda Uzunluğu 150 Dakikadan Büyük Olan Filmler İçin Kaç Farklı Replacement Cost Değeri Vardır?**  
   ```sql
   SELECT COUNT(DISTINCT replacement_cost)
   FROM film
   WHERE length > 150;
   ```

---

## ODEV7

### Sorgular:

1. **Film Tablosunda Bulunan Filmleri Rating Değerlerine Göre Gruplayın**  
   ```sql
   SELECT rating,
          COUNT(*)
   FROM film
   GROUP BY rating;
   ```

2. **Film Tablosunda Bulunan Filmleri Replacement Cost Sütununa Göre Grupladığınızda, Film Sayısı 50’den Fazla Olan Replacement Cost Değeri ve Karşılık Gelen Film Sayısını Sıralayın**  
   ```sql
   SELECT replacement_cost,
          COUNT(*)
   FROM film
   GROUP BY replacement_cost
   HAVING COUNT(*) > 50;
   ```

3. **Customer Tablosunda Store ID Değerlerine Karşılık Gelen Müşteri Sayılarını Sorgulayın**  
   ```sql
   SELECT store_id,
          COUNT(*)
   FROM customer
   GROUP BY store_id;
   ```

4. **City Tablosunda Şehir Verilerini Country ID Sütununa Göre Gruplandırın, Sonra En Fazla Şehir Sayısı Bulunan Country ID Bilgisini ve Şehir Sayısını Paylaşın**  
   ```sql
   SELECT country_id,
          COUNT(*)
   FROM city
   GROUP BY country_id
   ORDER BY COUNT(*) DESC
   LIMIT 1;
   ```

---

## Veri Tabanı Bağlantısı

- Veri tabanı olarak [dvdrental.zip](https://www.postgresqltutorial.com/wp-content/uploads/2019/05/dvdrental.zip) veri tabanı kullanılmıştır.

---

Bu README dosyası, projedeki tüm SQL sorgularını ve açıklamalarını içermektedir. Projeyi veritabanınızda çalıştırarak, her bir sorgunun doğru sonuçları verdiğinden emin olabilirsiniz.