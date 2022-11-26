<p align="center">
      <img src="https://i.ibb.co/bXbXPLn/Essential-db-logo.png" alt="Project Logo" width="726">
</p>

[![Made in Ukraine](https://img.shields.io/badge/made_in-ukraine-ffd700.svg?labelColor=0057b7)](https://github.com/PoixoN/essential-db)
[![Build](https://img.shields.io/github/workflow/status/Tyrrrz/CliFx/CI/master)](https://github.com/PoixoN/essential-db/actions)
[![Version](https://img.shields.io/nuget/v/CliFx.svg)](https://nuget.org/packages/CliFx)
[![Downloads](https://img.shields.io/nuget/dt/CliFx.svg)](https://nuget.org/packages/CliFx)
[![Fuck Russia](https://img.shields.io/badge/fuck-russia-e4181c.svg?labelColor=000000)](https://twitter.com/tyrrrz/status/1495972128977571848)

## About

Фрагментарна реалізація систем управління табличними базами даних

## І. Загальні вимоги

**Основні вимоги щодо структури бази:**

- кількість таблиць принципово не обмежена (реляції між таблицями не враховувати);
- кількість полів та кількість записів у кожній таблиці також принципово не обмежені.

**У кожній роботі треба забезпечити підтримку (для полів у таблицях) наступних (загальних для всіх варіантів!) типів:**

- integer;
- real;
- char;
- string.

**Також у кожній роботі треба реалізувати функціональну підтримку для:**

- створення бази;
- створення (із валідацією даних) та знищення таблиці з бази;
- перегляду та редагування рядків таблиці;
- збереження табличної бази на диску та, навпаки, зчитування її з диску.

## ІІ. Варіанти додаткових типів

**Потрібно забезпечити підтримку (для можливого використання у таблицях) двох додаткових типів у відповідності з одним із наступних варіантів:**

2. color (RGB код кольору); colorInvl;

Примiтка. Типи із суфіксом Invl (наприклад, colorInvl, integerInvl тощо) є "iнтервальними" типами.

## ІІІ. Варіанти додаткових операцiй над таблицями

**Потрібно реалізувати операцiї над таблицями у відповідності з варіантом:**

8. перейменування та/або перестановка колонок таблиці (з відповідною зміною схеми таблиці).

## Steps

- [Step 0 - Попередній етап](https://github.com/PoixoN/essential-db/blob/main/docs/Step0.md)
- [Step 1 - Використання UML](https://github.com/PoixoN/essential-db/blob/main/docs/Step1.md)
- [Step 2 - Розробка локальної + CLI](https://github.com/PoixoN/essential-db/blob/main/docs/Step2.md)
- [Step 3 - Unit тести + діаграма класів](https://github.com/PoixoN/essential-db/blob/main/docs/Step3.md)
- [Step 10 - REST web-сервіси](https://github.com/PoixoN/essential-db/blob/main/docs/Step10.md)
- [Step 11 - HATEOAS](https://github.com/PoixoN/essential-db/blob/main/docs/Step11.md)
- [Step 12 - Розробка OpenAPI Specificatio](https://github.com/PoixoN/essential-db/blob/main/docs/Step12.md)
- [Step 13 - Реалізація серверного проєкту (кодогенерація)](https://github.com/PoixoN/essential-db/blob/main/docs/Step13.md)
- [Step 14 - Реалізація клієнтського проєкту (кодогенерація)](https://github.com/PoixoN/essential-db/blob/main/docs/Step14.md)
- [Step 22 - Azure](https://github.com/PoixoN/essential-db/blob/main/docs/Step22.md)
- [Step 23 - Мікросервісна архітектура](https://github.com/PoixoN/essential-db/blob/main/docs/Step23.md)
- [Step 24 - Реляційна СУБД](https://github.com/PoixoN/essential-db/blob/main/docs/Step24.md)
