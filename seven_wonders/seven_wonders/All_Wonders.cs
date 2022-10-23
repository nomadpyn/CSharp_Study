using wonders;
    internal class All_Wonders
    {
    private readonly Pyramid_of_Cheops w1 = new Pyramid_of_Cheops();
    private readonly Gardens_of_Babylon w2 = new Gardens_of_Babylon();
    private readonly Zeus_Statue w3 = new Zeus_Statue();
    private readonly Temple_Of_Artemis w4 = new Temple_Of_Artemis();
    private readonly Halicarnassus_Mausoleum w5 = new Halicarnassus_Mausoleum();
    private readonly Colossus_Of_Rhodes w6 = new Colossus_Of_Rhodes();
    private readonly Alexandrian_Lighthouse w7 = new Alexandrian_Lighthouse();
    public void show_all_wonders() 
    {
        w1.show();
        w2.show();
        w3.show();
        w4.show();
        w5.show();
        w6.show();
        w7.show();
    }
}
