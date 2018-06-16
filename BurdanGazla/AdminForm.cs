using System;
using System.Diagnostics;
using System.Windows.Forms;
using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolver.Ninject;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace BurdanGazla
{
    public partial class AdminForm : Form
    {
        private IAdService _adService;
        private ICityService _cityService;
        private ICarsService _carsService;
        public AdminForm()
        {
            InitializeComponent();
            _adService = InstanceFactory.GetInstance<IAdService>();
            _cityService = InstanceFactory.GetInstance<ICityService>();
            _carsService = InstanceFactory.GetInstance<ICarsService>();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            HandleException((() =>
           {
               LoadAd();
               LoadCity();
               LoadCars();

           }));

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            HandleException((() =>
            {
                AddingAd();
                LoadAd();
            }));

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            HandleException((() =>
            {
                UpdateAd();
                LoadAd();
            }));

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

        private void LoadAd()
        {
            DgwIlan.DataSource = _adService.GetAll();
        }

        private void LoadCity()
        {
            AddCityBox.ValueMember = "SehirID";
            AddCityBox.DisplayMember = "Sehir";
            AddCityBox.DataSource = _cityService.GetAll();

            UpdateCityComboBox.ValueMember = "SehirID";
            UpdateCityComboBox.DisplayMember = "Sehir";
            UpdateCityComboBox.DataSource = _cityService.GetAll();

        }

        private void LoadCars()
        {
            dgwCars.DataSource = _carsService.GetAll();
        }


        private void UpdateAd()
        {
            _adService.Update(new Ad
            {
                IlanID = Convert.ToInt32(DgwIlan.SelectedCells[0].Value.ToString()),
                Ilan_Adi = UpdateNameBox.Text,
                Ilan_Fiyat = Convert.ToDecimal(UpdatePriceBox.Text),
                Ilan_Km = Convert.ToDecimal(UpdateKmBox.Text),
                Ilan_Tarih = UpdateDateTimePicker.Value,
                Ilan_SehirID = Convert.ToInt32(UpdateCityComboBox.SelectedValue),
                Ilan_ArabaID = Convert.ToInt32(dgwCars.SelectedCells[0].Value.ToString())
            });
            MessageBox.Show("Ürün güncellendi.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HandleException(() =>
            {
                DeleteAd();
                LoadAd();
            });

        }

        private void DeleteAd()
        {
            _adService.Delete(new Ad
            {
                IlanID = Convert.ToInt32(DgwIlan.SelectedCells[0].Value.ToString()),
            });
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            HandleException(() =>
            {
                DeleteCar();
                LoadCars();
            });
        }

        private void DeleteCar()
        {
            _carsService.Delete(new Cars
            {
                ArabaID = Convert.ToInt32(dgwCars.SelectedCells[0].Value.ToString())
            });
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
