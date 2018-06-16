using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolver.Ninject;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace BurdanGazla
{
    public partial class CustomerAddingAd : Form
    {
        private IAdService _adService;
        private ICityService _cityService;
        private ICarsService _carsService;
        public CustomerAddingAd()
        {
            InitializeComponent();
            _adService = InstanceFactory.GetInstance<IAdService>();
            _cityService = InstanceFactory.GetInstance<ICityService>();
            _carsService = InstanceFactory.GetInstance<ICarsService>();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {     
            HandleException(() =>
            {
                AddingAd();
                LoadAd();
            });
        }
        private void AddingAd()
        {
            _adService.Add(new Ad
            {
                Ilan_Adi = AddNameBox.Text,
                Ilan_Fiyat = Convert.ToDecimal(AddPriceBox.Text),
                Ilan_Km = Convert.ToDecimal(AddKmBox.Text),
                Ilan_Tarih = AddDateTimePicker.Value,
                Ilan_ArabaID = Convert.ToInt32(dgwCars.SelectedCells[0].Value.ToString()),
                Ilan_SehirID = Convert.ToInt32(AddCityBox.SelectedValue)
            });
            // Debug.WriteLine(""+AddDateTimePicker.Value+Convert.ToInt32(dgwCars.SelectedCells[0].Value.ToString()));
            MessageBox.Show("İlan Eklendi.");
        }

        private void CustomerAddingAd_Load(object sender, EventArgs e)
        {
            HandleException(() =>
            {
                LoadAd();
                LoadCity();
                LoadCars();
            });     
        }
        private void LoadAd()
        {
            DgwIlan.DataSource = _adService.GetAll();
        }

        private void LoadCity()
        {
            AddCityBox.ValueMember = "SehirID";
            AddCityBox.DisplayMember = "Sehir";
            AddCityBox.DataSource = _cityService.GetAll();

        }

        private void LoadCars()
        {
            dgwCars.DataSource = _carsService.GetAll();
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();

            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                throw;
            }
        }
    }
}
