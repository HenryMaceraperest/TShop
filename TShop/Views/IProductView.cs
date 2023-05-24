using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TShop.Views
{
    public interface IProductView
    {
        // Properties
        string ProductId { get; set; }
        string ProductName { get; set;}
        string ProductType { get; set; }
        string ProductQuantity { get; set; }
        bool ProductAgeLimit { get; set; }
        long ProductBarcode { get; set; }
        decimal ProductCost { get; set; }

        string SearchValue { get; set; }
        bool IsEdited { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        // Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        // Methods
        void SetProductListBindingSource(BindingSource productList);
        void Show();
    }
}