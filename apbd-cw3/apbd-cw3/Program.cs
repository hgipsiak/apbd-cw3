using apbd_cw3;
//Nowy kontener
LiquidContainer c = new LiquidContainer(2.5, 100, 1000, 500, true);
//Załadowanie kontenera
c.LoadUp(100);
//Statek i załadowanie kontenera na statek
Ship s = new Ship(11.4, 50, 7);
s.AddContainer(c);
//Załadowanie listy kontenerów na statek
List<Container> l = new List<Container>();
Product p = new Product("Cheese", 7.2);
CoolingContainer cc = new CoolingContainer(2.5, 100, 1000, 500, 5.0, p);
LiquidContainer lc = new LiquidContainer(2.5, 100, 1000, 500, true);
GasContainer gc = new GasContainer(2.5, 100, 1000, 500, 1350.7);
cc.LoadUp(100);
lc.LoadUp(100);
gc.LoadUp(100);
l.Add(cc);
l.Add(lc);
l.Add(gc);
s.AddContainers(l);
//Usunięcie kontenera
s.RemoveContainer(c);
//Rozładowanie kontenera
c.Unload();
//Zamina kontenerów
s.ReplaceContainer(lc, c);
//Wymiana kontenerów pomiędzy dwoma statkami
Ship s1 = new Ship(11.4, 50, 7);
s.ExchangeContainer(s1, c);
//Informacje o kontenerze
c.ShowInfo();
Console.WriteLine();
//Informacje o statku i przewożonym ładunku
s.ShowInfo();
