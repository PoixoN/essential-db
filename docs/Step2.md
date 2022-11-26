# Розробка локальної (не розподіленої) версії СУТБД (із власною реалізацією класів "Таблиця" та "База")

- Розробка (власних!) класів для понять "Таблиця", "База" та, можливо, деяких інших класів, спряжених із поняттям "Таблиця" (наприклад, "Схема таблиці", "Атрибут", "Рядок таблиці" тощо).
- Забезпечення інтерфейсу користувача на основі CLI

## Розробка (власних!) класів

- [Database](https://github.com/PoixoN/essential-db/blob/main/Database/EssentialDatabase.Core/Entities/Database.cs)
- [Table](https://github.com/PoixoN/essential-db/tree/main/Database/EssentialDatabase.Core/Entities/Table.cs)
- [Columns](https://github.com/PoixoN/essential-db/tree/main/Database/EssentialDatabase.Core/Entities/Columns)
- [Row](https://github.com/PoixoN/essential-db/tree/main/Database/EssentialDatabase.Core/Entities/Row.cs)

## Забезпечення інтерфейсу користувача на основі CLI

![CLI example](https://github.com/PoixoN/essential-db/blob/main/img/step_2/cli.jpg)

CLI розроблений на основі кінечних автоматів, де кожна команда це стан у автоматі.

- [CLI Manager](https://github.com/PoixoN/essential-db/blob/main/Database/EssentialDatabase.CLI/CLIManager.cs)
- [States](https://github.com/PoixoN/essential-db/tree/main/Database/EssentialDatabase.CLI/States)
- [Commands](https://github.com/PoixoN/essential-db/tree/main/Database/EssentialDatabase.CLI/Models)
- [Constants](https://github.com/PoixoN/essential-db/tree/main/Database/EssentialDatabase.CLI/Constants)
