using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TShop.Models;
using TShop.Views;

namespace TShop.Presenter
{
    public class ProductPresenter
    {
        // Fields
        private IProductView view;
        private IProductRepository repository;
        private BindingSource productBindingSource;
        private IEnumerable<ProductModel> productList;

        // Constructor
        public ProductPresenter(IProductView view, IProductRepository repository)
        {
            this.productBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            // Subscribe event handler methods to view events

            this.view.SearchEvent += SearchProduct;
            this.view.AddNewEvent += AddNewProduct;
            this.view.EditEvent += EditProduct;
            this.view.DeleteEvent += DeleteSelectedProduct;
            this.view.SaveEvent += SaveProduct;
            this.view.CancelEvent += CancelAction;
            // Set product binding source
            this.view.SetProductListBindingSource(productBindingSource);
            // Load product list view
            LoadAllProducts();
            // Show view
            this.view.Show();

        }

        private void LoadAllProducts()
        {
            productList = repository.GetAll();
            productBindingSource.DataSource = productList;
        }

        private void SearchProduct(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false) 
            {
                productList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                productList = repository.GetAll();
            }
            productBindingSource.DataSource = productList;
        }

        private void AddNewProduct(object? sender, EventArgs e)
        {
            view.IsEdited = false;
        }

        private void EditProduct(object? sender, EventArgs e)
        {
            var product = (ProductModel)productBindingSource.Current;
            view.ProductId = product.Id.ToString();
            view.ProductName = product.Name;
            view.ProductType = product.Type;
            view.ProductQuantity = product.Quantity;
            view.ProductAgeLimit = product.AgeLimit;
            view.ProductBarcode = product.Barcode;
            view.ProductCost = product.Cost;
            view.IsEdited = true;
        }

        private void SaveProduct(object? sender, EventArgs e)
        {
            var model = new ProductModel();
            model.Id = Convert.ToInt32(view.ProductId);
            model.Name = view.ProductName;
            model.Type = view.ProductType;
            model.Quantity = view.ProductQuantity;
            model.AgeLimit = view.ProductAgeLimit;
            model.Barcode = view.ProductBarcode;
            model.Cost = view.ProductCost;
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdited) 
                {
                    repository.Edit(model);
                    view.Message = "Edit saved successfully!";
                }
                else 
                {
                    repository.Add(model);
                    view.Message = "Successfully saved new product!";
                }
                view.IsSuccessful = true;
                LoadAllProducts();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.ProductId = "0";
            view.ProductName = "";
            view.ProductType = "";
            view.ProductQuantity = "";
            view.ProductAgeLimit = false;
            view.ProductBarcode = 0;
            view.ProductCost = 0;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void DeleteSelectedProduct(object? sender, EventArgs e)
        {
            try
            {
                var product = (ProductModel)productBindingSource.Current;
                repository.Delete(Convert.ToInt32(product.Id));
                view.IsSuccessful = true;
                view.Message = "Product deleted successfully!";
                LoadAllProducts();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Error! Could not delete the product!";
            }
        }
    }
}
