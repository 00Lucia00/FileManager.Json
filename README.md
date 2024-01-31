# JsonDictionaryTests

I denna uppgift arbeta vi med att skapa och implementera testfall för en applikation som hanterar
skapandet och hanteringen av JSON-filer med hjälp av dictionaries. Målet är att säkerställa applikationens
robusthet och korrekthet genom att skapa testfall för dynamiskt genererade JSON-strukturer.

Du kommer att använda Dictionary<string, object> för att dynamiskt skapa JSON-data. Ditt uppdrag är att skriva
testfall som validerar funktionerna i en JsonFileManager , som hanterar skapande, läsning och uppdatering av
JSON-filer.

**Specifikation**
Utgå från en konsol-applikation.
Fråga användaren vad den fill göra (läsa/skriva filer).
Om den vill läsa: Fråga om namnet på filen den vill läsa.
Om den vill skriva: Fråga om namnen på varje input samt deras värde (spara i en Dictionary<string,
object>.
Skapa JSON-filer från dictionaries.
Läsa och visa innehåll från befintliga JSON-filer.
Uppdatera innehåll i befintliga JSON-filer genom att använda dictionaries.
Validera JSON-strukturen med FluentAssertions.

**Testfall som ska implementeras**
1. TestCreateJsonFile: Validera att en JSON-fil skapas korrekt från en dictionary.
2. TestReadJsonFile: Kontrollera att innehåll från en befintlig fil läses korrekt och kan mappas till en dictionary.
3. TestUpdateJsonFile: Se till att uppdateringar i en dictionary korrekt återspeglas i den sparade JSON-filen.
4. TestJsonStructureValidation: Använd FluentAssertions för att validera dynamiskt genererade JSONstrukturer.
5. TestErrorHandlingFileNotFound: Verifiera att applikationen hanterar scenarier där filer inte hittas korrekt.
6. TestUserInputValidation: Kontrollera att användarinput som lagras i en dictionary valideras innan den
konverteras till JSON.

**Krav för Testimplementation**
Använd XUnit för att skriva och köra dina testfall.
Använd FluentAssertions för att validera JSON-strukturer som skapas från dictionaries.
Tänk på testa situationer där vi förväntar oss fel.
Dokumentera dina testfall och deras resultat tydligt
