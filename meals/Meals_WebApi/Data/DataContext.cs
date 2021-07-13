using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Meals_WebApi.Models;

namespace Meals_WebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) { }        
        public DbSet<Meal> Meals { get; set; }        
        protected override void OnModelCreating(ModelBuilder builder)
        {                       
            builder.Entity<Meal>()
                .HasData(new List<Meal>(){
                    new Meal(1, "Pizza", "Massa", "Italia", "No liquidificador bata o leite, o ovo, o sal, o açúcar, a margarina, a farinha de trigo e o fermento em pó até que tudo esteja encorporado. Despeje a massa em uma assadeira para pizza untada com margarina e leve ao forno preaquecido por 20 minutos. Retire do forno e despeje o molho de tomate. Cubra a massa com mussarela ralada, tomate e orégano a gosto. Leve novamente ao forno até derreter a mussarela."),
                    new Meal(2, "Panqueca", "Massa", "Italia", "Bata no liquidificador os ovos, o leite, o óleo, e acrescente a farinha de trigo aos poucos. Após acrescentar toda a farinha de trigo, adicione sal a gosto. Misture a massa até obter uma consistência cremosa. Em uma panela, doure a cebola com o óleo e acrescente a carne. Acrescente o tomate picado e tampe novamente."),
                    new Meal(3, "Lasanha", "Massa", "Itália", "Cozinhe a massa segundo as orientações do fabricante, despeje em um refratário com água gelada para não grudar e reserve. Refogue o alho, a cebola, a carne moída, o molho de tomate, deixe cozinhar por 3 minutos e reserve. Derreta a margarina, coloque as 3 colheres de farinha de trigo e mexa, despeje o leite aos poucos e continue mexendo. Por último, coloque o creme de leite, mexa por 1 minuto e desligue o fogo Despeje uma parte do molho à bolonhesa em um refratário, a metade da massa, a metade do presunto, a metade da mussarela, todo o molho branco e o restante da massa .Repita as camadas até a borda do recipiente. Finalize com o queijo ralado e leve ao forno alto (220° C), preaquecido, por cerca de 20 minutos."),
                    new Meal(4, "Bolo de chocolate", "Bolos", "México", "Em uma batedeira, bata as claras em neve, acrescente as gemas, o açúcar e bata novamente. Adicione a farinha, o chocolate em pó, o fermento, o leite e bata por mais alguns minutos.Despeje a massa em uma forma untada e leve para assar em forno médio (180° C), preaquecido, por 40 minutos. Em uma panela, leve a fogo médio o chocolate em pó, a manteiga e o leite, deixe até ferver.Despeje quente sobre o bolo já assado."),
                    // new Meal(5, "Paçoca de pinhão"),
                    // new Meal(6, "Brigadeiro"),
                    // new Meal(7, "Frago frito")
                });
    }
}
}