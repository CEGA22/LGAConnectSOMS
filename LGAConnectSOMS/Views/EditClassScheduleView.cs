using LGAConnectSOMS.Models;
using LGAConnectSOMS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LGAConnectSOMS.Views
{
    public partial class EditClassScheduleView : Form
    {
        public EditClassScheduleView()
        {
            InitializeComponent();
            LoadData();
        }

        public async void LoadData()
        {
            await LoadGradeLevelSection();
            await LoadSubjects();
            await LoadFaculty();
        }

        IEnumerable<GradeLevelSection> gradeLevelSections = new List<GradeLevelSection>();
        public async Task LoadGradeLevelSection()
        {
            GradeLevelSectionService gradeLevelSectionService = new GradeLevelSectionService();
            gradeLevelSections = await gradeLevelSectionService.GetGradeLevel();
            var gradelevelslist = gradeLevelSections.ToList();
        }

        IEnumerable<Subjects> subjects = new List<Subjects>();
        public async Task LoadSubjects()
        {
            SubjectsService subjectsService = new SubjectsService();
            subjects = await subjectsService.GetSubjects();
        }

        IEnumerable<SchoolAccount> schoolAccounts = new List<SchoolAccount>();
        public async Task LoadFaculty()
        {
            SchoolAccountService schoolAccountService = new SchoolAccountService();
            schoolAccounts = await schoolAccountService.GetSchoolAccountOnly();
            var facultylist = schoolAccounts.Where(x => x.isAdmin == 0).Select(x => x.Fullname);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAddClassSchedule_Click(object sender, EventArgs e)
        {
            var selectedGradeLevel = (string)txtGradeLevel.Text;
            //var selectedSection = cmbSections.SelectedItem;
            var selectedteacher = (string)txtFullname.Text;
            var selectedSubject = txtSubject.Text;
            //var gradeLevelId = gradeLevelSections.First(x => x.GradeLevels.Equals(selectedGradeLevel) && x.SectionName.Equals(selectedSection)).GradeLevel;
            //var subjectid = subjects.First(x => x.SubjectName.Equals(selectedSubject) && x.GradeLevel == gradeLevelId).GradeLevel;
            var teacherid = schoolAccounts.First(x => x.Fullname == selectedteacher).id;
            var starttime = Convert.ToDateTime(cmbStartTime.Text);
            var endtime = Convert.ToDateTime(cmbEndTime.Text);
            var startday = starttime.ToString("HH:mm:ss");
            var endday = endtime.ToString("HH:mm:ss");
        }
    }
}
