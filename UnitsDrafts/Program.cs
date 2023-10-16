using UnitsDrafts;

Barracs barracs = new Barracs();
var ft1 = barracs.CreateFootman();
var ft2 = barracs.CreateFootman();
var ft3 = barracs.CreateFootman();
var ft4 = barracs.CreateFootman();
Archer[] archers = new Archer[3]
{
    barracs.CreateArcher(),
    barracs.CreateArcher(),
    barracs.CreateArcher()
};

Statistics.ShowStatistics();














