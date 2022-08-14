using ContosoPizza.Models;

namespace ContosoPizza.Services;

public static class PizzaService
{
    static List<Pizza> Pizzas { get; }
    static int nextID = 3;
    static PizzaService()
    {
        Pizzas = new List<Pizza>
        {
            new Pizza {Id = 1, name = "Classic Italian", IsGlutenFree = false },
            new Pizza {Id = 2, name = "Veggie", IsGlutenFree = true}
        };
    }
    public static List<Pizza> GetAll() => Pizzas;
    
    public static Pizza? Get(int id) => Pizzas.FirstOrDefault(p => p.Id == id);

    public static void Add(Pizza pizza)
    {
        pizza.Id = nextID++;
        Pizzas.Add(pizza);
    }

    public static void Delete(int id)
    {
        var pizza = Get(id);
        if(pizza is null)
        return;

        Pizzas.Remove(pizza):
    }

    public static void Update(Pizza pizza)
    {
        var index = Pizzas.FindIndex(p => p.Id == pizza.id);
        if (index == -1)
        return;

        Pizzas[index] = pizza;
    }
}