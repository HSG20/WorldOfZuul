namespace WorldOfZuul;

class Inventory{
    public List<(string item, int count)> Items{get;set;}

    public Inventory(List<(string item,int count)> initial_items)
    {
        Items=initial_items;
    }
}