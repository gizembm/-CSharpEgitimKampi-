using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.Location.Count().ToString();
            lblSumCapasity.Text = db.Location.Sum(x=> x.LocationCapacity).ToString();
            lblGuideCount.Text = db.Guide.Count().ToString();
            lblAvgCapasity.Text = ((decimal)db.Location.Average(x => x.LocationCapacity)).ToString("F2");
            lblAvgLocationPrice.Text = ((decimal)db.Location.Average(x => x.LocationPrice)).ToString("F2") + " ₺";

            int lastCountyId = db.Location.Max(x => x.LocationId);
            lblLastCountryName.Text = db.Location.Where(x=> x.LocationId == lastCountyId).Select(y=> 
                   y.LocationCountry).FirstOrDefault().ToString();

            lblCappodociaLocationCapasity.Text = db.Location.Where(x=> x.LocationCity == "Kapadokya").Select(y=>
                   y.LocationCapacity).FirstOrDefault().ToString();

            lblAvgTurkeyLocation.Text = ((decimal)db.Location.Where(x=> x.LocationCountry == "Türkiye").Average(y=>
                   y.LocationCapacity)).ToString("F2");

            var romaGuideId = db.Location.Where(x=> x.LocationCity == "Roma").Select(y=> y.GuideId).FirstOrDefault();
            lblRomaGuide.Text = db.Guide.Where(x=> x.GuideId == romaGuideId).Select(y=> y.GuideName + " " +
                    y.GuideSurname).FirstOrDefault();

            var maxCapasity = db.Location.Max(x => x.LocationCapacity);
            lblMaxCapasityLocation.Text = db.Location.Where(x=> x.LocationCapacity == maxCapasity).Select(y=> 
                    y.LocationCity).FirstOrDefault();

            var maxPrice = db.Location.Max(x => x.LocationPrice);
            lblMaxPriceLocation.Text = db.Location.Where(x=> x.LocationPrice == maxPrice).Select(y=> 
                    y.LocationCity).FirstOrDefault();

            var guideByNameGizemEfe = db.Guide.Where(x => x.GuideName == "Gizem" && x.GuideSurname == "Efe").Select(y =>
                    y.GuideId).FirstOrDefault();
            lblGizemLocationCount.Text = db.Location.Where(x=> x.GuideId == guideByNameGizemEfe).Count().ToString();

            lblAtinaDayNight.Text = db.Location.Where(x=> x.LocationCity == "Atina").Select(y=>
                    y.DayNight).FirstOrDefault();


            var guideByNameAysegulCinar = db.Guide.Where(x => x.GuideName == "Ayşegül" && x.GuideSurname == "Çınar").Select(y =>
                   y.GuideId).FirstOrDefault();
            lblByNameAysegulCinarLocation.Text = db.Location.Where(x => x.GuideId == guideByNameAysegulCinar).Count().ToString();

            var minPrice = db.Location.Min(x => x.LocationPrice);
            lblMinLocation.Text = db.Location.Where(x=> x.LocationPrice == minPrice).Select(y=> 
                    y.LocationCity).FirstOrDefault();

            int lastGuide = db.Guide.Max(x => x.GuideId);
            lblLastGuide.Text = db.Guide.Where(x=> x.GuideId == lastGuide).Select(y=> y.GuideName + " " +
                   y.GuideSurname).FirstOrDefault();
                    




        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
