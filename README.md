# Varareanu Olivian - 3133A

## **Raspunsuri LAB2**

1. Un viewport este o regiune dreptunghiulară a ferestrei de afișare a unei aplicații grafice sau jocuri, în care se desenează sau se afișează conținutul grafic.
2. Conceptul de "frames per second" (FPS) în biblioteca OpenGL se referă la numărul de cadre sau imagini desenate pe ecran în fiecare secundă.
3. Metoda OnUpdateFrame() este rulată într-un ciclu de joc (game loop) și este responsabilă de actualizarea stării jocului sau aplicației grafice.
(immediate mode rendering) se referă la o tehnică mai veche de randare în OpenGL, în care obiectele și scenele sunt desenate imediat în funcție de instrucțiunile furnizate, fără a folosi un buffer intermediar sau o listă de afișare.
4. Ultima versiune de OpenGL care acceptă modul imediat de randare este OpenGL 3.0. După această versiune, modul imediat a fost depreciat și nu mai este inclus în specificațiile OpenGL.
5. Metoda OnRenderFrame() este rulată într-un ciclu de joc după ce metoda OnUpdateFrame() a actualizat starea jocului sau aplicației. Această metodă este responsabilă de randarea obiectelor și scenei pe ecran și de afișarea rezultatului final.
6. Metoda OnResize() trebuie să fie executată cel puțin o dată pentru a inițializa corect viewport-ul și pentru a ajusta raportul de aspect (aspect ratio) al scenei în funcție de dimensiunea ferestrei de afișare. Acest lucru asigură că conținutul este afișat corect și fără distorsiuni în funcție de dimensiunea ferestrei.
7. Metoda CreatePerspectiveFieldOfView() este utilizată pentru a crea o matrice de proiecție în OpenGL, care definește perspectiva unei scene 3D.

## **Raspunsuri LAB3**

1. Ordinea de desenare este in sens orar.
2. Anti-aliasing este o tehnică folosită în grafică pentru a îmbunătăți calitatea randării imaginilor pentru a netezi marginile obiectelor din cadrul vizual.
3. Comanda GL.lineWidth(float) setează lățimea liniilor la valoarea argumentului. GL.PointSize(float) setează dimensiunea punctelor. Aceste comenzi nu funcționează în interiorul unei zone glBegin().
4.  - LineLoop - vertexurile sunt conectatein ordine pentru a forma o bucla inchisa de linii.
    - LineStrip - vertexurile sunt conectate in ordine, creand un sir continuu de linii. fiecare linie este trasata intre un vertex si urmatorul sir.
    - TriangleFan - primul vertex specificat este conectat la fiecare alt vertex pentru a forma un set de triunghiuri.
    - TriangleStrip - fiecare triunghi este format din trei vertex consecutivi si se adauga un nou vertex pentru fiecare triunghi nou. Acest mod poate fi folosit pentru a crea fasii continue de triunghiuri conectate intre ele.
6. Folosirea culorilor diferite poate fi utila in mai multe cazuri, cum ar fi: perceptia formei si adancimii, diferentierea obiectelor, indicarea materialului si a texturii, aspectul estetic, imbunatatirea eficientei de lucru.
7. Un gradient de culoare reprezinta o tranzitie treptata intre doua sau mai multe culori. Pentru a se obtine un gradient de culoare, putem seta doua vertexuri de culori diferite iar cand vom desena linia ce va trece prin aceste doua puncte, OpenGL va face in mod automat tranzitia gradientului de culoare.
10. Cand folosim modul strip specificarea culorilor are un efect vizual semnificativ.
