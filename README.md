# Projekt-Dokumentation

Mohammad Bashiri

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | -----------------------------------------------------------  |
| 25.8  | 1       | An den Projekt-Dokumentation gearbeitet.                     |
| 1.9   | 2       | Angefangen mit programmieren aber nicht weit gekommen.       |
| 8.9   | 3       | Mit programmieren bin ich fast fertig geworden und habe      |
|       |         | weiter an mein Projekt-Dokumentation.                        |
| 15.9  | 4       | Ich habe mein Programm fertig gemacht.                       |

## 1 Informieren

### 1.1 Ihr Projekt

Der Computer speichert eine Zufallszahl zwischen 1 und 100 als Geheimzahl, der Benutzer kann Zahlen erraten und der Computer gibt für jede der erratenen Zahlen einen Hinweis

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ        | Beschreibung                                                                                             |
| ---- | --------------- | ---------- | -------------------------------------------------------------------------------------------------------- |
| 1    |  Muss           | Funktional | Als Benutzer möchte ich eine Zahl eingeben, um zu wissen, ob sie höher oder niedriger ist                |
| 2    |  Muss           | Funktional | Als Benutzer möchte ich wieder spielen, wenn ich die Zahl richtig errate.                                |
| 3    |  Muss           | Funktional | Als Benutzer möchte ich wissen, was die Mindest- und Höchstzahlen sind.                                  |
| 4    |  Kann           | Qualität   | Als Benutzer möchte ich eine gut aussehende Benutzeroberfläche.                                          |
| 5    |  Kann           | Qualität   | Als Benutzer wäre es schön zu wissen, wie viele Versuche nötig waren, um die richtige Zahl zu erhalten.  |
| 6    |  Kann           | Qualität   | Als Benutzer wäre es schön zu wissen, welche Nummern ich zuvor versucht habe.                            |


### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe                                                                              |Erwartete Ausgabe                                    |
| ---- | ------------ | -------------------------------------------------------------------------------------|---------------------------------------------------- |
| 1.1  | Console App  | Benutzer gibt eine Zahl ein und drückt enter                                         |Es zeigt an, ob die Zufallszahl höher oder niedriger |                                                                                                                 ist.                                                 |
| 1.2  | Console App  | Benutzer gibt true, false oder y,n ein und drückt enter                              |Das Spiel wird nach der Eingabe neu gestartet        | 
| 1.3  | Console App  | Benutzer muss am Anfang sehen, was die Mindest- und Höchstzahlen sind.               |Das Spiel zeigt die maximalen und minimalen Zahlen an|
| 1.4  | Console App  | Benutzer kann leicht durch die Benutzeroberfläche navigieren und versteht sie.       |Das Spiel is einfach zu verstehen                    |
| 1.5  | Console App  | Benutzer errät die richtige Zahl und es zeigt an, wie viele Versuche es gedauert hat.|Es zeigt die Anzahl der Versuche am Ende             |
| 1.6  | Console App  | Benutzer errät die richtige Nummer und es zeigt, welche Nummern verwendet wurden.    |Es zeigt die versuchten Zahlen am Ende.              |


## 2 Planen

| AP-№ | Frist   | Zuständig | Beschreibung         | geplante Zeit |
| ---- | ------- | --------- | -------------------- | ------------- |
| 1.A  | 1.Sept  | Mohammad  | User Input           | 30 min        |
| 1.B  | 15.Sept | Mohammad  | Gestalten            | 1h            |    
| 2.A  | 1.Sept  | Mohammad  | lernen zu Gestalten  | 1h            |     
| 2.B  | 15.Sept | Mohammad  | Timer                | 1h            |     
| 2.C  | 1.Sept  | Mohammad  | Gewonnenmechanismus  | 2h            |     
| 2.D  | 8.Sept  | Mohammad  | Feedback             | 30min         |     
| 3.A  | 15.Sept | Mohammad  | Erneut Spielen       | 1h            |     

Total: 8h


## 3 Entscheiden

Eine schwere Entscheidung für mich war die Auswahl verschiedener Farben für die Konsole. Ich wusste nicht, was gut aussehen würde, und entschied mich schließlich für Blau und Weiß, wie Windows Powershell.

## 4 Realisieren

| AP-№ | Datum  | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ------ | --------- | ------------- | ----------------- |
| 1.A  | 1.Sept | Mohammad  |  30min        | 25min             |
| 1.B  | 8.Sept | Mohammad  |  60min        | 60min             |
| 3.A  | 8.Sept | Mohammad  |  60min        | 120min            |
| 2.C  | 1.Sept | Mohammad  |  30min        | 25min             |
| 2.A  | 8.Sept | Mohammad  |  60min        | 90min             |


## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  | 22.9  | Zeigte ob meine zu hoch oder zu niedrig war.|  ich   |
| 1.2  | 22.9  | Diese Funktion verlief nicht wie beabsichtigt. Es sagte danke fürs Spielen und das Programm wurde geschlossen.|  ich   |
| 1.3  | 22.9  | Die maximalen und minimalen Zahlen wurden zu Beginn angezeigt. |  ich   |
| 1.4  | 22.9  | Ich habe mich entschieden, hellere Farben für die Konsole auszuwählen, damit sie besser lesbar ist. |  ich   |
| 1.5  | 22.9  | Es hat mir am Ende gezeigt, wie viele Versuche ich gebraucht habe, um die richtige Nummer zu bekommen. |  ich   |
| 1.6  | 22.9  | Diese Funktion funktionierte nicht, weil ich nicht herausfinden konnte, wie ich sie zum Laufen bringen sollte. |  ich   |




## 6 Auswerten

https://github.com/ShaheerBashiri/verbose-telegram/blob/main/Lernbericht.md
