using apbd_cw3;
//Nowy kontener
LiquidContainer c = new LiquidContainer(2.5, 100, 1000, 500, true);
//Załadowanie kontenera
c.loadUp(100);
//Statek i załadowanie kontenera na statek
Ship s = new Ship(11.4, 50, 7);
s.AddContainer(c);
