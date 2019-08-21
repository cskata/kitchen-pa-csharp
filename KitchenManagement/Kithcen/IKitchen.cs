using KitchenManagement.Staff;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitchenManagement.Kithcen
{
    interface IKitchen
    {
        void GetKitchenHelperWithIngredient(Ingredients randomIngredient);
    }
}
