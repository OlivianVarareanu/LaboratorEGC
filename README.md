# Varareanu Olivian - 3133A

Raspunsuri LAB2

1. Un viewport este o regiune dreptunghiulară a ferestrei de afișare a unei aplicații grafice sau jocuri, în care se desenează sau se afișează conținutul grafic.
2. Conceptul de "frames per second" (FPS) în biblioteca OpenGL se referă la numărul de cadre sau imagini desenate pe ecran în fiecare secundă.
3. Metoda OnUpdateFrame() este rulată într-un ciclu de joc (game loop) și este responsabilă de actualizarea stării jocului sau aplicației grafice.
(immediate mode rendering) se referă la o tehnică mai veche de randare în OpenGL, în care obiectele și scenele sunt desenate imediat în funcție de instrucțiunile furnizate, fără a folosi un buffer intermediar sau o listă de afișare.
4. Ultima versiune de OpenGL care acceptă modul imediat de randare este OpenGL 3.0. După această versiune, modul imediat a fost depreciat și nu mai este inclus în specificațiile OpenGL.
5. Metoda OnRenderFrame() este rulată într-un ciclu de joc după ce metoda OnUpdateFrame() a actualizat starea jocului sau aplicației. Această metodă este responsabilă de randarea obiectelor și scenei pe ecran și de afișarea rezultatului final.
6. Metoda OnResize() trebuie să fie executată cel puțin o dată pentru a inițializa corect viewport-ul și pentru a ajusta raportul de aspect (aspect ratio) al scenei în funcție de dimensiunea ferestrei de afișare. Acest lucru asigură că conținutul este afișat corect și fără distorsiuni în funcție de dimensiunea ferestrei.
7. Metoda CreatePerspectiveFieldOfView() este utilizată pentru a crea o matrice de proiecție în OpenGL, care definește perspectiva unei scene 3D.
