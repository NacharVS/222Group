using UnitsDrafts;

Barracs barracs = new Barracs();
TownHall TownHalls = new TownHall();

Archer[] archers = new Archer[3]
{
    barracs.CreateArcher(),
    barracs.CreateArcher(),
    barracs.CreateArcher()
};

Bishop[] bishops = new Bishop[4]
    {
        TownHalls.CreateBishop(),
        TownHalls.CreateBishop(),
        TownHalls.CreateBishop(),
        TownHalls.CreateBishop()
    };


      

Statistics.ShowStatistics();

bishops[2].ShowInfo();












