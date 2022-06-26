using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPlace_2022.Shared {
    public class HardCodedMenuService : IMenuService {
        public ValueTask<Menu> GetMenu() => new ValueTask<Menu>(
            new Menu {
                Pizzas = new List<Pizza> {
                    new Pizza(1, "Dây Chuyền Bạc Nam", 8M, Spiciness.daychuyen),
                    new Pizza(2, "Nhẫn Bạc Nam", 7M, Spiciness.nhan),
                    new Pizza(3, "Vòng Tay Bạc Nam", 6M, Spiciness.vongtay)
                }
             });
    }
}

