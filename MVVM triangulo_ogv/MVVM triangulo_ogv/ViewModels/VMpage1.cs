﻿using MVVM_triangulo_ogv.Models;
using MVVM_triangulo_ogv.Views;
using MVVM_triangulo_ogv.VistaModelo;
using MVVM_triangulo_ogv.Vistas;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_triangulo_ogv.ViewModels
{
    public class VMpage1 : BaseViewModel
    {
        #region VARIABLES
        string _N1;
        string _N2;
        string _R;
        #endregion 
        #region CONSTRUCTOR
        public VMpage1(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region OBJETOS
        public string N1
        {
            get { return _N1; }
            set { SetValue(ref _N1, value); }
        }
        public string N2
        {
            get { return _N2; }
            set { SetValue(ref _N2, value); }
        }
        public string R
        {
            get { return _R; }
            set { SetValue(ref _R, value); }
        }
        #endregion
        #region PROCESOS
        public async Task NavegarPagina2()
        {
            await Navigation.PushAsync(new Page2());
        }
        public void Sumar()
        {
            double n1 = 0;
            double n2 = 0;
            double r = 0;

            n1 = Convert.ToDouble(N1);
            n2 = Convert.ToDouble(N2);
            r = Convert.ToDouble(r);

            r = n1 + n2;
            R = r.ToString();
        }
        #endregion
        #region COMANDOS
        public ICommand PNavegarpagina2command => new Command(async () => await NavegarPagina2());
        public ICommand Suymarcommand => new Command(Sumar);
        #endregion
    }
}