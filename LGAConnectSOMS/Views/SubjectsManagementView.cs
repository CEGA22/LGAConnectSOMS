using LGAConnectSOMS.Models;
using LGAConnectSOMS.Properties;
using LGAConnectSOMS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LGAConnectSOMS.Views
{
    public partial class SubjectsManagementView : Form
    {

        #region Fields

        private readonly SchoolAccountService _schoolAccountService;
        private readonly SubjectsService _subjectsService;

        private IEnumerable<SchoolAccount> _schoolAccounts = Enumerable.Empty<SchoolAccount>();
        private IEnumerable<SchoolAccount> _facultyList = Enumerable.Empty<SchoolAccount>();
        private IEnumerable<SectionsHandled> _sectionsHandled = Enumerable.Empty<SectionsHandled>();

        private List<Subjects> _allSubjects = new List<Subjects>();
        private List<Subjects> _subjects = new List<Subjects>();
        private List<SubjectsHandled> _subjectsHandled = new List<SubjectsHandled>();

        private FacultyModel _selectedFaculty;
        private SectionsHandled _selectedGradeLevel;

        private BindingSource _subjectsBindingSource;
        private BindingSource _subjectsHandledBindingSource;

        private Point _mouseLoc;

        #endregion

        public SubjectsManagementView()
        {
            InitializeComponent();
            this.RestoreWindowPosition();
            MaximizeIcon();
            _schoolAccountService = new SchoolAccountService();
            _subjectsService = new SubjectsService();

        }

        #region Methods

        private async Task PreparePageDataSources()
        {
            await FetchFacultyRecord();
            await FetchUnHanldedSubjects();
        }

        public IEnumerable<UnHandledSubjects> subjectsUnHandled = new List<UnHandledSubjects>();
        public async Task FetchUnHanldedSubjects()
        {
            try
            {
                SubjectsService subjectsService = new SubjectsService();
                subjectsUnHandled = await subjectsService.GetAllUnHandledSubjectsHandled();
                var UnHandled = subjectsUnHandled.OrderBy(o => o.GradeLevel).ThenBy(o => o.SubjectName).ToList();
                UnHandledDataGridView.Invoke((MethodInvoker)(() => UnHandledDataGridView.DataSource = UnHandled));
                UnHandledDataGridView.CurrentCell = null;
            }
            catch (Exception e)
            {

                throw;
            }
        }

        private async Task FetchFacultyRecord()
        {
            try
            {
                cmbFaculty.Invoke((MethodInvoker)(() => cmbFaculty.Enabled = false));
                lblFacultyLoading.Invoke((MethodInvoker)(() => lblFacultyLoading.Visible = true));

                _schoolAccounts = await _schoolAccountService.GetSchoolAccountOnly();
                _facultyList = _schoolAccounts.Where(x => x.isAdmin == 0).OrderBy(o => o.firstname);

                cmbFaculty.Invoke((MethodInvoker)(() =>
                {
                    cmbFaculty.ValueMember = "Id";
                    cmbFaculty.DisplayMember = "FullName";
                }));

                var facultyList = new List<FacultyModel>();

                foreach (var faculty in _facultyList)
                {
                    facultyList.Add(new FacultyModel
                    {
                        Id = faculty.id,
                        FullName = faculty.Fullname
                    });
                }

                cmbFaculty.Invoke((MethodInvoker)(() => cmbFaculty.DataSource = facultyList));
            }
            catch
            {
                cmbFaculty.Invoke((MethodInvoker)(() => cmbFaculty.Enabled = true));
                lblFacultyLoading.Invoke((MethodInvoker)(() => lblFacultyLoading.Visible = false));
            }
            finally
            {
                cmbFaculty.Invoke((MethodInvoker)(() => cmbFaculty.Enabled = true));
                lblFacultyLoading.Invoke((MethodInvoker)(() => lblFacultyLoading.Visible = false));
            }
        }

        private async Task FetchSectionsHandled()
        {
            try
            {
                cmbGradeLevel.Invoke((MethodInvoker)(() => cmbGradeLevel.Enabled = false));
                lblGradeLevelLoading.Invoke((MethodInvoker)(() => lblGradeLevelLoading.Visible = true));

                FacultyService facultyService = new FacultyService();
                _sectionsHandled = await facultyService.GetSectionsHandled(_selectedFaculty.Id);

                cmbGradeLevel.Invoke((MethodInvoker)(() =>
                {
                    cmbGradeLevel.ValueMember = "GradeLevelID";
                    cmbGradeLevel.DisplayMember = "DisplayText";
                }));

                cmbGradeLevel.Invoke((MethodInvoker)(() => cmbGradeLevel.DataSource = _sectionsHandled));

            }
            catch (Exception e)
            {

            }
            finally
            {
                if (!_sectionsHandled.Any())
                {
                    cmbGradeLevel.Invoke((MethodInvoker)(() => cmbGradeLevel.Text = string.Empty));
                    cmbGradeLevel_SelectedIndexChanged(this, null);
                }

                cmbGradeLevel.Invoke((MethodInvoker)(() => cmbGradeLevel.Enabled = _sectionsHandled.Any()));
                lblGradeLevelLoading.Invoke((MethodInvoker)(() => lblGradeLevelLoading.Visible = false));
            }
        }

        private async Task FetchSubjectByGradeLevel()
        {
            try
            {

                dtSubjects.Invoke((MethodInvoker)(() => dtSubjects.Enabled = false));
                lblSubjectsLoading.Invoke((MethodInvoker)(() => lblSubjectsLoading.Visible = true));
                btnSelectSubject.Invoke((MethodInvoker)(() => btnSelectSubject.Visible = false));

                var gradeLevel = _selectedGradeLevel.GradeLevel.Replace("Grade ", "");
                var result = (await _subjectsService.GetSubjectsByGradeLevel(int.Parse(gradeLevel))).OrderBy(x => x.SubjectName);

                _subjects.Clear();
                _allSubjects.Clear();

                foreach (var subject in result)
                {
                    if (!_subjectsHandled.Any(x => x.GradeLevelId == subject.GradeLevel && x.SubjectId == subject.ID))
                    {
                        _subjects.Add(new Subjects
                        {
                            GradeLevel = subject.GradeLevel,
                            Grade_Level = subject.Grade_Level,
                            ID = subject.ID,
                            SubjectCode = subject.SubjectCode,
                            SubjectName = subject.SubjectName,
                        });

                        _allSubjects.Add(new Subjects
                        {
                            GradeLevel = subject.GradeLevel,
                            Grade_Level = subject.Grade_Level,
                            ID = subject.ID,
                            SubjectCode = subject.SubjectCode,
                            SubjectName = subject.SubjectName,
                        });
                    }
                }

                _subjectsBindingSource.ResetBindings(true);
            }
            catch
            {
                dtSubjects.Invoke((MethodInvoker)(() => dtSubjects.Enabled = true));
                lblSubjectsLoading.Invoke((MethodInvoker)(() => lblSubjectsLoading.Visible = false));
            }
            finally
            {
                dtSubjects.Invoke((MethodInvoker)(() => dtSubjects.Enabled = true));
                lblSubjectsLoading.Invoke((MethodInvoker)(() => lblSubjectsLoading.Visible = false));
                btnSelectSubject.Invoke((MethodInvoker)(() => btnSelectSubject.Visible = true));
            }
        }

        private async Task FetchSubjectHandled()
        {
            try
            {
                dtSubjectsHandled.Invoke((MethodInvoker)(() => dtSubjectsHandled.Enabled = false));
                lblSubjectsHandledLoading.Invoke((MethodInvoker)(() => lblSubjectsHandledLoading.Visible = true));
                btnSubmit.Invoke((MethodInvoker)(() => btnSubmit.Visible = false));

                var result = (await _subjectsService.GetSubjectsHandled(_selectedFaculty.Id, _selectedGradeLevel.GradeLevelID)).OrderBy(x => x.SubjectName);

                _subjectsHandled.Clear();

                foreach (var subject in result)
                {
                    _subjectsHandled.Add(new SubjectsHandled
                    {
                        GradeLevelId = subject.GradeLevelId,
                        GradeLevel = _sectionsHandled.FirstOrDefault(x => x.GradeLevelID == subject.GradeLevelId).GradeLevel,
                        SubjectId = subject.SubjectId,
                        SubjectName = subject.SubjectName,
                        SubjectCode = subject.SubjectCode,
                        TeacherId = subject.TeacherId,
                    });
                }

                _subjectsHandledBindingSource.ResetBindings(true);
            }
            catch
            {
                dtSubjectsHandled.Invoke((MethodInvoker)(() => dtSubjectsHandled.Enabled = true));
                lblSubjectsHandledLoading.Invoke((MethodInvoker)(() => lblSubjectsHandledLoading.Visible = false));
            }
            finally
            {
                dtSubjectsHandled.Invoke((MethodInvoker)(() => dtSubjectsHandled.Enabled = true));
                lblSubjectsHandledLoading.Invoke((MethodInvoker)(() => lblSubjectsHandledLoading.Visible = false));
                btnSubmit.Invoke((MethodInvoker)(() => btnSubmit.Visible = true));
                btnRemoveSubjectsHandled.Invoke((MethodInvoker)(() => btnRemoveSubjectsHandled.Visible = _subjectsHandled.Any()));
            }
        }

        private void SetupSubjectsList()
        {
            dtSubjects.AutoGenerateColumns = false;
            _subjectsBindingSource = new BindingSource { DataSource = _subjects };
            dtSubjects.Invoke((MethodInvoker)(() => dtSubjects.DataSource = _subjectsBindingSource));

            dtSubjects.Columns[0].DataPropertyName = "SubjectName";
            dtSubjects.Columns[0].Visible = false;
        }

        private void SetupSubjectsHandledList()
        {
            dtSubjectsHandled.AutoGenerateColumns = false;
            _subjectsHandledBindingSource = new BindingSource { DataSource = _subjectsHandled };
            dtSubjectsHandled.Invoke((MethodInvoker)(() => dtSubjectsHandled.DataSource = _subjectsHandledBindingSource));

            dtSubjectsHandled.Columns[0].DataPropertyName = "SubjectName";
            dtSubjectsHandled.Columns[0].Visible = false;
        }

        private void RemoveSelectedSubjects(IEnumerable<Subjects> itemsToRemove)
        {
            foreach (var item in itemsToRemove)
            {
                _subjects.Remove(item);
            }

            _subjectsBindingSource.ResetBindings(true);
        }

        private void RemoveSubjectsHandled(IEnumerable<SubjectsHandled> itemsToRemove)
        {
            foreach (var item in itemsToRemove)
            {
                _subjectsHandled.Remove(item);
            }

            _subjectsHandledBindingSource.ResetBindings(true);
        }

        private void RestoreWindowPosition()
        {

            try
            {
                if (Settings.Default.HasSetDefault)
                {
                    this.WindowState = Settings.Default.WindowState;
                    this.Location = Settings.Default.Location;
                    this.Size = Settings.Default.Size;


                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void SaveWindowPosition()
        {
            try
            {
                Settings.Default.WindowState = this.WindowState;

                if (this.WindowState == FormWindowState.Normal)
                {
                    Settings.Default.Location = this.Location;
                    Settings.Default.Size = this.Size;


                }
                else
                {
                    Settings.Default.Location = this.RestoreBounds.Location;
                    Settings.Default.Size = this.RestoreBounds.Size;
                }

                Settings.Default.HasSetDefault = true;

                Settings.Default.Save();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void MaximizeIcon()
        {

            try
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    btnMaximize.Image = LGAConnectSOMS.Properties.Resources.NormalBlack;
                }

                else if (this.WindowState == FormWindowState.Normal)
                {
                    btnMaximize.Image = LGAConnectSOMS.Properties.Resources.FullScreenBlack;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        #endregion

        #region Events

        private void SubjectsManagementView_Load(object sender, EventArgs e)
        {
            SetupSubjectsList();
            SetupSubjectsHandledList();

            Task.Run(async () => await PreparePageDataSources());
        }

        private async void cmbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedFaculty = (FacultyModel)cmbFaculty.SelectedItem;

            if (_selectedFaculty != null)
            {
                await FetchSectionsHandled();
            }
        }

        private async void cmbGradeLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedGradeLevel = (SectionsHandled)cmbGradeLevel.SelectedItem;

            if (_selectedGradeLevel != null)
            {
                await FetchSubjectHandled();
                await FetchSubjectByGradeLevel();
            }
            else
            {
                _subjectsHandled.Clear();
                _subjectsHandledBindingSource.ResetBindings(true);

                btnRemoveSubjectsHandled.Visible = false;
                btnSubmit.Visible = false;

                _subjects.Clear();
                _allSubjects.Clear();
                _subjectsBindingSource.ResetBindings(true);

                btnSelectSubject.Visible = false;
            }
        }

        private void DragWindowsPanel_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Normal;
                    btnMaximize.Image = LGAConnectSOMS.Properties.Resources.FullScreenBlack;

                }
                _mouseLoc = e.Location;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void DragWindowsPanel_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    int dx = e.Location.X - _mouseLoc.X;
                    int dy = e.Location.Y - _mouseLoc.Y;
                    this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.SaveWindowPosition();
            var HVA = new HomeViewAdmin();
            HVA.Show();
            this.Hide();
        }

        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            btnBack.Image = LGAConnectSOMS.Properties.Resources.BackArrowYellow24;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.Image = LGAConnectSOMS.Properties.Resources.BackArrow24;
        }



        #endregion

        private void btnSelectSubject_Click(object sender, EventArgs e)
        {
            if (_selectedGradeLevel != null && dtSubjects.SelectedRows.Count > 0)
            {
                var itemsToRemove = new List<Subjects>();

                foreach (DataGridViewRow row in dtSubjects.SelectedRows)
                {
                    var selectedItem = dtSubjects.Rows[row.Index].DataBoundItem as Subjects;

                    _subjectsHandled.Add(new SubjectsHandled
                    {
                        GradeLevel = selectedItem.Grade_Level,
                        GradeLevelId = _selectedGradeLevel.GradeLevelID,
                        SubjectCode = selectedItem.SubjectCode,
                        SubjectId = selectedItem.ID,
                        SubjectName = selectedItem.SubjectName,
                        TeacherId = _selectedFaculty.Id,
                        TeacherName = _selectedFaculty.FullName
                    });

                    itemsToRemove.Add(selectedItem);
                }

                _subjectsHandledBindingSource.ResetBindings(true);

                RemoveSelectedSubjects(itemsToRemove);
            }
        }

        private void btnRemoveGraceSection_Click(object sender, EventArgs e)
        {

            var itemsToRemove = new List<SubjectsHandled>();

            foreach (DataGridViewRow row in dtSubjectsHandled.SelectedRows)
            {
                var selectedItem = dtSubjectsHandled.Rows[row.Index].DataBoundItem as SubjectsHandled;

                _subjects.Add(new Subjects
                {
                    GradeLevel = selectedItem.GradeLevelId,
                    Grade_Level = selectedItem.GradeLevel,
                    ID = selectedItem.SubjectId,
                    SubjectCode = selectedItem.SubjectCode,
                    SubjectName = selectedItem.SubjectName
                });

                itemsToRemove.Add(selectedItem);
            }

            _subjectsBindingSource.ResetBindings(true);

            RemoveSubjectsHandled(itemsToRemove);

            btnRemoveSubjectsHandled.Visible = _subjectsHandled.Any();

        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                btnSubmit.Invoke((MethodInvoker)(() => btnSubmit.Visible = false));
                btnRemoveSubjectsHandled.Invoke((MethodInvoker)(() => btnRemoveSubjectsHandled.Visible = false));
                lblSubjectsHandledLoading.Invoke((MethodInvoker)(() => lblSubjectsHandledLoading.Visible = true));
                lblSubjectsHandledLoading.Invoke((MethodInvoker)(() => lblSubjectsHandledLoading.Text = "Saving... Please wait..."));

                var service = new SubjectsService();

                var isSuccess = await service.SaveSubjectsHandled(new SubjectsHandledRequest
                {
                    GradeLevelID = _selectedGradeLevel.GradeLevelID,
                    SubjectsHandled = _subjectsHandled,
                    TeacherID = _selectedFaculty.Id
                });;

                if (isSuccess)
                {
                    lblDisplayResult.Invoke((MethodInvoker)(() => lblDisplayResult.Text = "Successfully saved!"));
                    lblDisplayResult.Invoke((MethodInvoker)(() => lblDisplayResult.Visible = true));
                    lblDisplayResult.Invoke((MethodInvoker)(() => lblDisplayResult.ForeColor = Color.DarkGreen));
                }
               
            }
            catch (Exception ex)
            {
                btnSubmit.Invoke((MethodInvoker)(() => btnSubmit.Visible = true));
                btnRemoveSubjectsHandled.Invoke((MethodInvoker)(() => btnRemoveSubjectsHandled.Visible = true));
                lblSubjectsHandledLoading.Invoke((MethodInvoker)(() => lblSubjectsHandledLoading.Visible = false));
                lblSubjectsHandledLoading.Invoke((MethodInvoker)(() => lblSubjectsHandledLoading.Text = "Loading... Please wait..."));

                lblDisplayResult.Invoke((MethodInvoker)(() => lblDisplayResult.Text = ex.Message));
                lblDisplayResult.Invoke((MethodInvoker)(() => lblDisplayResult.Visible = true));
                lblDisplayResult.Invoke((MethodInvoker)(() => lblDisplayResult.ForeColor = Color.DarkRed));
            }
            finally
            {
                btnSubmit.Invoke((MethodInvoker)(() => btnSubmit.Visible = true));
                btnRemoveSubjectsHandled.Invoke((MethodInvoker)(() => btnRemoveSubjectsHandled.Visible = _sectionsHandled.Any()));
                lblSubjectsHandledLoading.Invoke((MethodInvoker)(() => lblSubjectsHandledLoading.Visible = false));
                lblSubjectsHandledLoading.Invoke((MethodInvoker)(() => lblSubjectsHandledLoading.Text = "Loading... Please wait..."));
                await FetchUnHanldedSubjects();
                tmrSaveResult.Start();
            }
        }

        private void tmrSaveResult_Tick(object sender, EventArgs e)
        {
            lblDisplayResult.Invoke((MethodInvoker)(() => lblDisplayResult.Visible = false));
            tmrSaveResult.Stop();
        }
    }
}
