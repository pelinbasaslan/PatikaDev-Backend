--1)test veritabanınızda employee isimli sütun bilgileri id(INTEGER), name VARCHAR(50), birthday DATE, email VARCHAR(100) olan bir tablo oluşturalım.

CREATE TABLE employee(id INTEGER PRIMARY KEY,
                                         name VARCHAR(50) NOT NULL,
                                                          birthday DATE, email VARCHAR(100) );

--2)Oluşturduğumuz employee tablosuna 'Mockaroo' servisini kullanarak 50 adet veri ekleyelim.

insert into employee (id, name, birthday, email)
values (1,
        'Boone Gabby',
        '1939-03-31',
        'bgabby0@thetimes.co.uk');


insert into employee (id, name, birthday, email)
values (2,
        'Gerard Jenking',
        '1951-08-30',
        'gjenking1@berkeley.edu');


insert into employee (id, name, birthday, email)
values (3,
        'Garret Burkill',
        '2005-05-23',
        null);


insert into employee (id, name, birthday, email)
values (4,
        'Laurette Crilly',
        '1966-06-29',
        'lcrilly3@technorati.com');


insert into employee (id, name, birthday, email)
values (5,
        'Wait Mathiassen',
        null,
        'wmathiassen4@state.tx.us');


insert into employee (id, name, birthday, email)
values (6,
        'Kalila Lezemore',
        null,
        'klezemore5@hc360.com');


insert into employee (id, name, birthday, email)
values (7,
        'Avigdor Messum',
        null,
        'amessum6@netlog.com');


insert into employee (id, name, birthday, email)
values (8,
        'Ferrel Carlozzi',
        '1905-05-06',
        'fcarlozzi7@skyrock.com');


insert into employee (id, name, birthday, email)
values (9,
        'Bond Pollastro',
        '1996-02-16',
        null);


insert into employee (id, name, birthday, email)
values (10,
        'Kaye Jaskiewicz',
        '1931-01-22',
        null);


insert into employee (id, name, birthday, email)
values (11,
        'Barde Cackett',
        '1964-09-17',
        'bcacketta@networksolutions.com');


insert into employee (id, name, birthday, email)
values (12,
        'Chico Burnes',
        null,
        null);


insert into employee (id, name, birthday, email)
values (13,
        'Kirsti Krysiak',
        '1928-03-03',
        'kkrysiakc@naver.com');


insert into employee (id, name, birthday, email)
values (14,
        'Esteban Benedit',
        '1936-02-16',
        'ebeneditd@domainmarket.com');


insert into employee (id, name, birthday, email)
values (15,
        'Fredia Dunphy',
        '1967-02-27',
        null);


insert into employee (id, name, birthday, email)
values (16,
        'Judie Wilde',
        '1984-03-25',
        'jwildef@ft.com');


insert into employee (id, name, birthday, email)
values (17,
        'Delilah Fowley',
        '1926-07-03',
        'dfowleyg@google.co.jp');


insert into employee (id, name, birthday, email)
values (18,
        'Miquela Luciani',
        '1947-11-10',
        'mlucianih@netvibes.com');


insert into employee (id, name, birthday, email)
values (19,
        'Royal Brealey',
        '1945-02-28',
        'rbrealeyi@google.com.hk');


insert into employee (id, name, birthday, email)
values (20,
        'Tanitansy Sharma',
        '1928-12-16',
        'tsharmaj@upenn.edu');


insert into employee (id, name, birthday, email)
values (21,
        'Roth Muspratt',
        null,
        'rmusprattk@admin.ch');


insert into employee (id, name, birthday, email)
values (22,
        'Clemmy Udell',
        '1988-12-30',
        null);


insert into employee (id, name, birthday, email)
values (23,
        'Dennie Soane',
        '1986-05-05',
        'dsoanem@stanford.edu');


insert into employee (id, name, birthday, email)
values (24,
        'Daphne Matveichev',
        '1964-08-06',
        'dmatveichevn@upenn.edu');


insert into employee (id, name, birthday, email)
values (25,
        'Sonja Gain',
        '1956-09-09',
        'sgaino@free.fr');


insert into employee (id, name, birthday, email)
values (26,
        'Gilbertine Schistl',
        '1963-09-23',
        'gschistlp@cmu.edu');


insert into employee (id, name, birthday, email)
values (27,
        'Conrade Gobourn',
        '2014-07-16',
        'cgobournq@abc.net.au');


insert into employee (id, name, birthday, email)
values (28,
        'Kristel Brason',
        '1912-04-08',
        'kbrasonr@prweb.com');


insert into employee (id, name, birthday, email)
values (29,
        'Urban Gormley',
        '1963-11-23',
        'ugormleys@chicagotribune.com');


insert into employee (id, name, birthday, email)
values (30,
        'Ettore Espina',
        '1906-05-20',
        'eespinat@ovh.net');


insert into employee (id, name, birthday, email)
values (31,
        'Caterina Vela',
        '1937-04-27',
        'cvelau@last.fm');


insert into employee (id, name, birthday, email)
values (32,
        'Arlette Gawthorpe',
        null,
        'agawthorpev@wix.com');


insert into employee (id, name, birthday, email)
values (33,
        'Riannon Mableson',
        null,
        'rmablesonw@wordpress.org');


insert into employee (id, name, birthday, email)
values (34,
        'Armin Yesipov',
        '1909-05-02',
        'ayesipovx@forbes.com');


insert into employee (id, name, birthday, email)
values (35,
        'Dom O''Criane',
        null,
        null);


insert into employee (id, name, birthday, email)
values (36,
        'Amabel Elderkin',
        null,
        'aelderkinz@trellian.com');


insert into employee (id, name, birthday, email)
values (37,
        'Clareta Maidlow',
        '2012-04-30',
        'cmaidlow10@npr.org');


insert into employee (id, name, birthday, email)
values (38,
        'Vannie Jandel',
        '1921-09-17',
        'vjandel11@hao123.com');


insert into employee (id, name, birthday, email)
values (39,
        'Huey Klagges',
        '1909-11-16',
        null);


insert into employee (id, name, birthday, email)
values (40,
        'Ringo Persent',
        '1964-06-13',
        'rpersent13@seattletimes.com');


insert into employee (id, name, birthday, email)
values (41,
        'Dodi Bradford',
        '1922-05-30',
        'dbradford14@sohu.com');


insert into employee (id, name, birthday, email)
values (42,
        'Horst Kobisch',
        '1963-05-26',
        'hkobisch15@shutterfly.com');


insert into employee (id, name, birthday, email)
values (43,
        'Launce Hatherall',
        null,
        null);


insert into employee (id, name, birthday, email)
values (44,
        'Kippie Thumann',
        '1948-03-25',
        'kthumann17@wufoo.com');


insert into employee (id, name, birthday, email)
values (45,
        'Gerhardt Aulds',
        '2018-04-20',
        'gaulds18@shutterfly.com');


insert into employee (id, name, birthday, email)
values (46,
        'Louella Ocklin',
        '1921-10-07',
        'locklin19@creativecommons.org');


insert into employee (id, name, birthday, email)
values (47,
        'Zane Patrono',
        '2017-01-26',
        'zpatrono1a@techcrunch.com');


insert into employee (id, name, birthday, email)
values (48,
        'Kamila Klaff',
        null,
        'kklaff1b@topsy.com');


insert into employee (id, name, birthday, email)
values (49,
        'Althea Camerello',
        '2016-05-12',
        'acamerello1c@yandex.ru');


insert into employee (id, name, birthday, email)
values (50,
        'Valaree Snoddin',
        '1963-02-24',
        'vsnoddin1d@google.com.br');

--3)Sütunların her birine göre diğer sütunları güncelleyecek 5 adet UPDATE işlemi yapalım.

UPDATE employee
SET id=1,
    name='Orhan Pamuk',
    birthday='1940-04-19',
    email='orhan@gmail.com'
WHERE id=1;


UPDATE employee
SET name = 'Pelin Su Başaslan',
    birthday = '1996-08-14',
    email = 'pelin.basaslan@gmail.com'
WHERE id BETWEEN 2 AND 5;

--4)Sütunların her birine göre ilgili satırı silecek 5 adet DELETE işlemi yapalım.

DELETE
FROM employee
WHERE ID <6;


DELETE
FROM employee
WHERE id=30;


DELETE
FROM employee
WHERE id=16;


DELETE
FROM employee
WHERE name LIKE 'A%';


DELETE
FROM employee
WHERE name LIKE '%n_%n__%';