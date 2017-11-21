using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Appointed.ViewModels;
using System.Globalization;
using Appointed.Classes;

namespace Appointed.Models
{
    class AppointmentDatabaseModel
    {
        public List<Appointment> _pearsonEmpty;
        public List<Appointment> _specterEmpty;
        public List<Appointment> _paulsenEmpty;

        public List<Appointment> _pearsonNovember032017;
        public List<Appointment> _pearsonNovember042017;
        public List<Appointment> _pearsonNovember052017;
        public List<Appointment> _pearsonNovember062017;
        public List<Appointment> _pearsonNovember072017;
        public List<Appointment> _pearsonNovember082017;
        public List<Appointment> _pearsonDecember052017;
        public List<Appointment> _pearsonDecember152017;
        public List<Appointment> _pearsonDecember162017;


        public List<Appointment> _specterNovember032017;
        public List<Appointment> _specterNovember042017;
        public List<Appointment> _specterNovember052017;
        public List<Appointment> _specterNovember062017;
        public List<Appointment> _specterNovember072017;
        public List<Appointment> _specterNovember082017;
        public List<Appointment> _specterDecember052017;
        public List<Appointment> _specterDecember152017;
        public List<Appointment> _specterDecember162017;


        public List<Appointment> _paulsenNovember032017;
        public List<Appointment> _paulsenNovember042017;
        public List<Appointment> _paulsenNovember052017;
        public List<Appointment> _paulsenNovember062017;
        public List<Appointment> _paulsenNovember072017;
        public List<Appointment> _paulsenNovember082017;
        public List<Appointment> _paulsenDecember052017;
        public List<Appointment> _paulsenDecember152017;
        public List<Appointment> _paulsenDecember162017;

        public AppointmentDatabaseModel()
        {
            _pearsonEmpty = new List<Appointment>
            {
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            };

            _pearsonNovember032017 = new List<Appointment>
            {
            // One
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Mike Ross", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "James Dean", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Jeremy Pumpkinspice", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4"},

            // Two
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Marcus Tonality", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Evangelinous Konstantinos", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Three
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Spam Is My Favorite", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Origami Rules", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },

            // Four
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Trick Thomas", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Mary Ross", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Consultation", Height = "70", Margin = "0,2,0,0", Patient = "Brody Jackson", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Collapsed", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
     
            // Five
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Mandy Ross", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Consultation", Height = "70", Margin = "0,2,0,0", Patient = "Frodo Baggins", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Collapsed", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            
            // Six
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Mark Ross", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Moby Ross", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Morton Ross", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            
            // Seven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Meeves Ross", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Meepus Ross", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Moriarty Ross", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            
            // Eight
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Eminem", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Funny Fred", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            
            // Nine
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Ten
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eleven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Twelve
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            };


            _pearsonNovember042017 = new List<Appointment>
            {
            // One
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Mike Ross", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "James Dean", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Two
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Three
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Tappity Thomas", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Consultation", Height = "70", Margin = "0,2,0,0", Patient = "Liam Schoepp", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Collapsed", Cursor = "Hand", RowSpan = "1", Opacity = "0"},

            // Four
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Consultation", Height = "70", Margin = "0,2,0,0", Patient = "Orville Reddenschtapper", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Collapsed", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Five
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            
            // Six
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Xylogioanoupolous, Chwawaaagaraonopouus", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Kerry Hart", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Seven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Spilly Susan", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Madison Ross", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eight
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Crunching Kathy", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Nine
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Ten
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eleven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Twelve
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            };


            _pearsonNovember052017 = new List<Appointment>
            {
            // One
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Two
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Consultation", Height = "70", Margin = "0,2,0,0", Patient = "Brody Jackson's Aunty", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Collapsed", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Three
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Consultation", Height = "70", Margin = "0,2,0,0", Patient = "George Martin", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Collapsed", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Four
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Consultation", Height = "70", Margin = "0,2,0,0", Patient = "Liam Schoepp", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Collapsed", Cursor = "Hand", RowSpan = "1", Opacity = "0"},

            // Five
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0",  Patient = "Kerry Josephson", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Scary Larry", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Six
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Seven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eight
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Nine
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Ten
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eleven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Twelve
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            };


            _pearsonNovember062017 = new List<Appointment>
            {
            // One
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Consultation", Height = "70", Margin = "0,2,0,0", Patient = "Freddison", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Collapsed", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Brody Jackson", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            //Two
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Three
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Four
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Five
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Consultation", Height = "70", Margin = "0,2,0,0", Patient = "Dabin Lamming", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Collapsed", Cursor = "Hand", RowSpan = "1", Opacity = "0"},

            // Six
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Seven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eight
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Nine
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Ten
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eleven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Twelve
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            };


            _pearsonNovember072017 = new List<Appointment>
            {
            // One
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Consultation", Height = "70", Margin = "0,2,0,0", Patient = "George Martin", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Collapsed", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Two
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Trick Thomas", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Mary Ross", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },

            // Three
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Four
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Consultation", Height = "70", Margin = "0,2,0,0", Patient = "James Aberdeen", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Collapsed", Cursor = "Hand", RowSpan = "1", Opacity = "0"},

            // Five
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Consultation", Height = "70", Margin = "0,2,0,0", Patient = "Brody Jackson", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Collapsed", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Six
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Mandy Ross", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Seven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Consultation", Height = "70", Margin = "0,2,0,0", Patient = "Frodo Baggins", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Collapsed", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eight
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Nine
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Ten
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eleven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Twelve
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            };


            _pearsonNovember082017 = new List<Appointment>
            {
            // One
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Two
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Three
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Consultation", Height = "70", Margin = "0,2,0,0", Patient = "Harry Potter", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Collapsed", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Nuisance Nancy", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Four
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            // Five
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Six
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Seven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Annoying Albert", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eight
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            
            // Nine
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Ten
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eleven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Twelve
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            };


            _pearsonDecember052017 = new List<Appointment>
            {
            // One
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Two
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Consultation", Height = "70", Margin = "0,2,0,0", Patient = "Mary Poppins", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Collapsed", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Freddison", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Three
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Consultation", Height = "70", Margin = "0,2,0,0", Patient = "Kerry Hart", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Four
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "James Dean", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Melvin Ross", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            // Five
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Odor Onus", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Consltation", Height = "70", Margin = "0,2,0,0", Patient = "Scary Larry", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },

            // Six
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Consultation", Height = "70", Margin = "0,2,0,0", Patient = "Dr. Dre", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Seven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Cornell Smith", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eight
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            
            // Nine
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Ten
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eleven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Twelve
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            };


            _pearsonDecember152017 = new List<Appointment>
            {
            // One
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Marc Ross", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Molly Ross", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Two
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Three
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Max Ross", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Four
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Melvin Ross", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            // Five
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Marylin Ross", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Six
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Seven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eight
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            
            // Nine
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Marylin Ross", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Mr. No Chill", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Ten
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eleven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Twelve
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            };


            _pearsonDecember162017 = new List<Appointment>
            {
            // One
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Consultation", Height = "70", Margin = "0,2,0,0", Patient = "Star Buck", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },

            // Two
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Collapsed", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "George Martin", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "James Aberdeen", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Three
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Four
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            // Five
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Six
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Seven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eight
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            
            // Nine
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Ten
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eleven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Twelve
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Pearson", Colour = "DarkTurquoise", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            };









            //=================================================================================
            // ======================== Specter ===============================================
            //=================================================================================

            _specterEmpty = new List<Appointment>
            {
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            };

            _specterNovember032017 = new List<Appointment>
            {
            // One
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Consultation", Height = "70", Margin = "0,2,0,0", Patient = "Francis Francois", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Collapsed", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Two
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Consultation", Height = "70", Margin = "0,2,0,0", Patient = "Tim Horton", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Collapsed", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
 
            // Three
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Four
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            // Five
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Six
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Seven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eight
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            
            // Nine
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Ten
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eleven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Twelve
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            };


            _specterNovember042017 = new List<Appointment>
            {
            // One
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Daryll Dogood", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Consultation", Height = "70", Margin = "0,2,0,0", Patient = "Odor Onus", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Collapsed", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Two
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Lenny Lame", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Three
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Arya Stark", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Sansa Stark", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Dr. Dre", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Four
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            // Five
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Six
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Seven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eight
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            
            // Nine
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Ten
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eleven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Twelve
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            };


            _specterNovember052017 = new List<Appointment>
            {
                        // One
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Two
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Three
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Debbie Downer", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Four
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Consultation", Height = "70", Margin = "0,2,0,0", Patient = "Mr. Voldemort", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Collapsed", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Party Pooper", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            // Five
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Six
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Seven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eight
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            
            // Nine
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Ten
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eleven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Twelve
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            };


            _specterNovember062017 = new List<Appointment>
            {
            // One
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Two
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Three
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Four
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Consultation", Height = "70", Margin = "0,2,0,0", Patient = "Brody Jackson's Aunty", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Collapsed", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Consultation", Height = "70", Margin = "0,2,0,0", Patient = "Fred", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Collapsed", Cursor = "Hand", RowSpan = "1", Opacity = "0"},

            // Five
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Six
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Seven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eight
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            
            // Nine
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Ten
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eleven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Twelve
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            };


            _specterNovember072017 = new List<Appointment>
            {
            // One
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Two
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Three
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Tappity Thomas", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Consultation", Height = "70", Margin = "0,2,0,0", Patient = "Brandon Slack", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Collapsed", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Four
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Ned Stark", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            // Five
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Six
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Seven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eight
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            
            // Nine
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Ten
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eleven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Twelve
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            };


            _specterNovember082017 = new List<Appointment>
            {
            // One
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Two
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Three
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Consultation", Height = "70", Margin = "0,2,0,0", Patient = "Bilbo Baggins", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Collapsed", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Four
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Brody Jackson's Aunty", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "George Martin", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Five
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Liam Schoepp", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Six
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Seven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eight
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            
            // Nine
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Ten
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eleven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Twelve
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            };


            _specterDecember052017 = new List<Appointment>
            {
            // One
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Two
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Three
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Four
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Consultation", Height = "70", Margin = "0,2,0,0", Patient = "Jonathan Shabash", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Collapsed", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            // Five
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Denaerys Targarian", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Jon Snow", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Six
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Seven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eight
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            
            // Nine
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Ten
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eleven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Twelve
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            };


            _specterDecember152017 = new List<Appointment>
            {

            // One
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Two
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Three
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Four
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Mike Ross", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "James Dean", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Jeremy Pumpkinspice", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
       
            // Five
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Odor Onus", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Mr. Voldemort", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Six
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Seven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eight
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            
            // Nine
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Ten
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eleven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Twelve
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            };

            _specterDecember162017 = new List<Appointment>
            {
            // One
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Two
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Three
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Four
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Arya Stark", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Sansa Stark", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            // Five
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Six
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Seven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eight
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            
            // Nine
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Ten
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eleven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Twelve
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Specter", Colour = "Violet", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            };














            //=================================================================================
            // ======================== Paulsen ===============================================
            //=================================================================================

            _paulsenEmpty = new List<Appointment>
            {
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            };


            _paulsenNovember032017 = new List<Appointment>
            {

            // One
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Two
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Three
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Consultation", Height = "70", Margin = "0,2,0,0", Patient = "Wendy Wendelson", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Collapsed", Cursor = "Hand", RowSpan = "1", Opacity = "0"},

            // Four
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            // Five
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Six
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Seven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eight
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Consultation", Height = "70", Margin = "0,2,0,0", Patient = "Mike Jones", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Collapsed", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Frodo Baggins", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            
            // Nine
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Ten
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eleven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Twelve
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
        };


            _paulsenNovember042017 = new List<Appointment>
        {

            // One
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Two
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Three
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Consultation", Height = "70", Margin = "0,2,0,0", Patient = "Samwise Goungy", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Collapsed", Cursor = "Hand", RowSpan = "1", Opacity = "0"},

            // Four
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            // Five
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Six
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Seven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eight
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            
            // Nine
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Ten
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eleven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Twelve
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
        };


            _paulsenNovember052017 = new List<Appointment>
        {

            // One
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Two
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Three
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Four
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            // Five
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Six
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Seven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eight
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Consultation", Height = "70", Margin = "0,2,0,0", Patient = "Samwise Goungy", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Collapsed", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            
            // Nine
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Ten
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eleven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Twelve
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
        };


            _paulsenNovember062017 = new List<Appointment>
        {



            // One
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Two
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Three
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Four
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
 
            // Five
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Consultation", Height = "70", Margin = "0,2,0,0", Patient = "Orville Reddenschtapper", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Collapsed", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Francis Francois", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Tim Horton", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },

            // Six
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Seven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eight
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            
            // Nine
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Ten
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eleven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Twelve
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

        };


            _paulsenNovember072017 = new List<Appointment>
        {

            // One
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Two
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Three
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Ichiban Foresupper", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Cornell Smith", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Four
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            // Five
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Six
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Seven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eight
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            
            // Nine
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Ten
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eleven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Twelve
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
        };


            _paulsenNovember082017 = new List<Appointment>
        {


            // One
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Two
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Three
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Four
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            // Five
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Six
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Seven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eight
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            
            // Nine
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Ten
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eleven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Twelve
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
        };


            _paulsenDecember052017 = new List<Appointment>
        {
            // One
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Two
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Three
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Consultation", Height = "70", Margin = "0,2,0,0", Patient = "Georgina Joseph", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Collapsed", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Liam Schoepp", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Four
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Orville Reddenschtapper", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Dabin Lamming", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Consultation", Height = "70", Margin = "0,2,0,0", Patient = "Brody Jackson's Aunty", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Collapsed", Cursor = "Hand", RowSpan = "1", Opacity = "0"},

            // Five
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
           new Appointment ( ){ DateTime = DateTime.Today, Type = "Consultation", Height = "70", Margin = "0,2,0,0", Patient = "Fred", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Collapsed", Cursor = "Hand", RowSpan = "1", Opacity = "0"},
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Six
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Tappity Thomas", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Brandon Slack", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Ned Stark", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Bilbo Baggins", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },

            // Seven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eight
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            
            // Nine
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Ten
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eleven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Twelve
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
        };


            _paulsenDecember152017 = new List<Appointment>
        {

            // One
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Two
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Three
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Four
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Denaerys Targarian", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Jon Snow", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
 
            // Five
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Harry Potter", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Jonathan Shabash", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Six
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Seven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eight
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            
            // Nine
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Ten
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eleven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Twelve
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
        };


            _paulsenDecember162017 = new List<Appointment>
        {

            // One
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Two
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Three
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Four
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
 
            // Five
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Six
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Seven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Debbie Downer", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Party Pooper", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0.4" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "Standard", Height = "35", Margin = "0,1,0,0", Patient = "Mary Poppins", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "2", Opacity = "0.4" },
 
            // Eight
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            
            // Nine
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Ten
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Eleven
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },

            // Twelve
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
            new Appointment ( ){ DateTime = DateTime.Today, Type = "", Height = "35", Margin = "0,1,0,0", Patient = "", DoctorName = "Dr. Paulsen", Colour = "Orange", Visibility = "Visible", Cursor = "Hand", RowSpan = "1", Opacity = "0" },
        };
        }


    }
}
