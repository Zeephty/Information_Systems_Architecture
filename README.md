# InformationSystemsArchitecture

Учебный проект по архитектуре приложений. Сущность — **Робот**.

## Архитектура

```
RobotApp.Model — изолированный слой (сущность + бизнес-логика)
RobotApp.WinForms — многооконное представление
RobotApp.Console — консольное представление
```

Представления зависят только от `InformationSystemsArchitecture.Model`. Модель не знает о представлениях.

## Сущность «Робот»

Свойства: `Id`, `Number`, `Series`, `Type`, `Name`, `Goal`, `Details`, `Appearance`, `Score`, `CriteriaCodes`, `PriceRub`.

## Бизнес-логика (`Logic`)

| Метод | Назначение |
|---|---|
| `Add` | Создание робота |
| `GetById` / `GetAll` | Чтение |
| `Update` | Изменение |
| `Delete` | Удаление |
| `GroupByType` | БФ №1: группировка роботов по типу |
| `AveragePriceBySeries` | БФ №2: средняя цена по серии |
| `Save` / `Load` | Сохранение и загрузка из JSON |

## Хранение данных

Каждое представление использует **свой файл** `robots.json` рядом со своим `.exe`:

- InformationSystemsArchitecture.WinForms/bin/Debug/net8.0/robots.json
- InformationSystemsArchitecture.Console/bin/Debug/net8.0/robots.json


Приложения независимы: изменения в одном не влияют на другое.

## Ветки и релиз

| Ветка | Назначение |
|---|---|
| `develop` | Основная разработка. Все коммиты идут сюда |
| `main` | Только релизы. Обновляется через Pull Request на GitHub |

**Процесс релиза:**
1. Работа ведётся в `develop`.
2. По готовности — на GitHub создаётся Pull Request `develop → main`.
3. После ревью PR мержится через веб-интерфейс GitHub.
4. `main` всегда содержит стабильную версию.

## Требования

- .NET 8 SDK
- Windows (для WinForms)