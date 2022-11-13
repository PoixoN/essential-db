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

## Stages

- [Stage 0](https://github.com/PoixoN/essential-db/blob/main/docs/Step0.md)
- [Stage 1](https://github.com/PoixoN/essential-db/blob/main/docs/Step1.md)
- [Stages 2-3](https://github.com/PoixoN/essential-db/blob/main/docs/Step2-3.md)
- [Stage 10](https://github.com/PoixoN/essential-db/blob/main/docs/Step10.md)
- [Stage 11](https://github.com/PoixoN/essential-db/blob/main/docs/Step11.md)
- [Stage 12](https://github.com/PoixoN/essential-db/blob/main/docs/Step12.md)
- [Stage 22](https://github.com/PoixoN/essential-db/blob/main/docs/Step22.md)
- [Stage 23](https://github.com/PoixoN/essential-db/blob/main/docs/Step23.md)
- [Stage 24](https://github.com/PoixoN/essential-db/blob/main/docs/Step24.md)
- [Stage 25](https://github.com/PoixoN/essential-db/blob/main/docs/Step25.md)

## License

Project is distributed under the MIT license.

**Burning-Lab Registry:**

```json
{
  "name": "Burning-Lab Registry",
  "url": "https://packages.burning-lab.com",
  "scopes": ["com.burning-lab"]
}
```

## Documentation

### Settings:

- **-** **`Swipe Detection Mode (DetectionMode)`** - Swipes detection mode.

- **-** **`Min Swipe Distance (float)`** - Minimum swipe length.

- **-** **`Is Paused (bool)`** - Pause. If the value is `true`, the component does not process swipes and does not raise events.

### Configuration defines:

- `DEBUG_BURNING_LAB_SDK` - Output all Burning-Lab sdk logs.

- `DEBUG_SWIPE_DETECTOR` - Output swipe detector logs only.

### Examples:

- **-** **`BurningLab/SwipeDetector/Examples/Scenes/SwipeInputDemoScene`**

## Distribute

- [packages.burning-lab.com](https://packages.burning-lab.com/-/web/detail/com.burning-lab.swipedetector)
