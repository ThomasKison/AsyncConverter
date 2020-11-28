using System;
using System.Collections.ObjectModel;
using AsyncConverter.Models;
using AsyncConverter.Services;

namespace AsyncConverter.ViewModels
{
    public class MainPageViewModel
    {
        
        private ProductsService _productsService;
        public MainPageViewModel(ProductsService productsService)
        {
            _productsService = productsService;
            InitAsync();
        }

        private async void InitAsync()
        {
            var products = await _productsService.GetProducts();
            products.ForEach(Products.Add);
        }

        public ObservableCollection<Product> Products { get; } = new ObservableCollection<Product>();
    }
}
