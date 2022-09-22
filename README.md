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


✍️ Jede User Story hat eine ganzzahlige Nummer (1, 2, 3 etc.), eine Verbindlichkeit (Muss oder Kann?), und einen Typ (Funktional, Qualität, Rand). Die User Story selber hat folgende Form: *Als ein 🤷‍♂️ möchte ich 🤷‍♂️, damit 🤷‍♂️*.

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe                                                                                                                |
| ---- | ------------ | ------- | -------------------------------------------------------------------------------------------------------------------------------- |
| 1.1  | Console App  | Benutzer gibt eine Zahl ein und drückt enter                                         |Es zeigt an, ob die Zufallszahl höher oder niedriger |                                                                                                               ist.                                                 |
| 1.2  | Console App  | Benutzer gibt true, false oder y,n ein und drückt enter                              |Das Spiel wird nach der Eingabe neu gestartet        | 
| 1.3  | Console App  | Benutzer muss am Anfang sehen, was die Mindest- und Höchstzahlen sind.               |Das Spiel zeigt die maximalen und minimalen Zahlen an|
| 1.4  | Console App  | Benutzer kann leicht durch die Benutzeroberfläche navigieren und versteht sie.       |Das Spiel is einfach zu verstehen                    |
| 1.5  | Console App  | Benutzer errät die richtige Zahl und es zeigt an, wie viele Versuche es gedauert hat.|Es zeigt die Anzahl der Versuche am Ende             |
| 1.6  | Console App  | Benutzer errät die richtige Nummer und es zeigt, welche Nummern verwendet wurden.    |Es zeigt die versuchten Zahlen am Ende.              |

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

### 1.4 Diagramme

✍️ Hier können Sie PAPs, Use Case- und Gantt-Diagramme oder Ähnliches einfügen.

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

Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum  | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ------ | --------- | ------------- | ----------------- |
| 1.A  | 1.Sept | Mohammad  |  30min        | 25min             |
| 1.B  | 8.Sept | Mohammad  |  60min        | 60min             |
| 3.A  | 8.Sept | Mohammad  |  60min        | 120min            |
| 2.C  | 1.Sept | Mohammad  |  30min        | 25min             |
| 2.A  | 8.Sept | Mohammad  |  60min        | 90min             |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
