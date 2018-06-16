using System;
using System.Diagnostics;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolver.Ninject;

namespace BurdanGazla
{
    public partial class SearchForm : Form
    {
        private IAdService _adService;
        private ICityService _cityService;
        private IColorService _colorService;
        private ICarsService _carsService;
        private IGearService _gearService;
        private IFuelService _fuelService;
        public SearchForm()
        {
            InitializeComponent();
            _adService = InstanceFactory.GetInstance<IAdService>();
            _cityService = InstanceFactory.GetInstance<ICityService>();
            _colorService = InstanceFactory.GetInstance<IColorService>();
            _carsService = InstanceFactory.GetInstance<ICarsService>();
            _gearService = InstanceFactory.GetInstance<IGearService>();
            _fuelService = InstanceFactory.GetInstance<IFuelService>();

        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            HandleException(() =>
              {
                  LoadAd();
                  LoadCity();
                  LoadColor();
                  LoadGears();
                  LoadFuels();
                  FuelBox.SelectedIndex = -1;
                  gearComboBox.SelectedIndex = -1;
                  ColorComboBox.SelectedIndex = -1;
                  CityComboBox.SelectedIndex = -1;

              });         
        }

        private void LoadAd()
        {
            DgwIlan.DataSource = _adService.GetAll();
        }

        private void LoadCity()
        {
            CityComboBox.ValueMember = "SehirID";
            CityComboBox.DisplayMember = "Sehir";
            CityComboBox.DataSource = _cityService.GetAll();

        }
        private void LoadColor()
        {
            ColorComboBox.ValueMember = "RenkID";
            ColorComboBox.DisplayMember = "Renk";
            ColorComboBox.DataSource = _colorService.GetAll();

        }
        private void LoadGears()
        {
            gearComboBox.ValueMember = "VitesTuruID";
            gearComboBox.DisplayMember = "VitesTuru";
            gearComboBox.DataSource = _gearService.GetAll();

        }
        private void LoadFuels()
        {
            FuelBox.ValueMember = "YakitTuruID";
            FuelBox.DisplayMember = "YakitTuru";
            FuelBox.DataSource = _fuelService.GetAll();

        }

        private void CityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CityComboBox.SelectedIndex == -1)
            {
                LoadAd();
            }
            else
            {
                try
                {
                    DgwIlan.DataSource = _adService.GetAdByCity(Convert.ToInt32(CityComboBox.SelectedValue));
                }
                catch
                {

                }
            }
        }

        private void NameSearch_TextChanged(object sender, EventArgs e)
        {
            if(CityComboBox.SelectedIndex !=-1 && NameSearch.Text!="")
            //HandleException(GetAdByName);
            HandleException(GetAdByName);
        }
     //   Sample
        //private void GetAdByCityAndName()
        //{
        //    if (!String.IsNullOrEmpty(NameSearch.Text))
        //    {
        //        DgwIlan.DataSource = _adService.GetAdbByCityandName(Convert.ToInt32(CityComboBox.SelectedValue), NameSearch.Text);
        //    }
        //    else
        //    {
        //        LoadAd();
        //    }           
        //}
        private void GetAdByName()
        {
            if (!String.IsNullOrEmpty(NameSearch.Text))
            {
                DgwIlan.DataSource = _adService.GetAdByAdName(NameSearch.Text);
            }
            else
            {
                LoadAd();
            }
        }

        private void ColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ColorComboBox.SelectedIndex == -1)
            {
                LoadAd();
            }
            else
            {
                try
                {
                    DgwIlan.DataSource =
                        _adService.GetAdByCarsId(
                            _carsService.GetCarsByColor(Convert.ToInt32(ColorComboBox.SelectedValue)));

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    throw;
                }

            }
        }

        private void gearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gearComboBox.SelectedIndex == -1)
            {
                LoadAd();
            }
            else
            {
                try
                {
                    DgwIlan.DataSource =
                        _adService.GetAdByCarsId(
                            _carsService.GetCarsByGear(Convert.ToInt32(gearComboBox.SelectedValue)));

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    throw;
                }

            }
        }

        private void FuelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FuelBox.SelectedIndex == -1)
            {
                LoadAd();
            }
            else
            {
                try
                {
                    DgwIlan.DataSource =
                        _adService.GetAdByCarsId(
                            _carsService.GetCarsByFuel(Convert.ToInt32(FuelBox.SelectedValue)));

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    throw;
                }

            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            HandleException(SearchByKm);
        }

        private void SearchByKm()
        {
            if (minKmBox.Text != "" && maxKmBox.Text != "")
            {
                DgwIlan.DataSource = _adService.GetAdByAdKm(minKmBox.Text, maxKmBox.Text);
            }
            else if (minKmBox.Text == "" && maxKmBox.Text != "")
            {
                var min = "0";
                DgwIlan.DataSource = _adService.GetAdByAdKm(min, maxKmBox.Text);
            }
            else
            {
                MessageBox.Show(@"Lütfen Filtreleme kutularını doldurun!");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HandleException(SearchByPrice);
        }

        private void SearchByPrice()
        {
            if (minPriceBox.Text != "" && maxPriceBox.Text != "")
            {
                DgwIlan.DataSource = _adService.GetAdByAdPrice(minPriceBox.Text, maxPriceBox.Text);
            }
            else if (minPriceBox.Text == "" && maxPriceBox.Text != "")
            {
                var min = "0";
                DgwIlan.DataSource = _adService.GetAdByAdPrice(min, maxPriceBox.Text);
            }
            else
            {
                MessageBox.Show(@"Lütfen Filtreleme kutularını doldurun!");
            }
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            UptoDownRanking();
        }

        private void UptoDownRanking()
        {
            //  DgwIlan.DataSource = _adService.GetAdByUpToDown();
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
