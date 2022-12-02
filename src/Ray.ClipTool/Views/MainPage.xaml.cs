﻿using Ray.ClipTool.AppService;
using Ray.ClipTool.ViewModels;
using Volo.Abp.DependencyInjection;

namespace Ray.ClipTool;

public partial class MainPage : ContentPage, ISingletonDependency
{
    public MainPage(MainViewModel mainViewModel)
    {
        InitializeComponent();
        BindingContext = mainViewModel;

        MessagingCenter.Subscribe<MainViewModel>(this, "success", vm =>
        {
            DisplayAlert("Success!", "The video url are shown below, you can check it out and try to download it.", "OK");
        });
    }
}
