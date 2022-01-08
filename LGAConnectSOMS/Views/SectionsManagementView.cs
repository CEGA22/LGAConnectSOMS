using LGAConnectSOMS.Models;
using LGAConnectSOMS.Properties;
using LGAConnectSOMS.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LGAConnectSOMS.Views
{
    public partial class SectionsManagementView : Form
    {
        #region Fields

        private string _facultyId;

        private IEnumerable<SchoolAccount> _schoolAccounts = Enumerable.Empty<SchoolAccount>();
        private IEnumerable<SchoolAccount> _facultyList = Enumerable.Empty<SchoolAccount>();

        private List<GradeLevelSection> _allGradeLevelSections = new List<GradeLevelSection>();

        private List<GradeLevelSection> _gradeLevelSections = new List<GradeLevelSection>();

        private List<SectionsHandled> _sectionsHandled = new List<SectionsHandled>();

        private BindingSource _sectionsHandledBindingSource;
        private BindingSource _gradeSectionsBindingSource;

        private FacultyModel _selectedFaculty;

        private bool _isFirstLoad = true;

        private CancellationTokenSource _loadFacultyCancellationToken;
        private CancellationTokenSource _loadGradeLevelCancellationToken;

        #endregion

        #region Constructor

        public SectionsManagementView()
        {
            InitializeComponent();
            RenewCancellationTokens();
        }

        #endregion

        #region Methods

        private async Task PreparePageBindings()
        {
            SetupGradeLevelSection();
            SetupFacultySettingsPreview();

            await FetchFacultyRecord();

            LoadFacultyListForSettings();
        }

        private async Task FetchFacultyRecord()
        {
            try
            {
                cmbFaculty.Invoke((MethodInvoker)(() => cmbFaculty.Enabled = false));
                lblFacultyLoading.Invoke((MethodInvoker)(() => lblFacultyLoading.Visible = true));

                SchoolAccountService schoolAccountService = new SchoolAccountService();
                _schoolAccounts = await schoolAccountService.GetSchoolAccountDetails();
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
                btnSubmit.Invoke((MethodInvoker)(() => btnSubmit.Visible = false));
                btnRemoveGraceSection.Invoke((MethodInvoker)(() => btnRemoveGraceSection.Visible = false));
                lblPreviewLoading.Invoke((MethodInvoker)(() => lblPreviewLoading.Visible = true));

                FacultyService facultyService = new FacultyService();
                var result = await facultyService.GetSectionsHandled(_selectedFaculty.Id);
               
                _sectionsHandled.Clear();

                if (result != null && result.Any())
                {

                    foreach (var items in result)
                    {
                        var facultyDetails = _facultyList.First(x => x.id == items.TeacherId);

                        _sectionsHandled.Add(new SectionsHandled
                        {
                            ID = items.ID,
                            TeacherId = items.TeacherId,
                            FacultyName = facultyDetails.Fullname,
                            GradeLevelID = items.GradeLevelID,
                            GradeLevel = items.GradeLevel,
                            SectionName = items.SectionName,
                        });
                    }

                    dtSectionsHandledPreview.Invoke((MethodInvoker)(() => dtSectionsHandledPreview.Enabled = true));
                    btnRemoveGraceSection.Invoke((MethodInvoker)(() => btnRemoveGraceSection.Visible = true));
                }

                btnSubmit.Invoke((MethodInvoker)(() => btnSubmit.Visible = true));

                _sectionsHandledBindingSource.ResetBindings(true);
            }
            catch (Exception e)
            {
                lblPreviewLoading.Invoke((MethodInvoker)(() => lblPreviewLoading.Visible = false));
            }
            finally
            {
                lblPreviewLoading.Invoke((MethodInvoker)(() => lblPreviewLoading.Visible = false));
            }
        }

        private void LoadFacultyListForSettings()
        {
            //1. Clear faculty combobox
            if (cmbFaculty.Items.Count > 0)
                cmbFaculty.Invoke((MethodInvoker)(() => cmbFaculty.Items.Clear()));


            //2. Order faculty list by first name
            _facultyList = _schoolAccounts.Where(x => x.isAdmin == 0).OrderBy(o => o.firstname);

            //3. Assign value and display member
            cmbFaculty.Invoke((MethodInvoker)(() =>
            {
                cmbFaculty.ValueMember = "Id";
                cmbFaculty.DisplayMember = "FullName";
            }));

            //4. Create and set datasource
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

            //5. Set combobox to default - no selected item
            //cmbFaculty.SelectedIndex = -1;
        }

        private void SetupGradeLevelSection()
        {
            dtGradeSection.AutoGenerateColumns = false;
            _gradeSectionsBindingSource = new BindingSource { DataSource = _gradeLevelSections };
            dtGradeSection.Invoke((MethodInvoker)(() => dtGradeSection.DataSource = _gradeSectionsBindingSource));

            dtGradeSection.Columns[0].DataPropertyName = "GradeLevels";
            dtGradeSection.Columns[1].DataPropertyName = "SectionName";
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

        private void RenewCancellationTokens()
        {
            _loadFacultyCancellationToken?.Cancel();
            _loadFacultyCancellationToken = new CancellationTokenSource();

            _loadGradeLevelCancellationToken?.Cancel();
            _loadGradeLevelCancellationToken = new CancellationTokenSource();
        }

        #endregion

        #region Events

        private void SectionsManagementView_Load(object sender, EventArgs e)
        {
            this.RestoreWindowPosition();
            MaximizeIcon();

            Task.Run(async () => await PreparePageBindings());
        }


        private void SectionsManagementView_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.SaveWindowPosition();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Minimized;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.WindowState == FormWindowState.Normal)
                {
                    this.WindowState = FormWindowState.Maximized;
                    btnMaximize.Image = LGAConnectSOMS.Properties.Resources.NormalBlack;

                }

                else
                {
                    this.WindowState = FormWindowState.Normal;
                    btnMaximize.Image = LGAConnectSOMS.Properties.Resources.FullScreenBlack;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Point _mouseLoc;

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

            _loadFacultyCancellationToken?.Cancel();
            _loadGradeLevelCancellationToken?.Cancel();

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

        private void btnAddGradeSection_Click(object sender, EventArgs e)
        {
            var selectedFaculty = (FacultyModel)cmbFaculty.SelectedItem;

            if (selectedFaculty != null && dtGradeSection.SelectedRows.Count > 0)
            {
                var gradeLevelSectionList = _gradeLevelSections.ToList();
                var itemsToRemove = new List<GradeLevelSection>();

                foreach (DataGridViewRow row in dtGradeSection.SelectedRows)
                {
                    var selectedItem = dtGradeSection.Rows[row.Index].DataBoundItem as GradeLevelSection;

                    _sectionsHandled.Add(new SectionsHandled
                    {
                        TeacherId = selectedFaculty.Id,
                        FacultyName = selectedFaculty.FullName,
                        GradeLevelID = selectedItem.Id,
                        GradeLevel = selectedItem.GradeLevels,
                        SectionName = selectedItem.SectionName,
                    });

                    itemsToRemove.Add(selectedItem);
                }

                _sectionsHandledBindingSource.ResetBindings(true);

                RemoveGradeSections(itemsToRemove);

                btnRemoveGraceSection.Visible = true;
                btnSubmit.Visible = true;
                dtSectionsHandledPreview.Enabled = true;

            }
        }

        private void RemoveGradeSections(IEnumerable<GradeLevelSection> itemsToRemove) 
        {
            foreach(var item in itemsToRemove) 
            {
                _gradeLevelSections.Remove(item);
            }

            _gradeSectionsBindingSource.ResetBindings(true);
        }

        private void RemoveSelectedGradeSections(IEnumerable<SectionsHandled> itemsToRemove)
        {
            foreach (var item in itemsToRemove)
            {
                _sectionsHandled.Remove(item);
            }

            _sectionsHandledBindingSource.ResetBindings(true);
        }

        private void SetupFacultySettingsPreview()
        {
            dtSectionsHandledPreview.AutoGenerateColumns = false;

            _sectionsHandledBindingSource = new BindingSource { DataSource = _sectionsHandled };
            dtSectionsHandledPreview.Invoke((MethodInvoker)(() => dtSectionsHandledPreview.DataSource = _sectionsHandledBindingSource));

            dtSectionsHandledPreview.Columns[0].DataPropertyName = "FacultyName";
            dtSectionsHandledPreview.Columns[1].DataPropertyName = "GradeLevel";
            dtSectionsHandledPreview.Columns[2].DataPropertyName = "SectionName";
        }

        private void dtGradeSection_SelectionChanged(object sender, EventArgs e)
        {
            btnAddGradeSection.Visible = dtGradeSection.SelectedRows.Count > 0;
        }

        private async void cmbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {

            _selectedFaculty = (FacultyModel)cmbFaculty.SelectedItem;

            if (_selectedFaculty != null)
            {
                try
                {
                    await FetchSectionsHandled();

                    dtGradeSection.Enabled = false;
                    btnAddGradeSection.Visible = false;
                    lblGradeLevelLoading.Visible = true;

                    GradeLevelSectionService gradeLevelSectionService = new GradeLevelSectionService();
                    var result = await gradeLevelSectionService.GetGradeLevel();

                    if (result.Any())
                    {
                        _gradeLevelSections.Clear();
                        _allGradeLevelSections.Clear();

                        foreach (var item in result)
                        {
                            if (_loadGradeLevelCancellationToken?.IsCancellationRequested == true)
                                return;

                            if (!_sectionsHandled.Any(x => x.GradeLevel == item.GradeLevels
                                                        && x.SectionName == item.SectionName
                                                        && x.TeacherId == _selectedFaculty.Id))
                            {
                                _gradeLevelSections.Add(new GradeLevelSection
                                {
                                    Id = item.Id,
                                    GradeLevel = item.GradeLevel,
                                    GradeLevels = item.GradeLevels,
                                    SectionName = item.SectionName
                                });
                            }

                            _allGradeLevelSections.Add(new GradeLevelSection
                            {
                                Id = item.Id,
                                GradeLevel = item.GradeLevel,
                                GradeLevels = item.GradeLevels,
                                SectionName = item.SectionName
                            });
                        }

                        _gradeSectionsBindingSource.ResetBindings(true);
                    }

                }
                catch (Exception ex)
                {
                    dtGradeSection.Enabled = true;
                    lblGradeLevelLoading.Visible = false;
                }
                finally
                {
                    dtGradeSection.Enabled = true;
                    lblGradeLevelLoading.Visible = false;
                }
            }
            else
            {
                _gradeLevelSections.Clear();
                _gradeSectionsBindingSource.ResetBindings(true);
            }
        }

        private void btnRemoveGraceSection_Click(object sender, EventArgs e)
        {
            var itemsToRemove = new List<SectionsHandled>();

            foreach (DataGridViewRow row in dtSectionsHandledPreview.SelectedRows)
            {
                var selectedItem = dtSectionsHandledPreview.Rows[row.Index].DataBoundItem as SectionsHandled;

                _gradeLevelSections.Add(new GradeLevelSection
                {
                    GradeLevel = selectedItem.GradeLevelID,
                    GradeLevels = selectedItem.GradeLevel,
                    SectionName = selectedItem.SectionName
                });

                _gradeSectionsBindingSource.ResetBindings(true);
                itemsToRemove.Add(selectedItem);
            }

            SortGradeLevels();
            RemoveSelectedGradeSections(itemsToRemove);

            btnRemoveGraceSection.Visible = _sectionsHandled.Count > 0;

        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                btnSubmit.Invoke((MethodInvoker)(() => btnSubmit.Visible = false));
                btnRemoveGraceSection.Invoke((MethodInvoker)(() => btnRemoveGraceSection.Visible = false));
                lblPreviewLoading.Invoke((MethodInvoker)(() => lblPreviewLoading.Visible = true));
                lblPreviewLoading.Invoke((MethodInvoker)(() => lblPreviewLoading.Text = "Saving... Please wait..."));

                var facultyService = new FacultyService();
                await facultyService.SaveSectionsHandled(new SectionsHandledRequest 
                {
                    TeacherId = _selectedFaculty.Id,
                    SectionsHandled = _sectionsHandled
                });

                lblDisplayResult.Invoke((MethodInvoker)(() => lblDisplayResult.Text = "Successfully saved!"));
                lblDisplayResult.Invoke((MethodInvoker)(() => lblDisplayResult.Visible = true));
                lblDisplayResult.Invoke((MethodInvoker)(() => lblDisplayResult.ForeColor = Color.DarkGreen));


            }
            catch (Exception ex)
            {
                btnSubmit.Invoke((MethodInvoker)(() => btnSubmit.Visible = true));
                btnRemoveGraceSection.Invoke((MethodInvoker)(() => btnRemoveGraceSection.Visible = true));
                lblPreviewLoading.Invoke((MethodInvoker)(() => lblPreviewLoading.Visible = false));
                lblPreviewLoading.Invoke((MethodInvoker)(() => lblPreviewLoading.Text = "Loading... Please wait..."));

                lblDisplayResult.Invoke((MethodInvoker)(() => lblDisplayResult.Text = ex.Message));
                lblDisplayResult.Invoke((MethodInvoker)(() => lblDisplayResult.Visible = true));
                lblDisplayResult.Invoke((MethodInvoker)(() => lblDisplayResult.ForeColor = Color.DarkRed));
            }
            finally
            {
                btnSubmit.Invoke((MethodInvoker)(() => btnSubmit.Visible = true));
                btnRemoveGraceSection.Invoke((MethodInvoker)(() => btnRemoveGraceSection.Visible = _sectionsHandled.Any()));
                lblPreviewLoading.Invoke((MethodInvoker)(() => lblPreviewLoading.Visible = false));
                lblPreviewLoading.Invoke((MethodInvoker)(() => lblPreviewLoading.Text = "Loading... Please wait..."));

                tmrSaveResult.Start();
            }
        }


        #endregion

        private void SortGradeLevels() 
        {
            var gradeSectionItems = _gradeLevelSections.OrderBy(x => x.GradeLevel).ToList();
            _gradeLevelSections.Clear();
            _gradeLevelSections.AddRange(gradeSectionItems);
            _gradeSectionsBindingSource.ResetBindings(true);
        }

        private void tmrSaveResult_Tick(object sender, EventArgs e)
        {
            lblDisplayResult.Invoke((MethodInvoker)(() => lblDisplayResult.Visible = false));
            tmrSaveResult.Stop();
        }
    }
}
